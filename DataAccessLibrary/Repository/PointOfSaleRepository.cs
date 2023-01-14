using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class PointOfSaleRepository : IPointOfSale
    {
        private PointOfSale _record;

        public PointOfSale Record{ 
            get => _record; 
            set => _record= value; 
        }
        public Result result { get ; set; }
        
        public List<PointOfSale> SelectAll(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.PointOfSales.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Result Add(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.PointOfSales.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new PointOfSale Record successfully.";
            }
                return result;
        }

        public Result Delete(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a PointOfSale Record successfully.";

                return result;
            }
        }
        public Result Edit(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                //var recordToEdit = db.PointOfSales.SingleOrDefault(t => t.Id == _record.Id);
                //db.PointOfSales.Attach(recordToEdit);
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a PointOfSale Record successfully.";
                return result;
            }
        }

        public List<PointOfSalesViewModel> SelectAllViewModel()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.PointOfSaleViewModel().ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public object SelectSellerTransactions(DateTime paramDateFrom, DateTime paramDateTo, string paramUserName)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var records = (from pos in db.PointOfSales
                               join posDetails in db.PointOfSaleDetails
                               on pos.Id equals posDetails.POSId
                               join stock in db.Inventories
                               on posDetails.ProductId equals stock.Id
                               join refProdType in db.References
                               on stock.TypeID equals refProdType.Id
                               select new {
                                   pos.Id,
                                   pos.TransactionDateTime,
                                   pos.ReceiptNumber,
                                   pos.CustomerName,
                                   pos.SellerName,
                                   posDetails.ProductId,
                                   refProdType.Name,
                                   stock.Model,
                                   ProfitPerStock = posDetails.Price - stock.DistributorPrice,
                                   TotalProfit = (posDetails.Price * posDetails.Quantity) - (stock.DistributorPrice * posDetails.Quantity),
                                   ProfitSignal =( posDetails.Price - stock.DistributorPrice)>0 ?"Green":"Red",
                                   stock.DistributorPrice,
                                   stock.SuggestedRetailPrice,
                                   posDetails.Price,
                                   posDetails.Quantity
                               }).OrderByDescending(p=>p.TransactionDateTime).ThenBy(p=>p.SellerName).ToList();

                records = records.Where(p => p.TransactionDateTime >= paramDateFrom && p.TransactionDateTime <= paramDateTo).ToList();

                if (paramUserName.Length > 0)
                    records = records.Where(p => p.SellerName == paramUserName).ToList();

                return records;
            }
        }
    }
}
