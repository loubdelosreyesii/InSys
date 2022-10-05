
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
    internal class RafflePrizeRepository : IRafflePrize
    {
        private RafflePrize _record;

        public RafflePrize Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<RafflePrize> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RafflePrizes.ToList();

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
                db.RafflePrizes.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new RafflePrize Record successfully.";
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
                result.Message = "Deleted a RafflePrize Record successfully.";

                return result;
            }
        }

        public Result DeleteBulkByRaffleId()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.RafflePrizes.RemoveRange(db.RafflePrizes.Where(p=>p.RaffleId==Record.RaffleId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a RafflePrize Record successfully.";

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
                result.Message = "Updated a RafflePrize Record successfully.";
                return result;
            }
        }

        public RafflePrize Select(int id)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RafflePrizes.SingleOrDefault(p=>p.Id == id);

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public List<sp_RaffleDraw_SelectForView_Result> SelectProducts(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.sp_RaffleDraw_SelectForView(paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
