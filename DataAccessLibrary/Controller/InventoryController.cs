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
    public class InventoryController{

        public  Result result { get; set; }
        public Inventory record { get; set; }

        public Inventory Select(){
            IInventory service = new InventoryRepository();
            result = new Result();

            try{
                service.Record = record;
                record = service.Select();

                result = service.Result;
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }
        public decimal SelectRemainingInventoryAmount() {
            IInventory service = new InventoryRepository();
            Decimal decAmount;
            
            decAmount= service.SelectRemainingInventoryAmount();
           
            return decAmount;
        }
        public List<Inventory> SelectAll(int RaffleId)
        {

            IInventory service = new InventoryRepository();
            List<Inventory> records = new List<Inventory>();

            result = new Result();

            try
            {
                records = service.SelectAll();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return records;

        }

        public List<Inventory> SelectInventories()
        {
            IInventory service = new InventoryRepository();
            List<Inventory> records = new List<Inventory>();

            result = new Result();

            try
            {
                service.Record = record;
                records = service.SelectInventories();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return records;

        }

        public List<Inventory> SelectAll(){
            
            IInventory service = new InventoryRepository();
            List<Inventory> records = new List<Inventory>();

            result = new Result();

            try{
                records = service.SelectAll();
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return records;
        }
        public Result Add() {
            IInventory service = new InventoryRepository();
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

        public Result Edit()
        {
            IInventory service = new InventoryRepository();
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
            IInventory service = new InventoryRepository();
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
