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
    public partial class frmDealerDetail : Form
    {
        DealerController dealerController = new DealerController();

        public Dealer Record { get; set; }

        public bool IsAddTransaction { get; set; }
        public Result result { get; set; }

        public frmDealerDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNName.Text.Trim().Length <= 0) {
                MessageBox.Show("No Dealer Name provided. ",APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (IsAddTransaction)
            {
                Record = new Dealer();

                Record.Name = txtNName.Text;
                Record.Address = txtAddress.Text;
                Record.ContactNumber = txtContactNumber.Text;

                dealerController.record = Record;
                result = dealerController.Add();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Record.Name = txtNName.Text;
                Record.Address = txtAddress.Text;
                Record.ContactNumber = txtContactNumber.Text;

                dealerController.record = Record;
                result = dealerController.Edit();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            if (Record != null)
            {
                txtNName.Text = Record.Name;
                txtContactNumber.Text = Record.ContactNumber;
                txtAddress.Text = Record.Address;
            }
        }
    }
}
