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
    public partial class registerDepartmentTab : UserControl
    {

        public static registerDepartmentTab _instance;
        public static registerDepartmentTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new registerDepartmentTab();
                return _instance;
            }
        }
        public registerDepartmentTab()
        {
            InitializeComponent();
        }


        private void LoadDepatments()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loaddepartment = "select deptName 'Department Name' from department";

            MySqlCommand com = new MySqlCommand(loaddepartment, con);
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

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

           
            if (!string.IsNullOrWhiteSpace(newDepartmentTxt.Text) && !string.IsNullOrWhiteSpace(deptCode.Text))
            {
                string registerNewDepartment = "insert into department(deptCode,deptName) values('SEC-"+deptCode.Text.ToUpper()+"','" + newDepartmentTxt.Text.ToUpper() + "')";

                MySqlCommand com = new MySqlCommand(registerNewDepartment, con);

                MySqlDataReader rd;

                try
                {
                    con.Open();

                    //register the new Department
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Registerd " + newDepartmentTxt.Text.ToUpper() + " Department");

                    loadAllTimer.Start();
                    newDepartmentTxt.Text = "";

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Write the name of the new Department and its ID on the textboxes");
            }
        }

        Timer loadAllTimer;
        private void registerDepartmentTab_Load(object sender, EventArgs e)
        {
            //starting the timer for loading the registered allowance
            loadAllTimer = new Timer();
            loadAllTimer.Interval = 100;
            loadAllTimer.Tick += new EventHandler(loadAllTimer_Tick);
            loadAllTimer.Start();
        }

        //a function for the time
        private void loadAllTimer_Tick(object sender, EventArgs e)
        {
            loadAllTimer.Stop();
            LoadDepatments();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadAllTimer.Start();
        }
    }
}
