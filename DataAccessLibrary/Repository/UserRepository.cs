using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class UserRepository : IUser
    {
        private User _record;

        public User Record{ 
            get => _record; 
            set => _record= value; 
        }
        public Result result { get ; set; }
        
        public List<User> SelectAll(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Users.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Result Add(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Users.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new User Record successfully.";
            }
                return result;
        }

        public Result Delete(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a User Record successfully.";

                return result;
            }
        }
        public Result Edit(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a User Record successfully.";
                return result;
            }
        }

        public User SelectToLogin(string paramUserName, string paramPassword)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Users.SingleOrDefault(p => p.UserName == paramUserName && p.Password == paramPassword);

                if (record != null){
                    result.Code = true;
                    result.Message = String.Empty;
                }
                else {
                    result.Code = false;
                    result.Message = "No UserName and Password found. Please try again.";
                }

                return record;
            }
        }
    }
}
