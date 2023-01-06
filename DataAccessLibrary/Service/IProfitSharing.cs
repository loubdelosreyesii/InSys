using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;
namespace DataAccessLibrary.Service{
    internal interface IProfitSharing{
        ProfitSharing Record { get; set; }
        Result result { get; set; }
        List<ProfitSharing> SelectAll();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
