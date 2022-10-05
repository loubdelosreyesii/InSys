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
    public class LuckyDrawWinnerController
    {
        public Result result { get; set; }
        public LuckyDrawWinner record { get; set; }

        public sp_LuckyDraw_PickupWinner_Result SelectWinner(int paramRaffleId, int paramNumber1, int paramNumber2, int paramNumber3, int paramProductId, int paramLuckyDrawPrizeId)
        {
            ILuckyDrawWinner service = new LuckyDrawWinnerRepository();
            sp_LuckyDraw_PickupWinner_Result record = new sp_LuckyDraw_PickupWinner_Result();

            result = new Result();

            try{
                record = service.SelectWinner(paramRaffleId, paramNumber1, paramNumber2, paramNumber3,paramProductId, paramLuckyDrawPrizeId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<LuckyDrawWinner> SelectAll()
        {
            ILuckyDrawWinner service = new LuckyDrawWinnerRepository();
            List<LuckyDrawWinner> record = new List<LuckyDrawWinner>();

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

        public List<LuckyDrawWinner> SelectAll(int paramRaffleId)
        {
            ILuckyDrawWinner service = new LuckyDrawWinnerRepository();
            List<LuckyDrawWinner> record = new List<LuckyDrawWinner>();

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
            ILuckyDrawWinner service = new LuckyDrawWinnerRepository();
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
