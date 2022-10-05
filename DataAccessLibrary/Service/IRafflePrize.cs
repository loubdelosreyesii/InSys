using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IRafflePrize
    {
        RafflePrize Record { get; set; }
        
        List<RafflePrize> SelectAll();
        List<sp_RaffleDraw_SelectForView_Result> SelectProducts(int paramRaffleId);
        RafflePrize Select(int id);
        Result Add();
        Result Edit();
        Result Delete();
        Result DeleteBulkByRaffleId();
    }
}
