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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace RaffleUI
{
    public partial class frmPeraPingPong : Form
    {
        public string SourceFolder { get; set; }
        public Raffle RecordRaffle{ get; set; }
        public int MaxLuckyDrawNumber { get; set; }
        public double ShuffleTime { get; set; }
        public double ShuffleColorTime { get; set; }
        List<sp_PingPongDraw_SelectForView_Result> _pingPongDrawList;
        List<sp_PingPongDraw_SelectForView_Result> _pingPongDrawListShuffledFromControl;
        PingPongPrizeController _pingPongPrizeController = new PingPongPrizeController();
        List<Color> _colors = new List<Color>();

        frmPeraPingPongControlPanel frmPanel = new frmPeraPingPongControlPanel();

        Thread threadUpdatePrizes;
        bool isStopThreadGuessing;
        string strPhoto;
        public frmPeraPingPong()
        {
            InitializeComponent();
        }
        private void frmPeraPingPong_Load(object sender, EventArgs e)
        {
            ////For Testing
            //RecordRaffle = new Raffle();    
            //RecordRaffle.Id = 18;
            //
            _colors = new List<Color>();
            _pingPongDrawList = _pingPongPrizeController.SelectProducts(RecordRaffle.Id);

            isParticipantPick = false;

            //_colors.Add(Color.Green);
            //_colors.Add(Color.Blue);
            //_colors.Add(Color.Black);
            //_colors.Add(Color.Pink);
            //_colors.Add(Color.Red);

            //string strPhoto = $"{Environment.CurrentDirectory}\\Products\\{_pingPongDrawList[0].InventoryId}.jpg";
            //pic1.Image = new Bitmap(strPhoto);

            //strPhoto = $"{Environment.CurrentDirectory}\\Products\\{_pingPongDrawList[1].InventoryId}.jpg";
            //pic2.Image = new Bitmap(strPhoto);

            //strPhoto = $"{Environment.CurrentDirectory}\\Products\\{_pingPongDrawList[2].InventoryId}.jpg";
            //pic3.Image = new Bitmap(strPhoto);

            //strPhoto = $"{Environment.CurrentDirectory}\\Products\\{_pingPongDrawList[3].InventoryId}.jpg";
            //pic4.Image = new Bitmap(strPhoto);

            //strPhoto = $"{Environment.CurrentDirectory}\\Products\\{_pingPongDrawList[4].InventoryId}.jpg";
            //pic5.Image = new Bitmap(strPhoto);

            isStopThreadGuessing = false;
            threadUpdatePrizes = new Thread(new ThreadStart(GuessingPrizes));
            threadUpdatePrizes.IsBackground = true;
            threadUpdatePrizes.Start();

            frmPanel.prizes = _pingPongDrawList;
            frmPanel.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - frmPanel.Width,
                       Screen.PrimaryScreen.WorkingArea.Height - frmPanel.Height);
            frmPanel.Show();
        }
        private delegate void InvokeOnPictureBox1(List<sp_PingPongDraw_SelectForView_Result> items);
        private delegate void InvokeOnPictureBox2(List<sp_PingPongDraw_SelectForView_Result> items);
        private delegate void InvokeOnPictureBox3(List<sp_PingPongDraw_SelectForView_Result> items);
        private delegate void InvokeOnPictureBox4(List<sp_PingPongDraw_SelectForView_Result> items);
        private delegate void InvokeOnPictureBox5(List<sp_PingPongDraw_SelectForView_Result> items);

        private void GuessingPrizes() {
            while (!isStopThreadGuessing) {

                _pingPongDrawListShuffledFromControl = frmPanel.prizes;

                if (_pingPongDrawListShuffledFromControl.Count != 5)
                    continue;
                
                //foreach (var item in _pingPongDrawListShuffledFromControl)
                //{
                //    Console.WriteLine("PingPong UI: " + item.RafflePrizeId);
                //}
                if (pic1.InvokeRequired)
                    this.pic1.Invoke(new InvokeOnPictureBox1(UpdatePictureBox1), _pingPongDrawListShuffledFromControl);
                else
                    UpdatePictureBox1(_pingPongDrawListShuffledFromControl);

                if (pic2.InvokeRequired)
                    this.pic2.Invoke(new InvokeOnPictureBox2(UpdatePictureBox2), _pingPongDrawListShuffledFromControl);
                else
                    UpdatePictureBox2(_pingPongDrawListShuffledFromControl);


                if (pic3.InvokeRequired)
                    this.pic3.Invoke(new InvokeOnPictureBox3(UpdatePictureBox3), _pingPongDrawListShuffledFromControl);
                else
                    UpdatePictureBox3(_pingPongDrawListShuffledFromControl);


                if (pic4.InvokeRequired)
                    this.pic4.Invoke(new InvokeOnPictureBox4(UpdatePictureBox4), _pingPongDrawListShuffledFromControl);
                else
                    UpdatePictureBox4(_pingPongDrawListShuffledFromControl);


                if (pic5.InvokeRequired)
                    this.pic5.Invoke(new InvokeOnPictureBox5(UpdatePictureBox5), _pingPongDrawListShuffledFromControl);
                else
                    UpdatePictureBox5(_pingPongDrawListShuffledFromControl);

                Thread.Sleep(400);
            }
        }

        private void UpdatePictureBox1(List<sp_PingPongDraw_SelectForView_Result> items) {

            if (items.Count != 5)
                return;
            if (isPic1Open)
            {
                strPhoto = $"{Environment.CurrentDirectory}\\Products\\{items[0].InventoryId}.jpg";
                Console.WriteLine("   Pic1 :" + items[0].InventoryId);
                pic1.Image = new Bitmap(strPhoto);
            }
            else{
                pic1.Image = null;
                pic1.BackColor = Color.Black;
            }
        }

        private void UpdatePictureBox2(List<sp_PingPongDraw_SelectForView_Result> items)
        {
            if (items.Count != 5)
                return;

            if(isPic2Open)
            { 
            strPhoto = $"{Environment.CurrentDirectory}\\Products\\{items[1].InventoryId}.jpg";
            Console.WriteLine("   Pic2 :" + items[1].InventoryId);
            pic2.Image = new Bitmap(strPhoto);
            }
            else
            {
                pic2.Image = null;
                pic2.BackColor = Color.Green;
            }
        }

        private void UpdatePictureBox3(List<sp_PingPongDraw_SelectForView_Result> items)
        {
            if (items.Count != 5)
                return;
            strPhoto = $"{Environment.CurrentDirectory}\\Products\\{items[2].InventoryId}.jpg";

            if (isPic3Open)
            {
                Console.WriteLine("   Pic3 :" + items[2].InventoryId);
                pic3.Image = new Bitmap(strPhoto);
            }
            else{
                pic3.Image = null;
                pic3.BackColor = Color.Red;
            }
}

        private void UpdatePictureBox4(List<sp_PingPongDraw_SelectForView_Result> items)
        {
            if (items.Count != 5)
                return;

            if (isPic4Open) { 
            strPhoto = $"{Environment.CurrentDirectory}\\Products\\{items[3].InventoryId}.jpg";
            Console.WriteLine("   Pic4 :" + items[3].InventoryId);
            pic4.Image = new Bitmap(strPhoto);
            }
            else
            {
                pic4.Image = null;
                pic4.BackColor = Color.Blue;
            }
        }

        private void UpdatePictureBox5(List<sp_PingPongDraw_SelectForView_Result> items)
        {
            if (items.Count != 5)
                return;

            if(isPic5Open)
            { 
            strPhoto = $"{Environment.CurrentDirectory}\\Products\\{items[4].InventoryId}.jpg";
            Console.WriteLine("   Pic5 :" + items[4].InventoryId);
            pic5.Image = new Bitmap(strPhoto);
            }
            else
            {
                pic5.Image = null;
                pic5.BackColor = Color.Pink;
            }
        }

        private void pic1_DoubleClick(object sender, EventArgs e)
        {
            if (isParticipantPick)
            {
                isPic1Open = false;
                lbl1.ForeColor = Color.Orange;
            }
            else {
                isPic1Open = true;
                lbl1.ForeColor = Color.Red;

                frmPanel.isPic1Open = true;
            }
        }

        public bool isPic1Open { get; set; }
        public bool isPic2Open { get; set; }
        public bool isPic3Open { get; set; }
        public bool isPic4Open { get; set; }
        public bool isPic5Open { get; set; }

        bool isParticipantPick = true;


        private void pic2_DoubleClick(object sender, EventArgs e)
        {
            if (isParticipantPick)
            {
                isPic2Open = false;
                lbl2.ForeColor = Color.Orange;
            }
            else
            {
                isPic2Open = true;
                lbl2.ForeColor = Color.Red;

                frmPanel.isPic2Open = true;
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void pic3_DoubleClick(object sender, EventArgs e)
        {
            if (isParticipantPick)
            {
                isPic3Open = false;
                lbl3.ForeColor = Color.Orange;
            }
            else
            {
                isPic3Open = true;
                lbl3.ForeColor = Color.Red;

                frmPanel.isPic3Open = true;
            }
        }

        private void pic4_DoubleClick(object sender, EventArgs e)
        {
            if (isParticipantPick)
            {
                isPic4Open = false;
                lbl4.ForeColor = Color.Orange;
            }
            else
            {
                isPic4Open = true;
                lbl4.ForeColor = Color.Red;

                frmPanel.isPic4Open = true;
            }
        }

        private void pic5_DoubleClick(object sender, EventArgs e)
        {
            if (isParticipantPick)
            {
                isPic5Open = false;
                lbl5.ForeColor = Color.Orange;
            }
            else
            {
                isPic5Open = true;
                lbl5.ForeColor = Color.Red;

                frmPanel.isPic5Open = true;
            }
        }

        private void frmPeraPingPong_FormClosing(object sender, FormClosingEventArgs e)
        {
            isStopThreadGuessing = true;

            if (frmPanel != null) {
                frmPanel.Close();
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }


        private void btnClaimPrizeOffer_Click(object sender, EventArgs e)
        {
            btnClaimCardPrize.Visible = false;
            btnClaimPrizeOffer.Visible = false;
        }

        private void btnClaimCardPrize_Click(object sender, EventArgs e)
        {

            btnClaimCardPrize.Visible = false;
            btnClaimPrizeOffer.Visible = false;
        }
        PingPongPrizeController pingPongController = new PingPongPrizeController();

    }
}
