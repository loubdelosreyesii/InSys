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
    public class RaffleEntryController
    {
        public Result result { get; set; }
        public RaffleEntry  record { get; set; }

        public List<RaffleEntry > SelectAll()
        {
            IRaffleEntry  service = new RaffleEntryRepository();
            List<RaffleEntry > record = new List<RaffleEntry >();

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

        public RaffleEntry Select(string  paramRaffleNumber)
        {
            IRaffleEntry service = new RaffleEntryRepository();
            RaffleEntry record = new RaffleEntry();

            result = new Result();

            try
            {
                record = service.Select(paramRaffleNumber);
            }
            catch (Exception ex)
            {
                record = null;
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }


        public List<RaffleEntry> SelectAll(int paramRaffleId,int paramParticipantId)
        {
            IRaffleEntry service = new RaffleEntryRepository();
            List<RaffleEntry> record = new List<RaffleEntry>();
            

            result = new Result();

            try
            {
                record = service.SelectAll(paramRaffleId,paramParticipantId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public List<RaffleEntry> SelectAllWithoutWinners(int paramRaffleId, int paramParticipantId)
        {
            IRaffleEntry service = new RaffleEntryRepository();
            List<RaffleEntry> record = new List<RaffleEntry>();
            List<RaffleWinner> recordWinners = new List<RaffleWinner>();

            result = new Result();

            try
            {
                record = service.SelectAll(paramRaffleId, paramParticipantId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public List<RaffleEntry> SelectAll(int paramRaffleId)
        {
            IRaffleEntry service = new RaffleEntryRepository();
            List<RaffleEntry> record = new List<RaffleEntry>();

            result = new Result();

            try
            {
                record = service.SelectAll(paramRaffleId);
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
            IRaffleEntry  service = new RaffleEntryRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Add();
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
            IRaffleEntry  service = new RaffleEntryRepository();
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
            IRaffleEntry  service = new RaffleEntryRepository();
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

        public Result DeleteBulk(int ParticipantId)
        {
            IRaffleEntry  service = new RaffleEntryRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.DeleteBulk(ParticipantId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result DeleteBulk(int paramRaffleId,int paramParticipantId)
        {
            IRaffleEntry service = new RaffleEntryRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.DeleteBulk(paramRaffleId,paramParticipantId);
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
