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
    internal class ParticipantRepository : IParticipant
    {
        private Participant _record;

        public Participant Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<Participant> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = (from part in db.Participants
                              join re in  db.RaffleEntries
                              on part.Id equals re.ParticipantId
                              select part).OrderBy(p=>p.LastName).ThenBy(p=>p.FirstName).ToList();

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
                db.Participants.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Participant Record successfully.";

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
                result.Message = "Deleted a Participant Record successfully.";

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
                result.Message = "Updated a Participant Record successfully.";
                return result;
            }
        }

        public List<Participant> SelectAllByRaffleId(int RaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var raffleParticipants =(from part in db.RaffleEntries where part.RaffleId ==RaffleId select part.ParticipantId);
                
                var record = (from part in db.Participants
                              where raffleParticipants.Contains(part.Id)
                                select part).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public List<sp_Raffle_PickupWinner_Result> SelectRaffleParticipants(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                var record = db.sp_Raffle_PickupWinner( paramRaffleId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
