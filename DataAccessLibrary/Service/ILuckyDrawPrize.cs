using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface ILuckyDrawPrize
    {
        RaffleLuckyDrawPrize Record { get; set; }
        
        List<RaffleLuckyDrawPrize> SelectAll();
        List<RaffleLuckyDrawPrize> SelectAll(int RaffleId);
        List<sp_LuckyDraw_SelectForView_Result> SelectProducts(int paramRaffleId);
        RaffleLuckyDrawPrize Select(int id);
        Result Add();
        Result Edit();
        Result Delete();
        Result DeleteBulkByRaffleId();
    }
}

