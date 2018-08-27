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
    public partial class addDeductionTab : UserControl
    {
        public static addDeductionTab _instance;
        public static addDeductionTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addDeductionTab();
                return _instance;
            }
        }
        public addDeductionTab()
        {
            InitializeComponent();
        }

        //a function to load the registered deduction

        private void LoadDeduction()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadDeduction = "select DeductionID 'Deduction Number', DeductionName 'Deduction Name' from Deduction";

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
        private void addDeductionBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

           

            if (!string.IsNullOrWhiteSpace(newDeductionTxt.Text))
            {
                string registerNewDeduction = "insert into deduction(deductionName) values('" + newDeductionTxt.Text.ToUpper() + "')";

                MySqlCommand com = new MySqlCommand(registerNewDeduction, con);

                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //register the new Deductiom
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Registered " + newDeductionTxt.Text.ToUpper() + " Deduction");

                    loadAllTimer.Start();
                    newDeductionTxt.Text = "";
                   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Write the name of the new Deduction in the Textbox.");
            }
        }
        Timer loadAllTimer;
        private void addDeductionTab_Load(object sender, EventArgs e)
        {
            //starting the timer for loading the registered Deduction
            loadAllTimer = new Timer();
            loadAllTimer.Interval = 100;
            loadAllTimer.Tick += new EventHandler(loadAllTimer_Tick);
            loadAllTimer.Start();
        }

        //a function for the time
        private void loadAllTimer_Tick(object sender, EventArgs e)
        {
            loadAllTimer.Stop();
            LoadDeduction();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadAllTimer.Start();
        }
    }
}
