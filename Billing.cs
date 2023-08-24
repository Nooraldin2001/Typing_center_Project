using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using Image = iTextSharp.text.Image;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;
using System.Security.Claims;
using iTextSharp.text.pdf.languages;
using System.Data.SqlClient;
using DbUp.SqlServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace H2H_App
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        SqlServerConnectionManager cn = new SqlServerConnectionManager();
        string customerName;
        string productName;
        float productElectronicFee;
        DateTime orderDate;
        float orderProfit;
        string paymentStatus;
        string paymentType;
        string minus_Money_status;
        string empName;

        public void SetEmployeeName(string employeeName)
        {
            if (!string.IsNullOrEmpty(employeeName))
            {
                empName = employeeName;
            }
        }

        public void CalculateCashVisa()
        {
            DataTable filteredData;
            filteredData = (DataTable)dailyCashiergrid.DataSource;
            // Calculate the total sum of order profits and separate sums for each payment status
            decimal totalOrderProfit = 0;
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
            lblTotalCash.Text = "الحساب الكاش: " + sumCash.ToString();
            lblTotalVisa.Text = "الحساب الفيزا: " + sumVIsa.ToString();
        }

        private void LoadAutoCompleteDataProducts()
        {
            try
            {
                // Open the database connection
                SqlConnection con = cn.Getconnection();
                con.Open();
                // Retrieve the product names from the database
                SqlCommand command = new SqlCommand("SELECT product_name, product_electronic_fee FROM Products", con);
                SqlDataReader reader = command.ExecuteReader();

                // Create dictionaries to hold the product names and electronic fees
                Dictionary<string, string> productNames = new Dictionary<string, string>();
                Dictionary<string, List<string>> productElectronicFees = new Dictionary<string, List<string>>();


                // Fill the dictionaries with data from the database
                while (reader.Read())
                {
                    string productName = reader.GetString(0);
                    float electronicFee = Convert.ToSingle(reader.GetValue(1)); 

                    string electronicFeetext = electronicFee.ToString();

                    productNames.Add(productName, electronicFeetext);
                    //productElectronicFees.Add(electronicFeetext, productName);
                    // Add the electronic fee to the dictionary or update the existing entry
                    if (productElectronicFees.ContainsKey(electronicFeetext))
                    {
                        productElectronicFees[electronicFeetext].Add(productName);
                    }
                    else
                    {
                        productElectronicFees.Add(electronicFeetext, new List<string> { productName });
                    }
                }

                // Set the auto-complete custom source for the TextBox
                process_TB.AutoCompleteCustomSource.AddRange(productNames.Keys.ToArray());

                // Handle the TextChanged event of the TextBox
                process_TB.TextChanged += (sender, e) =>
                {
                    string selectedProductName = process_TB.Text;
                    if (productNames.ContainsKey(selectedProductName))
                    {
                        string electronicFee = productNames[selectedProductName];

                        // Set the electronic fee text box with the selected product's electronic fee
                        electronicFee_TB.Text = electronicFee;
                    }
                    else
                    {
                        // Clear the electronic fee text box if the selected product is not found
                        electronicFee_TB.Text = string.Empty;
                    }
                };

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                cn.CloseConnection();
            }
        }

        public void LoadAutoCompleteDataCustomers(TextBox textBox)
        {
            try
            {
                // Open the database connection
                SqlConnection con = cn.Getconnection();
                con.Open();
                // Retrieve the product names from the database
                SqlCommand command = new SqlCommand("SELECT customer_name FROM Customers", con);
                SqlDataReader reader = command.ExecuteReader();

                // Create an AutoCompleteStringCollection to hold the suggestions
                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

                // Add the product names to the collection
                while (reader.Read())
                {
                    //string productName = reader.GetString(0);
                    autoCompleteCollection.Add(reader.GetString(0));
                }

                // Set the auto-complete custom source for the TextBox
                textBox.AutoCompleteCustomSource = autoCompleteCollection;

                // Close the reader
                //reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                cn.CloseConnection();
            }
        }

        public void PopulateDailyCashier()
        {
            try
            {
                cn.FilterDailyCashierByEmployeeName(empName, dailyCashiergrid);
                
                CalculateCashVisa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Invoice_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            // Populate the employee combo box with some dummy data
            LoadAutoCompleteDataProducts();
            LoadAutoCompleteDataCustomers(cusName_TB);
            //cn.FilterDailyCashierByEmployeeName(empName, dailyCashiergrid);
            PopulateDailyCashier();
            dicountTb.Text = "نسبة الخصم(%)";
            dicountTb.ForeColor = Color.Gray; // Change the text color if desired
        }

        //private void Delete_Row(KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Back)
        //    {
        //        if (dailyCashiergrid.SelectedRows.Count > 0)
        //        {
        //            // Get the subtotal of the row to be deleted
        //            int ID = (int)dailyCashiergrid.SelectedRows[0].Cells["ID"].Value;
        //            cn.DeleteDailyCashier(ID);
        //            PopulateDailyCashier(dailyCashiergrid);
        //            // Delete the selected row
        //            //dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

        //            // Subtract the subtotal from the total 
        //            //double total = double.Parse(subtotalTb.Text.Substring(3)) - subtotal;

        //            // Update the total label
        //            //subtotalTb.Text = total.ToString("C");
        //        }
        //    }
        //}

        private void InsertData()
        {
               try
               {
                    customerName = cusName_TB.Text;
                    productName = process_TB.Text;
                    productElectronicFee = float.Parse(electronicFee_TB.Text);
                    orderDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                    orderProfit = float.Parse(orederProfitTB.Text);
                    paymentStatus = paymentStatusCB.SelectedItem?.ToString();
                    paymentType = paymentTypeCB.SelectedItem?.ToString();
                    minus_Money_status = minus_Money_statusCB.SelectedItem?.ToString();
                    //empName = employeeCB.SelectedItem?.ToString();

                    if (paymentType == null || minus_Money_status == null)
                    {
                          minus_Money_status = "لا يوجد";
                    }

                    cn.InsertDailyCashier(customerName, productName, productElectronicFee, orderDate, orderProfit, paymentStatus, paymentType, minus_Money_status, empName);
                    cn.FilterDailyCashierByEmployeeName(empName, dailyCashiergrid);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
            
        }

        private void Refresh(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {

                cusName_TB.Text = string.Empty;
                process_TB.Text = string.Empty;
                electronicFee_TB.Text = string.Empty;
                //DateTime orderDate = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                orederProfitTB.Text = string.Empty;
                paymentStatusCB.SelectedItem = null;
                paymentTypeCB.SelectedItem = null;
                minus_Money_statusCB.SelectedItem = null;
                //employeeCB.SelectedItem = null;
                dicountTb.Text = string.Empty;
                cn.FilterDailyCashierByEmployeeName(empName, dailyCashiergrid);
            }
        }

        private void Invoice_Form_KeyDown(object sender, KeyEventArgs e)
        {
            Refresh(e);
        }

        private void Print_TB_Click(object sender, EventArgs e)
        {
            print();
        }

        private void print()
        {
            // Get the selected rows from the DataGridView
            IEnumerable<DataGridViewRow> selectedRows = dailyCashiergrid.SelectedRows.Cast<DataGridViewRow>();

            // Call the PrintInvoice method
            PDFPrinter.PrintInvoice(selectedRows);
        }

        private void dicountTb_GotFocus(object sender, EventArgs e)
        {
            if (dicountTb.Text == "نسبة الخصم(%)")
            {
                dicountTb.Text = "";
                dicountTb.ForeColor = Color.Black; // Change the text color if desired
            }
        }

        private void dicountTb_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dicountTb.Text))
            {
                dicountTb.Text = "نسبة الخصم(%)";
                dicountTb.ForeColor = Color.Gray; // Change the text color if desired
            }
        }

        private void paymentMethodComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (paymentStatusCB.SelectedIndex == 0)
            //{
            //    paymentTypeCB.Enabled = false;
            //    accountNameCB.Enabled = false;
            //}
            //else
            //{
            //    paymentTypeCB.Enabled = true;
            //    accountNameCB.Enabled = true;
            //}
        }

        //private void dailyCashiergrid_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Delete_Row(e);
        //}

        //private void employeeCB_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //   AddingToCB(sender, e);
        //}

        //private void AddingToCB(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        ComboBox comboBox = (ComboBox)sender;
        //        string newItem = comboBox.Text.Trim();

        //        if (!string.IsNullOrEmpty(newItem))
        //        {
        //            // Add the new item to the ComboBox
        //            comboBox.Items.Add(newItem);
        //            comboBox.Text = string.Empty;
        //        }

        //        e.Handled = true; // Prevent the Enter key from being processed further
        //    }
        //}

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainmenuForm mainmenu = new MainmenuForm();
            mainmenu.Show();
            this.Hide();
        }

        private void ADD_Btn_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();   
            signIn.Show();
            this.Hide();
            cn.OpenConnection();
            SqlCommand insertLogCommand = new SqlCommand("InsertSignInLog", cn.connection);
            insertLogCommand.CommandType = CommandType.StoredProcedure;
            insertLogCommand.Parameters.AddWithValue("@UserName", empName + " (out)");
            insertLogCommand.Parameters.AddWithValue("@SignInDateTime", DateTime.Now);
            insertLogCommand.ExecuteNonQuery();
            cn.CloseConnection();
        }
    }
}
