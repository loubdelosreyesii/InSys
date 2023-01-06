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
    public class ProfitSharingController{
        public  Result result { get; set; }
        public ProfitSharing record { get; set; }

        public List<ProfitSharing> SelectAll(){
            
            IProfitSharing service = new ProfitSharingRepository();
            List<ProfitSharing> record = new List<ProfitSharing>();

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
            IProfitSharing service = new ProfitSharingRepository();
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
            IProfitSharing service = new ProfitSharingRepository();
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
            IProfitSharing service = new ProfitSharingRepository();
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
