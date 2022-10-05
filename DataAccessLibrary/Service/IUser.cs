using DataAccessLibrary.Model;
using System.Collections.Generic;
using ResultHelper;
namespace DataAccessLibrary.Service{
    internal interface IUser{
        User Record { get; set; }
        Result result { get; set; }
        List<User> SelectAll();
        User SelectToLogin(string paramUserName, string paramPassword);
        Result Add();
        Result Edit();
        Result Delete();
    }
}
