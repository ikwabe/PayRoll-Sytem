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
    public partial class addNewUserTab : UserControl
    {

        //an instance to call this control to the parent form(AdminForm)
        public static addNewUserTab _instance;
        public static addNewUserTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new addNewUserTab();
                return _instance;
            }
        }


        public addNewUserTab()
        {
            InitializeComponent();
        }

        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select CONCAT(fname,' ', mname,' ', lname) 'Employee Name' from employee";
            MySqlCommand com = new MySqlCommand(loadEmpNames, con);
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
        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select CONCAT(fname,' ', mname,' ', lname) 'Employee Name' from employee where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%'";
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

        private void addNewUserTab_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void clearFields()
        {
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            userNameTxt.Text = "";
            passwordTxt.Text = "";
            middleNameTxt.Text = "";
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text == ""
                || lastNameTxt.Text == ""
                || userNameTxt.Text == ""
                || passwordTxt.Text == "")
            {
                MessageBox.Show("Please, select an employee from the list");
            }
            else if(userCategory.selectedIndex == -1)
            {
                MessageBox.Show("Please, select category for a user.");
            }
            else
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

                string value = "values('" + firstNameTxt.Text.ToUpper() + 
                    "','" + middleNameTxt.Text.ToUpper() +
                    "','" + lastNameTxt.Text.ToUpper() +
                    "','" + userNameTxt.Text.ToUpper() +
                    "','" + Login.GetMD5Hash(passwordTxt.Text) +
                    "','" + DateTime.Now +
                    "','" + userCategory.selectedValue.ToUpper()+"')";

                string registerUser = "insert into users(fname,mname,lname,username,password,dateRegistered,userCategory) " + value;

                MySqlCommand com = new MySqlCommand(registerUser, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //registering an employee
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Registered " + firstNameTxt.Text.ToUpper() + " " + middleNameTxt.Text.ToUpper() + " " + lastNameTxt.Text.ToUpper() + " As a new user to the system");

                    MessageBox.Show("User Added Successful");

                    clearFields();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string EmployeeFullName;
            if(e.Button == MouseButtons.Left)
            {
                try
                {
                    int index = e.RowIndex;

                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadEmpDetails = "select * from employee where CONCAT(fname,' ', mname,' ', lname) = '" + EmployeeFullName + "'";
                    MySqlCommand com = new MySqlCommand(loadEmpDetails, con);
                    MySqlDataAdapter da;
                    DataTable table = new DataTable();

                    try
                    {
                        con.Open();
                        da = new MySqlDataAdapter(com);
                        da.Fill(table);

                        if (table.Rows.Count > 0)
                        {

                            firstNameTxt.Text = table.Rows[0][1].ToString();
                            middleNameTxt.Text = table.Rows[0][2].ToString();
                            lastNameTxt.Text = table.Rows[0][3].ToString();

                            userNameTxt.Text = table.Rows[0][4].ToString().ToLower();
                            passwordTxt.Text = table.Rows[0][3].ToString().ToLower();
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
    }
}
