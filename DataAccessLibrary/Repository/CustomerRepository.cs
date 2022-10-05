using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repository
{
    internal class CustomerRepository : ICustomer
    {
        private Customer _record;

        public Customer Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<Customer> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Customers.OrderBy(p=>p.LastName).ThenBy(p=>p.FirstName).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }

        public Result Add()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Customers.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Customer Record successfully.";

            }
            return result;
        }

        public Result Delete()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a Customer Record successfully.";

                return result;
            }
        }

        public Result Edit()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a Customer Record successfully.";
                return result;
            }
        }
    }
}
