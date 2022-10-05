using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;

namespace DataAccessLibrary.Service{
    internal interface IPointOfSale{
        PointOfSale Record { get; set; }
        List<PointOfSale> SelectAll();
        List<PointOfSalesViewModel> SelectAllViewModel();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
