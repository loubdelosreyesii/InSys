﻿using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmInventoryDetail : Form
    {
        ReferenceController referenceController = new ReferenceController();
        InventoryController inventoryController = new InventoryController();
        DealerController dealerController = new DealerController(); 

        public Inventory Record { get; set; }

        public bool IsAddTransaction   { get; set; }
        public Result result { get; set; }

        private List<Reference> references;
        private List<Dealer> dealers;

        string strPhotoName = string.Empty;

        public frmInventoryDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtModel.Text.Length > 0)
                if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal decSuggestedRetailPrice = 0.00m;
            decimal decDistributorPrice = 0.00m;
            int intQuantity = 0;
            if (picProductPhoto.Image == null) {
                MessageBox.Show("Please select an image for this inventory record.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtModel.Text.Trim().Length<=0)
            {
                MessageBox.Show("No Model provided.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtSuggestedRetailPrice.Text, out decSuggestedRetailPrice)) {
                MessageBox.Show("Invalid Suggested Retail Price Amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(txtDistributorPrice.Text, out decDistributorPrice))
            {
                MessageBox.Show("Invalid Distributor Price Amount.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out intQuantity))
            {
                MessageBox.Show("Invalid Quantity Value.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (decDistributorPrice < 0)
            {
                MessageBox.Show("Negative value for Distributor Price  is not allowed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (decSuggestedRetailPrice < 0)
            {
                MessageBox.Show("Negative value for Suggested Retail Price is not allowed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (intQuantity < 0) {
                MessageBox.Show("Negative value for Quantity is not allowed.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsAddTransaction)
            {
                Record = new Inventory();

                Record.Model = txtModel.Text;
                Record.TypeID = Convert.ToInt32(cboxTypes.SelectedValue);
                Record.BrandID = Convert.ToInt32(cboxBrands.SelectedValue);
                Record.DealerID = Convert.ToInt32(cboxDealers.SelectedValue);
                Record.Quantity = Convert.ToInt32(txtQuantity.Text);
                Record.DistributorPrice = Convert.ToDecimal(decDistributorPrice);
                Record.SuggestedRetailPrice = Convert.ToDecimal(decSuggestedRetailPrice);

                inventoryController.record = Record;
                result = inventoryController.Add();

                string strImgFolder = Path.GetDirectoryName(Application.ExecutablePath) + $"\\Products";

                if (strPhotoName.Length > 0 && !Directory.Exists(strImgFolder))
                {
                    Directory.CreateDirectory(strImgFolder);
                }
                File.Copy(strPhotoName, strImgFolder + $"\\" + Record.Id + ".jpg", true);

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Record.Model = txtModel.Text;
                Record.TypeID = Convert.ToInt32(cboxTypes.SelectedValue);
                Record.BrandID = Convert.ToInt32(cboxBrands.SelectedValue);
                Record.DealerID = Convert.ToInt32(cboxDealers.SelectedValue);
                Record.Quantity = Convert.ToInt32(txtQuantity.Text);
                Record.DistributorPrice = Convert.ToDecimal(decDistributorPrice);
                Record.SuggestedRetailPrice = Convert.ToDecimal(decSuggestedRetailPrice);

                inventoryController.record = Record;
                result = inventoryController.Edit();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           

            this.Close();
        }

        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            references = referenceController.SelectAll();
            dealers = dealerController.SelectAll();

            cboxBrands.DataSource = references.Where(r => r.CategoryID==2).ToList();
            cboxBrands.DisplayMember = "Name";
            cboxBrands.ValueMember = "ID";

            cboxTypes.DataSource = references.Where(r => r.CategoryID == 1).ToList();
            cboxTypes.DisplayMember = "Name";
            cboxTypes.ValueMember = "ID";

            cboxDealers.DataSource = dealers;
            cboxDealers.DisplayMember = "Name";
            cboxDealers.ValueMember = "ID";

            if (cboxBrands.Items.Count <= 0) {
                MessageBox.Show("No Brands in the Reference Module found yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (cboxTypes.Items.Count <= 0)
            {
                MessageBox.Show("No Types in the Reference Module found yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (cboxDealers.Items.Count <= 0)
            {
                MessageBox.Show("No Dealers in the Dealers Module found yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            if (Record != null)
            {
                txtModel.Text = Record.Model;
                cboxTypes.SelectedValue = Record.TypeID;
                cboxBrands.SelectedValue = Record.BrandID;
                cboxDealers.SelectedValue = Record.DealerID;
                txtDistributorPrice.Text = Record.DistributorPrice.ToString();
                txtSuggestedRetailPrice.Text= Record.SuggestedRetailPrice.ToString();
                txtQuantity.Text = Record.Quantity.ToString();
                string strImgFolder = Path.GetDirectoryName(Application.ExecutablePath) + $"\\Products";

                picProductPhoto.Image = new Bitmap($"{strImgFolder}\\{Record.Id}.jpg");
                btnUploadPicture.Visible = false;
            }
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                strPhotoName = open.FileName;
                picProductPhoto.Image = new Bitmap(strPhotoName);
            }
        }

    }
}
