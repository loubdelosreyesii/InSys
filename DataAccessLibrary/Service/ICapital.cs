using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Service
{
    internal interface ICapital
    {
        Capital Record { get; set; }
        List<Capital> SelectAll();
        Result Add(string paramTransaction);
        Result Edit(bool paramIsNotExecute,string paramTransaction);
        List<CapitalHistory> GetCapitalHistories(DateTime paramDateFrom,DateTime paramDateTo);
    }
}
