using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace H2H_App
{
    public class SqlServerConnectionManager
    {
        public SqlConnection connection;

        public SqlConnection Getconnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "Data Source=Noor;Initial Catalog=H2H;Integrated Security=True";
            return Con;
        }

        public void OpenConnection()
        {
            try
            {
                connection = Getconnection();
                connection.Open();
            }
            catch (SqlException ex)
            {
                // Handle the exception according to your application's requirements
                throw ex;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (Getconnection() != null && Getconnection().State == System.Data.ConnectionState.Open)
                {
                    Getconnection().Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle the exception according to your application's requirements
                throw ex;
            }
        }
        // Additional methods for executing queries, transactions, etc. can be added here.
        public void InsertDailyCashier(string customerName, string productName, float productElectronicFee, DateTime orderDate, float orderProfit, string paymentStatus, string paymentType, string minus_Money_status, string empName)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("InsertDailyCashier", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameter values
                command.Parameters.AddWithValue("@CUSTOMER_NAME", customerName);
                command.Parameters.AddWithValue("@PRODUCT_NAME", productName);
                command.Parameters.AddWithValue("@PRODUCT_ELECTRONIC_FEE", productElectronicFee);
                command.Parameters.AddWithValue("@order_date", orderDate);
                command.Parameters.AddWithValue("@order_profit", orderProfit);
                command.Parameters.AddWithValue("@payment_status", paymentStatus);
                command.Parameters.AddWithValue("@payment_type", paymentType);
                command.Parameters.AddWithValue("@emp_Name", empName);
                command.Parameters.AddWithValue("@minus_Money_status", minus_Money_status);

                command.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally { connection.Close(); }
        }

        public DataTable GetDailyCashierData()
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("SelectDailyCashier", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public void DeleteDailyCashier(int orderId)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("DeleteDailyCashier", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameter values
                command.Parameters.AddWithValue("@Order_ID", orderId);

                command.ExecuteNonQuery();

                MessageBox.Show("Data deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateDailyCashier(int orderId, string customerName, string productName, float productElectronicFee, float orderProfit, string paymentStatus, string paymentType, string accountOfficeName, string empName)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("UpdateDailyCashier", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set the parameter values
                command.Parameters.AddWithValue("@ORDER_ID", orderId);
                command.Parameters.AddWithValue("@CUSTOMER_NAME", customerName);
                command.Parameters.AddWithValue("@PRODUCT_NAME", productName);
                command.Parameters.AddWithValue("@PRODUCT_ELECTRONIC_FEE", productElectronicFee);
                command.Parameters.AddWithValue("@order_profit", orderProfit);
                command.Parameters.AddWithValue("@payment_status", paymentStatus);
                command.Parameters.AddWithValue("@payment_type", paymentType);
                command.Parameters.AddWithValue("@account_office_name", accountOfficeName);
                command.Parameters.AddWithValue("@emp_Name", empName);

                command.ExecuteNonQuery();

                MessageBox.Show("Data updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally { connection.Close(); }
        }

        public DataTable GetFilteredDailyCashierData(string paymentStatus, string customerName)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetFilteredDailyCashierData", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
            command.Parameters.AddWithValue("@CustomerName", customerName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        } 
        
        public DataTable GetFilteredDailyCashierPayment(string paymentStatus)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetFilteredDailyCashierPayment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        
        public DataTable GetFilteredDailyCashierCustomer(string customerName)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetFilteredDailyCashierCustomer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CustomerName", customerName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable GetFilteredMonthlyReports(int months, int years)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetFilteredMonthlyReports", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Month", months);
            command.Parameters.AddWithValue("@Year", years);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable GetCustomerAccountsData()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetCustomerAccounts", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public DataTable GetempAccountsData()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("GetEmpAccounts", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public DataTable GetSignInLog()
        {
            DataTable dataTable = new DataTable();
            OpenConnection();
            SqlCommand command = new SqlCommand("SelectSignInLog", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public void InsertEmployee(string empName, string empPhoneNumber, string empEmail, string empType)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("InsertEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.Add("@empName", SqlDbType.NVarChar, 50).Value = empName;
                command.Parameters.Add("@empPhoneNumber", SqlDbType.NVarChar, 15).Value = empPhoneNumber;
                command.Parameters.Add("@empEmail", SqlDbType.NVarChar, 100).Value = empEmail;
                command.Parameters.Add("@empType", SqlDbType.NVarChar, 50).Value = empType;

                command.ExecuteNonQuery();

                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally { connection.Close(); }
        }

        public void PopulateEmployeeNames(System.Windows.Forms.ComboBox employeeCB)
        {
            // Replace "YourConnectionString" with the actual connection string to your SQL Server database
           OpenConnection();
            SqlCommand command = new SqlCommand("GetEmployeeNames", connection);
                
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        // Clear the ComboBox before adding new items
                        employeeCB.Items.Clear();

                        while (reader.Read())
                        {
                            string empName = reader.GetString(0);
                            employeeCB.Items.Add(empName);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions here
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    finally { connection.Close(); }

        }

        public void InsertUserInfo(string userName, string password, string confirmPassword, string empName)
        {
            try
            {
                OpenConnection();

                // Check if the password and confirm password match
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password do not match.");
                    return;
                }

                SqlCommand checkAccountCommand = new SqlCommand("SELECT COUNT(*) FROM userInfo WHERE empID IN (SELECT empID FROM employee WHERE empName = @EmpName)", connection);
                checkAccountCommand.Parameters.AddWithValue("@EmpName", empName);
                int existingAccounts = (int)checkAccountCommand.ExecuteScalar();

                // Check if the user with the provided empName already has an account
                if (existingAccounts > 0)
                {
                    MessageBox.Show("User with the provided empName already has an account.");
                    return;
                }

                SqlCommand command = new SqlCommand("InsertUserInfo", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters to the stored procedure
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = userName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = password;
                command.Parameters.Add("@empName", SqlDbType.NVarChar, 50).Value = empName;

                string insertedEmpName = (string)command.ExecuteScalar();

                // Check if the empName exists or not based on the returned value
                if (insertedEmpName == empName)
                {
                    // Sign up successful, display the empName in the message
                    MessageBox.Show("User info inserted successfully! Employee Name: " + insertedEmpName);
                }
                else
                {
                    // Employee with the provided name does not exist
                    MessageBox.Show("Employee with the provided name does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void SignInlog(string userName, string password)
        {
            try
            {
                OpenConnection();

                // Call the stored procedure to check sign-in credentials and get empType
                SqlCommand command = new SqlCommand("CheckSignInCredentials", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                string empType = command.ExecuteScalar()?.ToString();

                if (empType == "Admin")
                {
                    // Open the main menu form and enable everything
                    MainmenuForm mainMenuForm = new MainmenuForm();
                    mainMenuForm.Show();
                    SignIn signIn = new SignIn();
                    signIn.Hide();
                }
                else if (empType == "Employee")
                {
                    // Open the daily cashier form directly for employees
                    Billing dailyCashierForm = new Billing();
                    dailyCashierForm.SetEmployeeName(userName); // Pass the employee name to the daily cashier form
                    dailyCashierForm.Show();
                    SignIn signIn = new SignIn();
                    signIn.Hide();
                }
                else if (string.IsNullOrEmpty(empType))
                {
                    MessageBox.Show("Invalid username or password! Please try again.");
                }
                else
                {
                    MessageBox.Show("Unknown error occurred. Please contact the system administrator.");
                }

                // Insert sign-in log into the database
                if (!string.IsNullOrEmpty(empType))
                {
                    SqlCommand insertLogCommand = new SqlCommand("InsertSignInLog", connection);
                    insertLogCommand.CommandType = CommandType.StoredProcedure;
                    insertLogCommand.Parameters.AddWithValue("@UserName", userName + " (in)");
                    insertLogCommand.Parameters.AddWithValue("@SignInDateTime", DateTime.Now);
                    insertLogCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void FilterDailyCashierByEmployeeName(string employeeName, DataGridView dataGridView)
        {
            try
            {
                OpenConnection();

                SqlCommand command = new SqlCommand("SelectDailyCashierEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeName", employeeName);

                // Use a data adapter and data table to retrieve the result
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Bind the result to your data grid view or display it as needed
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

