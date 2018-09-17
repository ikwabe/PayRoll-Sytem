using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;

namespace PayRoll_Sytem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            createDirectory();
        }


        //mysql connection string
        public static string computerName = Environment.UserName;
        public static string DBconnection = "server = localhost; user = root; password = '' ; database = payrolldatabase ";
       
        static void createDirectory()
        {
            string rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SEC Payroll";
            string payrollDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SEC PayRoll Records";
            try
            {
                if (!Directory.Exists(rootDirectory)) { Directory.CreateDirectory(rootDirectory); }
                if (!Directory.Exists(rootDirectory + "\\Receipts")) { Directory.CreateDirectory(rootDirectory + "\\Receipts"); }
                if (!Directory.Exists(rootDirectory + "\\Logo")) { Directory.CreateDirectory(rootDirectory + "\\Logo"); }
                if (!Directory.Exists(rootDirectory + "\\Database Backups")) { Directory.CreateDirectory(rootDirectory + "\\Database Backups"); }

                //directory for payrolls
                if (!Directory.Exists(payrollDirectory)) { Directory.CreateDirectory(payrollDirectory); }

                if(!File.Exists("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Logo/Church_logo.png"))
                {
                    Bitmap img = new Bitmap(Properties.Resources._Church_logo);
                    img.Save("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Logo/Church_logo.png");
                }
            }
            catch
            {

            }


        }

        private void checkUser()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadUser = "select userCategory from users where UID = '" + Login.UID + "'";
          
            MySqlCommand com = new MySqlCommand(loadUser, con);

            MySqlDataAdapter da;

            DataTable tab = new DataTable();

            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(tab);
                da.Dispose();

               
                if(tab.Rows[0][0].ToString() == "ADMINISTRATOR")
                {
                    //label2.Visible = true;
                    //adiminBtn.Visible = true;

                    ChangePasswordBtn.Visible = false;
                    label10.Visible = false;
                }
                else
                {
                    //possitioning buttons and labels for normal user
                    pay_RollBtn.Location = new Point(293, 201);
                    pay_RollBtn.BringToFront();
                    employeeButn.Visible = false;

                    label8.Location = new Point(302, 330);
                    label8.BringToFront();
                    label3.Visible = false;

                    receiptsBtn.Location = new Point(479, 201);
                    receiptsBtn.BringToFront();
                    allowanceAndDeductionBtn.Visible = false;

                    label9.Location = new Point(498, 330);
                    label9.BringToFront();
                    label4.Visible = false;

                    departimentBn.Visible = false;
                    label7.Visible = false;

                    label2.Visible = false;
                    adiminBtn.Visible = false;
                    //ChangePasswordBtn.Visible = true;
                    //label10.Visible = true;
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void adiminBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AdminForm adm = new AdminForm();
                adm.ShowDialog();
            }
            
        }

        private void employeeButn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                EmployeeRegForm emp = new EmployeeRegForm();
                emp.ShowDialog();
            }
        }

        private void allowanceAndDeductionBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AllowanceAndDeductionForm allD = new AllowanceAndDeductionForm();
                allD.ShowDialog();
            }
        }

        private void empAllowanceAndDeductionbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                EmployeeAllawanceAndDeductionForm emp = new EmployeeAllawanceAndDeductionForm();
                emp.ShowDialog();
            }
        }

        private void departimentBn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                departmentForm dept = new departmentForm();
                dept.ShowDialog();
            }
        }

        private void pay_RollBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PayRollForm payrol = new PayRollForm();
                payrol.ShowDialog();
            }
        }

        private void receiptsBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReceiptForm rcp = new ReceiptForm();
                rcp.ShowDialog();
            }
        }

        private void UpdateLogout(string USID)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadUser = "update users set loginstatus = 'logout' where UID = '" + USID + "'";

            MySqlCommand com = new MySqlCommand(loadUser, con);

            MySqlDataReader rd;
            try
            {
                con.Open();
                rd = com.ExecuteReader();
                rd.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                UpdateLogout(Login.UID);
                Login.RecordUserActivity("Logout");
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            checkUser();
            DataBaseBackUp();
        }

        private void ChangePasswordBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ChangePassword change = new ChangePassword();
                change.ShowDialog();
            }
        }


        //Database backup
        private void DataBaseBackUp()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            MySqlCommand com = new MySqlCommand();
            MySqlBackup bckp;
                    
            com.Connection = con;

            con.Open();

            if (File.Exists("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Database Backups/Payroll_backup.sql"))
            {
                bckp =  new MySqlBackup(com);
                File.Delete("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Database Backups/Payroll_backup.sql");
                bckp.ExportToFile("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Database Backups/Payroll_backup.sql");
            }
            else
            {
                bckp = new MySqlBackup(com);
                bckp.ExportToFile("C:/Users/" + Home.computerName + "/AppData/Roaming/SEC Payroll/Database Backups/Payroll_backup.sql");
            }     
                
            con.Close();
        }

    }
}
