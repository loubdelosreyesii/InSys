using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Service;
using ResultHelper;
namespace DataAccessLibrary.Controller{
    public class PointOfSaleDetailController{
        public  Result result { get; set; }
        public PointOfSaleDetail record { get; set; }
        public List<PointOfSaleDetail> SelectAll(){
            
            IPointOfSaleDetail service = new PointOfSaleDetailRepository();
            List<PointOfSaleDetail> record = new List<PointOfSaleDetail>();

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
        public Result Add() {
            IPointOfSaleDetail service = new PointOfSaleDetailRepository();
            ICapital serviceCaptical = new CapitalRepository();
            IInventory serviceInventory = new InventoryRepository();

            service.Record = record;
            var recordInventory = serviceInventory.SelectAll().First(p => p.Id == record.ProductId);
            result = new Result();
            try{
                result = service.Add();
                serviceCaptical.Record = new Capital { Id = 1, Amount= serviceCaptical.SelectAll().First().Amount + (record.Price * record.Quantity), TransactionDateTime = DateTime.Now };
                result = serviceCaptical.Edit(false,$"Sold Product : {recordInventory.Model}; Price: {record.Price}; Qty: {record.Quantity};");
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result Edit()
        {
            IPointOfSaleDetail service = new PointOfSaleDetailRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Edit();
                
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public Result Delete()
        {
            IPointOfSaleDetail service = new PointOfSaleDetailRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Delete();
               
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
    }
}
