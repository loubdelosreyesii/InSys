using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;
namespace DataAccessLibrary.Service{
    internal interface IPointOfSaleDetail{
        PointOfSaleDetail Record { get; set; }
        List<PointOfSaleDetail> SelectAll();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
