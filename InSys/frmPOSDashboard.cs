using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmPOSDashboard : Form
    {
        PointOfSaleController pointOfSaleController = new PointOfSaleController();
        List<PointOfSalesViewModel> list = new List<PointOfSalesViewModel>();
        BindingSource listSource = new BindingSource();

        public frmPOSDashboard()
        {
            InitializeComponent();
        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            RefreshGridBindings();
            dgvwRecords.DataSource = listSource;
        }
        private void RefreshGridBindings()
        {
            dgvwRecords.ScrollBars = ScrollBars.Both;
            list = pointOfSaleController.SelectViewModelAll();
            listSource.DataSource = list.ToList();
            listSource.ResetBindings(false);
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();

            frm.Show();
        }
    }
}
