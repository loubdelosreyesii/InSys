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
    public class PingPongPrizeController
    {
        public Result result { get; set; }
        public PingPongPrize record { get; set; }

        public List<sp_PingPongDraw_SelectForView_Result> SelectProducts(int paramRaffleId){
            IPingPongPrize service = new PingPongPrizeRepository();
            List<sp_PingPongDraw_SelectForView_Result> record = new List<sp_PingPongDraw_SelectForView_Result>();

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

        public List<PingPongPrize> SelectAll(){
            IPingPongPrize service = new PingPongPrizeRepository();
            List<PingPongPrize> record = new List<PingPongPrize>();

            result = new Result();

            try{
                record = service.SelectAll();
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public Result Add(){
            IPingPongPrize service = new PingPongPrizeRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Add();
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public Result SubtractWinnerPrize(int Id) {
            IPingPongPrize service = new PingPongPrizeRepository();
            
            result = new Result();
            try{
                record = service.Select(Id);
                service.Record = record;

                if (service.Record != null){
                    service.Record.Quantity = record.Quantity - 1;
                    result = service.Edit();
                }
                result.Code = true;
                result.Message = string.Empty;
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public Result Edit()
        {
            IPingPongPrize service = new PingPongPrizeRepository();
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
            IPingPongPrize service = new PingPongPrizeRepository();
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
            IPingPongPrize service = new PingPongPrizeRepository();
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
