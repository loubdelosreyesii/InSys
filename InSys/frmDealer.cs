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
    public partial class frmDealer : Form
    {
        DealerController dealerController = new DealerController();     

        List<Dealer> dealers = new List<Dealer>();

        Dealer record;
        Result result;

        frmDealerDetail frmDetail;
        BindingSource listSource = new BindingSource();
        
        public frmDealer()
        {
            InitializeComponent();

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmDealerDetail();
            frmDetail.IsAddTransaction = true;

            frmDetail.ShowDialog();
            RefreshGridBindings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Dealer();
            frmDetail = new frmDealerDetail();
            

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Address = selectedRow.Address;
            record.ContactNumber = selectedRow.ContactNumber; 

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;

        }

        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;

            dealers = dealerController.SelectAll();
            listSource.DataSource = dealers;

            listSource.ResetBindings(false);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Dealer();

            if (dgvwRecords.Rows.Count == 0)
                MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Address = selectedRow.Address;
            record.ContactNumber = selectedRow.ContactNumber;

            dealerController.record = record;

            result = dealerController.Delete();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }
    }
}
