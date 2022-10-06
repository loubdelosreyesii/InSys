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
    public partial class frmInventory : Form
    {
        InventoryController inventoryController = new InventoryController();
        ReferenceController referenceController = new ReferenceController();
        DealerController dealerController = new DealerController();     

        List<Inventory> list = new List<Inventory>();
        List<Reference> references = new List<Reference>();
        List<Dealer> dealers = new List<Dealer>();

        Inventory record;
        Result result;

        frmInventoryDetail frmDetail;
        BindingSource listSource = new BindingSource();

        public frmInventory()
        {
            InitializeComponent();

            references = referenceController.SelectAll();
            dealers = dealerController.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmInventoryDetail();
            frmDetail.IsAddTransaction = true;

            frmDetail.ShowDialog();
            RefreshGridBindings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Inventory();
            frmDetail = new frmInventoryDetail();


            if (dgvwRecords.RowCount == 0)
            {
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.Model = selectedRow.Model;
            record.TypeID = selectedRow.TypeID;
            record.BrandID = selectedRow.BrandID;
            record.DealerID= selectedRow.DealerID;
            record.Quantity = selectedRow.Quantity;
            record.DistributorPrice = selectedRow.DistributorPrice; 
            record.SuggestedRetailPrice = selectedRow.SuggestedRetailPrice;

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvwRecords.DataSource = listSource;
            RefreshGridBindings();
        }

        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;

            list = inventoryController.SelectAll();

            
            listSource.DataSource = from listInventories in list
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

            if (list.Count > 0)
                listSource.ResetBindings(false);
            else
                listSource.Clear();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Inventory();

            if (dgvwRecords.RowCount == 0)
            {
                MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.Model = selectedRow.Model;
            record.TypeID = selectedRow.TypeID;
            record.BrandID = selectedRow.BrandID;
            record.DealerID = selectedRow.DealerID;
            record.Quantity = selectedRow.Quantity;
            record.DistributorPrice = selectedRow.DistributorPrice;
            record.SuggestedRetailPrice = selectedRow.SuggestedRetailPrice;

            inventoryController.record = record;

            result = inventoryController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }
    }
}
