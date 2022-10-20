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
    public class PingPongWinnerController
    {
        public Result result { get; set; }
        public PingPongWinner record { get; set; }

        public List<PingPongWinner> SelectAll()
        {
            IPingPongWinner service = new PingPongWinnerRepository();
            List<PingPongWinner> record = new List<PingPongWinner>();

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

        public List<PingPongWinner> SelectAll(int paramRaffleId)
        {
            IPingPongWinner service = new PingPongWinnerRepository();
            List<PingPongWinner> record = new List<PingPongWinner>();

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
            IPingPongWinner service = new PingPongWinnerRepository();
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
