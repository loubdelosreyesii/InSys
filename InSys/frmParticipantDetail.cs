using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
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
    public partial class frmParticipantDetail : Form
    {
        ReferenceController referenceController = new ReferenceController();
        ParticipantController participantController = new ParticipantController();
        RaffleEntryController raffleEntryController = new RaffleEntryController();

        public Participant Record { get; set; }
        public Raffle RecordRaffle { get; set; }

        public bool IsAddTransaction   { get; set; }
        public Result result { get; set; }

        private List<Reference> references;
        private List<RaffleEntry> raffleEntries;

        frmParticipantEntry frmEntry = new frmParticipantEntry();

        public frmParticipantDetail()
        {
            InitializeComponent();
            dgvwRecords.AutoGenerateColumns = false;
            references = referenceController.SelectAll(); //Payment Methods
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvwRecords.RowCount == 0){
                MessageBox.Show("No Raffle Entries added yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            result = new Result();

            if (IsAddTransaction){
                Record = new Participant();
                Record.FirstName = txtFirstName.Text;
                Record.MiddleName = txtMiddleName.Text;
                Record.LastName = txtLastName.Text;
                Record.FacebookLink = txtFacebookLink.Text;
                Record.EmailAddress = txtEmailAddress.Text;
                Record.ContactNumber = txtContactNumber.Text;
                Record.BirthDate = string.Empty;
                participantController.record = Record;
                result = participantController.Add();
            }
            else{
                Record.FirstName = txtFirstName.Text;
                Record.MiddleName = txtMiddleName.Text;
                Record.LastName = txtLastName.Text;
                Record.FacebookLink = txtFacebookLink.Text;
                Record.EmailAddress = txtEmailAddress.Text;
                Record.ContactNumber = txtContactNumber.Text;
                Record.BirthDate = string.Empty;

                participantController.record = Record;
                result = participantController.Edit();
            }

            MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result.Code){
                string strReceiptFolder = Path.GetDirectoryName(Application.ExecutablePath) + $"\\Receipts";
                string strRaffleFolder = strReceiptFolder + $"\\{RecordRaffle.Name}";
                string strParticipantFolder = strRaffleFolder + $"\\{Record.FirstName}";
                string strReceiptTemplate = Path.GetDirectoryName(Application.ExecutablePath) + $"\\Resources\\Templates\\Receipt.pdf";
                if (!Directory.Exists(strReceiptFolder))
                    Directory.CreateDirectory(strReceiptFolder);

                if (!Directory.Exists(strRaffleFolder))
                    Directory.CreateDirectory(strRaffleFolder);

                if (!Directory.Exists(strParticipantFolder))
                    Directory.CreateDirectory(strParticipantFolder);

                foreach (RaffleEntry item in raffleEntries){
                    var itemToAdd = item;
                    if (raffleEntryController.Select(itemToAdd.RaffleReferenceNumber) == null){
                        Console.WriteLine($"New Item added :{itemToAdd.RaffleReferenceNumber}!");

                        itemToAdd.ParticipantId = Record.Id;
                        raffleEntryController.record = itemToAdd;

                        raffleEntryController.Add();

                        //Create PDF Document
                        //You will have to add Page in PDF Document
                        PdfDocument document = PdfReader.Open(strReceiptTemplate, PdfDocumentOpenMode.Modify);
                        PdfAcroForm myForm = document.AcroForm;

                        if (myForm.Elements.ContainsKey("/NeedAppearances"))
                            myForm.Elements["/NeedAppearances"] = new PdfBoolean(true);
                        else
                            myForm.Elements.Add("/NeedAppearances", new PdfBoolean(true));

                        PdfTextField pdfParticipantName = (PdfTextField)(myForm.Fields["txtParticipantName"]);
                        PdfTextField pdfDrawDate = (PdfTextField)(myForm.Fields["txtDrawDate"]);
                        PdfTextField pdfDrawTime = (PdfTextField)(myForm.Fields["txtDrawTime"]);
                        PdfTextField pdfNumber1 = (PdfTextField)(myForm.Fields["txtNumber1"]);
                        PdfTextField pdfNumber2 = (PdfTextField)(myForm.Fields["txtNumber2"]);
                        PdfTextField pdfNumber3 = (PdfTextField)(myForm.Fields["txtNumber3"]);
                        PdfTextField pdfRaffleReferenceNumber = (PdfTextField)(myForm.Fields["txtReferenceNumber"]);

                        pdfDrawDate.Value = new PdfSharp.Pdf.PdfString($"{itemToAdd.TransactionDateTime.Date.ToString("MMM. dd,yyyy")}");
                        pdfDrawTime.Value = new PdfSharp.Pdf.PdfString($"{itemToAdd.TransactionDateTime.ToString("hh:mm tt")}");
                        pdfParticipantName.Value = new PdfSharp.Pdf.PdfString($"{Record.FirstName}");
                        pdfNumber1.Value = new PdfSharp.Pdf.PdfString($"{item.LuckyNumber1}");
                        pdfNumber2.Value = new PdfSharp.Pdf.PdfString($"{item.LuckyNumber2}");
                        pdfNumber3.Value = new PdfSharp.Pdf.PdfString($"{item.LuckyNumber3}");
                        pdfRaffleReferenceNumber.Value = new PdfSharp.Pdf.PdfString($"{itemToAdd.RaffleReferenceNumber}");

                        pdfParticipantName.ReadOnly = true;
                        pdfDrawDate.ReadOnly = true;
                        //Specify file name of the PDF file
                        string filename = $"{strParticipantFolder}\\{itemToAdd.RaffleReferenceNumber}.pdf";
                        document.Save(filename);

                    }
                    else {
                        Console.WriteLine($"Have It Already. Skipped this {item.RaffleReferenceNumber}!");
                    }
                }
                foreach (RaffleEntry item in listEntriesForRemoval)
                {
                    var itemToRemove = item;
                    raffleEntryController.record = itemToRemove;

                    if (raffleEntryController.Delete().Code)
                    {
                        Console.WriteLine($"Successfully deleted : {item.RaffleReferenceNumber}!");
                    }
                }
            }
            this.Close();
        }

        private void frmParticipantDetail_Load(object sender, EventArgs e)
        {
            listOfInventories = inventoryController.SelectAll();
            pnlSaveCancel.Enabled = false;

            if (Record != null)
            {
                txtFirstName.Text = Record.FirstName;
                txtLastName.Text = Record.LastName; 
                txtMiddleName.Text = Record.MiddleName;
                txtFacebookLink.Text = Record.FacebookLink;
                txtEmailAddress.Text = Record.EmailAddress; 
                txtContactNumber.Text = Record.ContactNumber;
            }
            RefreshGridBindings(false);
            dgvwRecords.DataSource = listSource;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEntry = new frmParticipantEntry();
            frmEntry.RecordRaffle = RecordRaffle;
            frmEntry.RecordParticipant = Record;
            frmEntry.IsAddTransaction = true;
            frmEntry.ShowDialog();

            listOfGeneratedRaffleEntries = listOfGeneratedRaffleEntries.Concat(frmEntry.RaffleEntries).ToList();
            RefreshGridBindings(true);
        }
        private void RefreshGridBindings(bool isFromModal)
        {
            if (isFromModal){
                raffleEntries = listOfGeneratedRaffleEntries;
            }
            else {
                listOfGeneratedRaffleEntries = raffleEntryController.SelectAll(RecordRaffle.Id, Record.Id);
                raffleEntries = listOfGeneratedRaffleEntries;
            }
            //Need updates
            //1. Paid Amount format should include currency and correct amount format.
            //2. Transaction Date column width add more space. DONE
            //3. RaffleName should be present

            //4. RaffleId should be hide on the display.
            this.dcolID.Visible=false;
            //5. Payment Method Name should be available.

            if (raffleEntries.Count > 0)
            {
                listSource.DataSource = from entry in raffleEntries
                                        join refer in references on entry.PaymentMethod equals refer.Id
                                        join invent in listOfInventories on  entry.ProductId equals  invent.Id into temp
                                        from tempRecord in temp.DefaultIfEmpty()
                                        join refBrand in references on  tempRecord==null?0:tempRecord.BrandID equals refBrand.Id into tempRef
                                        from tempRecordRef in tempRef.DefaultIfEmpty()
                                        select new
                                        {
                                            Id = entry.Id,
                                            RaffleId = RecordRaffle.Id,
                                            RecordRaffle.Name,
                                            TransactionDateTime = entry.TransactionDateTime,
                                            RaffleReferenceNumber = entry.RaffleReferenceNumber,
                                            PaymentMethodName = refer.Name,
                                            PaymentMethodId = entry.Id,
                                            PaidAmount = $"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", RecordRaffle.EntryPrice)}",//$"{string.Format(new CultureInfo(APP_CURRENCY), "{0:C}", entry.PaidAmount)}",
                                            PaymentReceipt = entry.PaymentReceipt,
                                            RaffleName = RecordRaffle.Name,
                                            RafflePrizeId = entry.RafflePrizeId,
                                            ProductId = tempRecord == null ? 0:tempRecord.Id,
                                            PrizeName = tempRecord == null ? string.Empty : tempRecordRef == null ? string.Empty : $"{tempRecordRef.Name}-{tempRecord.Model}"
                                        };

                pnlSaveCancel.Enabled = true;
            }
            else
            {
                pnlSaveCancel.Enabled = false;
                dgvwRecords.Rows.Clear();
            }
            listSource.ResetBindings(false);
        }

        BindingSource listSource = new BindingSource();
        List<RaffleEntry> listOfGeneratedRaffleEntries = new List<RaffleEntry>();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvwRecords.RowCount <= 0) { return; }

            dynamic record = dgvwRecords.CurrentRow.DataBoundItem;
            string strRaffleEntryToRemove = record.RaffleReferenceNumber;
            RaffleEntry itemToRemove = raffleEntries.Single(p => p.RaffleReferenceNumber == strRaffleEntryToRemove);
            
            listEntriesForRemoval.Add(itemToRemove);
            raffleEntries.Remove(itemToRemove);

            //listOfGeneratedRaffleEntries.Remove(record);
            RefreshGridBindings(true);
        }
        List<RaffleEntry> listEntriesForRemoval = new List<RaffleEntry>();
        List<Inventory> listOfInventories = new List<Inventory>();

        InventoryController inventoryController = new InventoryController();

        private void dgvwRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
