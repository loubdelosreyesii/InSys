using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InSys.CapitalForm
{
    public partial class frmCapital : Form
    {
        CapitalController capitalController = new CapitalController();
        Capital recordCapital = new Capital();

        public frmCapital()
        {
            InitializeComponent();
        }
        private void LoadBalance() {
            capitalController = new CapitalController();
            txtCurrentBalance.Text = capitalController.SelectCurrentBalance().ToString("N2");
        }

        private void LoadHistories() {
            capitalController = new CapitalController();

            dtpFrom.Value = new DateTime(dtpFrom.Value.Year, dtpFrom.Value.Month, dtpFrom.Value.Day, 0, 0, 0);
            dtpTo.Value = new DateTime(dtpTo.Value.Year, dtpTo.Value.Month, dtpTo.Value.Day, 23, 59, 59);

            dgvwPOSTransactions.DataSource = capitalController.GetCapitalHistories(dtpFrom.Value,dtpTo.Value);

            dgvwPOSTransactions.Columns["Id"].Visible = false;

            dgvwPOSTransactions.Columns["TransactionDateTime"].HeaderText = "Transaction Date/Time";
            dgvwPOSTransactions.Columns["OldFundBalance"].HeaderText = "Previous Fund Balance";

            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvwPOSTransactions.Columns["TransactionDateTime"].DisplayIndex = 0;
            dgvwPOSTransactions.Columns["TransactionDateTime"].Width = 200;
            dgvwPOSTransactions.Columns["Amount"].Width = 180;
            dgvwPOSTransactions.Columns["Description"].Width = 400;
            dgvwPOSTransactions.Columns["OldFundBalance"].Width = 180;

            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvwPOSTransactions.Columns["Amount"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.Format = "c";
            dgvwPOSTransactions.Columns["OldFundBalance"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

        }
        private void btnAddFund_Click(object sender, EventArgs e)
        {
            pnlAddFund.Visible = true;
            txtFundAmountAdd.Text = String.Empty;
        }
        private void frmCapital_Load(object sender, EventArgs e)
        {
            LoadBalance();
            LoadHistories();
        }
        private void txtCurrentBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Decimal decAmountFunded;
            if (Decimal.TryParse(txtFundAmountAdd.Text, out decAmountFunded))
            {
                if (decAmountFunded < 0) {
                    MessageBox.Show("Amount provided is below zero. Please try again.", "InSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                capitalController = new CapitalController();
                pnlAddFund.Visible = false;

                recordCapital = new Capital();
                recordCapital.Id = 1;
                recordCapital.Amount = Convert.ToDecimal(txtCurrentBalance.Text) + decAmountFunded;
                recordCapital.TransactionDateTime = DateTime.Now;
                capitalController.record = recordCapital;
                capitalController.AddFund("Add Fund");
            }
            else
            {
                MessageBox.Show("Invalid Amount provided. Please try again.", "InSys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadBalance();
            LoadHistories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlAddFund.Visible = false;
            LoadBalance();
            LoadHistories();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadBalance();
            LoadHistories();
        }
    }
}
