using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Service;
using ResultHelper;
namespace DataAccessLibrary.Controller
{
    public class ParticipantController
    {
        public Result result { get; set; }
        public Participant record { get; set; }


        public List<sp_Raffle_PickupWinner_Result> SelectRaffleParticipants(int paramRaffleId)
        {
            IParticipant service = new ParticipantRepository();
            List<sp_Raffle_PickupWinner_Result> record = new List<sp_Raffle_PickupWinner_Result>();

            result = new Result();

            try
            {
                record = service.SelectRaffleParticipants(paramRaffleId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<Participant> SelectAll()
        {

            IParticipant service = new ParticipantRepository();
            List<Participant> record = new List<Participant>();

            result = new Result();

            try
            {
                record = service.SelectAll();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public List<Participant> SelectAllByRaffleId(int RaffleId)
        {

            IParticipant service = new ParticipantRepository();
            List<Participant> record = new List<Participant>();

            result = new Result();

            try
            {
                record = service.SelectAllByRaffleId(RaffleId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public Result Add()
        {
            IParticipant service = new ParticipantRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Add();
                record = service.Record;
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result Edit()
        {
            IParticipant service = new ParticipantRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Edit();

            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public Result Delete()
        {
            IParticipant service = new ParticipantRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Delete();

            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
    }
}
