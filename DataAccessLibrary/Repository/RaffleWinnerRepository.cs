
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
    internal class RaffleWinnerRepository : IRaffleWinner
    {
        private RaffleWinner _record;

        public RaffleWinner Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<RaffleWinner> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleWinners.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public List<RaffleWinner> SelectAll(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleWinners.Where(p=>p.RaffleId ==paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public RaffleWinner Select(string paramRaffleNumber)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.RaffleWinners.SingleOrDefault(p => p.RaffleReferenceNumber == paramRaffleNumber);

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
                db.RaffleWinners.Add(_record);
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

        public List<RaffleWinner> SelectAll(int RaffleId, int ParticipantId)
        {
            List<RaffleWinner> raffleEntries = new List<RaffleWinner>();

            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                if (ParticipantId >0)
                    raffleEntries = db.RaffleWinners.Where(p=> p.ParticipantId == ParticipantId && p.RaffleId == RaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return raffleEntries;
            }
        }

        public Result DeleteBulk(int paramParticipantId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities()){
                db.RaffleWinners.RemoveRange(db.RaffleWinners.Where(p => p.ParticipantId == paramParticipantId));
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
                db.RaffleWinners.RemoveRange(db.RaffleWinners.Where(p => p.ParticipantId == paramParticipantId && p.RaffleId == paramRaffleId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a RafflePrize Record successfully.";

                return result;
            }
        }
    }
}
