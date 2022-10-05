using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSys
{
    internal static class GlobalVariables
    {
        public const string APP_NAME = "InSys v1.0";
        public const string APP_CURRENCY = "en-PH";
        public static List<Inventory> checkedProducts = new List<Inventory>();
    }
}
