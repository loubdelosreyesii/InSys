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
        List<Reference> listOfProductTypes = new List<Reference>();

        Inventory record;
        Result result;

        frmInventoryDetail frmDetail;
        BindingSource listSource = new BindingSource();
        BindingSource listSourceProductType = new BindingSource();

        int selectedProductId=0;
        string strKeywordSearch = string.Empty;

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

        //public void frmLoad()
        //{
        //    listOfProductTypes = referenceController.SelectByCategoryId(1);
        //    listOfProductTypes.Insert(0, new Reference { Id = 0, Name = "All Product Types", CategoryID = 0, Description = "All Product Types" });
        //    dgvwRecords.DataSource = listSource;

        //    RefreshGridBindings();
        //}
        private void frmInventory_Load(object sender, EventArgs e)
        {
            listOfProductTypes = referenceController.SelectByCategoryId(1);
            listOfProductTypes.Insert(0,new Reference { Id = 0, Name= "All Product Types", CategoryID=0 , Description= "All Product Types"}) ;
            dgvwRecords.DataSource = listSource;

            RefreshGridBindings();
        }

        private void RefreshGridBindings()
        {
            int intProductType = selectedProductId;

            dgvwRecords.ScrollBars = ScrollBars.Both;

            if (strKeywordSearch.Length <= 0)
                list = inventoryController.SelectAll();
            else
            {
                inventoryController.record = new Inventory();
                inventoryController.record.Model = strKeywordSearch;
                list = inventoryController.SelectInventories();
            }

            if (intProductType > 0)
            {
                if (list.Count(x => x.TypeID == intProductType) > 0)
                {
                    if (intProductType <= 10)
                    {
                        listSource.DataSource = from listInventories in list
                                                join listRefType in references
                                                on listInventories.TypeID equals listRefType.Id
                                                join listRefBrand in references
                                                on listInventories.BrandID equals listRefBrand.Id
                                                join listDealers in dealers
                                                on listInventories.DealerID equals listDealers.Id
                                                where listInventories.TypeID == intProductType
                                                select new
                                                {
                                                    ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{listInventories.Id}.jpg"),
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
                    }
                    else {
                        listSource.DataSource = from listInventories in list
                                                join listRefType in references
                                                on listInventories.TypeID equals listRefType.Id
                                                join listRefBrand in references
                                                on listInventories.BrandID equals listRefBrand.Id
                                                join listDealers in dealers
                                                on listInventories.DealerID equals listDealers.Id
                                                where listInventories.TypeID >=intProductType
                                                select new
                                                {
                                                    ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{listInventories.Id}.jpg"),
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
                    }
                }
                else
                {
                    MessageBox.Show("No Products yet available in the selected Product Type.", "InSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                listSource.DataSource = from listInventories in list
                                        join listRefType in references
                                        on listInventories.TypeID equals listRefType.Id
                                        join listRefBrand in references
                                        on listInventories.BrandID equals listRefBrand.Id
                                        join listDealers in dealers
                                        on listInventories.DealerID equals listDealers.Id
                                        select new
                                        {
                                            ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{listInventories.Id}.jpg"),
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
            }
            listSource.ResetBindings(false);

            FormatDataGridView();
            GetInventoryTotalCost();
        }
        private void GetInventoryTotalCost() {
            inventoryController = new InventoryController();
            lblInventoryAmount.Text = inventoryController.SelectRemainingInventoryAmount().ToString("N");
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

        private void cboxProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshGridBindings();
        }

        private void cboxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
          RefreshGridBindings();
        }

        

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            selectedProductId = 1;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            selectedProductId = 0;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            selectedProductId = 2;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            selectedProductId = 3;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            selectedProductId = 4;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            selectedProductId = 5;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            selectedProductId = 6;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            selectedProductId = 7;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            selectedProductId = 8;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            selectedProductId = 9;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            selectedProductId = 10;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            strKeywordSearch = txtKeywordSearch.Text.Trim();
            RefreshGridBindings();
        }

        private void FormatDataGridView()
        {
            if (dgvwRecords.Rows.Count > 0)
            {
                dgvwRecords.Columns["Id"].Visible = false;
                dgvwRecords.Columns["TypeId"].Visible = false;
                dgvwRecords.Columns["BrandId"].Visible = false;
                dgvwRecords.Columns["DealerId"].Visible = false;

                dgvwRecords.Columns["ProductPhoto"].HeaderText = "Product Photo";
                dgvwRecords.Columns["BrandName"].HeaderText = "Brand";
                dgvwRecords.Columns["TypeName"].HeaderText = "Product Type";
                dgvwRecords.Columns["DistributorPrice"].HeaderText = "Distributor Price";
                dgvwRecords.Columns["SuggestedRetailPrice"].HeaderText = "Selling Price";
                dgvwRecords.Columns["DealerName"].HeaderText = "Dealer";


                ((DataGridViewImageColumn)dgvwRecords.Columns["ProductPhoto"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

                //ID = listInventories.Id,
                //                            TypeID = listRefType.Id,
                //                            TypeName = listRefType.Name,
                //                            BrandID = listRefBrand.Id,
                //                            BrandName = listRefBrand.Name,
                //                            Model = listInventories.Model,
                //                            Quantity = listInventories.Quantity,
                //                            DistributorPrice = listInventories.DistributorPrice,
                //                            SuggestedRetailPrice = listInventories.SuggestedRetailPrice,
                //                            DealerID = listDealers.Id,
                //                            DealerName = listDealers.Name

                dgvwRecords.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvwRecords.Columns["DistributorPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvwRecords.Columns["SuggestedRetailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvwRecords.Columns["Model"].Width = 250;
                dgvwRecords.Columns["DistributorPrice"].Width = 150;
                dgvwRecords.Columns["SuggestedRetailPrice"].Width = 150;
                dgvwRecords.Columns["DealerName"].Width = 200;


            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            selectedProductId = 11;
            strKeywordSearch = string.Empty;
            RefreshGridBindings();
        }
    }
}
