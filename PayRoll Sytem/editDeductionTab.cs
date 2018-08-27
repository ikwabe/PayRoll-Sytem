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
    public partial class editDeductionTab : UserControl
    {

        public static editDeductionTab _instance;
        public static editDeductionTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new editDeductionTab();
                return _instance;
            }
        }
        public editDeductionTab()
        {
            InitializeComponent();
        }


        private void LoadDeduction()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadDeduction = "select DeductionName 'Deduction Name' from Deduction";

            MySqlCommand com = new MySqlCommand(loadDeduction, con);
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
            LoadDeduction();
        }

        private void editDeductionTab_Load(object sender, EventArgs e)
        {
            //starting the timer for loading the registered Deduction
            loadAllTimer = new Timer();
            loadAllTimer.Interval = 100;
            loadAllTimer.Tick += new EventHandler(loadAllTimer_Tick);
            loadAllTimer.Start();
        }

        // afunction to catch the index number of the selected deduction
        private static string deductionNumber = null;
        private static string dedName = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string deductionName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    deductionName = selectedIndex.Cells[0].Value.ToString();
                    dedName = selectedIndex.Cells[0].Value.ToString();
                    editedDeductionTxt.Text = selectedIndex.Cells[0].Value.ToString();

                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadDeduction = "select deductionID from deduction where deductionName = '" + deductionName + "'";
                    MySqlCommand com = new MySqlCommand(loadDeduction, con);
                    MySqlDataAdapter da;
                    DataTable table = new DataTable();

                    try
                    {
                        con.Open();
                        da = new MySqlDataAdapter(com);
                        da.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            deductionNumber = table.Rows[0][0].ToString();
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
                    MessageBox.Show("Error occured during selection.");
                }

            }
        }

        private void deletDeductionBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if (deductionNumber != null)
            {


                string deleteAllowance = "delete from deduction where deductionID = '" + deductionNumber + "'";
                MySqlCommand com = new MySqlCommand(deleteAllowance, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Deleted" + dedName + " deduction from the system");

                    loadAllTimer.Start();
                    deductionNumber = null;
                    editedDeductionTxt.Text = "";
                    MessageBox.Show("Deduction deleted");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Deduction from the list");
            }
        
    }

        private void updateDeductionBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            if (deductionNumber != null)
            {
                string updateDeduction = "update deduction set deductionName = '" + editedDeductionTxt.Text.ToUpper() + "' where deductionID = '" + deductionNumber + "'";
                MySqlCommand com = new MySqlCommand(updateDeduction, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed " + dedName + " deduction to " + editedDeductionTxt.Text.ToUpper());

                    loadAllTimer.Start();
                    deductionNumber = null;
                    editedDeductionTxt.Text = "";
                    MessageBox.Show("Deduction updated");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Deduction from the list");
            }

        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select deductionName 'Deduction Name' from deduction where deductionName like '" + searchText.Text + "%'";
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
