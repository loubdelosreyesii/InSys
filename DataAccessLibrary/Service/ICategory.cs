using DataAccessLibrary.Model;
using System.Collections.Generic;

namespace DataAccessLibrary.Service
{
    internal interface ICategory
    {
        List<Category> SelectAll();
    }
}
