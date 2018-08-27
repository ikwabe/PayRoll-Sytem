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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }


        private void UpdateLogin(string USID)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadUser = "update users set loginstatus = 'login' where UID = '"+USID+"'";

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

    
        public static string UID = null;
        private void login()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
            }
            else
            {
                string loadUser = "select * from users where username = '" + username.Text + "' and password = '" + GetMD5Hash(password.Text) + "'";

                string loadUserStatus = "select * from users where username = '" + username.Text + "' and password = '" + GetMD5Hash(password.Text) + "' and loginstatus = 'login'";

                MySqlCommand com1 = new MySqlCommand(loadUserStatus, con);

                MySqlCommand com = new MySqlCommand(loadUser, con);

                MySqlDataAdapter da;

                DataTable tab = new DataTable();
                try
                {
                    con.Open();

                    da = new MySqlDataAdapter(com1);
                    da.Fill(tab);
                    da.Dispose();

                    if(tab.Rows.Count > 0)
                    {
                        UID = tab.Rows[0][0].ToString();
                        this.Hide();
                        VerifyLogin very = new VerifyLogin();
                        very.ShowDialog();
                        
                    }
                    else
                    {
                        da = new MySqlDataAdapter(com);
                        da.Fill(tab);
                        da.Dispose();

                        if (tab.Rows.Count > 0)
                        {
                            UID = tab.Rows[0][0].ToString();
                            RecordUserActivity("Login");
                            UpdateLogin(UID);
                            Home home = new Home();
                            home.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password");
                        }
                    }

                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }


        //function to catch up all activites done by user

        public static void RecordUserActivity(string activity)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string catchActivity = "insert into recordlogs(userID,activityPerformed,datePerformed) values ('" + UID + "','" + activity.ToUpper() + "','" + DateTime.Now + "')";

            MySqlCommand com = new MySqlCommand(catchActivity, con);

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


        //Function to Encrypt the Password
        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }


    }
}
