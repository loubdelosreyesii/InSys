using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using Guna.UI2.HtmlRenderer.Adapters;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace RaffleUI{
    public partial class frmRaffleMain : Form{
        
        public frmRaffleMain(){
            InitializeComponent();
        }
        private void LoadRaffleInformation() {
            if (RecordRaffle != null){
                panelRaffleShuffle.Enabled = true;
                lblRaffleEvent.Text = RecordRaffle.Name;
                lblRaffleDescription.Text = RecordRaffle.Description;
                btnSelectRaffle.Visible = false;
            }
            else{
                lblRaffleEvent.Text = "No Raffle Event selected yet.";
                lblRaffleDescription.Text = "Choose Raffle Event first.";
                panelRaffleShuffle.Enabled = false;
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e){
            frmChooseEvent = new frmChooseRaffleEvent();

            frmChooseEvent.ShowDialog(this);
            RecordRaffle = frmChooseEvent.RecordRaffle;
            LoadRaffleInformation();

            gifGirl.Visible = false;
            gifCongratulations.Visible = false;

            isPrizeShuffled = false;
            isParticipantShuffled = false;  

            btnClaimPrize.Visible = false;
            btnNoShow.Visible = false;
        }
        private void guna2Button1_Click_1(object sender, EventArgs e){
            frmChooseEvent = new frmChooseRaffleEvent();
            frmChooseEvent.ShowDialog(this);
            RecordRaffle = frmChooseEvent.RecordRaffle;
            LoadRaffleInformation();
        }
        private void ThreadSleep(double diffInSeconds){
            if (diffInSeconds < 4)
                Thread.Sleep(300);
            else if (diffInSeconds < 6)
                Thread.Sleep(300);
            else
                Thread.Sleep(300);
        }
        private void InitializeScreen() {
            gifGirl.Visible = false;
            gifCongratulations.Visible = false;
            lblRaffleReferenceNumber.Text = string.Empty;
            lblParticipantName.Text = string.Empty;
            pboxProductToRaffle.Image = null;
            intLuckyPrizeIdSelected = 0;
            intProductIdSelected = 0;
            lblProductToRaffle.Text = "Prize to Raffle";

            isBetterLuckNextActivated = false;
            isPrizeShuffled = false;
            isParticipantShuffled = false;
        }
        private void btnStartShuffle_Click(object sender, EventArgs e){
            if (isPrizeClaimed) {
                InitializeScreen();
                isPrizeClaimed = false;
            }
            if (RecordRaffle == null) {
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (RecordRaffle.Id ==0){
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            stopShuffle = false;

            listOfRaffleEntries = raffleEntryController.SelectAll(RecordRaffle.Id);
            
            threadStartShuffleForPrize = new Thread(new ThreadStart(ShufflePrizeInvoke));
            threadStartShuffleForPrize.IsBackground = true;
            threadStartShuffleForPrize.Start();
        }
        private void ToggleControlPanel(bool toggle) {
            pnlControls.Enabled = toggle;
        }


        private void ShufflePrizeInvoke() {
            try{
                Random r = new Random();
                DateTime dtStart = DateTime.Now;
                DateTime dtEnd = DateTime.Now;
                double diffInSeconds;

                intProductIdSelected = 0;
                intLuckyPrizeIdSelected = 0;

                listOfRafflePrizes = rafflePrizeController.SelectProducts(RecordRaffle.Id);

                int intShuffleLevel = listOfRafflePrizes.Select(p => p.ShuffleLevel).OrderBy(p => p).Take(1).SingleOrDefault() ;

                listOfRafflePrizes = listOfRafflePrizes.Where(p => p.ShuffleLevel == intShuffleLevel).ToList();

                if (pnlControls.InvokeRequired)
                    this.pnlControls.Invoke(new InvokeOnControlPanel(ToggleControlPanel), false);
                else
                    ToggleControlPanel(false);

                if (listOfRafflePrizes.Count == 0){
                    if (lblReturnMessage.InvokeRequired){
                        this.lblReturnMessage.Invoke(new InvokeOnReturnMessage(DisplayErrorMessage), "No more Lucky Prizes left.");
                    }
                    else
                        lblReturnMessage.Text = "No more Lucky Prizes left.";
                    
                    if (pnlControls.InvokeRequired)
                        this.pnlControls.Invoke(new InvokeOnControlPanel(ToggleControlPanel), true);
                    else
                        ToggleControlPanel(true);

                    return;
                }

                while (!stopShuffle){
                    dtEnd = DateTime.Now;
                    int rIntForPrizes = r.Next(0, listOfRafflePrizes.Count);
                    intProductIdSelected = listOfRafflePrizes[rIntForPrizes].InventoryId;
                    intLuckyPrizeIdSelected = listOfRafflePrizes[rIntForPrizes].RafflePrizeId;

                    Console.WriteLine(rIntForPrizes);

                    if (lblProductToRaffle.InvokeRequired){
                        this.lblProductToRaffle.Invoke(new InvokeOnRaffleWinnerLabels(ShuffleAll), rIntForPrizes);
                    }
                    else{
                        ShuffleAll(rIntForPrizes);
                    }

                    diffInSeconds = (dtEnd - dtStart).TotalSeconds;
                    string strPhoto = $"{Environment.CurrentDirectory}\\Products\\{intProductIdSelected}.jpg";

                    pboxProductToRaffle.Image = new Bitmap(strPhoto);

                    ThreadSleep(diffInSeconds);

                    if (diffInSeconds >= ShuffleTime){
                        SoundPlayer player = new SoundPlayer($"{Path.GetDirectoryName(Application.ExecutablePath) + $"\\Resources\\SelectProduct.wav"}");
                        player.Play();

                        strPhoto = $"{Environment.CurrentDirectory}\\Products\\{intProductIdSelected}.jpg";
                        pboxProductToRaffle.Image = new Bitmap(strPhoto);

                        Thread.Sleep(1000);
                        player.Stop();

                        stopShuffle = true;
                    }
                    Thread.Sleep(100);
                }

                if (pnlControls.InvokeRequired)
                    this.pnlControls.Invoke(new InvokeOnControlPanel(ToggleControlPanel), true);
                else
                    ToggleControlPanel(true);

                isPrizeShuffled = true;
                isBetterLuckNextActivated = false;

                if (isParticipantShuffled)
                {
                    Console.WriteLine("You can now save the winner in the database.");

                    if (btnClaimPrize.InvokeRequired)
                        this.btnClaimPrize.Invoke((MethodInvoker)delegate
                        {
                            this.btnClaimPrize.Visible = true;
                        });
                    else
                        this.btnClaimPrize.Visible = true;

                    if (btnNoShow.InvokeRequired)
                        this.btnNoShow.Invoke((MethodInvoker)delegate
                        {
                            this.btnNoShow.Visible = true;
                        });
                    else
                        this.btnNoShow.Visible = true;
                }
                else {
                    Console.WriteLine("Please select Participants");
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }
        sp_Raffle_PickupWinner_Result vPreDeterminedRaffleWinner;
        private void ShuffleWinnerInvoke() {
            try
            {
                Random r = new Random();
                DateTime dtStart = DateTime.Now;
                DateTime dtEnd = DateTime.Now;
                double diffInSeconds;

                listOfRaffleQualifiedParticipants = participantController.SelectRaffleParticipants(RecordRaffle.Id);

                if (listOfRaffleQualifiedParticipants.Count == 0)
                {
                    if (lblReturnMessage.InvokeRequired)
                    {
                        this.lblReturnMessage.Invoke(new InvokeOnReturnMessage(DisplayErrorMessage), "No more Qualified Participants left.");
                    }
                    else
                        lblReturnMessage.Text = "No more Lucky Prizes left.";
                    return;
                }

                if (pnlControls.InvokeRequired)
                    this.pnlControls.Invoke(new InvokeOnControlPanel(ToggleControlPanel), false);
                else
                    ToggleControlPanel(false);

                dtStart = DateTime.Now;
                dtEnd = DateTime.Now;

                bool stopRaffleParticipantShuffle = false;
                int intRaffleWinner = 0;

                vPreDeterminedRaffleWinner = listOfRaffleQualifiedParticipants.Where(p => p.RafflePrizeId == intLuckyPrizeIdSelected && p.ProductId == intProductIdSelected).Take(1).SingleOrDefault();

                while (!stopRaffleParticipantShuffle)
                {
                    listOfNoProductIdsParticipants = listOfRaffleQualifiedParticipants.Where(p => (p.RafflePrizeId == null || p.RafflePrizeId == 0) && (p.ProductId == null || p.RafflePrizeId == 0)).ToList();

                    intRaffleWinner = r.Next(0, listOfRaffleQualifiedParticipants.Count);
                    dtEnd = DateTime.Now;

                    if (lblParticipantName.InvokeRequired)
                    {
                        this.lblParticipantName.Invoke(new InvokeOnRaffleWinnerLabels(ShuffleWinner), intRaffleWinner);
                    }
                    else
                    {
                        ShuffleWinner(intRaffleWinner);
                    }

                    if (lblRaffleReferenceNumber.InvokeRequired)
                    {
                        this.lblRaffleReferenceNumber.Invoke(new InvokeOnRaffleWinnerRaffleReferenceNo(ShuffleWinnerRaffleReferenceNo), intRaffleWinner);
                    }
                    else
                    {
                        ShuffleWinnerRaffleReferenceNo(intRaffleWinner);
                    }
                    diffInSeconds = (dtEnd - dtStart).TotalSeconds;

                    ThreadSleep(diffInSeconds);

                    if (diffInSeconds >= ShuffleTime)
                        stopRaffleParticipantShuffle = true;
                }

                if (vPreDeterminedRaffleWinner == null)
                {
                    while (listOfRaffleQualifiedParticipants[intRaffleWinner].RafflePrizeId != null)
                    {
                        intRaffleWinner = r.Next(0, listOfRaffleQualifiedParticipants.Count);

                        if (lblParticipantName.InvokeRequired)
                        {
                            this.lblParticipantName.Invoke(new InvokeOnRaffleWinnerLabels(ShuffleWinner), intRaffleWinner);
                        }
                        else
                        {
                            ShuffleWinner(intRaffleWinner);
                        }

                        if (lblRaffleReferenceNumber.InvokeRequired)
                        {
                            this.lblRaffleReferenceNumber.Invoke(new InvokeOnRaffleWinnerRaffleReferenceNo(ShuffleWinnerRaffleReferenceNo), intRaffleWinner);
                        }
                        else
                        {
                            ShuffleWinnerRaffleReferenceNo(intRaffleWinner);
                        }
                        Console.WriteLine("Reshuffle due to specific participant was picked up");

                        Thread.Sleep(300);
                    }
                }
                else
                {
                    if (lblParticipantName.InvokeRequired)
                    {
                        this.lblParticipantName.Invoke(new InvokeOnPreDefinedRaffleWinnerLabels(ShufflePreDeterminedWinner), vPreDeterminedRaffleWinner);
                    }
                    else
                    {
                        ShufflePreDeterminedWinner(vPreDeterminedRaffleWinner);
                    }
                    if (lblRaffleReferenceNumber.InvokeRequired)
                    {
                        this.lblRaffleReferenceNumber.Invoke(new InvokeOnPreDefinedRaffleWinnerRaffleReferenceNo(ShuffleWinnerPreDeterminedRaffleReferenceNo), vPreDeterminedRaffleWinner);
                    }
                    else
                    {
                        ShuffleWinnerPreDeterminedRaffleReferenceNo(vPreDeterminedRaffleWinner);
                    }
                }
                
                isParticipantShuffled = true;

                if (isPrizeShuffled || isBetterLuckNextActivated)
                {
                    Console.WriteLine("You can now save the winner in the database.");
                    
                    if (btnClaimPrize.InvokeRequired)
                        this.btnClaimPrize.Invoke((MethodInvoker)delegate
                        {
                            this.btnClaimPrize.Visible = true;
                        });
                    else
                        this.btnClaimPrize.Visible = true;

                    if (btnNoShow.InvokeRequired)
                        this.btnNoShow.Invoke((MethodInvoker)delegate
                        {
                            this.btnNoShow.Visible = true;
                        });
                    else
                        this.btnNoShow.Visible = true;

                }
                else
                {
                    Console.WriteLine("Please select Participants");
                }

                if (pnlControls.InvokeRequired)
                    this.pnlControls.Invoke(new InvokeOnControlPanel(ToggleControlPanel), true);
                else

                    ToggleControlPanel(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void DisplayErrorMessage(string paramMessage)
        {
            this.lblReturnMessage.Text = $"{paramMessage}";
        }
        private void DisplayGif1() {
            gifCongratulations.Visible = true;
        }

        private void DisplayGif2() {
            gifGirl.Visible = true;
        }
        private void DisplayButtonShuffle(bool toggle){
            btnStartShuffle.Enabled = toggle;
        }

        private void DisplayButtonGoto(bool toggle)
        {
            btnGotoLuckyDraw.Enabled = toggle;
        }

        private void SaveWinnerToDatabase(){
            if (vPreDeterminedRaffleWinner == null){
                recordRaffleWinner = new RaffleWinner();

                recordRaffleWinner.RaffleReferenceNumber = currentParticipantPick.RaffleReferenceNumber;
                recordRaffleWinner.RaffleId = RecordRaffle.Id;
                recordRaffleWinner.PrizeId = intLuckyPrizeIdSelected;
                recordRaffleWinner.ParticipantId = currentParticipantPick.Id;
                recordRaffleWinner.ProductId = intProductIdSelected;

                raffleWinnerController.record = recordRaffleWinner;
                raffleWinnerController.Add();

                rafflePrizeController.SubtractWinnerPrize(recordRaffleWinner.PrizeId);
            }
            else{
                recordRaffleWinner = new RaffleWinner();

                recordRaffleWinner.RaffleReferenceNumber = vPreDeterminedRaffleWinner.RaffleReferenceNumber;
                recordRaffleWinner.RaffleId = RecordRaffle.Id;
                recordRaffleWinner.PrizeId = intLuckyPrizeIdSelected;
                recordRaffleWinner.ParticipantId = vPreDeterminedRaffleWinner.Id;
                recordRaffleWinner.ProductId = intProductIdSelected;

                raffleWinnerController.record = recordRaffleWinner;
                raffleWinnerController.Add();

                rafflePrizeController.SubtractWinnerPrize(recordRaffleWinner.PrizeId);
            }
        }
        private void ShuffleAll(int intIndex){
            itemRafflePrize = listOfRafflePrizes[intIndex];

            this.lblProductToRaffle.Text = $"{itemRafflePrize.BrandModel}";
            this.lblProductToRaffle.Refresh();
        }
        private void ShuffleWinner(int intIndex){
            currentParticipantPick = listOfRaffleQualifiedParticipants[intIndex];
            this.lblParticipantName.Text = $"{currentParticipantPick.FirstName}";
            Console.WriteLine($"{currentParticipantPick.FirstName}");
        }
        private void ShuffleWinnerRaffleReferenceNo(int intIndex){
            currentParticipantPick = listOfRaffleQualifiedParticipants[intIndex];
            this.lblRaffleReferenceNumber.Text = $"{currentParticipantPick.RaffleReferenceNumber}";
            Console.WriteLine($"{currentParticipantPick.RaffleReferenceNumber}");
        }
        private void ShufflePreDeterminedWinner(sp_Raffle_PickupWinner_Result paramWinner){
            this.lblParticipantName.Text = $"{paramWinner.FirstName}";
            Console.WriteLine($"{paramWinner.FirstName}");
        }
        private void ShuffleWinnerPreDeterminedRaffleReferenceNo(sp_Raffle_PickupWinner_Result paramWinner){
            this.lblRaffleReferenceNumber.Text = $"{paramWinner.RaffleReferenceNumber}";
            Console.WriteLine($"{paramWinner.RaffleReferenceNumber}");
        }
        private void guna2Button4_Click_1(object sender, EventArgs e){
            frmParticipantView frm = new frmParticipantView();
            frm.RaffleSource = RecordRaffle;
            frm.ShowDialog();
        }
        private void guna2Button1_Click_3(object sender, EventArgs e){
            if (RecordRaffle == null){
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (RecordRaffle.Id == 0){
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmLuckyDrawMain frmLuckyDraw = new frmLuckyDrawMain();
            frmLuckyDraw.RecordRaffle = RecordRaffle;
            frmLuckyDraw.MaxLuckyDrawNumber = 33;
            frmLuckyDraw.ShuffleTime = 7;
            frmLuckyDraw.Show() ;
        }
        private void btnShuffleParticipants_Click(object sender, EventArgs e){
            if (isPrizeClaimed){
                InitializeScreen();
                isPrizeClaimed = false;
            }

            listOfParticipants = participantController.SelectAllByRaffleId(RecordRaffle.Id);

            if (RecordRaffle == null){
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0.0.5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (RecordRaffle.Id == 0){
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0.0.5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gifGirl.Visible = false;
            gifCongratulations.Visible = false;

            lblParticipantName.Text = String.Empty;
            lblRaffleReferenceNumber.Text = String.Empty;

            stopShuffle = false;

            listOfRaffleEntries = raffleEntryController.SelectAll(RecordRaffle.Id);

            threadStartShuffleForWinner = new Thread(new ThreadStart(ShuffleWinnerInvoke));
            threadStartShuffleForWinner.IsBackground = true;
            threadStartShuffleForWinner.Start();
        }

        private void guna2Button1_Click_2(object sender, EventArgs e){
            string strPhoto = $"{Environment.CurrentDirectory}\\Resources\\Photos\\BetterLuck.jpg";

            pboxProductToRaffle.Image = new Bitmap(strPhoto);
            intLuckyPrizeIdSelected = 0;
            intProductIdSelected = 0;

            isPrizeShuffled = false;    
            isBetterLuckNextActivated = true;
        }
        PingPongPrizeController _pingPongPrizeController = new PingPongPrizeController();
        List<sp_PingPongDraw_SelectForView_Result> _pingPongDrawList;
        private void btnPeraOPingPong_Click(object sender, EventArgs e){
            if (RecordRaffle == null)
            {
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0.0.5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (RecordRaffle.Id == 0)
            {
                MessageBox.Show("Select a Raffle Event first.", "Raffle v1.0.0.5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _pingPongDrawList = _pingPongPrizeController.SelectProducts(RecordRaffle.Id);

            if (_pingPongDrawList.Count != 5)
            {
                MessageBox.Show("Select 5 Prizes for this game first.", "Raffle v1.0.0.5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmPeraPingPong frmPingPong = new frmPeraPingPong();
            frmPingPong.RecordRaffle = RecordRaffle;
            frmPingPong.ShuffleTime = 7;
            frmPingPong.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e){
            frmRaffleWinnerView frm = new frmRaffleWinnerView();
            frm.RaffleSource = RecordRaffle;
            frm.ShowDialog();
        }
        private void guna2Button3_Click(object sender, EventArgs e){
            if (isPrizeShuffled && isParticipantShuffled){
                intProductIdSelected = -1;
                intLuckyPrizeIdSelected = -1;

                SaveWinnerToDatabase();
                isPrizeClaimed = true;
                btnClaimPrize.Visible = false;
                btnNoShow.Visible = false;
            }
        }
        private void btnClaimPrize_Click(object sender, EventArgs e){
            if ((isBetterLuckNextActivated || isPrizeShuffled) && isParticipantShuffled){
                SaveWinnerToDatabase();
                //if (gifCongratulations.InvokeRequired)
                //{
                //    this.gifCongratulations.Invoke(new InvokeOnGif1(DisplayGif1));
                //}
                //else
                DisplayGif1();
                //if (gifGirl.InvokeRequired)
                //{
                //    this.gifGirl.Invoke(new InvokeOnGif2(DisplayGif2));
                //}
                //else
                //{
                DisplayGif2();
                //}
                isPrizeClaimed = true;
                btnClaimPrize.Visible = false;
                btnNoShow.Visible = false;
            }
        }
        ParticipantController participantController = new ParticipantController();
        RafflePrizeController rafflePrizeController = new RafflePrizeController();
        RaffleEntryController raffleEntryController = new RaffleEntryController();
        RaffleWinnerController raffleWinnerController = new RaffleWinnerController();

        sp_RaffleDraw_SelectForView_Result itemRafflePrize = new sp_RaffleDraw_SelectForView_Result();

        List<sp_RaffleDraw_SelectForView_Result> listOfRafflePrizes = new List<sp_RaffleDraw_SelectForView_Result>();
        List<sp_Raffle_PickupWinner_Result> listOfRaffleQualifiedParticipants = new List<sp_Raffle_PickupWinner_Result>();
        List<sp_Raffle_PickupWinner_Result> listOfNoProductIdsParticipants = new List<sp_Raffle_PickupWinner_Result>();
        List<RaffleWinner> listOfRaffleWinners = new List<RaffleWinner>();
        List<Participant> listOfParticipants = new List<Participant>();
        List<RaffleEntry> listOfRaffleEntries = new List<RaffleEntry>();

        RaffleWinner recordRaffleWinner;
        sp_Raffle_PickupWinner_Result currentParticipantPick;

        private Thread threadStartShuffleForPrize;

        private Thread threadStartShuffleForWinner;

        private delegate void InvokeOnClaimButton();
        private delegate void InvokeOnControlPanel(bool toggle);
        private delegate void InvokeOnRaffleWinnerLabels(int intIndex);
        private delegate void InvokeOnReturnMessage(string paramMessage);
        private delegate void InvokeOnRaffleWinnerRaffleReferenceNo(int intIndex);
        private delegate void InvokeOnPreDefinedRaffleWinnerLabels(sp_Raffle_PickupWinner_Result paramWinner);
        private delegate void InvokeOnPreDefinedRaffleWinnerRaffleReferenceNo(sp_Raffle_PickupWinner_Result paramWinner);
        private bool stopShuffle = false;

        frmChooseRaffleEvent frmChooseEvent = new frmChooseRaffleEvent();
        public string SourceFolder { get; set; }
        public Raffle RecordRaffle { get; set; }

        private const double ShuffleTime = 7;
        private bool isPrizeShuffled = false;
        private bool isParticipantShuffled = false;
        private bool isBetterLuckNextActivated = false;
        private bool isPrizeClaimed = false;

        int intProductIdSelected = 0, intLuckyPrizeIdSelected = 0;

        
    }
}
