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
    public partial class frmRafflePrizeDetail : Form
    {
        RafflePrizeController RafflePrizeController = new RafflePrizeController();

        public RafflePrize Record { get; set; }
        public Raffle RecordRaffle { get; set; }
        public bool IsAddTransaction { get; set; }
        public Result result { get; set; }
        public string ProductToUpdate { get; set; }
        private Inventory selectedProduct;
        public frmRafflePrizeDetail(){
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e){
            if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Tag == null || txtProductName.Tag.ToString().Length <= 0)
            {
                MessageBox.Show("Please select Product in the Inventory first.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudQuantity.Value == 0) {
                MessageBox.Show("Set the Quantity before saving this prize record.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudQuantity.Value > selectedProduct.Quantity) {
                MessageBox.Show($"You can only set the Maximum Number of Prizes to : {selectedProduct.Quantity}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsAddTransaction){
                Record = new RafflePrize();

                Record.RaffleId = RecordRaffle.Id;

                if (txtProductName.Text.Length > 0)
                    Record.ProductId = Convert.ToInt32(txtProductName.Tag);

                if (nudQuantity.Value > 0)
                    Record.Quantity = Convert.ToInt32(nudQuantity.Value);
                
                RafflePrizeController.record = Record;
                result = RafflePrizeController.Add();

                RafflePrizeController.SubtractInventoryPrice(Record.ProductId, Math.Abs(Record.Quantity));


                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                int previousQuantity = 0;
                int QuantityToUpdate = 0;

                Record.RaffleId = Convert.ToInt32(RecordRaffle.Id);
                Record.ProductId = Convert.ToInt32(txtProductName.Tag);
                Record.Quantity = Convert.ToInt32(nudQuantity.Value);
                RafflePrizeController.record = Record;
                
                result = RafflePrizeController.Edit();

                QuantityToUpdate = previousQuantity - Record.Quantity;
                if (QuantityToUpdate > 0)
                {
                    //Add to Inventory back
                    RafflePrizeController.AddInventoryPrice(Record.ProductId, Math.Abs(QuantityToUpdate));
                }
                else if (QuantityToUpdate < 0)
                {
                    //Subtract to inventory
                    RafflePrizeController.SubtractInventoryPrice(Record.ProductId, Math.Abs(QuantityToUpdate));

                }
                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            if (Record != null && !IsAddTransaction)
            {
                nudQuantity.Value = Record.Quantity;
                txtProductName.Text = $"{ProductToUpdate}";
                txtProductName.Tag = Record.ProductId;
                btnSearchProduct.Visible = false;
            }
            else
                btnSearchProduct.Visible = true;
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            frmInventorySearch frm = new frmInventorySearch();
            selectedProduct = new Inventory();

            frm.ShowDialog();

            selectedProduct = frm.Record;

            if (selectedProduct != null)
            {
                txtProductName.Text = $"{frm.BrandName}-{selectedProduct.Model}";
                txtProductName.Tag = selectedProduct.Id;
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
