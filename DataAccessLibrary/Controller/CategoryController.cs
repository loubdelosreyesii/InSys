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
    public class CategoryController{
        internal Result resultHelper { get; set; }

        public List<Category> SelectAll(){
            
            ICategory service = new CategoryRepository();
            List<Category> record = new List<Category>();
            
            resultHelper = new Result();

            try
            {
                record = service.SelectAll();

                resultHelper.Code = true;
                resultHelper.Message = String.Empty;
            }
            catch (Exception ex)
            {
                resultHelper.Code = false;
                resultHelper.Message = ex.ToString();
            }
            return record;
        }
    }
}
