using DataAccessLibrary.Controller;
using DataAccessLibrary.Model;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InSys.GlobalVariables;
namespace InSys
{
    public partial class frmReference : Form
    {
        ReferenceController referenceController = new ReferenceController();
        CategoryController categoryController = new CategoryController();

        List<Reference> list = new List<Reference>();
        List<Category> categories = new List<Category>();

        Reference record;
        Result result;

        frmReferenceDetail frmDetail = new frmReferenceDetail();
        BindingSource listSource = new BindingSource();

        public frmReference()
        {
            InitializeComponent();

            categories = categoryController.SelectAll(); 

        }

        private void frmReference_Load(object sender, EventArgs e)
        {

            RefreshGridBindings();
            dgvRecords.DataSource = listSource;

            //dgvRecords.Columns[3].Visible = false;
        }
         private void RefreshGridBindings() {
            list = referenceController.SelectAll();
            listSource.DataSource = from listReference in list
                                    join listCategories in categories
                                    on listReference.CategoryID equals listCategories.Id
                                    select new {
                                        ID = listReference.Id,
                                        Name = listReference.Name,
                                        Description = listReference.Description,
                                        CategoryID= listCategories.Id,
                                        CategoryName = listCategories.Name
                                    };

            listSource.ResetBindings(false);

            dcolCategoryID.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmReferenceDetail();

            frmDetail.IsAddTransaction = true;
            frmDetail.ShowDialog();
            
            RefreshGridBindings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new Reference();
            frmDetail = new frmReferenceDetail();   

            if (dgvRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.CategoryID = Convert.ToInt32(selectedRow.CategoryID); 

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }
        private void GetRecordInfo() { 
        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new Reference();

            if (dgvRecords.Rows.Count == 0) 
                MessageBox.Show("No Records to be deleted.", APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.Name = selectedRow.Name;
            record.Description = selectedRow.Description;
            record.CategoryID = selectedRow.CategoryID;

            referenceController.record = record;
            
            result=referenceController.Delete();

            MessageBox.Show(result.Message, APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);

            RefreshGridBindings();
        }

       
    }
}
