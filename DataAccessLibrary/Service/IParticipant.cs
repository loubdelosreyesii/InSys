using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IParticipant
    {
        Participant Record { get; set; }
        
        List<Participant> SelectAll();
        List<Participant> SelectAllByRaffleId(int RaffleId);
        List<sp_Raffle_PickupWinner_Result> SelectRaffleParticipants(int paramRaffleId);

        Result Add();
        Result Edit();
        Result Delete();
    }
}
