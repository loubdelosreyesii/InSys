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
    public partial class frmParticipant : Form
    {
        public Raffle RaffleSource { get; set; }
        ParticipantController participantController = new ParticipantController();
        RaffleController raffleController = new RaffleController();
        RaffleEntryController raffleEntriesController = new RaffleEntryController();

        List<Participant> participants = new List<Participant>();
        List<Raffle> raffleEvents = new List<Raffle>();
        List<RaffleEntry> raffleEntries = new List<RaffleEntry>();

        Participant record;
        Result result;
        Raffle raffleEvent;
        frmParticipantDetail frmDetail;
        BindingSource listSource = new BindingSource();

        int iRaffleId = 0;
        public frmParticipant()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmParticipantDetail();

            frmDetail.RecordRaffle = raffleController.SelectById(Convert.ToInt32(cboxRaffleEvents.SelectedValue)); 
            frmDetail.Record = new Participant { Id =0};
            frmDetail.IsAddTransaction = true;

            frmDetail.ShowDialog();
            RefreshGridBindings(iRaffleId);

            updateProgressBar(dgvwRecords.Rows.Count, raffleEvent.MaxEntries);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Participant();
            frmDetail = new frmParticipantDetail();


            if (dgvwRecords.Rows.Count == 0){
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ParticipantId;
            record.FirstName = selectedRow.FirstName;
            record.LastName = selectedRow.LastName; 
            record.MiddleName = selectedRow.MiddleName;
            record.FacebookLink = selectedRow.FacebookLink;
            record.EmailAddress = selectedRow.EmailAddress;
            record.ContactNumber = selectedRow.ContactNumber;

            frmDetail.Record = record;
            frmDetail.RecordRaffle =(Raffle) cboxRaffleEvents.SelectedItem;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings(iRaffleId);

            updateProgressBar(dgvwRecords.Rows.Count, raffleEvent.MaxEntries);
        }

        private void frmParticipant_Load(object sender, EventArgs e)
        {
            raffleEvents = raffleController.SelectAll();
            raffleEvent = new Raffle();

            cboxRaffleEvents.DataSource = raffleEvents;
            cboxRaffleEvents.DisplayMember = "Name";
            cboxRaffleEvents.ValueMember = "Id";

            if (RaffleSource == null)
                RaffleSource = raffleEvents[0];

            iRaffleId = RaffleSource.Id;
            cboxRaffleEvents.SelectedValue = iRaffleId;

            RefreshGridBindings(iRaffleId);
            dgvwRecords.DataSource = listSource;

            raffleEvent.Id = iRaffleId;
            raffleController.record = raffleEvent;

            raffleEvent = raffleController.Select();

            updateProgressBar(dgvwRecords.Rows.Count,raffleEvent.MaxEntries);
        }
        private void updateProgressBar(int paramParticipantCount, int paramMaxEntries) {
            txtNoOfParticipants.Text = $"{paramParticipantCount}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Participant();
            frmDetail = new frmParticipantDetail();

            if (dgvwRecords.Rows.Count == 0)
            {
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ParticipantId;
            record.FirstName = selectedRow.FirstName;
            record.LastName = selectedRow.LastName;
            record.MiddleName = selectedRow.MiddleName;
            record.FacebookLink = selectedRow.FacebookLink;
            record.EmailAddress = selectedRow.EmailAddress;
            record.ContactNumber = selectedRow.ContactNumber;

            frmDetail.Record = record;
            frmDetail.RecordRaffle = (Raffle)cboxRaffleEvents.SelectedItem;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings(iRaffleId);

            updateProgressBar(dgvwRecords.Rows.Count, raffleEvent.MaxEntries);

            //RaffleEntryController raffleEntryController = new RaffleEntryController();

            //record = new Participant();

            //if (dgvwRecords.Rows.Count == 0)
            //{
            //    MessageBox.Show("No Records to be deleted.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (MessageBox.Show($"Are you sure you want to delete the selected row?{Environment.NewLine} This action will also delete the Participant Raffle Entry records. {Environment.NewLine} Press Yes to proceed this action.", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //    return;

            //dynamic selectedRow = dgvwRecords.CurrentRow.DataBoundItem;

            //record.Id = selectedRow.Id;
            //participantController.record = record;
            //raffleEntryController.record = new RaffleEntry {  ParticipantId = record.Id};

            //participantController.Delete();
            //result = raffleEntryController.DeleteBulk(record.Id);

            //MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //RefreshGridBindings(iRaffleId);
            //updateProgressBar(dgvwRecords.Rows.Count, raffleEvent.MaxEntries);
        }

        private void cboxRaffleEvents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboxRaffleEvents.SelectedIndex == -1)
                return;

            txtSearchCustomer.Clear();
            raffleEvent = new Raffle();
            iRaffleId= Convert.ToInt32(cboxRaffleEvents.SelectedValue);

            raffleEvent.Id = iRaffleId;
            raffleController.record = raffleEvent;

            raffleEvent = raffleController.Select();

            RefreshGridBindings(iRaffleId);

            updateProgressBar(dgvwRecords.Rows.Count, raffleEvent.MaxEntries);
        }

        private void RefreshGridBindings(int RaffleId,string strKeyword="")
        {
            dgvwRecords.AutoGenerateColumns = false;

            dgvwRecords.ScrollBars = ScrollBars.Both;
           
                raffleEntries = raffleEntriesController.SelectAll(RaffleId);
                participants = participantController.SelectAllByRaffleId(RaffleId);
           

            var itemToDisplay = from entry in raffleEntries
                                join part in participants on entry.ParticipantId equals part.Id

                                select new {
                                    Id = entry.Id,
                                    ParticipantId = part.Id,
                                    TransactionDateTime = entry.TransactionDateTime,
                                    RaffleReferenceNumber = entry.RaffleReferenceNumber,
                                    PaymentReceipt = entry.PaymentReceipt,
                                    LastName= part.LastName,
                                    FirstName= part.FirstName,
                                    MiddleName = part.MiddleName,
                                    ContactNumber= part.ContactNumber,
                                    FacebookLink = part.FacebookLink,
                                    EmailAddress= part.EmailAddress
                                };

            if(strKeyword.Length== 0)
                listSource.DataSource = itemToDisplay.ToList();
            else
                listSource.DataSource = itemToDisplay.Where(p=>p.FirstName.Contains(strKeyword) || 
                                                                p.LastName.Contains(strKeyword) || 
                                                                p.MiddleName.Contains(strKeyword) ||
                                                                p.RaffleReferenceNumber.Contains(strKeyword) ||
                                                                p.EmailAddress.Contains(strKeyword)).ToList();
            listSource.ResetBindings(false);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            RefreshGridBindings(iRaffleId,txtSearchCustomer.Text);
        }

        private void cboxRaffleEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
