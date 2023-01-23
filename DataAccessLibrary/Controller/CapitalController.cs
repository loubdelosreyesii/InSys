using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Service;
using ResultHelper;
namespace DataAccessLibrary.Controller{
    public class CapitalController{
        public  Result result { get; set; }
        public Capital record { get; set; }

        public decimal SelectCurrentBalance() {
            ICapital service = new CapitalRepository();
            decimal decCurrentBalance = 0.00m;

            result = new Result();

            try
            {
                decCurrentBalance = service.SelectAll().First().Amount;
            }
            catch (Exception ex)
            {
                decCurrentBalance = 0.00m;
                result.Code = false;
                result.Message = ex.ToString();
            }
            return decCurrentBalance;
        }
        public Result AddFund(string paramTransaction) {
            ICapital service = new CapitalRepository();
            List<Capital> records = new List<Capital>();
            service.Record = record;

            result = new Result();

            try
            {
                records = SelectAll();
                if (records.Count <= 0)
                    result = service.Add(paramTransaction);
                else
                    result = service.Edit(false,"Add Fund");
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public List<Capital> SelectAll(){
            
            ICapital service = new CapitalRepository();
            List<Capital> record = new List<Capital>();

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

        public Result Add(string paramTransaction) {
            ICapital service = new CapitalRepository();
            service.Record = record;
            
            result = new Result();
            try{
                result = service.Add(paramTransaction);
               
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result Edit(bool paramIsNotExecuted,string paramTransaction)
        {
            ICapital service = new CapitalRepository();
            service.Record = record;

            result = new Result();
            try{
                result = service.Edit(paramIsNotExecuted,paramTransaction);
                
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }
        public List<CapitalHistory> GetCapitalHistories(DateTime paramDateFrom, DateTime paramDateTo)
        {
            ICapital service = new CapitalRepository();
            List<CapitalHistory> records = new List<CapitalHistory>();
            result = new Result();
            try
            {
                records = service.GetCapitalHistories(paramDateFrom, paramDateTo);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return records;
        }
    }
}
