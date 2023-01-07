﻿using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static InSys.GlobalVariables;

namespace InSys{
    public partial class frmPOS : Form{
        InventoryController inventoryController = new InventoryController();
        ReferenceController referenceController = new ReferenceController();
        DealerController dealerController = new DealerController();
        CustomerController customerController = new CustomerController();
        PointOfSaleController pointOfSaleController = new PointOfSaleController();
        PointOfSaleDetailController pointOfSaleDetailController = new PointOfSaleDetailController();

        List<Reference> references = new List<Reference>();
        List<Dealer> dealers = new List<Dealer>();
        List<PointOfSaleDetail> listPOSDetails = new List<PointOfSaleDetail>();

        Inventory record;
        Result result;
        PointOfSale recordPOS;
        PointOfSaleDetail recordPOSDetail;
        Customer recordCustomer;

        decimal POSPrice = 00.00m;
        int itemIndex = 0;
        int intProductTypeId = 0;
        public frmPOS(){
            InitializeComponent();

            references = referenceController.SelectAll();
            dealers = dealerController.SelectAll();
        }

        private void frmPOS_Load(object sender, EventArgs e){
            
            GlobalMethods.POSProductView = dgvwRecords;
            GlobalMethods.references = references;
            GlobalMethods.dealers = dealers;

            GlobalMethods.RefreshGridBindings(string.Empty,intProductTypeId);

            if (dgvwRecords.RowCount<= 0)
            {
                MessageBox.Show("No Inventory Record yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e){
            GlobalMethods.POSTotalAmountScreen = this.lblTotalPrice;

            if (dgvwRecords.RowCount == 0)
            {
                MessageBox.Show("No Products to add to the cart. Kindly manage first your inventory.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            itemIndex += 1;

            
            var selectedItem = dgvwRecords.CurrentRow;
            dynamic selectedInventory = selectedItem.DataBoundItem;

            Inventory _inventory =  new Inventory {
                Id= selectedInventory.Id,
                TypeID = selectedInventory.TypeID,
                BrandID = selectedInventory.BrandID,
                Model = selectedInventory.Model,
                Quantity= 1,
                DistributorPrice = selectedInventory.DistributorPrice,
                SuggestedRetailPrice = selectedInventory.SuggestedRetailPrice,
                DealerID = selectedInventory.DealerID
            };

            int recordCheck= checkedProducts.Where(p => p.Id == _inventory.Id).Count();

            if (recordCheck > 0) {
                MessageBox.Show("Item is already in the cart. Please modify the item in the Cart Section.",APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            checkedProducts.Add(_inventory);

            CheckedItems checkedItem = new CheckedItems();

            checkedItem.ProductID = _inventory.Id;
            checkedItem.Brand = selectedItem.Cells["dcolBrandName"].Value.ToString();
            checkedItem.Currency = "en-PH";
            checkedItem.Model = _inventory.Model;
            checkedItem.Name = $"checkedItem{itemIndex}";
            checkedItem.parentControl =  flowLayoutPanel1;
            checkedItem.Photo = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{checkedItem.ProductID}.jpg";
            checkedItem.Price = _inventory.SuggestedRetailPrice;

            checkedItem.Quantity = _inventory.Quantity;
            checkedItem.Size = new System.Drawing.Size(284, 109);
            checkedItem.TabIndex = itemIndex;
            checkedItem.TotalPrice = _inventory.Quantity * _inventory.SuggestedRetailPrice;
            
            flowLayoutPanel1.Controls.Add(checkedItem);

            GlobalMethods.UpdatePOSUI();
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int recordCount = 0;
            DateTime dtNow = DateTime.Now;
            recordPOS = new PointOfSale();

            if(recordCustomer != null)
                recordPOS.CustomerId = recordCustomer.Id;

            recordPOS.ReceiptNumber = dtNow.ToString("yyyyhhddMMmmss");
            recordPOS.TransactionDateTime = dtNow;

            pointOfSaleController.record = recordPOS;
            pointOfSaleController.Add();

            recordPOS = pointOfSaleController.record;

            foreach (Control item in flowLayoutPanel1.Controls){
                if (item is CheckedItems){
                    CheckedItems checkedItem = (CheckedItems)item;
                    recordPOSDetail = new PointOfSaleDetail();
                    record = new Inventory();

                    recordPOSDetail.POSId = recordPOS.Id;
                    recordPOSDetail.Quantity = checkedItem.Quantity;
                    recordPOSDetail.Price = checkedItem.Price;
                    recordPOSDetail.ProductId = checkedItem.ProductID;

                    pointOfSaleDetailController.record = recordPOSDetail;
                    result = pointOfSaleDetailController.Add();

                    if (!result.Code){
                        MessageBox.Show($"{result.Message}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    recordCount += 1;
                    record.Id = recordPOSDetail.ProductId;
                    inventoryController.record = record;
                    
                    record = inventoryController.Select();

                    if (!inventoryController.result.Code){
                        MessageBox.Show($"{result.Message}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (record != null){
                        record.Quantity = record.Quantity-checkedItem.Quantity;
                        inventoryController.record = record;
                        inventoryController.Edit();
                    }
                }
            }
            if (recordCount > 0)
            {
                MessageBox.Show("POS Transaction Record saved successfully.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetVariables();
            }
            else {
                MessageBox.Show("No items in the cart found. Please try again.", APP_NAME, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void ResetVariables() {
            checkedProducts.Clear();
            flowLayoutPanel1.Controls.Clear();
            GlobalMethods.UpdatePOSUI();
            GlobalMethods.RefreshGridBindings(string.Empty, intProductTypeId);
        }
        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        string strKeyword = string.Empty;

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            intProductTypeId = 0;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            intProductTypeId = 1;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            intProductTypeId = 2;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            intProductTypeId = 3;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            intProductTypeId = 4;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            intProductTypeId = 5;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            intProductTypeId = 6;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            intProductTypeId = 7;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            intProductTypeId = 8;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            intProductTypeId = 9;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            intProductTypeId = 10;
            GlobalMethods.RefreshGridBindings(txtSearchProducts.Text, intProductTypeId);
        }
    }
}
