using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class CategoryRepository : ICategory
    {
        public List<Category> SelectAll()
        {
            using (var db = new X2MO_InSysEntities()) {
                var record = db.Categories.ToList();

                return record;
            }
        }
    }
}
