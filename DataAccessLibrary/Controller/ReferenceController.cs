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
    public class ReferenceController{
        public  Result result { get; set; }
        public Reference record { get; set; }
        public List<Reference> SelectAll(){
            
            IReference service = new ReferenceRepository();
            List<Reference> record = new List<Reference>();

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
        public List<Reference> SelectByCategoryId(int Id)
        {

            IReference service = new ReferenceRepository();
            List<Reference> record = new List<Reference>();

            result = new Result();

            try
            {
                record = service.SelectByCategoryId(Id);
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public Result Add() {
            IReference service = new ReferenceRepository();
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
            IReference service = new ReferenceRepository();
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
            IReference service = new ReferenceRepository();
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
