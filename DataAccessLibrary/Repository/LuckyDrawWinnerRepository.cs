
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
    internal class LuckyDrawWinnerRepository : ILuckyDrawWinner
    {
        private LuckyDrawWinner _record;

        public LuckyDrawWinner Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<LuckyDrawWinner> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.LuckyDrawWinners.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public List<LuckyDrawWinner> SelectAll(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.LuckyDrawWinners.Where(p=>p.RaffleId ==paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public LuckyDrawWinner Select(string paramRaffleNumber)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.LuckyDrawWinners.SingleOrDefault(p => p.RaffleReferenceNumber == paramRaffleNumber);

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
                db.LuckyDrawWinners.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Raffle Entry Record successfully.";
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
                result.Message = "Deleted a Raffle Entry Record successfully.";

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
                result.Message = "Updated a Raffle Entry Record successfully.";
                return result;
            }
        }

        public List<LuckyDrawWinner> SelectAll(int RaffleId, int ParticipantId)
        {
            List<LuckyDrawWinner> raffleEntries = new List<LuckyDrawWinner>();

            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                if (ParticipantId >0)
                    raffleEntries = db.LuckyDrawWinners.Where(p=> p.ParticipantId == ParticipantId && p.RaffleId == RaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return raffleEntries;
            }
        }

        public Result DeleteBulk(int paramParticipantId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities()){
                db.LuckyDrawWinners.RemoveRange(db.LuckyDrawWinners.Where(p => p.ParticipantId == paramParticipantId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a RafflePrize Record successfully.";

                return result;
            }
        }

        public Result DeleteBulk(int paramRaffleId, int paramParticipantId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities()){
                db.LuckyDrawWinners.RemoveRange(db.LuckyDrawWinners.Where(p => p.ParticipantId == paramParticipantId && p.RaffleId == paramRaffleId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a RafflePrize Record successfully.";

                return result;
            }
        }

        public sp_LuckyDraw_PickupWinner_Result SelectWinner(int paramRaffleId, int paramNumber1, int paramNumber2, int paramNumber3, int paramProductId, int paramLuckyDrawPrizeId)
        {
            sp_LuckyDraw_PickupWinner_Result winner;

            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                winner = db.sp_LuckyDraw_PickupWinner(paramRaffleId, paramNumber1, paramNumber2, paramNumber3, paramProductId,paramLuckyDrawPrizeId).SingleOrDefault();

                result.Code = true;
                result.Message = String.Empty;

                return winner;
            }
        }
    }
}
