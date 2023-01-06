using InSys.ProfitSharing;
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            catch (ObjectDisposedException ex)
            {
                fInventory = new frmInventory();

                ReShow(fInventory);
            }
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
            catch (ObjectDisposedException ex)
            {
                fProfitSharing = new frmProfitSharing();

                ReShow(fProfitSharing);
            }
        }

        frmInventory fInventory = new frmInventory();
        frmProfitSharing fProfitSharing = new frmProfitSharing();
        frmPOS fPOS = new frmPOS();

        private void btnPOS_Click(object sender, EventArgs e)
        {
            try
            {
                if (fPOS == null)
                    fPOS = new frmPOS();

                ReShow(fPOS);
            }
            catch (ObjectDisposedException ex)
            {
                fPOS = new frmPOS();

                ReShow(fPOS);
            }
        }
    }
}
