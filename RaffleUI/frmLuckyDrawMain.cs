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

namespace RaffleUI
{
    public partial class frmLuckyDrawMain : Form
    {
        public string SourceFolder { get; set; }
        public Raffle RecordRaffle{ get; set; }
        public int MaxLuckyDrawNumber { get; set; }
        public double ShuffleTime { get; set; }
        int counter = 1;

        List<int> LottoNumbers = new List<int>();
        public frmLuckyDrawMain()
        {
            InitializeComponent();
        }
        
        private void CreateLottoNumbers() {
            for (int i = 1; i <= MaxLuckyDrawNumber; i++){
                LottoNumbers.Add(i);
            }
        }
        
        private void InitializeControls()
        {
            pboxProductToRaffle.Image = null;
            lblProductToRaffle.Text = string.Empty;
            btnNumber1.Text = "0";
            btnNumber2.Text = "0";
            btnNumber3.Text = "0";
        }
        private void guna2Button4_Click(object sender, EventArgs e) //retain
        {
            stopShuffle = false;
            InitializeControls();

            threadStartShuffleAll = new Thread(new ThreadStart(ShuffleAllInvoke));
            threadStartShuffleAll.IsBackground = true;
            threadStartShuffleAll.Start();
        }

        private void ThreadSleep(double diffInSeconds)
        {
            if (diffInSeconds < 4)
                Thread.Sleep(100);
            else if (diffInSeconds < 6)
                Thread.Sleep(300);
            else
                Thread.Sleep(500);
        }
        private void ShuffleAllInvoke() {
            Random r = new Random();
            DateTime dtStart = DateTime.Now;
            DateTime dtEnd = DateTime.Now;
            double diffInSeconds;
            bool stopNumber1Shuffle = false,stopNumber2Shuffle=false, stopNumber3Shuffle = false;
            int intProductIdSelected=0,intLuckyPrizeIdSelected=0;
            
            listOfLuckyDrawPrizes = luckyDrawPrizeController.SelectProducts(RecordRaffle.Id);

            if (listOfLuckyDrawPrizes.Count == 0) {
                if (lblReturnMessage.InvokeRequired) {
                    this.lblReturnMessage.Invoke(new InvokeOnReturnMessage(DisplayErrorMessage), "No more Lucky Prizes left.");
                }
                else
                    lblReturnMessage.Text = "No more Lucky Prizes left.";
                return;
            }
            while (!stopShuffle){

                dtEnd = DateTime.Now;
                int rIntForPrizes = r.Next(0, listOfLuckyDrawPrizes.Count);
                intProductIdSelected = listOfLuckyDrawPrizes[rIntForPrizes].InventoryId;
                intLuckyPrizeIdSelected = listOfLuckyDrawPrizes[rIntForPrizes].LuckyPrizeId;
                Console.WriteLine(rIntForPrizes);

                if (lblProductToRaffle.InvokeRequired){
                    this.lblProductToRaffle.Invoke(new InvokeOnRaffleWinnerLabels(ShuffleAll), rIntForPrizes);
                }
                else{
                    ShuffleAll(rIntForPrizes);
                }

                diffInSeconds = (dtEnd- dtStart).TotalSeconds;
                string strPhoto = $"{Environment.CurrentDirectory}\\Products\\{intProductIdSelected}.jpg";

                pboxProductToRaffle.Image = new Bitmap(strPhoto);

                ThreadSleep(diffInSeconds);  

                if (diffInSeconds >= ShuffleTime){
                    SoundPlayer player = new SoundPlayer($"{Path.GetDirectoryName(Application.ExecutablePath) + $"\\Resources\\SelectProduct.wav"}");
                    player.Play();

                    stopShuffle = true;
                    
                    strPhoto = $"{Environment.CurrentDirectory}\\Products\\{intProductIdSelected}.jpg";
                    pboxProductToRaffle.Image = new Bitmap(strPhoto);
                    
                    Thread.Sleep(600);
                    player.Stop();
                }
                Thread.Sleep(100);
            }

            //Thread.Sleep(1000);

            dtStart = DateTime.Now;
            dtEnd = DateTime.Now;
            int intLuckyNumbers=0;

            while (!stopNumber1Shuffle){
                intLuckyNumbers = r.Next(0, LottoNumbers.Count);
                dtEnd = DateTime.Now;
                if (btnNumber1.InvokeRequired)
                {
                    this.btnNumber1.Invoke(new InvokeOnLuckyNumber1(ShuffleNumber1), intLuckyNumbers);
                }
                else {
                    ShuffleNumber1(intLuckyNumbers);
                }
                
                diffInSeconds = (dtEnd - dtStart).TotalSeconds;

                ThreadSleep(diffInSeconds);


                Console.WriteLine(diffInSeconds.ToString());

                if (diffInSeconds >= ShuffleTime)
                    stopNumber1Shuffle = true;
            }
            LottoNumbers.RemoveAt(intLuckyNumbers);

            //Thread.Sleep(1000);

            dtStart = DateTime.Now;
            dtEnd = DateTime.Now;

            while (!stopNumber2Shuffle)
            {
                intLuckyNumbers = r.Next(0, LottoNumbers.Count);
                dtEnd = DateTime.Now;
                if (btnNumber1.InvokeRequired)
                {
                    this.btnNumber2.Invoke(new InvokeOnLuckyNumber1(ShuffleNumber2), intLuckyNumbers);
                }
                else
                {
                    ShuffleNumber2(intLuckyNumbers);
                }

                diffInSeconds = (dtEnd - dtStart).TotalSeconds;

                ThreadSleep(diffInSeconds);


                if (diffInSeconds > ShuffleTime)
                    stopNumber2Shuffle = true;
            }
            LottoNumbers.RemoveAt(intLuckyNumbers);

            //Thread.Sleep(1000);

            dtStart = DateTime.Now;
            dtEnd = DateTime.Now;

            while (!stopNumber3Shuffle)
            {
                intLuckyNumbers = r.Next(0, LottoNumbers.Count);
                dtEnd = DateTime.Now;
                if (btnNumber1.InvokeRequired)
                {
                    this.btnNumber3.Invoke(new InvokeOnLuckyNumber1(ShuffleNumber3), intLuckyNumbers);
                }
                else
                {
                    ShuffleNumber3(intLuckyNumbers);
                }

                diffInSeconds = (dtEnd - dtStart).TotalSeconds;

                ThreadSleep(diffInSeconds);

                if (diffInSeconds > ShuffleTime)
                    stopNumber3Shuffle = true;
            }
            LottoNumbers.RemoveAt(intLuckyNumbers);

            //Thread.Sleep(3000);

            frmWinnerView frmWinner = new frmWinnerView();

            frmWinner.RecordRaffle = RecordRaffle;
            frmWinner.ProductId = intProductIdSelected;
            frmWinner.LuckyPrizeId = intLuckyPrizeIdSelected;
            frmWinner.LuckyNumber1 = Convert.ToInt32(btnNumber1.Text);
            frmWinner.LuckyNumber2 = Convert.ToInt32(btnNumber2.Text);
            frmWinner.LuckyNumber3 = Convert.ToInt32(btnNumber3.Text);
            
            frmWinner.ShowDialog();
        }
        private void DisplayErrorMessage(string paramMessage)
        {
            this.lblReturnMessage.Text = $"{paramMessage}";
        }
        private void ShuffleNumber1(int intIndex)
        {
            int displayNumber = LottoNumbers[intIndex];
            this.btnNumber1.Text = $"{displayNumber.ToString()}";
        }
        private void ShuffleNumber2(int intIndex)
        {
            int displayNumber = LottoNumbers[intIndex];
            this.btnNumber2.Text = $"{displayNumber.ToString()}";

        }
        private void ShuffleNumber3(int intIndex)
        {
            int displayNumber = LottoNumbers[intIndex];
            this.btnNumber3.Text = $"{displayNumber.ToString()}";
            
        }

        private void ShuffleAll(int intIndex)
        {
            itemLuckyDrawPrize = listOfLuckyDrawPrizes[intIndex];

            this.lblProductToRaffle.Text = $"{itemLuckyDrawPrize.BrandModel}";
            this.lblProductToRaffle.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateLottoNumbers();
            
        }
        RaffleEntryController raffleEntryController = new RaffleEntryController();
        ParticipantController participantController = new ParticipantController();
        RaffleWinnerController raffleWinnerController = new RaffleWinnerController();
        RafflePrizeController rafflePrizeController = new RafflePrizeController();
        RaffleLuckyDrawPrizeController luckyDrawPrizeController = new RaffleLuckyDrawPrizeController();
        
        List<RaffleEntry> listOfRaffleEntries = new List<RaffleEntry>();
        List<Participant> listOfParticipants = new List<Participant>();
        List<sp_LuckyDraw_SelectForView_Result> listOfLuckyDrawPrizes = new List<sp_LuckyDraw_SelectForView_Result>();
        List<Inventory> listOfInventories = new List<Inventory>();
        List<ParticipantView> listOfParticipantView;
        List<InventoryView> listOfInventoryView = new List<InventoryView>();

        sp_LuckyDraw_SelectForView_Result itemLuckyDrawPrize = new sp_LuckyDraw_SelectForView_Result();
        ParticipantView currentParticipantPick;
        RaffleWinner recordRaffleWinner;

        private Thread threadStartShuffleAll;
        private delegate void InvokeOnRaffleWinnerLabels(int intIndex);
        private delegate void InvokeOnReturnMessage(string paramMessage);
        private delegate void InvokeOnLuckyNumber1(int intIndex);
        private delegate void InvokeOnLuckyNumber2(int intIndex);
        private delegate void InvokeOnLuckyNumber3(int intIndex);
        private bool stopShuffle=false;

        private void guna2Button4_Click_1(object sender, EventArgs e)//retain
        {
            frmParticipantView frm = new frmParticipantView();
            frm.RaffleSource = RecordRaffle;
            frm.IsFromLuckyDraw = true;
            frm.ShowDialog();
        }

        private void btnViewWinners_Click(object sender, EventArgs e)
        {

        }
    }
}
