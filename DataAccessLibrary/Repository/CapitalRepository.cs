using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class CapitalRepository : ICapital
    {
        private Capital _record;

        public Result result { get ; set; }

        public Capital Record { get => _record;
            set => _record = value; 
        }

        public List<Capital> SelectAll(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Capitals.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Result Add(string paramDescription){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                CapitalHistory capitalHistory = new CapitalHistory();

                decimal decCurrentFundValue = db.Capitals.First().Amount;
                db.Capitals.Add(new Capital { Id=1, Amount = _record.Amount, TransactionDateTime =_record.TransactionDateTime});
                db.SaveChanges();

                capitalHistory.OldFundBalance = decCurrentFundValue;
                capitalHistory.Amount = _record.Amount;
                capitalHistory.TransactionDateTime = _record.TransactionDateTime;
                capitalHistory.Description = paramDescription;

                db.CapitalHistories.Add(capitalHistory);

                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Capital Record successfully.";
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
                result.Message = "Deleted a Capital Record successfully.";

                return result;
            }
        }
        public Result Edit(bool paramIsNotExecute,string paramTransaction)
        {
            result = new Result();
            
            using (var db = new X2MO_InSysEntities())
            {
                CapitalHistory capitalHistory = new CapitalHistory();

                var recordOld = db.Capitals.Where(p => p.Id == 1).First();

                capitalHistory.OldFundBalance = recordOld.Amount;
                capitalHistory.Amount = _record.Amount - recordOld.Amount;
                capitalHistory.TransactionDateTime = _record.TransactionDateTime;
                capitalHistory.Description = paramTransaction;

                recordOld.Amount = _record.Amount;
                recordOld.TransactionDateTime = _record.TransactionDateTime;
                
                db.SaveChanges();

                //if (!paramIsNotExecute)
                //{
                db.CapitalHistories.Add(capitalHistory);
                db.SaveChanges();
                //}

                result.Code = true;
                result.Message = "Updated a Capital Record successfully.";
                return result;
            }
        }

        public List<CapitalHistory> GetCapitalHistories(DateTime paramDateFrom, DateTime paramDateTo)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                List<CapitalHistory> record = db.CapitalHistories.Where(p=>p.TransactionDateTime>= paramDateFrom && p.TransactionDateTime<= paramDateTo).OrderByDescending(p=>p.TransactionDateTime).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
