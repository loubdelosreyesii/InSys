using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;
namespace DataAccessLibrary.Service{
    internal interface IReference{
        Reference Record { get; set; }
        List<Reference> SelectAll();
        List<Reference> SelectByCategoryId(int paramId);
        Result Add();
        Result Edit();
        Result Delete();
    }
}
