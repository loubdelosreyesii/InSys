using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;
using System;

namespace DataAccessLibrary.Service{
    internal interface IPointOfSale{
        PointOfSale Record { get; set; }
        List<PointOfSale> SelectAll();
        List<PointOfSalesViewModel> SelectAllViewModel();
        Result Add();
        Result Edit();
        Result Delete();
        object SelectSellerTransactions(DateTime paramDateFrom, DateTime paramDateTo, string paramUserName);
    }
}
