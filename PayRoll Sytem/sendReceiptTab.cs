﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Web;
using System.Threading;
using System.IO;


namespace PayRoll_Sytem
{
    public partial class sendReceiptTab : UserControl
    {

        public static sendReceiptTab _instance;
        public static sendReceiptTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new sendReceiptTab();
                return _instance;
            }
        }
        public sendReceiptTab()
        {
            InitializeComponent();
        }

       
        private void sendReceiptTab_Load(object sender, EventArgs e)
        {
            receiptDate.CustomFormat = "MMMM yyyy";

        }

        private void getGeneratedPayRoll()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadPayRoll = "select empFullName 'Employee Name', email 'Employee E-mail' from payroll where dateGenerated = '" + receiptDate.Text + "'";

            MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

            MySqlDataAdapter da;

            DataTable payRollTable = new DataTable();

            try
            {

                da = new MySqlDataAdapter(payroll);
                da.Fill(payRollTable);
                da.Dispose();
                if (payRollTable.Rows.Count > 0)
                {
                    payRollDataGrid.DataSource = payRollTable;

                }
                else
                {
                    payRollDataGrid.DataSource = null;
                    MessageBox.Show("The Receipt is not Found.");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        Label sendInfo;
        private void sendEmail(string email,string message)
        {
            sendInfo = new Label();
            sendInfo.Font = new Font("Calibri", 11);
           
            sendInfo.AutoSize = true;

            using (MailMessage mail = new MailMessage("adventistsec@gmail.com", email, "TESTING THE SALARY SLIP EMAIL SENDER", message))
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            using (Attachment file = new Attachment("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf"))
            {

                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("adventistsec@gmail.com", "secadventist01");
                client.EnableSsl = true;

                file.Name = "Salary Slip for " + receiptDate.Text + ".pdf";
                mail.Attachments.Add(file);
                try
                {
                    client.Send(mail);
                    Login.RecordUserActivity("Sent the Salary Slip to " + email);

                    sendInfo.ForeColor = Color.LightGreen;
                    sendInfo.Text = "Email sent to: " + email + "     (" + DateTime.Now.ToLongTimeString() + ")";
                    information.Controls.Add(sendInfo);
                }
                catch
                {
                    sendInfo.ForeColor = Color.Orange;
                    sendInfo.Text = "Email NOT sent to: " + email + "     (" + DateTime.Now.ToLongTimeString() + ")";
                    information.Controls.Add(sendInfo);
                }
            }


        }

        Label done;
        int yearOfService;


        private void sendEmail()
        {
            //A label for done 
            done = new Label();
            done.Font = new Font("Calibri", 12, FontStyle.Bold);
            done.ForeColor = Color.LimeGreen;
            done.AutoSize = true;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string getSlipDetails = "select * from payroll where dateGenerated = '" + receiptDate.Text + "'";

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
                    Cursor = Cursors.WaitCursor;


                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string getYear = "select dateRegistered from employee where empCode = '" + table.Rows[i][3].ToString() + "' AND STATE = 'ACTIVE'";

                        MySqlCommand com2 = new MySqlCommand(getYear, con);

                        DataTable tab = new DataTable();

                        da = new MySqlDataAdapter(com2);
                        da.Fill(tab);
                        da.Dispose();

                        for (int j = 0; j < tab.Rows.Count; j++)
                        {

                            if (tab.Rows[j][0].ToString().Substring(4, 1) == "/")
                                yearOfService = DateTime.Now.Year - int.Parse(tab.Rows[j][0].ToString().Substring(0, 4));
                            else
                                yearOfService = DateTime.Now.Year - int.Parse(tab.Rows[j][0].ToString().Substring(6));

                        }
                        salarySlip.PreapareSalarySlip(table.Rows[i][2].ToString(),
                                            table.Rows[i][3].ToString(),
                                            table.Rows[i][5].ToString(),
                                            table.Rows[i][37].ToString(),
                                            table.Rows[i][7].ToString(),
                                            string.Format("{0:n}", table.Rows[i][6]),
                                            yearOfService.ToString(),
                                            receiptDate.Text,
                                            string.Format("{0:n}", table.Rows[i][10]),
                                            string.Format("{0:n}", table.Rows[i][11]),
                                            string.Format("{0:n}", table.Rows[i][12]),
                                            string.Format("{0:n}", table.Rows[i][13]),
                                            string.Format("{0:n}", table.Rows[i][14]),
                                            string.Format("{0:n}", table.Rows[i][15]),
                                            string.Format("{0:n}", table.Rows[i][16]),
                                            string.Format("{0:n}", table.Rows[i][17]),
                                            string.Format("{0:n}", table.Rows[i][18]),
                                            string.Format("{0:n}", table.Rows[i][20]),
                                            string.Format("{0:n}", table.Rows[i][19]),
                                            string.Format("{0:n}", table.Rows[i][21]),
                                            string.Format("{0:n}", table.Rows[i][22]),
                                            string.Format("{0:n}", table.Rows[i][23]),
                                            string.Format("{0:n}", table.Rows[i][24]),
                                            string.Format("{0:n}", table.Rows[i][25]),
                                            string.Format("{0:n}", table.Rows[i][26]),
                                            string.Format("{0:n}", table.Rows[i][27]),
                                            string.Format("{0:n}", table.Rows[i][30]),
                                            string.Format("{0:n}", table.Rows[i][29]),
                                            string.Format("{0:n}", table.Rows[i][28]),
                                            string.Format("{0:n}", table.Rows[i][31]),
                                            string.Format("{0:n}", table.Rows[i][32]),
                                            string.Format("{0:n}", table.Rows[i][33]),
                                            string.Format("{0:n}", table.Rows[i][39]),
                                            string.Format("{0:n}", table.Rows[i][34]),
                                            string.Format("{0:n}", table.Rows[i][35]),
                                            string.Format("{0:n}", table.Rows[i][36]));

                        sendEmail(table.Rows[i][38].ToString(),message);
                    }

                    done.Text = "DONE!    (" + DateTime.Now.ToLongTimeString() + ")";
                    information.Controls.Add(done);
                    label2.Visible = false;
                }
                else
                {
                    label2.Visible = false;
                    MessageBox.Show("Sorry, The Payroll for this Month is not present. Please check for another Month.");
                }
                Cursor = Cursors.Arrow;
            }
            catch (MySqlException ex)
            {
                label2.Visible = false;
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public static bool swich = false;
        private void sendReceiptBtn_Click(object sender, EventArgs e)
        {
            
            label2.Visible = true;
            swich = true;
            printreceiptTab.swich = false;
            MessageTab msg = new MessageTab();
            msg.ShowDialog();

        }

        private void ViewPayRoll_Click(object sender, EventArgs e)
        {
            getGeneratedPayRoll();
        }

       
        public static bool check = false;
        public static string message = null;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check == true)
            {

              check = false;
               
               sendEmail();
            }

        }
    }
}
