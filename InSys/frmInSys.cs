using DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaffleUI;
using System.Security.Cryptography;
using UserMan;

namespace InSys
{
    public partial class frmInSys : Form
    {
        frmLogin frmUserLogin = new frmLogin();
        public frmInSys()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
                   
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmPOSDashboard frm = new frmPOSDashboard();
            frm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmRaffle frm = new frmRaffle();
            frm.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void frmInSys_Load(object sender, EventArgs e)
        {
            //frmUserLogin.ShowDialog();

            //if (!frmUserLogin.result.Code) {
            //    this.Close();
            //}
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            frmRaffleMain frm = new frmRaffleMain();
            frm.Show();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            frm.Show();
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            frmRaffle frm = new frmRaffle();
            frm.ShowDialog();
        }

        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            frmDealer frm = new frmDealer();
            frm.Show();
        }

        private void gunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            frmReference frm = new frmReference();
            frm.Show();
        }
    }
}
