using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IRaffle
    {
        Raffle Record { get; set; }
        
        List<Raffle> SelectAll();
        sp_RaffleOverview_Result SelectRaffleOverview(int paramRaffleId); 
        Raffle SelectById(int Id);
        Raffle Select();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
