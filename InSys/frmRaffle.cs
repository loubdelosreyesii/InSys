using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;

namespace InSys
{
    public partial class frmRaffle : Form
    {
        RaffleController raffleController = new RaffleController();
        RafflePrizeController rafflePrizeController = new RafflePrizeController();
        RaffleLuckyDrawPrizeController luckDrawController = new RaffleLuckyDrawPrizeController();

        List<Raffle> Raffles = new List<Raffle>();

        Raffle record;
        Result result;

        frmRaffleDetail frmDetail;
        BindingSource listSource = new BindingSource();

        public frmRaffle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmRaffleDetail();
                
            frmDetail.Record = new Raffle { 
                    DrawDate = DateTime.Now
            };
            frmDetail.IsAddTransaction = true;

            frmDetail.ShowDialog();
            RefreshGridBindings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Raffle();
            frmDetail = new frmRaffleDetail();


        if (dgvwRecords.Rows.Count == 0){
            MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.DrawDate = Convert.ToDateTime(selectedRow.DrawDate);
            record.EntryPrice = Convert.ToDecimal(selectedRow.EntryPrice);
            record.MaxEntries = Convert.ToInt32(selectedRow.MaxEntries);
                
            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }

        private void frmRaffle_Load(object sender, EventArgs e)
        {
            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;

            GetCurrentRowDetail();
        }

        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;

            Raffles = raffleController.SelectAll();
            listSource.DataSource = Raffles;

            listSource.ResetBindings(false);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Raffle();

            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete the selected row?{Environment.NewLine} This action will also delete the Prize and Participants records. {Environment.NewLine} Press Yes to proceed this action.", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;

            raffleController.record = record;
                
            result = raffleController.Delete();

            rafflePrizeController.record = new RafflePrize {
                                        RaffleId = record.Id                                    
                                        };

            luckDrawController.record = new RaffleLuckyDrawPrize
                                        {
                                            RaffleId = record.Id
                                        };
            rafflePrizeController.DeleteBulkByRaffleId();
            luckDrawController.DeleteBulkByRaffleId();

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridBindings();
        }
        private void btnManageParticipants_Click(object sender, EventArgs e)
        {

        }

        private void btnManagePrize_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            record = new Raffle();
            frmDetail = new frmRaffleDetail();


            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.DrawDate = Convert.ToDateTime(selectedRow.DrawDate);
            record.EntryPrice = Convert.ToDecimal(selectedRow.EntryPrice);
            record.MaxEntries = Convert.ToInt32(selectedRow.MaxEntries);

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
            GetCurrentRowDetail();
        }

        private void btnManagePrizes_Click(object sender, EventArgs e)
        {
            record = new Raffle();
            frmDetail = new frmRaffleDetail();


            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.DrawDate = Convert.ToDateTime(selectedRow.DrawDate);
            record.EntryPrice = Convert.ToDecimal(selectedRow.EntryPrice);
            record.MaxEntries = Convert.ToInt32(selectedRow.MaxEntries);

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
            GetCurrentRowDetail();
        }

        private void btnManageParticipant_Click(object sender, EventArgs e)
        {
            record = new Raffle();

            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.Id;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.DrawDate = Convert.ToDateTime(selectedRow.DrawDate);
            record.EntryPrice = Convert.ToDecimal(selectedRow.EntryPrice);
            record.MaxEntries = Convert.ToInt32(selectedRow.MaxEntries);

            frmParticipant frm = new frmParticipant();
            frm.RaffleSource = record;
            frm.ShowDialog();

            RefreshGridBindings();
            GetCurrentRowDetail();
        }
        private void GetCurrentRowDetail() {
            txtTotalPrizeAlloted.Text = string.Empty;
            txTotalEntryAmountCollected.Text = string.Empty;

            if (dgvwRecords.Rows.Count == 0)
                return;

            dynamic item = dgvwRecords.CurrentRow.DataBoundItem;

            var record = raffleController.SelectRaffleOverview(item.Id);

            if (record != null)
            {
                if (record.TotalPrizeAlloted != null)
                    txtTotalPrizeAlloted.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", record.TotalPrizeAlloted)}";
                else
                    txtTotalPrizeAlloted.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", 0.00)}";
                if (record.TotalAmountCollected != null)
                    txTotalEntryAmountCollected.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", record.TotalAmountCollected)}";
                else
                    txTotalEntryAmountCollected.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", 0.00)}";
            }
        }
        private void dgvwRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetCurrentRowDetail();
        }
    }
}
