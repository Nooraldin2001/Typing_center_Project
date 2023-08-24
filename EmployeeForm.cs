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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        SqlServerConnectionManager cn = new SqlServerConnectionManager();

        private void InsertEmpBtn_Click(object sender, EventArgs e)
        {
            InsertEmp();
        }

        private void InsertEmp()
        {
            string empName = nameEmpLoyeeTB.Text;
            string empPhoneNumber = phoneEmployeeTB.Text;
            string empEmail = EmailTB.Text;
            string empType = empPositionCB.SelectedItem.ToString();
            cn.InsertEmployee(empName, empPhoneNumber, empEmail, empType);
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
