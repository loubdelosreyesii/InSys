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
    public partial class frmCustomerSearch : Form
    {
        public Customer Customer { get; set; }

        CustomerController customerController = new CustomerController();     
        List<Customer> customers = new List<Customer>();

        BindingSource listSource = new BindingSource();
        
        public frmCustomerSearch(){
            InitializeComponent();
        }
        
        private void frmInventory_Load(object sender, EventArgs e){
            RefreshGridBindings(string.Empty);
            dgvwRecords.DataSource = listSource;
        }

        private void RefreshGridBindings(string paramKeyword){

            List<Customer> customers = new List<Customer>();

            var query = customerController.SelectAll();
            listSource.DataSource = null;

            if (paramKeyword.Length > 0)
                customers = query.Where(p => p.LastName.Contains(paramKeyword) || p.FirstName.Contains(paramKeyword)).ToList();
            else
                customers = query.ToList();

            listSource.DataSource = customers;

            listSource.ResetBindings(false);
        }
        private void dgvwRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwRecords.RowCount > 0) {
                Customer = (Customer) dgvwRecords.CurrentRow.DataBoundItem;
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            RefreshGridBindings(txtSearchCustomer.Text);
        }

        private void dgvwRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
