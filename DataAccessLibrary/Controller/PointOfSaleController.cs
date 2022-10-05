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
    public class PointOfSaleController{
        public  Result result { get; set; }
        public PointOfSale record { get; set; }
        public List<PointOfSale> SelectAll(){
            
            IPointOfSale service = new PointOfSaleRepository();
            List<PointOfSale> record = new List<PointOfSale>();

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
        public List<PointOfSalesViewModel> SelectViewModelAll()
        {
            IPointOfSale service = new PointOfSaleRepository();
            List<PointOfSalesViewModel> record = new List<PointOfSalesViewModel>();

            result = new Result();

            try
            {
                record = service.SelectAllViewModel();
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public Result Add() {
            IPointOfSale service = new PointOfSaleRepository();
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
            IPointOfSale service = new PointOfSaleRepository();
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
            IPointOfSale service = new PointOfSaleRepository();
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
