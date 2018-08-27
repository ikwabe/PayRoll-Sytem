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
    public partial class updateUserTab : UserControl
    {
        //an instance to call the control to the parent form(AdminForm)
        public static updateUserTab _instance;
        public static updateUserTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new updateUserTab();
                return _instance;
            }
        }
        public updateUserTab()
        {
            InitializeComponent();
        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select CONCAT(fname,' ', mname,' ', lname) 'User Name' from users where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%'";
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

        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select CONCAT(fname,' ', mname,' ', lname) 'User Name' from users";
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
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void updateUserTab_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string EmployeeFullName;
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    int index = e.RowIndex;

                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadEmpDetails = "select * from users where CONCAT(fname,' ', mname,' ', lname) = '" + EmployeeFullName + "'";
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
                            empID = table.Rows[0][0].ToString();
                            firstNameTxt.Text = table.Rows[0][1].ToString();
                            middleNameTxt.Text = table.Rows[0][2].ToString();
                            lastNameTxt.Text = table.Rows[0][3].ToString();

                            userNameTxt.Text = table.Rows[0][4].ToString();
                            passwordTxt.Text = table.Rows[0][5].ToString();

                            try
                            {
                                switch (table.Rows[0][8].ToString())
                                {
                                    case "TREASURER":
                                        userCategory.selectedIndex = 0;
                                        break;
                                    case "ADMINISTRATOR":
                                        userCategory.selectedIndex = 1;
                                        break;
                                    case "ACCOUNTANT":
                                        userCategory.selectedIndex = 2;
                                        break;
                                    default:
                                        MessageBox.Show("Sorry, there is an error in User Category..!");
                                        break;
                                }
                            }
                            catch
                            {

                            }
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
        string empID = null;
        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text == ""
               || lastNameTxt.Text == ""
               || userNameTxt.Text == ""
               || passwordTxt.Text == ""
               )
            {
                MessageBox.Show("Please, fill all the fields..!");
            }
            else if (userCategory.selectedIndex == -1)
            {
                MessageBox.Show("Please, select category for a user.");
            }
            else if (empID == null)
            {
                MessageBox.Show("Please, select a User for updating.!");
            }
            else
            {

             
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

              
                string updateUser = "update users set fname = '" + firstNameTxt.Text.ToUpper() + "', mname = '" + middleNameTxt.Text.ToUpper() +
                    "', lname = '" + lastNameTxt.Text.ToUpper() +
                    "', username = '" + userNameTxt.Text.ToLower() +
                    "', password = '" + Login.GetMD5Hash(passwordTxt.Text) +
                    "', userCategory = '" + userCategory.selectedValue.ToString().ToUpper() +
                    "' where UID = '" + empID + "'";

                MySqlCommand com = new MySqlCommand(updateUser, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //update an employee
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed user information for user Id " + empID);
                    LoadEmployee();
                    empID = null;
                    firstNameTxt.Text = "";
                    middleNameTxt.Text = "";
                    lastNameTxt.Text = "";
                    userNameTxt.Text = "";
                    passwordTxt.Text = "";
                    MessageBox.Show("User Updated Successful");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string delete = " delete from users where UID = '" + empID + "'";

            MySqlCommand com = new MySqlCommand(delete, con);
            MySqlDataReader rd;
            try
            {
                con.Open();

                if(empID != null)
                {
                    if (MessageBox.Show("Are sure you want to delete this user?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //delete an employee
                        rd = com.ExecuteReader();
                        rd.Close();

                        Login.RecordUserActivity("Deleted User " + firstNameTxt.Text + " " + middleNameTxt.Text + " " + lastNameTxt.Text + " from the system");
                        LoadEmployee();
                        empID = null;
                        firstNameTxt.Text = "";
                        middleNameTxt.Text = "";
                        lastNameTxt.Text = "";
                        userNameTxt.Text = "";
                        passwordTxt.Text = "";
                        MessageBox.Show("User Deleted Successful");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select User to delete");
                }
                             

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
