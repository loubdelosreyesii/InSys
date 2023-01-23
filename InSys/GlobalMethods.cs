using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;

namespace InSys
{
    public partial class InventoryView
    {
        public Image ProductPhoto { get; set; }
        public int Id { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public int OriginalQuantity { get; set; }
        public decimal DistributorPrice { get; set; }
        public decimal SuggestedRetailPrice { get; set; }
        public int DealerID { get; set; }
        public string DealerName { get; set; }
    }

    internal static class GlobalMethods
    {
        public static Guna2TileButton POSTotalAmountScreen{ get; set; }
        public static DataGridView POSProductView { get; set; }
        public static List<Inventory> list { get; set; }
        public static List<Reference> references { get; set; }
        public static List<Dealer> dealers { get; set; }

        public static BindingSource listSource { get; set; }

        private static InventoryController inventoryController;
        public static void UpdatePOSUI() {
            decimal decTotalAmounToBePaid = checkedProducts.Sum(p=>p.SuggestedRetailPrice * p.Quantity);
            POSTotalAmountScreen.Text = $"{string.Format(new CultureInfo("en-PH"), "{0:C}", decTotalAmounToBePaid)}";
        }

        public static void RefreshGridBindings(string paramKeyword,int paramProductTypeId)
        {
            List<InventoryView> queryList;
            inventoryController = new InventoryController();
            list = inventoryController.SelectAll();

            listSource = new BindingSource();

            listSource.DataSource = null;

            var query = from listInventories in list
                                    join listRefType in references
                                    on listInventories.TypeID equals listRefType.Id
                                    join listRefBrand in references
                                    on listInventories.BrandID equals listRefBrand.Id
                                    join listDealers in dealers
                                    on listInventories.DealerID equals listDealers.Id
                                    where listInventories.Quantity>0
                                    select new InventoryView{
                                        ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{listInventories.Id}.jpg"),
                                        Id = listInventories.Id,
                                        TypeID = listRefType.Id,
                                        TypeName = listRefType.Name,
                                        BrandID = listRefBrand.Id,
                                        BrandName = listRefBrand.Name,
                                        Model = listInventories.Model,
                                        Quantity = listInventories.Quantity,
                                        OriginalQuantity = listInventories.Quantity,
                                        DistributorPrice = listInventories.DistributorPrice,
                                        SuggestedRetailPrice = listInventories.SuggestedRetailPrice,
                                        DealerID = listDealers.Id,
                                        DealerName = listDealers.Name
                                    };

            if (paramProductTypeId > 0)
                if(paramProductTypeId<=10)
                    query = query.Where(p => p.TypeID == paramProductTypeId);
                else if(paramProductTypeId>=11)
                    query = query.Where(p => p.TypeID >= paramProductTypeId);

            if (paramKeyword.Length>0)
                queryList = query.Where(p=>p.Model.Contains(paramKeyword)).ToList();
            else
                queryList = query.ToList();

            foreach (var itemChecked in checkedProducts)
            {
                foreach (var item in queryList.Where(p => p.Id == itemChecked.Id))
                {
                    item.Quantity = item.OriginalQuantity - itemChecked.Quantity;
                }
            }

            listSource.DataSource = queryList;
            POSProductView.DataSource = listSource;
            POSProductView.Refresh();
        }
    }
}
