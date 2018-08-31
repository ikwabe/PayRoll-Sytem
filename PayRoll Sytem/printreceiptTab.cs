using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace PayRoll_Sytem
{
    public partial class printreceiptTab : UserControl
    {
        public static printreceiptTab _instance;
        public static printreceiptTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new printreceiptTab();
                return _instance;
            }
        }
        public printreceiptTab()
        {
            InitializeComponent();
        }

       
        private void checkEmpReceiptBtn_Click(object sender, EventArgs e)
        {
            LoadSlip();


        }

       

        // a function to load employee names
        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select CONCAT(fname,' ',mname, ' ',lname) 'Employee Name' from employee";
            MySqlCommand com = new MySqlCommand(loadEmpNames, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                if (table.Rows.Count > 0)
                {
                    searchResultDataGrid.DataSource = table;
                }
                else
                {
                    searchResultDataGrid.DataSource = null;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private static string empID = null;
        private static string empCode = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string EmployeeFullName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();


                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadEmpDetails = "select * from employee where CONCAT(fname,' ',mname, ' ',lname) = '" + EmployeeFullName + "'";
                    MySqlCommand com = new MySqlCommand(loadEmpDetails, con);
                    MySqlDataAdapter da;
                    DataTable table = new DataTable();

                    try
                    {
                        con.Open();
                        da = new MySqlDataAdapter(com);
                        da.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            empID = table.Rows[0][0].ToString();
                            employeeNameLabel.Text = EmployeeFullName;
                            empCode = table.Rows[0][4].ToString();

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();

                }
                catch
                {
                    MessageBox.Show("Error on EmpId or Empcode.");
                }

            }
            else
            {
                MessageBox.Show("Uncheck the Allocation for All Staffs to select the name.");
            }
        }

        //the function to load the slip details for the employee
        private void LoadSlip()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if (empCode != null && employeeNameLabel.Text !="")
            {
                string getSlipDetails = "select * from payroll where empCode = '" + empCode + "' and dateGenerated = '" + payRollDate.Text + "'";

                MySqlCommand com = new MySqlCommand(getSlipDetails, con);

                MySqlDataAdapter da;

                DataTable table = new DataTable();
                try
                {
                    con.Open();

                    da = new MySqlDataAdapter(com);
                    da.Fill(table);
                    da.Dispose();

                    if(table.Rows.Count > 0)
                    {
                        string getYear = "select dateRegistered from employee where empCode = '" + table.Rows[0][3].ToString() + "' ";

                        MySqlCommand com2 = new MySqlCommand(getYear, con);

                        DataTable tab = new DataTable();

                        da = new MySqlDataAdapter(com2);
                        da.Fill(tab);da.Dispose();


                        int yearOfService = int.Parse(DateTime.Now.ToShortDateString().Substring(6)) - int.Parse(tab.Rows[0][0].ToString().Substring(6));
                     
                        salarySlip.PreapareSalarySlip(table.Rows[0][2].ToString(),
                                            table.Rows[0][3].ToString(),
                                            table.Rows[0][5].ToString(),
                                            table.Rows[0][37].ToString(),
                                            table.Rows[0][7].ToString(),
                                            string.Format("{0:n}", table.Rows[0][6]),
                                            yearOfService.ToString(),
                                            DateTime.Now.ToShortDateString(),
                                            string.Format("{0:n}", table.Rows[0][10]),
                                            string.Format("{0:n}", table.Rows[0][11]),
                                            string.Format("{0:n}", table.Rows[0][12]),
                                            string.Format("{0:n}", table.Rows[0][13]),
                                            string.Format("{0:n}", table.Rows[0][14]),
                                            string.Format("{0:n}", table.Rows[0][15]),
                                            string.Format("{0:n}", table.Rows[0][16]),
                                            string.Format("{0:n}", table.Rows[0][17]),
                                            string.Format("{0:n}", table.Rows[0][18]),
                                            string.Format("{0:n}", table.Rows[0][20]),
                                            string.Format("{0:n}", table.Rows[0][19]),
                                            string.Format("{0:n}", table.Rows[0][21]),
                                            string.Format("{0:n}", table.Rows[0][22]),
                                            string.Format("{0:n}", table.Rows[0][23]),
                                            string.Format("{0:n}", table.Rows[0][24]),
                                            string.Format("{0:n}", table.Rows[0][25]),
                                            string.Format("{0:n}", table.Rows[0][26]),
                                            string.Format("{0:n}", table.Rows[0][27]),
                                            string.Format("{0:n}", table.Rows[0][30]),
                                            string.Format("{0:n}", table.Rows[0][29]),
                                            string.Format("{0:n}", table.Rows[0][28]),
                                            string.Format("{0:n}", table.Rows[0][31]),
                                            string.Format("{0:n}", table.Rows[0][32]),
                                            string.Format("{0:n}", table.Rows[0][33]),
                                            string.Format("{0:n}", table.Rows[0][39]),
                                            string.Format("{0:n}", table.Rows[0][34]),
                                            string.Format("{0:n}", table.Rows[0][35]),
                                            string.Format("{0:n}", table.Rows[0][36]));

                        receiptPdf.src = "C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf";

                        Login.RecordUserActivity("Viewed or (probably) Printed the salary slip for " + table.Rows[0][2].ToString() + " of " + table.Rows[0][3].ToString() + " as Employee ID");

                    }
                    else
                    {
                        MessageBox.Show("Sorry, this Employee is not pressent in this payroll Month. Please check for another Month.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the name of an employee to view the Salary Slip");
            }
        }

       
        private void printreceiptTab_Load(object sender, EventArgs e)
        {

            LoadEmployee();
            payRollDate.CustomFormat = "MMMM yyyy";

        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select CONCAT(fname,' ',mname, ' ',lname) 'Employee Name' from employee where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%'";
            MySqlCommand com = new MySqlCommand(search, con);


            DataTable table = new DataTable();
            MySqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                table.Load(reader);
                reader.Close();
                searchResultDataGrid.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
