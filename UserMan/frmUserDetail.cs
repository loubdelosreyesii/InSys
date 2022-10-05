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
using System.Xml.Linq;
using static UserMan.GlobalVariables;
namespace UserMan
{
    public partial class frmUserDetail : Form
    {
        UserController userController = new UserController();
        ReferenceController referenceController = new ReferenceController();

        public User Record { get; set; }
        public bool IsAddTransaction { get; set; }
        Result result;

        public frmUserDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsAddTransaction)
            {
                Record = new User();

                Record.UserName = txtUserName.Text;
                Record.Password = txtPassword.Text;
                Record.UserType = Convert.ToInt32(cboxUserType.SelectedValue);

                userController.record = Record;
                result = userController.Add();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Record.UserName = txtUserName.Text;
                Record.Password = txtPassword.Text;
                Record.UserType = Convert.ToInt32(cboxUserType.SelectedValue);

                userController.record = Record;
                result = userController.Edit();

                MessageBox.Show(result.Message, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0)
                if (MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    this.Close();

        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            cboxUserType.DataSource = referenceController.SelectByCategoryId(4);
            cboxUserType.DisplayMember = "Name";
            cboxUserType.ValueMember = "ID";

            if (Record != null)
            {
                txtUserName.Text = Record.UserName;
                txtPassword.Text = Record.Password;
                cboxUserType.SelectedValue = Record.UserType;
            }
        }
        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0'; 
        }
    }
}
