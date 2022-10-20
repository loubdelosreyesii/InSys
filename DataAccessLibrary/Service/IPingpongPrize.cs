using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IPingPongPrize
    {
        PingPongPrize Record { get; set; }
        
        List<PingPongPrize> SelectAll();
        List<sp_PingPongDraw_SelectForView_Result> SelectProducts(int paramRaffleId);
        PingPongPrize Select(int id);
        Result Add();
        Result Edit();
        Result Delete();
        Result DeleteBulkByRaffleId();
    }
}
