using Bank.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            _loginBusiness = new LoginBiz();
        }

        private LoginBiz _loginBusiness;

        private void btn_login_Click(object sender, EventArgs e)
        {
            int type = _loginBusiness.getUserType(this.username.Text, this.password.Text);

            if (type == -1)
            {
                //wrong credentials
                MessageBox.Show("Ai gresit, mai incearca!");
                return;
            }

            if (type == 1)
            {
                Form userForm = new MainUserForm();
                this.Hide();
                userForm.FormClosed += userForm_FormClosed;
                userForm.Show();
            }
            else
            {
                Form userForm = new MainUserForm();
                this.Hide();
                userForm.FormClosed += userForm_FormClosed;
                userForm.Show();
            }
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
