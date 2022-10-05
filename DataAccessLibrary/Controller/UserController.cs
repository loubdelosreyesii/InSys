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
    public class UserController{
        public  Result result { get; set; }
        public User record { get; set; }

        public User SelectToLogin(string paramUserName, string paramPassword)
        {
            IUser service = new UserRepository();
            User record = new User();

            result = new Result();

            try{
                record = service.SelectToLogin(paramUserName,paramPassword);
                result = service.result;
            }
            catch (Exception ex){
                result.Code = false;
                result.Message = ex.ToString();
            }
            return record;
        }

        public List<User> SelectAll(){
            
            IUser service = new UserRepository();
            List<User> record = new List<User>();

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
            IUser service = new UserRepository();
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
            IUser service = new UserRepository();
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
            IUser service = new UserRepository();
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
