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
using UserMan;
using Model = DataAccessLibrary.Model;
using static InSys.GlobalVariables;
namespace InSys.ProfitSharing
{
    public partial class frmProfitSharing : Form
    {
        ProfitSharingController profitController = new ProfitSharingController();
        
        Model.ProfitSharing record = new Model.ProfitSharing();
        List<Model.ProfitSharing> records = new List<Model.ProfitSharing>();

        Result result;

        frmProfitShareDetail frmDetail = new frmProfitShareDetail();
        BindingSource listSource = new BindingSource();

        public frmProfitSharing()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmProfitShareDetail();
            
            frmDetail.IsAddTransaction = true;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void pnlFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmProfitSharing_Load(object sender, EventArgs e)
        {
            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;
        }

        private void RefreshGridBindings()
        {
            records = profitController.SelectAll();

            listSource.DataSource = records;

            listSource.ResetBindings(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Model.ProfitSharing();
            frmDetail = new frmProfitShareDetail();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.SellerName = selectedRow.SellerName;
            record.SharePercentage = selectedRow.SharePercentage;

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Model.ProfitSharing();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.SellerName = selectedRow.SellerName;
            record.SharePercentage = selectedRow.SharePercentage;

            profitController.record = record;
            result = profitController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }
    }
}
