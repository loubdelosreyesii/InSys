using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model= DataAccessLibrary.Model;
using static InSys.GlobalVariables;

namespace InSys.ProfitSharing
{
    public partial class frmProfitShareDetail : Form
    {
        public Model.ProfitSharing Record { get; set; }
        public bool IsAddTransaction { get; set; }

        ProfitSharingController profitController = new ProfitSharingController();
        Result result;

        public frmProfitShareDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAddTransaction)
            {
                Record = new Model.ProfitSharing();

                Record.SellerName = txtSellerName.Text;
                Record.SharePercentage = Convert.ToInt32(txtSharePercentage.Value);

                profitController.record = Record;

                result = profitController.Add();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Record.SellerName = txtSellerName.Text;
                Record.SharePercentage = Convert.ToInt32(txtSharePercentage.Value);

                profitController.record = Record;

                result = profitController.Edit();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (txtSellerName.Text.Length > 0)
                if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();

        }

        private void frmProfitShareDetail_Load(object sender, EventArgs e)
        {
            if (Record != null)
            {
                txtSellerName.Text = Record.SellerName;
                txtSharePercentage.Value = Record.SharePercentage;
            }
        }
    }
}
