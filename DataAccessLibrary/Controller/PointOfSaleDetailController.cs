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
