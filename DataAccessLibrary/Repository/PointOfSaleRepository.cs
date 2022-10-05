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
    }
}
