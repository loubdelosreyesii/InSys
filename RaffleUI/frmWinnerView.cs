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
    public partial class frmWinnerView : Form
    {

        public int LuckyNumber1 { get; set; }
        public int LuckyNumber2 { get; set; }
        public int LuckyNumber3 { get; set; }
        public Raffle RecordRaffle { get; set; }
        public int ProductId { get; set; }
        public int LuckyPrizeId { get; set; }

        LuckyDrawWinnerController luckyDrawWinnerController =  new LuckyDrawWinnerController();

        sp_LuckyDraw_PickupWinner_Result recordRandomWinner = new sp_LuckyDraw_PickupWinner_Result();

        public frmWinnerView()
        {
            InitializeComponent();
        }

        private void frmParticipant_Load(object sender, EventArgs e)
        {
            recordRandomWinner = luckyDrawWinnerController.SelectWinner(RecordRaffle.Id,LuckyNumber1,LuckyNumber2,LuckyNumber3,ProductId, LuckyPrizeId);

            tblPanelPart.Visible = false;
            tblRaffleNo.Visible = false;
            lblBetterLuck.Visible = false;
            gifBox2.Visible = false; 
            if (recordRandomWinner.ParticipantId>0) {
                lblWinner.Text = recordRandomWinner.ParticipantName;
                lblRaffleReferenceNumber.Text = recordRandomWinner.RaffleReferenceNumber;

                tblPanelPart.Visible = true;
                tblRaffleNo.Visible = true;
                lblBetterLuck.Visible = true;
                gifBox2.Visible = true;
            }
            else {
                lblBetterLuck.Visible = true;
            }
        }

       
    }
}
