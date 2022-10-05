using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IRaffleEntry
    {
        RaffleEntry Record { get; set; }
        
        List<RaffleEntry> SelectAll();
        RaffleEntry Select(string paramRaffleNumber);
        List<RaffleEntry> SelectAll(int RaffleId, int ParticipantId);
        List<RaffleEntry> SelectAll(int RaffleId);
        Result Add();
        Result Edit();
        Result Delete();
        Result DeleteBulk(int paramParticipantId);
        Result DeleteBulk(int paramRaffleId,int paramParticipantId);
    }
}
