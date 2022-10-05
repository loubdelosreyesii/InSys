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
    public class RaffleWinnerController
    {
        public Result result { get; set; }
        public RaffleWinner record { get; set; }

        public List<RaffleWinner> SelectAll()
        {
            IRaffleWinner service = new RaffleWinnerRepository();
            List<RaffleWinner> record = new List<RaffleWinner>();

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

        public List<RaffleWinner> SelectAll(int paramRaffleId)
        {
            IRaffleWinner service = new RaffleWinnerRepository();
            List<RaffleWinner> record = new List<RaffleWinner>();

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
            IRaffleWinner service = new RaffleWinnerRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Add();
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
