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
    public class RaffleController
    {
        public Result result { get; set; }
        public Raffle record { get; set; }

        
        public sp_RaffleOverview_Result SelectRaffleOverview(int paramRaffleId)
        {
            IRaffle service = new RaffleRepository();
            sp_RaffleOverview_Result record = new sp_RaffleOverview_Result();

            result = new Result();

            try{
                record = service.SelectRaffleOverview(paramRaffleId);
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public List<Raffle> SelectAll()
        {
            IRaffle service = new RaffleRepository();
            List<Raffle> record = new List<Raffle>();

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
        public Raffle SelectById(int id)
        {
            IRaffle service = new RaffleRepository();
            Raffle record = new Raffle();

            result = new Result();

            try
            {
                record = service.SelectById(id);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public Raffle Select()
        {
            IRaffle service = new RaffleRepository();

            result = new Result();

            try
            {
                service.Record = record;
                record = service.Select();
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
            IRaffle service = new RaffleRepository();
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
            IRaffle service = new RaffleRepository();
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
            IRaffle service = new RaffleRepository();
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
