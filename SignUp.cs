using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2H_App
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlServerConnectionManager cn = new SqlServerConnectionManager();
        private void SignUp_Load(object sender, EventArgs e)
        {
            cn.PopulateEmployeeNames(comboBoxEmployeeNames);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            string empname = comboBoxEmployeeNames.SelectedItem.ToString();
            cn.InsertUserInfo(username, password, confirmPassword, empname);
        }

        private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
