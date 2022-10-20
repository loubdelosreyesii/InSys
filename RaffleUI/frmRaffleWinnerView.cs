using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RaffleUI.GlobalVariables;

namespace RaffleUI
{
    public partial class frmRaffleWinnerView : Form
    {
        public Raffle RaffleSource { get; set; }
        public bool IsFromLuckyDraw { get; set; }

        ParticipantController participantController = new ParticipantController();
        RaffleController raffleController = new RaffleController();
        RaffleWinnerController raffleWinnerController = new RaffleWinnerController();
        LuckyDrawWinnerController luckyDrawWinnerController = new LuckyDrawWinnerController();
        RaffleEntryController raffleEntriesController = new RaffleEntryController();
        InventoryController inventoryController = new InventoryController();

        List<Participant> participants = new List<Participant>();
        List<Raffle> raffleEvents = new List<Raffle>();
        List<RaffleEntry> raffleEntries = new List<RaffleEntry>();

        Raffle raffleEvent;
        BindingSource listSource = new BindingSource();

        int iRaffleId = 0;

        public frmRaffleWinnerView()
        {
            InitializeComponent();
        }

        private void frmParticipant_Load(object sender, EventArgs e){
            raffleEvents = raffleController.SelectAll();
            raffleEvent = new Raffle();

            if (RaffleSource == null)
                RaffleSource = raffleEvents[0];

            iRaffleId = RaffleSource.Id;

            RefreshGridBindings(iRaffleId);
            dgvwRecords.DataSource = listSource;

            raffleEvent.Id = iRaffleId;
            raffleController.record = raffleEvent;

            raffleEvent = raffleController.Select();

        }
        private void RefreshGridBindings(int RaffleId,string strKeyword=""){
            dgvwRecords.AutoGenerateColumns = false;

            dgvwRecords.ScrollBars = ScrollBars.Both;

            string[] listOfAlreadyWinnerRaffleNumbers = raffleWinnerController.SelectAll(RaffleSource.Id).Where(p=>p.PrizeId>=0).Select(p => p.RaffleReferenceNumber).ToArray();
            
            var productPrizes = raffleWinnerController.SelectAll(RaffleSource.Id).ToList();
            var inventories = inventoryController.SelectAll();
            inventories.Add(new Inventory { 
                Id= 0
            });
            raffleEntries = raffleEntriesController.SelectAll(RaffleId).Where(p=>listOfAlreadyWinnerRaffleNumbers.Contains(p.RaffleReferenceNumber)).ToList();

            participants = participantController.SelectAllByRaffleId(RaffleId);

            var itemToDisplay = from entry in raffleEntries
                                join part in participants on entry.ParticipantId equals part.Id
                                join prize in productPrizes on part.Id  equals prize.ParticipantId
                                join prod in inventories on prize.ProductId equals prod.Id
                                select new {
                                    ProductPhoto = Image.FromFile($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Products\\{prize.ProductId}.jpg"),
                                    Model = prod.Model,
                                    RaffleEntryId = entry.Id,
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
                listSource.DataSource = itemToDisplay.OrderBy(p=>p.FirstName).ToList();
            else
                listSource.DataSource = itemToDisplay.Where(p=>p.FirstName.ToUpper().Contains(strKeyword.ToUpper()) || 
                                                                p.LastName.ToUpper().Contains(strKeyword.ToUpper()) || 
                                                                p.MiddleName.ToUpper().Contains(strKeyword.ToUpper()) ||
                                                                p.RaffleReferenceNumber.ToUpper().Contains(strKeyword.ToUpper()) ||
                                                                p.EmailAddress.ToUpper().Contains(strKeyword.ToUpper()))
                                                     .OrderBy(p => p.FirstName).ToList();
            listSource.ResetBindings(false);
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            RefreshGridBindings(iRaffleId,txtSearchCustomer.Text);
        }

       
    }
}
