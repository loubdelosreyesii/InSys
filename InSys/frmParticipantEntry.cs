using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using Guna.UI2.WinForms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmParticipantEntry : Form
    {
        RaffleEntryController RaffleEntryController = new RaffleEntryController();
        RaffleController RaffleController = new RaffleController();
        ReferenceController referenceController = new ReferenceController();

        public RaffleEntry Record { get; set; }
        public Raffle RecordRaffle { get; set; }
        public Participant RecordParticipant { get; set; }
        public bool IsAddTransaction { get; set; }
        public Result result { get; set; }
        public List<RaffleEntry> RaffleEntries{ get; set; }

        List<Raffle> RaffleEvents = new List<Raffle>();
        List<Reference> References = new List<Reference>();
        BindingSource listSource = new BindingSource();

        public frmParticipantEntry(){
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e){
            if (dgvwRecords.Rows.Count > 0)
                if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                    RaffleEntries = new List<RaffleEntry>();
                    this.Close();
                }
        }

        private void btnSave_Click(object sender, EventArgs e){
            
            if (dgvwRecords.Rows.Count <= 0) {
                MessageBox.Show("No Raffle Entry Reference Number generated yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            List<RaffleEntry> newRaffleEntries = new List<RaffleEntry>();
            foreach (DataGridViewRow item in dgvwRecords.Rows)
            {
                Record = new RaffleEntry();

                Record.RaffleId = RecordRaffle.Id;
                Record.ParticipantId = RecordParticipant.Id;
                Record.TransactionDateTime = Convert.ToDateTime(item.Cells["dcolTransactionDate"].Value);
                Record.PaymentReceipt = txtPaymentReferenceNumber.Text;
                Record.RaffleReferenceNumber = item.Cells["dcolRaffleReferenceNumber"].Value.ToString();

                if (RecordRaffle.EntryPrice <= 0)
                    Record.PaidAmount = 0.00m;
                else
                    Record.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);


                Record.PaymentMethod = Convert.ToInt32(item.Cells["dcolModeOfPayment"].Value);

                Record.LuckyNumber1 = Convert.ToInt32(item.Cells["dcolNumber1"].Value);
                Record.LuckyNumber2 = Convert.ToInt32(item.Cells["dcolNumber2"].Value);
                Record.LuckyNumber3 = Convert.ToInt32(item.Cells["dcolNumber3"].Value);

                 //validation2   
                if ((Record.LuckyNumber1  ==0 ||Record.LuckyNumber2 ==0 ||Record.LuckyNumber3== 0)){
                    newRaffleEntries.Add(Record);
                }
                //validation3
               else if (Record.LuckyNumber1 != 0 && Record.LuckyNumber2 != 0 && Record.LuckyNumber3 != 0){
                    
                    var innerValidation = newRaffleEntries.Where(p => p.LuckyNumber1 == Record.LuckyNumber1 && p.LuckyNumber2 == Record.LuckyNumber2 && p.LuckyNumber3 == Record.LuckyNumber3).ToList();

                    if (innerValidation.Count==0){
                        newRaffleEntries.Add(Record);
                    }
                    else{
                        MessageBox.Show($"Lucky Numbers are already picked in  Raffle Reference # :{innerValidation[0].RaffleReferenceNumber}. Please pick another numbers.");
                        return;
                    }

                    if (Record.LuckyNumber1 != Record.LuckyNumber2 &&
                       Record.LuckyNumber1 != Record.LuckyNumber3 &&
                       Record.LuckyNumber2 != Record.LuckyNumber3)
                    {
                        newRaffleEntries.Add(Record);
                        continue;
                    }
                    else
                    {
                        MessageBox.Show($"Lucky Numbers are should pick unique numbers for :{Record.RaffleReferenceNumber}.");
                        return;

                    }

                }
                else  { 
                    MessageBox.Show($"Complete all Lucky Numbers for  Raffle Reference # :{Record.RaffleReferenceNumber}.");
                    return;
                }
                newRaffleEntries.Add(Record);
            }
            this.Close();
        }

        private void frmInventoryDetail_Load(object sender, EventArgs e)
        {
            if (RaffleEntries == null)
                RaffleEntries = new List<RaffleEntry>();

            RaffleEvents = RaffleController.SelectAll();
            References = referenceController.SelectByCategoryId(3); //Payment Methods

            cboxRaffleEntries.DataSource = RaffleEvents;
            cboxRaffleEntries.DisplayMember = "Name";
            cboxRaffleEntries.ValueMember = "Id";

            cboxPaymentMethod.DataSource = References;
            cboxPaymentMethod.DisplayMember = "Name";
            cboxPaymentMethod.ValueMember = "Id";

            if (RecordRaffle != null)
                cboxRaffleEntries.SelectedValue = RecordRaffle.Id;

            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;

            cboxRaffleEntries.Enabled= false;
            txtRafflePrice.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", RecordRaffle.EntryPrice)}";
            txtRaffleDrawDate.Text = $"{RecordRaffle.DrawDate.ToString("MMM dd,yyyy")}";
        }
        bool isValidAmount = false;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (RecordRaffle.EntryPrice> 0  && txtPaidAmount.TextLength == 0){
                MessageBox.Show("Please enter the Paid Amount first.",APP_NAME,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RaffleEntries = new List<RaffleEntry>();
            int counter = 1;

            string strRaffleReferenceNumber = $"RE-{RecordRaffle.Id}-{DateTime.Now.ToString("yyHHMMmmddss")}";
            do{
                Record = new RaffleEntry();

                if (RecordParticipant == null) {
                    RecordParticipant = new Participant();
                    RecordParticipant.Id = 0;
                }
                
                Record.RaffleId = RecordRaffle.Id;
                Record.ParticipantId = RecordParticipant.Id;
                Record.TransactionDateTime = DateTime.Now;
                Record.PaymentReceipt = txtPaymentReferenceNumber.Text;
                Record.RaffleReferenceNumber = $"{strRaffleReferenceNumber}-{counter}";

                if (RecordRaffle.EntryPrice <= 0)
                    Record.PaidAmount = 0.00m;
                else
                    Record.PaidAmount = Convert.ToDecimal(txtPaidAmount.Text);
                
                Record.PaymentMethod = Convert.ToInt32(cboxPaymentMethod.SelectedValue);

                RaffleEntryController.record = Record;

                RaffleEntries.Add(Record);

                counter++;

            } while (nudRaffleEntriesCount.Value >= counter);

            RefreshGridBindings();
        }

        private void RefreshGridBindings() {
            listSource.DataSource = RaffleEntries;
            listSource.ResetBindings(false);
        }

        private void txtPaidAmount_Leave(object sender, EventArgs e){
            if (RecordRaffle.EntryPrice <= 0) {
                txtPaidAmount.Text = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}","0.00")}";
                nudRaffleEntriesCount.Value = 1;
                return;
            }

            if (txtPaidAmount.TextLength <= 0)
                return;

            if (((Convert.ToDecimal(txtPaidAmount.Text) / RecordRaffle.EntryPrice)%1) != 0){
                isValidAmount = false;
                MessageBox.Show("Invalid Paid Amount entered. Double check the Paid Amount to the Entry Price per ticket. Please try again.");
                return;
            }
            isValidAmount= true; 
            txtPaidAmount.Text = $"{string.Format(new CultureInfo(APP_CURRENCY),"{0:C}",txtPaidAmount.Text)}";
            nudRaffleEntriesCount.Value = Convert.ToDecimal(txtPaidAmount.Text) / RecordRaffle.EntryPrice;
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e){

        }

        private void txtPaidAmount_KeyPress(object sender, KeyPressEventArgs e){
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& e.KeyChar != '.')
                    e.Handled = true;

            if (e.KeyChar == '.' && (sender as Guna2TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void cboxRaffleEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvwRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvwRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvwRecords_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void nudRaffleEntriesCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPaymentReferenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRafflePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRaffleDrawDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
