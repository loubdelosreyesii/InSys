using InSys.CapitalForm;
using InSys.ProfitSharing;
using RaffleUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InSys
{
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (fInventory == null)
                    fInventory = new frmInventory();

                ReShow(fInventory);
            }
            catch (ObjectDisposedException)
            {
                fInventory = new frmInventory();

                ReShow(fInventory);
            }
        }
        private void ReShowNormalWindowMode(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        private void ReShow(Form form) {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        
        private void btnProfitSharing_Click(object sender, EventArgs e)
        {
            try
            {
                if (fProfitSharing == null)
                    fProfitSharing = new frmProfitSharing();

                ReShow(fProfitSharing);
            }
            catch (ObjectDisposedException)
            {
                fProfitSharing = new frmProfitSharing();

                ReShow(fProfitSharing);
            }
        }

       
        private void btnPOS_Click(object sender, EventArgs e)
        {
            try
            {
                if (fPOS == null)
                    fPOS = new frmPOS();

                ReShow(fPOS);
            }
            catch (ObjectDisposedException)
            {
                fPOS = new frmPOS();

                ReShow(fPOS);
            }
        }

        private void gunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (fReference == null)
                    fReference = new frmReference();

                ReShow(fReference);
            }
            catch (ObjectDisposedException)
            {
                fReference = new frmReference();

                ReShow(fReference);
            }
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (fCapital == null)
                    fCapital = new frmCapital();

                ReShow(fCapital);
            }
            catch (ObjectDisposedException)
            {
                fCapital = new frmCapital();

                ReShow(fCapital);
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (fInventory == null)
                    fInventory = new frmInventory();

                ReShow(fInventory);
            }
            catch (ObjectDisposedException)
            {
                fInventory = new frmInventory();

                ReShow(fInventory);
            }
        }

        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (fDealer == null)
                    fDealer = new frmDealer();

                ReShow(fDealer);
            }
            catch (ObjectDisposedException)
            {
                fDealer = new frmDealer();

                ReShow(fDealer);
            }
        }

        private void btnStartRaffle_Click(object sender, EventArgs e)
        {
            if (fRaffleEvent == null)
                fRaffleEvent = new frmChooseRaffleEvent();

            fRaffleEvent.ShowDialog();
        }

        frmRaffle fRaffle = new frmRaffle();
        frmInventory fInventory = new frmInventory();
        frmProfitSharing fProfitSharing = new frmProfitSharing();
        frmPOS fPOS = new frmPOS();
        frmReference fReference = new frmReference();
        frmCapital fCapital = new frmCapital();
        frmDealer fDealer = new frmDealer();
        frmChooseRaffleEvent fRaffleEvent = new frmChooseRaffleEvent();

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (fRaffle == null)
                    fRaffle = new frmRaffle();

                ReShow(fRaffle);
            }
            catch (ObjectDisposedException)
            {
                fRaffle = new frmRaffle();

                ReShow(fRaffle);
            }
        }
    }
}
