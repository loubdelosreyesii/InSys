using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface ILuckyDrawWinner
    {
        LuckyDrawWinner Record { get; set; }
        List<LuckyDrawWinner> SelectAll(int RaffleId);
        List<LuckyDrawWinner> SelectAll();
        
        sp_LuckyDraw_PickupWinner_Result SelectWinner(int paramRaffleId, int paramNumber1, int paramNumber2, int paramNumber3,int paramProductId, int paramLuckyDrawPrizeId);

        Result Add();
    }
}
