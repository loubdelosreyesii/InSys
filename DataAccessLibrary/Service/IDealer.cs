using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IDealer
    {
        Dealer Record { get; set; }
        
        List<Dealer> SelectAll();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
