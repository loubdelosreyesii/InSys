﻿using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Service
{
    internal interface IInventory
    {
        Inventory Record { get; set; }
        Result Result { get; set; }

        List<Inventory> SelectAll();
        List<Inventory> SelectInventories();
        Inventory Select();
        Result Add();
        Result Edit();
        Result Delete();
    }
}
