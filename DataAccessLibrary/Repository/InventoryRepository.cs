using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repository
{
    internal class InventoryRepository : IInventory
    {
        private Inventory _record;
        private CapitalController capitalController = new CapitalController();

        public Inventory Record
        {
            get => _record;
            set => _record = value;
        }
        public Result Result { get; set; }

        public List<Inventory> SelectAll()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Inventories.ToList();

                Result.Code = true;
                Result.Message = String.Empty;

                return record;
            }
        }

        public Result Add()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                Capital recordCapital = new Capital();
                DateTime dtNow = DateTime.Now;
                db.Inventories.Add(_record);
                db.SaveChanges();

                db.InventoryPriceHistories.Add(new InventoryPriceHistory { 
                    ProductId = _record.Id,
                    Quantity= _record.Quantity,
                    DistributorPrice = _record.DistributorPrice,
                    SuggestedRetailPrice = _record.SuggestedRetailPrice,
                    TransactionDateTime= dtNow
                });

                recordCapital.Amount = capitalController.SelectCurrentBalance() - (_record.Quantity * _record.DistributorPrice);
                recordCapital.TransactionDateTime = dtNow;

                capitalController = new CapitalController();
                capitalController.record = recordCapital;
                capitalController.Edit(true,$"Purchase Product: {_record.Model}; Distributor Price: {_record.DistributorPrice}; Qty: {_record.Quantity};");

                db.SaveChanges();

                Result.Code = true;
                Result.Message = "Added a new Inventory Record successfully.";
            }
            return Result;
        }

        public Result Delete()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                Result.Code = true;
                Result.Message = "Deleted a Inventory Record successfully.";

                return Result;

            }
        }

        public Result Edit()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                Capital recordCapital = new Capital();
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                db.InventoryPriceHistories.Add(new InventoryPriceHistory
                {
                    ProductId = _record.Id,
                    Quantity = _record.Quantity,
                    DistributorPrice = _record.DistributorPrice,
                    SuggestedRetailPrice = _record.SuggestedRetailPrice,
                    TransactionDateTime = DateTime.Now
                });

                db.SaveChanges();

                Result.Code = true;
                Result.Message = "Updated a Inventory Record successfully.";
                return Result;
            }
        }

        public Inventory Select()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Inventories.Where(p=>p.Id == _record.Id).SingleOrDefault();

                if (record == null)
                {
                    Result.Code = false;
                    Result.Message = "No Inventory Record found.";
                }

                Result.Code = true;
                Result.Message = String.Empty;

                return record;
            }
        }

        public List<Inventory> SelectInventories()
        {
            Result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var records = db.Inventories.ToList();

                if (_record != null && _record.Model.Length > 0)
                    records = records.Where(p => p.Model.Contains(_record.Model)).ToList();

                if (records == null)
                {
                    Result.Code = false;
                    Result.Message = "No Inventory Record found.";
                }

                Result.Code = true;
                Result.Message = String.Empty;

                return records;
            }
        }

        public decimal SelectRemainingInventoryAmount()
        {
            decimal decAmount = 0.00m;

            using (var db = new X2MO_InSysEntities()) {
                decAmount = db.Inventories.Where(p=>p.Quantity>0).AsEnumerable().Select(x=>x.Quantity * x.DistributorPrice).Aggregate((a,b)=> a + b);
            }

            return decAmount;
        }
    }
}
