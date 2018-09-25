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
    public partial class ViewActivites : Form
    {
        public ViewActivites()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void viewAllActivitiesBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getActivites = "select concat(fname,' ',mname,' ',lname) Username, activityPerformed 'Activity Performed',datePerformed 'Date Performed' from users join recordlogs on users.uid = recordlogs.userID";

            MySqlCommand CheckActivity = new MySqlCommand(getActivites, con);

            DataTable tab = new DataTable();
            MySqlDataAdapter da;
            try
            {
                da = new MySqlDataAdapter(CheckActivity);
                da.Fill(tab);
                da.Dispose();

                activityDataGrid.DataSource = tab;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewActivityBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getActivites = "select concat(fname,' ',mname,' ',lname) Username, activityPerformed 'Activity Performed',datePerformed 'Date Performed' from users join recordlogs on users.uid = recordlogs.userID where datePerformed like '"+activityDate.Text+"%' ";

            MySqlCommand CheckActivity = new MySqlCommand(getActivites, con);

            DataTable tab = new DataTable();
            MySqlDataAdapter da;
            try
            {
                da = new MySqlDataAdapter(CheckActivity);
                da.Fill(tab);
                da.Dispose();
                if(tab.Rows.Count > 0)
                {
                    activityDataGrid.DataSource = tab;
                }
                else
                {

                    activityDataGrid.DataSource = tab;
                    MessageBox.Show("No Record(s) Found for this date.");

                }
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
