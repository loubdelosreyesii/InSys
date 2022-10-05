using DataAccessLibrary.Controller;
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
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmReferenceDetail : Form
    {
        ReferenceController referenceController = new ReferenceController();
        CategoryController categoryController = new CategoryController();

        public Reference Record { get; set; }
        public bool IsAddTransaction { get; set; }
        Result result;

        public frmReferenceDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAddTransaction){
                Record = new Reference();
                
                Record.Name = txtName.Text;
                Record.Description = txtDescription.Text;
                Record.CategoryID =Convert.ToInt16(cboxCategories.SelectedValue);

                referenceController.record = Record;
                result = referenceController.Add();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Record.Name = txtName.Text;
                Record.Description = txtDescription.Text;
                Record.CategoryID = Convert.ToInt16(cboxCategories.SelectedValue);

                referenceController.record = Record;
                result = referenceController.Edit();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
                if(MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                    this.Close();

        }

        private void frmReferenceDetail_Load(object sender, EventArgs e)
        {
            cboxCategories.DataSource = categoryController.SelectAll();
            cboxCategories.DisplayMember = "Name";
            cboxCategories.ValueMember = "ID";

            if (Record != null)
            {
                txtName.Text = Record.Name;
                txtDescription.Text = Record.Description;
                cboxCategories.SelectedValue = Record.CategoryID;
            }
        }
    }
}
