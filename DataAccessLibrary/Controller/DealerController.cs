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
    public class DealerController
    {
        public Result result { get; set; }
        public Dealer record { get; set; }

        public List<Dealer> SelectAll()
        {

            IDealer service = new DealerRepository();
            List<Dealer> record = new List<Dealer>();

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
            IDealer service = new DealerRepository();
            service.Record = record;

            result = new Result();
            try
            {
                result = service.Add();

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
            IDealer service = new DealerRepository();
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
            IDealer service = new DealerRepository();
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
