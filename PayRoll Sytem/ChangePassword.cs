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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Oldpassword.Text) || String.IsNullOrWhiteSpace(Newpassword.Text))
            {
                MessageBox.Show("Please fill all the field.");
            }
            else
            {


                if (Oldpassword.Text != Newpassword.Text)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string verify = "select password from users where password = '" + Login.GetMD5Hash(Oldpassword.Text) + "'";

                    string update = "Update users set password = '" + Login.GetMD5Hash(Newpassword.Text) + "' where UID = '" + Login.UID + "'";
                    MySqlCommand com = new MySqlCommand(verify, con);

                    MySqlDataAdapter da;
                    MySqlDataReader rd;
                    DataTable tab = new DataTable();

                    try
                    {
                        con.Open();

                        da = new MySqlDataAdapter(com);
                        da.Fill(tab);
                        da.Dispose();

                        if (tab.Rows.Count > 0)
                        {
                            if (Newpassword.Text == retypePassword.Text)
                            {
                                MySqlCommand com1 = new MySqlCommand(update, con);

                                rd = com1.ExecuteReader();
                                rd.Close();

                                Login.RecordUserActivity("Changed password for userID " + Login.UID + "");
                                MessageBox.Show("Password Changed Successful.");
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("The New password did not match with the Re-type new password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Old Password");
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Old Password can not be the same as New Password");
                }
            }
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                this.Close();
            
        }
    }
}
