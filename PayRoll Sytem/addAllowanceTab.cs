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
    public partial class addAllowanceTab : UserControl
    {
        public static addAllowanceTab _instance;
        public static addAllowanceTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addAllowanceTab();
                return _instance;
            }
        }
        public addAllowanceTab()
        {
            InitializeComponent();
        }



        //a function to load the registered allowance

            private void LoadAllowance()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadAllowance = "select allowanceID 'Allowance Number', allowanceName 'Allowance Name' from allowance";

            MySqlCommand com = new MySqlCommand(loadAllowance, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                if(table.Rows.Count > 0)
                {
                    searchResultDataGrid.DataSource = table;
                }
                else
                {
                    searchResultDataGrid.DataSource = null;
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void addAllowanceBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            

            if(!string.IsNullOrWhiteSpace(newAllowanceTxt.Text))
            {
                string registerNewAllowance = "insert into allowance(allowanceName) values('" + newAllowanceTxt.Text.ToUpper() + "')";

                MySqlCommand com = new MySqlCommand(registerNewAllowance, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //register the new Allowance
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Registered " + newAllowanceTxt.Text.ToUpper() + " Allowance");

                    loadAllTimer.Start();
                    newAllowanceTxt.Text = "";
                   
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Write the name of the new Allowance in the Textbox.");
            }
        }

        Timer loadAllTimer;
        private void addAllowanceTab_Load(object sender, EventArgs e)
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
            LoadAllowance();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadAllTimer.Start();
        }
    }
}
