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
                db.Inventories.Add(_record);
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
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
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
    }
}
