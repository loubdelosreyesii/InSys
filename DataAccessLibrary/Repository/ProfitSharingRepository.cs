using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class ProfitSharingRepository : IProfitSharing
    {
        private ProfitSharing _record;

        public ProfitSharing Record{ 
            get => _record; 
            set => _record= value; 
        }
        public Result result { get ; set; }
        
        public List<ProfitSharing> SelectAll(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.ProfitSharings.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Result Add(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.ProfitSharings.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Seller Record successfully.";
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
                result.Message = "Deleted a Seller Record successfully.";

                return result;
            }
        }
        public Result Edit(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a Seller Record successfully.";
                return result;
            }
        }
    }
}
