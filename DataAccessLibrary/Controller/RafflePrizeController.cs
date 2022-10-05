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
    public class RafflePrizeController
    {
        public Result result { get; set; }
        public RafflePrize record { get; set; }

        public List<sp_RaffleDraw_SelectForView_Result> SelectProducts(int paramRaffleId)
        {
            IRafflePrize service = new RafflePrizeRepository();
            List<sp_RaffleDraw_SelectForView_Result> record = new List<sp_RaffleDraw_SelectForView_Result>();

            result = new Result();

            try{
                record = service.SelectProducts(paramRaffleId);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<RafflePrize> SelectAll()
        {
            IRafflePrize service = new RafflePrizeRepository();
            List<RafflePrize> record = new List<RafflePrize>();

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
            IRafflePrize service = new RafflePrizeRepository();
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
            IRafflePrize service = new RafflePrizeRepository();
            
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
            IRafflePrize service = new RafflePrizeRepository();
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
            IRafflePrize service = new RafflePrizeRepository();
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
            IRafflePrize service = new RafflePrizeRepository();
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
                Inventory recordInventory = new Inventory { Id = paramId };
                service.Record = recordInventory;

                recordInventory = service.Select();
                service.Record = recordInventory;

                if (service.Record != null)
                {
                    service.Record.Quantity = service.Record.Quantity - paramQuantity;
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
