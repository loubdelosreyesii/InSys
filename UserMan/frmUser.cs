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
using static UserMan.GlobalVariables;
namespace UserMan
{
    public partial class frmUser : Form
    {
        ReferenceController referenceController = new ReferenceController();
        UserController userController = new UserController();

        List<Reference> references = new List<Reference>();
        List<User> users = new List<User>();

        User record;
        Result result;

        frmUserDetail frmDetail = new frmUserDetail();
        BindingSource listSource = new BindingSource();

        public frmUser()
        {
            InitializeComponent();
            //references = referenceController.SelectByCategoryId(4);
            //users = userController.SelectAll();
        }

        private void frmReference_Load(object sender, EventArgs e)
        {

            RefreshGridBindings();
            dgvRecords.DataSource = listSource;

            //dgvRecords.Columns[3].Visible = false;
        }
        private void RefreshGridBindings() {

            references = referenceController.SelectByCategoryId(4);
            users = userController.SelectAll();

            listSource.DataSource = from user in users
                                    join refer in references
                                    on  user.UserType equals refer.Id
                                    select new {
                                        ID = user.Id,
                                        UserName = user.UserName,
                                        Password = user.Password,
                                        UserTypeId = user.UserType,
                                        UserTypeName = refer.Name
                                    };

            listSource.ResetBindings(false);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDetail = new frmUserDetail();

            frmDetail.IsAddTransaction = true;
            frmDetail.ShowDialog();
            
            RefreshGridBindings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            record = new User();
            frmDetail = new frmUserDetail();   

            if (dgvRecords.Rows.Count == 0)
                MessageBox.Show("No Records to edit.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            dynamic selectedRow = dgvRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.UserName = selectedRow.UserName;
            record.Password = selectedRow.Password;
            record.UserType = Convert.ToInt32(selectedRow.UserTypeId); 

            frmDetail.Record = record;
            frmDetail.IsAddTransaction = false;
            frmDetail.ShowDialog();

            RefreshGridBindings();
        }
        private void GetRecordInfo() { 
        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            record = new User();

            if (dgvRecords.Rows.Count == 0) 
                MessageBox.Show("No Records to be deleted.", APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (MessageBox.Show("Are you sure you want to delete the selected row?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            dynamic selectedRow = dgvRecords.CurrentRow.DataBoundItem;

            record.Id = selectedRow.ID;
            record.UserName = selectedRow.UserName;
            record.Password = selectedRow.Password;
            record.UserType = Convert.ToInt32(selectedRow.UserTypeId);

            userController.record = record;
            result= userController.Delete();

            MessageBox.Show(result.Message, APP_NAME,MessageBoxButtons.OK,MessageBoxIcon.Information);

            RefreshGridBindings();
        }

        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
