using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IPingPongWinner
    {
        PingPongWinner Record { get; set; }
        List<PingPongWinner> SelectAll(int PingPongId);
        List<PingPongWinner> SelectAll();
        Result Add();
    }
}
