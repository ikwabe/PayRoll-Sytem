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
    public partial class editDepartmentTab : UserControl
    {

        public static editDepartmentTab _instance;
        public static editDepartmentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new editDepartmentTab();
                return _instance;
            }
        } 
        public editDepartmentTab()
        {
            InitializeComponent();
        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select deptName 'Department Name' from department where deptName like '" + searchText.Text + "%'";
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

        private static string departmentNumber = null;
        private static string deptName = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string departmentName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    departmentName = selectedIndex.Cells[0].Value.ToString();
                    deptName = selectedIndex.Cells[0].Value.ToString();
                    editedDepartmentTxt.Text = selectedIndex.Cells[0].Value.ToString();

                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadAllowance = "select deptID from department where deptName = '" + departmentName + "'";
                    MySqlCommand com = new MySqlCommand(loadAllowance, con);
                    MySqlDataAdapter da;
                    DataTable table = new DataTable();

                    try
                    {
                        con.Open();
                        da = new MySqlDataAdapter(com);
                        da.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            departmentNumber = table.Rows[0][0].ToString();
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
        private void LoadDepartments()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadDepartment = "select deptName 'Department Name' from department";
            MySqlCommand com = new MySqlCommand(loadDepartment, con);
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
            LoadDepartments();
        }

        private void editDepartmentTab_Load(object sender, EventArgs e)
        {
            //starting the timer for loading the registered allowance
            loadAllTimer = new Timer();
            loadAllTimer.Interval = 100;
            loadAllTimer.Tick += new EventHandler(loadAllTimer_Tick);
            loadAllTimer.Start();
        }

        private void updateDepartmentBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            if (departmentNumber != null)
            {
                string updateDepartment = "update department set deptName = '" + editedDepartmentTxt.Text.ToUpper() + "' where deptID = '" + departmentNumber + "'";
                MySqlCommand com = new MySqlCommand(updateDepartment, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed Department name from " + deptName + " to " + editedDepartmentTxt.Text.ToUpper());

                    loadAllTimer.Start();
                    departmentNumber = null;
                    editedDepartmentTxt.Text = "";
                    MessageBox.Show("Department updated");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Department from the list");
            }
        }

        private void deleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            if (departmentNumber != null)
            {
                string deleteDepartment = "delete from department  where deptID = '" + departmentNumber + "'";
                MySqlCommand com = new MySqlCommand(deleteDepartment, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Deleted the department " + deptName + " from the system");

                    loadAllTimer.Start();

                    departmentNumber = null;
                    editedDepartmentTxt.Text = "";
                    MessageBox.Show("Department deleted Successful!");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select the Department from the list");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadAllTimer.Start();
        }
    }
}
