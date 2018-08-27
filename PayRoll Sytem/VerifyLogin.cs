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

namespace PayRoll_Sytem
{
    public partial class VerifyLogin : Form
    {
        public VerifyLogin()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Login.RecordUserActivity("Logout");
                this.Close();
                Login log = new Login();
                log.Show();
            }
        }

        private void VerifyLogin_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getName = "select CONCAT(fname,' ', mname,' ', lname) from users where UID = '" + Login.UID + "' ";

            MySqlCommand com = new MySqlCommand(getName, con);

            MySqlDataAdapter da;

            DataTable tab = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(tab);
                da.Dispose();

                employeeNameLabel.Text = tab.Rows[0][0].ToString();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if (password.Text == "")
            {
                MessageBox.Show("Please enter password.");
            }
            else
            {
                string loadUser = "select * from users where UID = '" + Login.UID + "' and password = '" + Login.GetMD5Hash(password.Text) + "'";

                MySqlCommand com = new MySqlCommand(loadUser, con);

                MySqlDataAdapter da;

                DataTable tab = new DataTable();
                try
                {
                    con.Open();             
                        da = new MySqlDataAdapter(com);
                        da.Fill(tab);
                        da.Dispose();

                        if (tab.Rows.Count > 0)
                        {
                           
                            Login.RecordUserActivity("Login");

                        this.Close();
                        Home home = new Home();
                        home.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
    }
}
