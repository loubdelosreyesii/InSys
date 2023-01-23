using controller= DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RaffleUI.GlobalVariables;
using DataAccessLibrary.Controller;

namespace RaffleUI
{
    public partial class frmChooseRaffleEvent : Form
    {
        RaffleController raffleController = new RaffleController();
        public Raffle RecordRaffle { get; set; }

        public frmChooseRaffleEvent()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReferenceDetail_Load(object sender, EventArgs e)
        {
            cboxRaffleEvents.DataSource = raffleController.SelectAll();
            cboxRaffleEvents.DisplayMember = "Name";
            cboxRaffleEvents.ValueMember = "ID";

            if (this.cboxRaffleEvents.Items.Count <= 0)
            {
                MessageBox.Show("No Raffle Events Record yet.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cboxRaffleEvents_SelectionChangeCommitted(object sender, EventArgs e){
            GetSelectedRaffleEvent();
        }
        private void GetSelectedRaffleEvent() {
            int selectedRaffleId = (int)cboxRaffleEvents.SelectedValue;
            RecordRaffle = raffleController.SelectById(selectedRaffleId);
        }
        private void btnChoose_Click(object sender, EventArgs e){
            
            GetSelectedRaffleEvent();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {

        }

        private void cboxRaffleEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
