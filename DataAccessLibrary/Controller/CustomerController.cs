using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
using DataAccessLibrary.Repository;
using DataAccessLibrary.Service;
using ResultHelper;
namespace DataAccessLibrary.Controller
{
    public class CustomerController
    {
        public Result result { get; set; }
        public Customer record { get; set; }

        public List<Customer> SelectAll()
        {

            ICustomer service = new CustomerRepository();
            List<Customer> record = new List<Customer>();

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
        public Result Add()
        {
            ICustomer service = new CustomerRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Add();
                record = service.Record;
            }
            catch (Exception ex)
            {
                result.Code = false;
                result.Message = ex.ToString();
            }
            return result;
        }

        public Result Edit()
        {
            ICustomer service = new CustomerRepository();
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
            ICustomer service = new CustomerRepository();
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
