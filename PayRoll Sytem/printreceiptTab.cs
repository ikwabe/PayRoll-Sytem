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
using System.Net.Mail;


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

       
        private bool checkReceipt = false;
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
        private static string email = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string EmployeeFullName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;
                checkReceipt = false;
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
                            email = table.Rows[0][10].ToString();
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


            
                if (empCode != null && employeeNameLabel.Text != "")
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

                        if (table.Rows.Count > 0)
                        {
                            checkReceipt = true;
                            string getYear = "select dateRegistered from employee where empCode = '" + table.Rows[0][3].ToString() + "' ";

                            MySqlCommand com2 = new MySqlCommand(getYear, con);

                            DataTable tab = new DataTable();

                            da = new MySqlDataAdapter(com2);
                            da.Fill(tab); da.Dispose();

                        int yearOfService;

                        if (tab.Rows[0][0].ToString().Substring(4, 1) == "/")
                            yearOfService = DateTime.Now.Year - int.Parse(tab.Rows[0][0].ToString().Substring(0,4));
                        else
                            yearOfService = DateTime.Now.Year - int.Parse(tab.Rows[0][0].ToString().Substring(6));


                        foreach (var process in System.Diagnostics.Process.GetProcesses(Environment.MachineName))
                        {
                            if (process.MainWindowTitle.Contains("receipt.pdf"))
                            {
                                process.Kill();
                                break;
                            }
                        }

                        salarySlip.PreapareSalarySlip(table.Rows[0][2].ToString(),
                                              table.Rows[0][3].ToString(),
                                              table.Rows[0][5].ToString(),
                                              table.Rows[0][37].ToString(),
                                              table.Rows[0][7].ToString(),
                                              string.Format("{0:n}", table.Rows[0][6]),
                                              yearOfService.ToString(),
                                              payRollDate.Text,
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
                                              string.Format("{0:n}", table.Rows[0][36])) ;

                        messagelabel.Text = "Please Wait, the receipt will open in another application. To send the slip through email, press 'Send Email' button.";

                        System.Diagnostics.Process.Start("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf");

                        // messagelabel.Text = "The slip has been created press 'Send Email' button to send it through email.";
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

        public static bool swich = false;
        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            if(checkReceipt == true)
            {
                swich = true;
                sendReceiptTab.swich = false;
                MessageTab msg = new MessageTab();
                msg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Check the recipt for an employee first.");
            }
           

        }

        private void sendEmail(string email, string message)
        {
            

            using (MailMessage mail = new MailMessage("adventistsec@gmail.com", email, "TESTING THE SALARY SLIP EMAIL SENDER", message))
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            using (Attachment file = new Attachment("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf"))
            {

                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("adventistsec@gmail.com", "secadventist01");
                client.EnableSsl = true;

                file.Name = "Salary Slip for " + payRollDate.Text + ".pdf";
                mail.Attachments.Add(file);
                try
                {
                    client.Send(mail);
                    Login.RecordUserActivity("Sent the Salary Slip to " + email);
                    
                    MessageBox.Show("Email Sent");
                    
                }
                catch
                {
                    MessageBox.Show("Email Not Sent");
                }
            }


        }
        public static bool check = false;

        public static string message = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(check == true && email != null)
            {

                check = false;
                Cursor = Cursors.WaitCursor;
                sendEmail(email, message);
                Cursor = Cursors.Arrow;
            }

            if(check == true && email == null)
            {
                check = false;
                MessageBox.Show("Email not found.");
            }
            
        }
     
    }
}
