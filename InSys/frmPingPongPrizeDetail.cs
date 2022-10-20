using DataAccessLibrary.Controller;
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
    public partial class frmPingPongPrizeDetail : Form
    {
        PingPongPrizeController pingPongPrizeController = new PingPongPrizeController();
        
        public PingPongPrize Record { get; set; }
        public Raffle RecordRaffle { get; set; }
        public bool IsAddTransaction { get; set; }
        public string ProductToUpdate { get; set; }
        public Result result { get; set; }

        private Inventory selectedProduct;

        public frmPingPongPrizeDetail(){
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
            if (nudQuantity.Value > selectedProduct.Quantity)
            {
                MessageBox.Show($"You can only set the Maximum Number of Prizes to : {selectedProduct.Quantity}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IsAddTransaction){
                Record = new PingPongPrize();

                Record.RaffleId = RecordRaffle.Id;

                if (txtProductName.Text.Length > 0)
                    Record.ProductId = Convert.ToInt32(txtProductName.Tag);

                if (nudQuantity.Value > 0)
                    Record.Quantity = Convert.ToInt32(nudQuantity.Value);

                //Record.ShuffleLevel = Convert.ToInt32(nudShuffleLevel.Value);
                pingPongPrizeController.record = Record;
                result = pingPongPrizeController.Add();

                pingPongPrizeController.SubtractInventoryPrice(Record.ProductId, Math.Abs(Record.Quantity));

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                int previousQuantity = 0;
                int QuantityToUpdate = 0;

                previousQuantity = Record.Quantity;
                QuantityToUpdate = previousQuantity - Convert.ToInt32(nudQuantity.Value);

                Record.RaffleId = Convert.ToInt32(RecordRaffle.Id);
                Record.ProductId = Convert.ToInt32(txtProductName.Tag);
                Record.Quantity = Convert.ToInt32(nudQuantity.Value);
                //Record.ShuffleLevel = Convert.ToInt32(nudShuffleLevel.Value);
                pingPongPrizeController.record = Record;

                result = pingPongPrizeController.Edit();


                if (QuantityToUpdate > 0){
                    //Add to Inventory back
                    pingPongPrizeController.AddInventoryPrice(Record.ProductId, Math.Abs(QuantityToUpdate));
                }
                else if (QuantityToUpdate < 0) {
                    //Subtract to inventory
                    pingPongPrizeController.SubtractInventoryPrice(Record.ProductId, Math.Abs(QuantityToUpdate));
                }

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            InventoryController inventoryController = new InventoryController();

            if (Record != null && !IsAddTransaction)
            {
                //nudShuffleLevel.Value = Convert.ToInt32(Record.ShuffleLevel);
                nudQuantity.Value = Record.Quantity;
                txtProductName.Text = $"{ProductToUpdate}";
                txtProductName.Tag = Record.ProductId;
               
                btnSearchProduct.Visible = false;

                selectedProduct = new Inventory();
                selectedProduct.Id = Record.ProductId;
                inventoryController.record = selectedProduct;

                selectedProduct = inventoryController.Select();
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
                txtProductName.Text = selectedProduct.Model;
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
