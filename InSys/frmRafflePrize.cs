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
    public partial class frmRafflePrize : Form
    {
            RafflePrizeController RafflePrizeController = new RafflePrizeController();

            List<RafflePrize> RafflePrizes = new List<RafflePrize>();

            RafflePrize record;
            Result result;

            frmRafflePrizeDetail frmDetail;
            BindingSource listSource = new BindingSource();

            public frmRafflePrize()
            {
                InitializeComponent();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                frmDetail = new frmRafflePrizeDetail();
                frmDetail.IsAddTransaction = true;

                frmDetail.ShowDialog();
                RefreshGridBindings();
            }

            private void btnEdit_Click(object sender, EventArgs e)
            {
                record = new RafflePrize();
                frmDetail = new frmRafflePrizeDetail();


                if (dgvwRecords.Rows.Count == 0)
                    MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

                record.Id = selectedRow.Id;
                //record.DrawDate = Convert.ToDateTime(selectedRow.DrawDate);
                //record.EntryPrice = Convert.ToDecimal(selectedRow.EntryPrice);
                //record.MaxEntries = Convert.ToInt32(selectedRow.MaxEntries);
                
                frmDetail.Record = record;
                frmDetail.IsAddTransaction = false;
                frmDetail.ShowDialog();

                RefreshGridBindings();
            }

            private void frmRafflePrize_Load(object sender, EventArgs e)
            {
                RefreshGridBindings();
                dgvwRecords.DataSource = listSource;

            }

            private void RefreshGridBindings()
            {
                dgvwRecords.ScrollBars = ScrollBars.Both;

                RafflePrizes = RafflePrizeController.SelectAll();
                listSource.DataSource = RafflePrizes;

                listSource.ResetBindings(false);
            }

            private void guna2Button1_Click(object sender, EventArgs e)
            {

            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                record = new RafflePrize();

                if (dgvwRecords.Rows.Count == 0)
                    MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

                record.Id = selectedRow.Id;

                RafflePrizeController.record = record;

                result = RafflePrizeController.Delete();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshGridBindings();
            }
    }
}
