using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IRaffleWinner
    {
        RaffleWinner Record { get; set; }
        List<RaffleWinner> SelectAll(int RaffleId);
        List<RaffleWinner> SelectAll();
        Result Add();
    }
}
