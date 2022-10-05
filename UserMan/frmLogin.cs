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
using static UserMan.GlobalVariables;
namespace UserMan
{
    public partial class frmLogin : Form
    {
        UserController userController = new UserController();

        public User record { get; set; }
        public Result result { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0)
                if(MessageBox.Show("Are you sure you want to cancel?", APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                    this.Close();

        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            result = new Result();
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            record = userController.SelectToLogin(txtUserName.Text, txtPassword.Text);
            this.result = userController.result;

            if (this.result.Code)
                this.Close();
            else
                MessageBox.Show($"{userController.result.Message}", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
