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
    public class RaffleLuckyDrawPrizeController
    {
        public Result result { get; set; }
        public RaffleLuckyDrawPrize record { get; set; }

        public List<sp_LuckyDraw_SelectForView_Result> SelectProducts(int RaffleId)
        {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
            List<sp_LuckyDraw_SelectForView_Result> record = new List<sp_LuckyDraw_SelectForView_Result>();

            result = new Result();

            try{
                record = service.SelectProducts(RaffleId);
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<RaffleLuckyDrawPrize> SelectAll(int RaffleId)
        {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
            List<RaffleLuckyDrawPrize> record = new List<RaffleLuckyDrawPrize>();

            result = new Result();

            try
            {
                record = service.SelectAll(RaffleId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<RaffleLuckyDrawPrize> SelectAll()
        {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
            List<RaffleLuckyDrawPrize> record = new List<RaffleLuckyDrawPrize>();

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
        public Result Add()
        {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
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
        public Result SubtractWinnerPrize(int Id) {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
            
            result = new Result();
            try
            {
                record = service.Select(Id);
                service.Record = record;

                if (service.Record != null)
                {
                    service.Record.Quantity = record.Quantity - 1;
                    result = service.Edit();
                }
                result.Code = true;
                result.Message = string.Empty;
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
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
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
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
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

        public Result DeleteBulkByRaffleId()
        {
            ILuckyDrawPrize service = new LuckyDrawPrizeRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.DeleteBulkByRaffleId();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result SubtractInventoryPrice(int paramId, int paramQuantity)
        {
            IInventory service = new InventoryRepository();

            result = new Result();
            try
            {
                Inventory recordInventory= new Inventory { Id = paramId };
                service.Record = recordInventory;

                recordInventory = service.Select();
                service.Record = recordInventory;

                if (service.Record != null)
                {
                    service.Record.Quantity = service.Record.Quantity- paramQuantity;
                    result = service.Edit();
                }
                result.Code = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result AddInventoryPrice(int paramId, int paramQuantity)
        {
            IInventory service = new InventoryRepository();

            result = new Result();
            try
            {
                Inventory recordInventory = new Inventory { Id = paramId };
                service.Record = recordInventory;

                recordInventory = service.Select();
                service.Record = recordInventory;

                if (service.Record != null)
                {
                    service.Record.Quantity = service.Record.Quantity + paramQuantity;
                    result = service.Edit();
                }
                result.Code = true;
                result.Message = string.Empty;
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
