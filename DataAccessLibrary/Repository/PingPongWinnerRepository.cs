
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
    internal class PingPongWinnerRepository : IPingPongWinner
    {
        private PingPongWinner _record;

        public PingPongWinner Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<PingPongWinner> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.PingPongWinners.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public List<PingPongWinner> SelectAll(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.PingPongWinners.Where(p=>p.RaffleId == paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public PingPongWinner Select(string paramRaffleNumber)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.PingPongWinners.SingleOrDefault(p => p.RaffleReferenceNumber == paramRaffleNumber);

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
                db.PingPongWinners.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new PingPong Entry Record successfully.";
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
                result.Message = "Deleted a PingPong Entry Record successfully.";

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
                result.Message = "Updated a PingPong Entry Record successfully.";
                return result;
            }
        }

        public List<PingPongWinner> SelectAll(int paramRaffleId, int ParticipantId)
        {
            List<PingPongWinner> raffleEntries = new List<PingPongWinner>();

            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                if (ParticipantId >0)
                    raffleEntries = db.PingPongWinners.Where(p=> p.ParticipantId == ParticipantId && p.RaffleId == paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return raffleEntries;
            }
        }

        public Result DeleteBulk(int paramParticipantId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities()){
                db.PingPongWinners.RemoveRange(db.PingPongWinners.Where(p => p.ParticipantId == paramParticipantId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a PingPongPrize Record successfully.";

                return result;
            }
        }

        public Result DeleteBulk(int paramRaffleId, int paramParticipantId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities()){
                db.PingPongWinners.RemoveRange(db.PingPongWinners.Where(p => p.ParticipantId == paramParticipantId && p.RaffleId == paramRaffleId));
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a PingPongPrize Record successfully.";

                return result;
            }
        }
    }
}
