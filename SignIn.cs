using DbUp.SqlServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2H_App
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        SqlServerConnectionManager cn = new SqlServerConnectionManager();

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string userName = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            cn.SignInlog(userName, password);
        }
    }
}
