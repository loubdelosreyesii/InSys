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
    internal class DealerRepository : IDealer
    {
        private Dealer _record;

        public Dealer Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<Dealer> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Dealers.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public Result Add()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Dealers.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Dealer Record successfully.";
            }
            return result;
        }

        public Result Delete()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a Dealer Record successfully.";

                return result;
            }
        }

        public Result Edit()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a Dealer Record successfully.";
                return result;
            }
        }
    }
}
