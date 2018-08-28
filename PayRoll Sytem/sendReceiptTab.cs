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
using System.Net.Mail;
using System.Web;

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
        private void sendEmail(string email)
        {
            sendInfo = new Label();
            sendInfo.Font = new Font("Calibri", 11);
           
            sendInfo.AutoSize = true;

            MailMessage mail = new MailMessage("ikwabe04@gmail.com", email, "TESTING THE SALARY SLIP EMAIL SENDER", "Habari Rafiki? Usishitushwe na ujumbe huu, tunajaribu system. Asante.");
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;

            client.Credentials = new System.Net.NetworkCredential("ikwabe04@gmail.com", "mikunjoyamwili");
            client.EnableSsl = true;

            Attachment file = new Attachment("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf");
            file.Name = "Salary Slip for " + DateTime.Now.ToString("MMMM yyyy") + ".pdf";
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
                sendInfo.Text = "Email NOT sent to: " + email + "     ("+DateTime.Now.ToLongTimeString()+")";
                information.Controls.Add(sendInfo);
            }


        }

        private void sendReceiptBtn_Click(object sender, EventArgs e)
        {
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
                    emailSendProgressBar.MaximumValue = table.Rows.Count;
                    emailSendProgressBar.Visible = true;
                    for (int i = 0; i< table.Rows.Count;i++)
                    {
                        emailSendProgressBar.Value = i/4;
                        salarySlip.PreapareSalarySlip(table.Rows[i][2].ToString(),
                                            table.Rows[i][3].ToString(),
                                            table.Rows[i][5].ToString(),
                                            table.Rows[i][37].ToString(),
                                            table.Rows[i][7].ToString(),
                                            table.Rows[i][6].ToString(),
                                            DateTime.Now.ToShortDateString().Substring(6),
                                            DateTime.Now.ToShortDateString(),
                                            table.Rows[i][10].ToString(),
                                            table.Rows[i][11].ToString(),
                                            table.Rows[i][12].ToString(),
                                            table.Rows[i][13].ToString(),
                                            table.Rows[i][14].ToString(),
                                            table.Rows[i][15].ToString(),
                                            table.Rows[i][16].ToString(),
                                            table.Rows[i][17].ToString(),
                                            table.Rows[i][18].ToString(),
                                            table.Rows[i][20].ToString(),
                                            table.Rows[i][19].ToString(),
                                            table.Rows[i][21].ToString(),
                                            table.Rows[i][22].ToString(),
                                            table.Rows[i][23].ToString(),
                                            table.Rows[i][24].ToString(),
                                            table.Rows[i][25].ToString(),
                                            table.Rows[i][26].ToString(),
                                            table.Rows[i][27].ToString(),
                                            table.Rows[i][30].ToString(),
                                            table.Rows[i][29].ToString(),
                                            table.Rows[i][28].ToString(),
                                            table.Rows[i][31].ToString(),
                                            table.Rows[i][32].ToString(),
                                            table.Rows[i][33].ToString(),
                                            table.Rows[i][39].ToString(),
                                            table.Rows[i][34].ToString(),
                                            table.Rows[i][35].ToString(),
                                            table.Rows[i][36].ToString());

                        sendEmail(table.Rows[i][38].ToString());  
                    }
                    emailSendProgressBar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sorry, The Payroll for this Month is not present. Please check for another Month.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void ViewPayRoll_Click(object sender, EventArgs e)
        {
            getGeneratedPayRoll();
        }
    }
}
