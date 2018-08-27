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

namespace PayRoll_Sytem
{
    public partial class editAllowanceTb : UserControl
    {

        public static editAllowanceTb _instance;
        public static editAllowanceTb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new editAllowanceTb();
                return _instance;
            }
        }
        public editAllowanceTb()
        {
            InitializeComponent();
        }

        //a function to load the registered allowance

        private void LoadAllowance()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadAllowance = "select allowanceName 'Allowance Name' from allowance";
            MySqlCommand com = new MySqlCommand(loadAllowance, con);
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

        Timer loadAllTimer;

        //a function for the time
        private void loadAllTimer_Tick(object sender, EventArgs e)
        {
            loadAllTimer.Stop();
            LoadAllowance();
        }

        private void editAllowanceTb_Load(object sender, EventArgs e)
        {
            //starting the timer for loading the registered allowance
            loadAllTimer = new Timer();
            loadAllTimer.Interval = 100;
            loadAllTimer.Tick += new EventHandler(loadAllTimer_Tick);
            loadAllTimer.Start();
        }

        private static string allowanceNumber =  null;
        private static string allName = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string allowanceName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    allowanceName = selectedIndex.Cells[0].Value.ToString();
                    allName = selectedIndex.Cells[0].Value.ToString();
                    editedAllowanceTxt.Text = selectedIndex.Cells[0].Value.ToString();

                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadAllowance = "select allowanceID from allowance where allowanceName = '"+allowanceName+"'";
                    MySqlCommand com = new MySqlCommand(loadAllowance, con);
                    MySqlDataAdapter da;
                    DataTable table = new DataTable();

                    try
                    {
                        con.Open();
                        da = new MySqlDataAdapter(com);
                        da.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            allowanceNumber = table.Rows[0][0].ToString();
                        }
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    con.Close();

                }
                catch 
                {
                    MessageBox.Show("Error occured during selection.");
                }
                
            }
        }

        //a function to update the allowance name
        private void updateAllowanceBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            if(allowanceNumber != null)
            {
                string updateAllowance = "update allowance set allowanceName = '" + editedAllowanceTxt.Text.ToUpper() + "' where allowanceID = '" + allowanceNumber + "'";
                MySqlCommand com = new MySqlCommand(updateAllowance, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();
                    Login.RecordUserActivity("Changeg Allowance Name From " + allName + " to " + editedAllowanceTxt.Text.ToUpper());
                    loadAllTimer.Start();
                    allowanceNumber = null;
                    editedAllowanceTxt.Text = "";
                    MessageBox.Show("Allowance updated");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Allowance from the list");
            }
            
        }

        private void deleteAllowanceBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if (allowanceNumber != null)
            {


                string deleteAllowance = "delete from allowance where allowanceID = '" + allowanceNumber + "'";
                MySqlCommand com = new MySqlCommand(deleteAllowance, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Deleted " + allName + " Allowance from the system");

                    loadAllTimer.Start();
                    allowanceNumber = null;
                    editedAllowanceTxt.Text = "";
                    MessageBox.Show("Allowance deleted");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Allowance from the list");
            }
        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select allowanceName 'Allowance Name' from allowance where allowanceName like '" + searchText.Text + "%'";
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadAllTimer.Start();
        }
    }
}
