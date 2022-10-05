using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface ICustomer
    {
        Customer Record { get; set; }
        
        List<Customer> SelectAll();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
