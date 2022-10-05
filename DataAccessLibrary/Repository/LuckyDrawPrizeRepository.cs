
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
    internal class LuckyDrawPrizeRepository : ILuckyDrawPrize
    {
        private RaffleLuckyDrawPrize _record;

        public RaffleLuckyDrawPrize Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<RaffleLuckyDrawPrize> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleLuckyDrawPrizes.ToList();

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
                db.RaffleLuckyDrawPrizes.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Lucky Draw Prize Record successfully.";
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
                result.Message = "Deleted a  Lucky Draw Prize Record successfully.";

                return result;
            }
        }

        public Result DeleteBulkByRaffleId()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.RaffleLuckyDrawPrizes.RemoveRange(db.RaffleLuckyDrawPrizes.Where(p=>p.RaffleId==Record.RaffleId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a  Lucky Draw Prize Record successfully.";

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
                result.Message = "Updated a LuckyDraw Prize Record successfully.";
                return result;
            }
        }

        public RaffleLuckyDrawPrize Select(int id)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleLuckyDrawPrizes.SingleOrDefault(p=>p.Id == id);

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public List<RaffleLuckyDrawPrize> SelectAll(int RaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleLuckyDrawPrizes.Where(p=>p.RaffleId == RaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public List<sp_LuckyDraw_SelectForView_Result> SelectProducts(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.sp_LuckyDraw_SelectForView(paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
