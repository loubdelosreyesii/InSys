using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmInventorySearch : Form
    {
        InventoryController inventoryController = new InventoryController();
        ReferenceController referenceController = new ReferenceController();
        DealerController dealerController = new DealerController();     

        List<Inventory> list = new List<Inventory>();
        List<Reference> references = new List<Reference>();
        List<Dealer> dealers = new List<Dealer>();

        BindingSource listSource = new BindingSource();

        public Inventory Record { get; set; }
        public string BrandName { get; set; }
        public frmInventorySearch()
        {
            InitializeComponent();

            references = referenceController.SelectAll();
            dealers = dealerController.SelectAll();
        }

        private void frmInventorySearch_Load(object sender, EventArgs e)
        {
            RefreshGridBindings(string.Empty);  
            dgvwRecords.DataSource = listSource;
        }

        private void RefreshGridBindings(string paramKeyword)
        {
            List<Inventory> inventories = new List<Inventory>();    

            list = inventoryController.SelectAll().Where(p => p.Quantity > 0).ToList();

            listSource.DataSource = null;
            var query = from listInventories in list
                                    join listRefType in references
                                    on listInventories.TypeID equals listRefType.Id
                                    join listRefBrand in references
                                    on listInventories.BrandID equals listRefBrand.Id
                                    join listDealers in dealers
                                    on listInventories.DealerID equals listDealers.Id
                                    select new
                                    {
                                        ProductPhoto = Image.FromFile($"{ Path.GetDirectoryName(Application.ExecutablePath) }\\Products\\{listInventories.Id}.jpg"),
                                        ID = listInventories.Id,
                                        TypeID = listRefType.Id,
                                        TypeName = listRefType.Name,
                                        BrandID = listRefBrand.Id,
                                        BrandName = listRefBrand.Name,
                                        Model = listInventories.Model,
                                        Quantity = listInventories.Quantity,
                                        DistributorPrice = listInventories.DistributorPrice,
                                        SuggestedRetailPrice = listInventories.SuggestedRetailPrice,
                                        DealerID = listDealers.Id,
                                        DealerName = listDealers.Name
                                    };
            dynamic customers;

            if (paramKeyword.Length > 0)
                customers = query.Where(p => p.Model.Contains(paramKeyword) || p.BrandName.Contains(paramKeyword)).ToList();
            else
                customers = query.ToList();

            listSource.DataSource = customers;
            listSource.ResetBindings(false);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvwRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwRecords.RowCount > 0)
            {
                Record = new Inventory();
                dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

                Record.Id = selectedRow.ID;
                Record.Model = selectedRow.Model;
                Record.TypeID = selectedRow.TypeID;
                Record.BrandID = selectedRow.BrandID;
                Record.DealerID = selectedRow.DealerID;
                Record.Quantity = selectedRow.Quantity;
                Record.DistributorPrice = selectedRow.DistributorPrice;
                Record.SuggestedRetailPrice = selectedRow.SuggestedRetailPrice;
                BrandName = selectedRow.BrandName;
                this.Close();
            }
        }

        private void dgvwRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
