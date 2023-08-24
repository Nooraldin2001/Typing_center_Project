using DbUp.Engine.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2H_App
{
    public partial class ReportsForm : Form
    {
        Billing Billing = new Billing();
        SqlServerConnectionManager cn = new SqlServerConnectionManager();
        public ReportsForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cn.PopulateEmployeeNames(employeeCB);
            Billing.LoadAutoCompleteDataCustomers(cusName_TB);
            ReportsGrid.DataSource = cn.GetDailyCashierData();
            CalculateInventory(cn.GetDailyCashierData());
        }

        private void filter_Btn_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            string selectedPaymentStatus = paymentStatusCB.SelectedItem?.ToString();
            string selectedCustomerName = cusName_TB.Text;
            DataTable filteredData = null;

            if (!string.IsNullOrEmpty(selectedPaymentStatus) && !string.IsNullOrEmpty(selectedCustomerName))
            {
                filteredData = cn.GetFilteredDailyCashierData(selectedPaymentStatus, selectedCustomerName);
            }
            if (!string.IsNullOrEmpty(selectedPaymentStatus) && string.IsNullOrEmpty(selectedCustomerName))
            {
                filteredData = cn.GetFilteredDailyCashierPayment(selectedPaymentStatus);
            }
            else if (!string.IsNullOrEmpty(selectedCustomerName) && string.IsNullOrEmpty(selectedPaymentStatus))
            {
                filteredData = cn.GetFilteredDailyCashierCustomer(selectedCustomerName);
            }

            if (filteredData != null)
            {
                ReportsGrid.DataSource = filteredData;
                CalculateInventory(filteredData);
                //lblSumTotal.Text = "اجمالي حساب العميل" + CalculateSum(filteredData).ToString();
            }
        }

        //private float CalculateSum(DataTable filteredData)
        //{
        //    //// Calculate and display the sum of totals in the label
        //    float sumTotal = 0;

        //    //if (filteredData.Columns.Contains("اجمالي"))
        //    //{
        //    //    // Check the data type of the column
        //    //    DataColumn totalColumn = filteredData.Columns["اجمالي"];

        //    //    if (totalColumn.DataType == typeof(float))
        //    //    {
        //    //        // Calculate the sum if the column is of type float
        //    //        sumTotal = filteredData.AsEnumerable().Sum(row => row.Field<float>("اجمالي"));
        //    //    }
        //    //    else if (totalColumn.DataType == typeof(double))
        //    //    {
        //    //        // Calculate the sum if the column is of type double
        //    //        sumTotal = (float)filteredData.AsEnumerable().Sum(row => row.Field<double>("اجمالي"));
        //    //    }
        //    //    else if (totalColumn.DataType == typeof(decimal))
        //    //    {
        //    //        // Calculate the sum if the column is of type decimal
        //    //        sumTotal = (float)filteredData.AsEnumerable().Sum(row => row.Field<decimal>("اجمالي"));
        //    //    }
        //    //    else
        //    //    {
        //    //        // Handle the case where the column is not of a supported numeric data type
        //    //        MessageBox.Show("Invalid data type for column 'اجمالي'.");
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    // Handle the case where the column doesn't exist
        //    //    MessageBox.Show("Column 'اجمالي' does not exist in the DataTable.");
        //    //}

        //    ////lblSumTotal.Text = sumTotal.ToString();

        //    return sumTotal;
        //}

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainmenuForm mainmenu = new MainmenuForm();
            mainmenu.Show();
            this.Hide();
        }

        private void FilterdTP_Leave(object sender, EventArgs e)
        {
            int month = FilterdTP.Value.Month;
            int year = FilterdTP.Value.Year;
            FilterMonthlyReports(month, year);
        }

        private void FilterMonthlyReports(int month, int year)
        {
            // Call the stored procedure to get the filtered data
            DataTable filteredData = cn.GetFilteredMonthlyReports(month, year);

            // Set the DataGridView's DataSource to the filtered data
            ReportsGrid.DataSource = filteredData;

            // Calculate the total sum of order profits and separate sums for each payment status
            CalculateInventory(filteredData);
        }

        private void CalculateInventory(DataTable filteredData)
        {
            // Calculate the total sum of order profits and separate sums for each payment status
            decimal totalOrderProfit = 0;
            decimal sumOrderPaid = 0;
            decimal sumOrderDeferred = 0;
            decimal sumOrderAdvance = 0;
            decimal sumVIsa = 0;
            decimal sumCash = 0;


            foreach (DataRow row in filteredData.Rows)
            {
                decimal orderProfit = Convert.ToDecimal(row["الربح"]);
                totalOrderProfit += orderProfit;


                decimal total = Convert.ToDecimal(row["اجمالي"]);
                decimal electronicFee = Convert.ToDecimal(row["الرسوم الالكترونية"]);
                string minusMoney = row["خصم المعامله"].ToString();
                string paymentStatus = row["حالة الدفع"].ToString();
                string paymentType = row["حالة التحصيل"].ToString();

                if (paymentStatus == "مدفوع")
                {
                    sumOrderPaid += total;
                    sumOrderPaid -= electronicFee;
                }
                if (paymentStatus == "مؤجل")
                {
                    sumOrderAdvance -= total;
                }
                else if (paymentStatus == "مقدم")
                {
                    sumOrderAdvance += total;
                }

                //Visa payment status
                if (minusMoney == "فيزا")
                {
                    if (paymentStatus == "مؤجل" && paymentType == "لم يتم التحصيل")
                    {
                        sumVIsa -= electronicFee;
                    }
                    if (paymentStatus == "مدفوع" && paymentType == "فيزا")
                    {
                        sumVIsa += total;
                        sumVIsa -= electronicFee;
                    }
                    else if (paymentStatus == "مقدم" && paymentType == "فيزا")
                    {
                        sumVIsa += total;
                    }
                }

                //Visa payment status
                if (minusMoney == "لم يتم الخصم")
                {
                    if (paymentStatus == "مدفوع" && paymentType == "فيزا")
                    {
                        sumVIsa += total;
                    }
                    else if (paymentStatus == "مقدم" && paymentType == "فيزا")
                    {
                        sumVIsa += total;
                    }
                }

                //Visa payment status
                if (minusMoney == "لم يتم الخصم")
                {
                    if (paymentStatus == "مدفوع" && paymentType == "كاش")
                    {
                        sumCash += total;
                    }
                    else if (paymentStatus == "مقدم" && paymentType == "كاش")
                    {
                        sumCash += total;
                    }
                }

                //cash payment status 
                if (minusMoney == "كاش")
                {
                    if (paymentStatus == "مؤجل" && paymentType == "لم يتم التحصيل")
                    {
                        sumCash -= electronicFee;
                    }
                    if (paymentStatus == "مدفوع" && paymentType == "كاش")
                    {
                        sumCash += totalOrderProfit;
                    }
                    else if (paymentStatus == "مقدم" && paymentType == "كاش")
                    {
                        sumCash += total;
                    }
                }

                if (minusMoney == "كاش")
                {
                    if (paymentStatus == "مدفوع" && paymentType == "فيزا")
                    {
                        sumCash -= total;
                        sumVIsa += total;
                    }
                    else if (paymentStatus == "مقدم" && paymentType == "فيزا")
                    {
                        sumVIsa += total;
                    }
                }
            }

            // Display the total sum of order profits and separate sums for each payment status
            lblSumOrderProfit.Text = "اجمالي ارباح الشهر: " + totalOrderProfit.ToString();
            lblSumTotal.Text = "اجمالي المدفوعات: " + sumOrderPaid.ToString();
            lblTotalDiebt.Text = "اجمالي المؤجلات: " + sumOrderDeferred.ToString();
            lblTotalGiven.Text = "اجمالي المقدمات: " + sumOrderAdvance.ToString();
            lblTotalCash.Text = "الحساب الكاش: " + sumCash.ToString();
            lblTotalVisa.Text = "الحساب الفيزا: " + sumVIsa.ToString();
        }

        private void PopulateCustomerAccounts()
        {
            try
            {
                //ReportsGrid.Rows.Clear();
                if (ReportsGrid.Rows.Count > 0)
                {
                    ReportsGrid.DataSource = cn.GetCustomerAccountsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateEmpAccounts()
        {
            try
            {
                //ReportsGrid.Rows.Clear();
                if (ReportsGrid.Rows.Count > 0)
                {
                    ReportsGrid.DataSource = cn.GetempAccountsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCriedtBtn_Click(object sender, EventArgs e)
        {
            PopulateCustomerAccounts();
        }

        private void ShowEmpAccountsBtn_Click(object sender, EventArgs e)
        {
            PopulateEmpAccounts();
        }

        private void Refresh(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ReportsGrid.DataSource = cn.GetDailyCashierData();
            }
        }

        //public void PopulateDailyCashier()
        //{
        //    try
        //    {
        //        ReportsGrid.DataSource = cn.GetDailyCashierData();
        //        CalculateCashVisa(cn.GetDailyCashierData());
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void CalculateCashVisa(DataTable filteredData)
        //{
        //    // Calculate the total sum of order profits and separate sums for each payment status
        //    decimal totalOrderProfit = 0;
        //    decimal sumVIsa = 0;
        //    decimal sumCash = 0;

        //    foreach (DataRow row in filteredData.Rows)
        //    {
        //        decimal orderProfit = Convert.ToDecimal(row["الربح"]);
        //        totalOrderProfit += orderProfit;


        //        decimal total = Convert.ToDecimal(row["اجمالي"]);
        //        decimal electronicFee = Convert.ToDecimal(row["الرسوم الالكترونية"]);
        //        string minusMoney = row["خصم المعامله"].ToString();
        //        string paymentStatus = row["حالة الدفع"].ToString();
        //        string paymentType = row["حالة التحصيل"].ToString();

        //        //Visa payment status
        //        if (minusMoney == "فيزا")
        //        {
        //            if (paymentStatus == "مؤجل" && paymentType == "لم يتم التحصيل")
        //            {
        //                sumVIsa -= electronicFee;
        //            }
        //            if (paymentStatus == "مدفوع" && paymentType == "فيزا")
        //            {
        //                sumVIsa += total;
        //                sumVIsa -= electronicFee;
        //            }
        //            else if (paymentStatus == "مقدم" && paymentType == "فيزا")
        //            {
        //                sumVIsa += total;
        //            }
        //        }

        //        //Visa payment status
        //        if (minusMoney == "لم يتم الخصم")
        //        {
        //            if (paymentStatus == "مدفوع" && paymentType == "فيزا")
        //            {
        //                sumVIsa += total;
        //            }
        //            else if (paymentStatus == "مقدم" && paymentType == "فيزا")
        //            {
        //                sumVIsa += total;
        //            }
        //        }

        //        //Visa payment status
        //        if (minusMoney == "لم يتم الخصم")
        //        {
        //            if (paymentStatus == "مدفوع" && paymentType == "كاش")
        //            {
        //                sumCash += total;
        //            }
        //            else if (paymentStatus == "مقدم" && paymentType == "كاش")
        //            {
        //                sumCash += total;
        //            }
        //        }

        //        //cash payment status 
        //        if (minusMoney == "كاش")
        //        {
        //            if (paymentStatus == "مؤجل" && paymentType == "لم يتم التحصيل")
        //            {
        //                sumCash -= electronicFee;
        //            }
        //            if (paymentStatus == "مدفوع" && paymentType == "كاش")
        //            {
        //                sumCash += totalOrderProfit;
        //            }
        //            else if (paymentStatus == "مقدم" && paymentType == "كاش")
        //            {
        //                sumCash += total;
        //            }
        //        }

        //        if (minusMoney == "كاش")
        //        {
        //            if (paymentStatus == "مدفوع" && paymentType == "فيزا")
        //            {
        //                sumCash -= total;
        //                sumVIsa += total;
        //            }
        //            else if (paymentStatus == "مقدم" && paymentType == "فيزا")
        //            {
        //                sumVIsa += total;
        //            }
        //        }
        //    }

        //    // Display the total sum of order profits and separate sums for each payment status
        //    lblTotalCash.Text = "الحساب الكاش: " + sumCash.ToString();
        //    lblTotalVisa.Text = "الحساب الفيزا: " + sumVIsa.ToString();
        //}

        private void ReportsForm_KeyDown(object sender, KeyEventArgs e)
        {
            Refresh(e);
        }

        private void PrintReports_TB_Click(object sender, EventArgs e)
        {

        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void SearchEmpBtn_Click(object sender, EventArgs e)
        {
            string empname = employeeCB.SelectedItem.ToString();
            cn.FilterDailyCashierByEmployeeName(empname, ReportsGrid);

        }

        private void PopulateSignInLog()
        {
            try
            {
                //ReportsGrid.Rows.Clear();
                if (ReportsGrid.Rows.Count > 0)
                {
                    ReportsGrid.DataSource = cn.GetSignInLog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignInLogData_Click(object sender, EventArgs e)
        {
            PopulateSignInLog();
        }
    }
}
