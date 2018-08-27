using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;

namespace PayRoll_Sytem
{
    public partial class EmployeeRegForm : Form
    {
        public EmployeeRegForm()
        {
            InitializeComponent();

        }
       

       

        // a function to load employee names
        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select CONCAT(fname,' ',mname, ' ',lname) 'Employee Name' from employee";
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

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                //Application.Exit();
                this.Close();

        }

        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.WindowState = FormWindowState.Minimized;
        }

        //timer to load the empcode and scale base
        Timer genEmpAndScaleBase;
        private void EmployeeRegForm_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            searchPanel.Visible = false;

            genEmpAndScaleBase = new Timer();

            genEmpAndScaleBase.Tick += new EventHandler(genEmpAndScaleBase_Tick);
            genEmpAndScaleBase.Interval = 1000;
            genEmpAndScaleBase.Start();

            LoadEmployee();
            
        }
        
        //check the empCode and Scale base
        private void genEmpAndScaleBase_Tick(object sender, EventArgs e)
        {
            //generating the codes
            generateEmpCodeAndScaleBasic();

            //check the email
            checkEmail(emailTxt.Text);


        }



        private void updateEmpInfoBnt_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            registerNewEmpBtn.Visible = true;
            deleteEmpBtn.Visible = true;
            updateEmpBtn.Visible = true;
            regiterEmpBtn.Visible = false;
            updateEmpInfoBnt.Visible = false;
            LoadEmployee();

        }


        #region REGEN FOR FUNCTIONS

        //fuction to clear fields
        private void clearFields()
        {
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            middleNameTxt.Text = "";
            empCodeTxt.Text = "";
            salaryCategory.selectedIndex = -1;
            scaleBaseTxt.Text = "";
            scalePercentTxt.Text = "";
            emailTxt.Text = "";
            phoneNumberTxt.Text = "";
            positionTxt.Text = "";
            bankNameTxt.Text = "";
            bankAcountNumberTxt.Text = "";
            employeeStatus.SelectedIndex = 0;
            salaryCategory.selectedIndex = 0;
           
        }
        //a function to generate employee code and Salary basic
        private void generateEmpCodeAndScaleBasic()
        {
            if (firstNameTxt.Text != "" && lastNameTxt.Text != "" && firstNameTxt.Text.Length >= 3 && lastNameTxt.Text.Length >= 3)
            {

                empCodeTxt.Text = ("ER" + lastNameTxt.Text.Substring(0, 3) + firstNameTxt.Text.Substring(0, 2) + "01").ToUpper();

            }
            else
            {
                empCodeTxt.Text = "";
            }

            try
            {
                switch (salaryCategory.selectedValue)
                {
                    case "":
                        scaleBaseTxt.Text = "";
                        break;
                    case "A":
                        scaleBaseTxt.Text = "680000";
                        break;
                    case "B":
                        scaleBaseTxt.Text = "544000";
                        break;
                    case "C":
                        scaleBaseTxt.Text = "408000";
                        break;
                    case "Others":
                        scaleBaseTxt.Text = "280000";
                        break;
                    default:
                        
                        MessageBox.Show("Sorry, there is an error in Salary Category..!");
                        break;
                }
            }
            catch
            {

            }
        }

        bool emailAllowed = false;
        //a function to check correct email
        private void checkEmail(string email)
        {
            //a regular expression to verifying the email if is valid

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(email))
            {
                emailAllowed = false;
            }
            else
            {
                emailAllowed = true;
            }
                 
        }


        //function to handle the entrace of only numbers in the text fields

        private void phoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        #endregion
        private void regiterEmpBtn_Click(object sender, EventArgs e)
        {
               if (firstNameTxt.Text == "" 
                || lastNameTxt.Text == ""
                || empCodeTxt.Text == ""
                || salaryCategory.selectedValue == ""
                || scaleBaseTxt.Text == ""
                || scalePercentTxt.Text == ""
                || emailTxt.Text == ""
                || phoneNumberTxt.Text == ""
                || positionTxt.Text == ""
                || bankNameTxt.Text == ""
                || bankAcountNumberTxt.Text == ""
                || employeeStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please, fill all the fields..!");
            }
            else
            {
               
                switch (emailAllowed)
                {
                    case true: //the email is correct, register employee
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = Home.DBconnection;

                        string value = "values('" + firstNameTxt.Text.ToUpper() + "','" + middleNameTxt.Text.ToUpper() +
                            "','" + lastNameTxt.Text.ToUpper() +
                            "','" + empCodeTxt.Text.ToUpper() +
                            "','ASTREAS01','" + dateOfBirth.Text +
                            "','" + salaryCategory.selectedValue +
                            "','" + scaleBaseTxt.Text +
                            "','" + scalePercentTxt.Text +
                            "','" + emailTxt.Text +
                            "','" + phoneNumberTxt.Text +
                            "','" + positionTxt.Text.ToUpper() +
                            "','" + bankAcountNumberTxt.Text.ToUpper() +
                            "','"+bankNameTxt.Text.ToUpper()+
                            "','"+DateTime.Now+
                            "','"+employeeStatus.Text.ToUpper()+"')";

                        string registerEmployee = "insert into employee(fname,mname,lname,empCode,DeptCode,DOB,salaryCategory,scaleBase,scalePercent,employeeEmail,phoneNumber,position,bankAccount,bankName,dateRegistered,statuse) " + value;

                        MySqlCommand com = new MySqlCommand(registerEmployee, con);
                        MySqlDataReader rd;
                        try
                        {
                            con.Open();

                            //registering an employee
                            rd = com.ExecuteReader();
                            rd.Close();

                            Login.RecordUserActivity("Registered " + firstNameTxt.Text + " " + middleNameTxt.Text + " " + lastNameTxt.Text + " as a new Employee in the system");

                            MessageBox.Show("Employee Registered Successful");

                            clearFields();

                        }
                        catch(MySqlException ex) {
                            MessageBox.Show(ex.Message);
                        }

                        con.Close();
                        break;
                    case false:
                        //the email is not correct
                        MessageBox.Show("Please, enter the valid email.");
                        break;
                }


            }
           
        }

        private void searchText_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string search = " select CONCAT(fname,' ',mname, ' ',lname) 'Employee Name' from employee where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%'";
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

       

        private void registerNewEmpBtn_Click(object sender, EventArgs e)
        {
            clearFields();
            searchPanel.Visible = false;
            registerNewEmpBtn.Visible = false;
            deleteEmpBtn.Visible = false;
            updateEmpBtn.Visible = false;
            regiterEmpBtn.Visible = true;
            updateEmpInfoBnt.Visible = true;
            
        }

        string empID = null;
        string dateRegistered = null;
        private static string empname = null;
        private static string empCode = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string EmployeeFullName;
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();
                   empname = selectedIndex.Cells[0].Value.ToString();

                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = Home.DBconnection;

                    string loadEmpDetails = "select * from employee where CONCAT(fname,' ',mname, ' ',lname) = '" + EmployeeFullName + "'";
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
                            dateOfBirth.Text = table.Rows[0][6].ToString();
                            scaleBaseTxt.Text = table.Rows[0][8].ToString();
                            scalePercentTxt.Text = table.Rows[0][9].ToString();
                            emailTxt.Text = table.Rows[0][10].ToString();
                            phoneNumberTxt.Text = table.Rows[0][11].ToString();
                            positionTxt.Text = table.Rows[0][12].ToString();
                            bankAcountNumberTxt.Text = table.Rows[0][13].ToString();
                            bankNameTxt.Text = table.Rows[0][14].ToString();
                            dateRegistered = table.Rows[0][15].ToString();
                            empCode = empCodeTxt.Text;


                            if (table.Rows[0][7].ToString() == "A")
                                salaryCategory.selectedIndex = 1;
                            if (table.Rows[0][7].ToString() == "B")
                                salaryCategory.selectedIndex = 2;
                            if (table.Rows[0][7].ToString() == "C")
                                salaryCategory.selectedIndex = 3;
                            if(table.Rows[0][7].ToString() == "Others")
                                salaryCategory.selectedIndex = 4;
                            if (table.Rows[0][16].ToString() == "STAFF")
                                employeeStatus.SelectedIndex = 1;
                            if (table.Rows[0][16].ToString() == "NORMAL")
                                employeeStatus.SelectedIndex = 2;
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

        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text == ""
                || lastNameTxt.Text == ""
                || empCodeTxt.Text == ""
                || salaryCategory.selectedValue == ""
                || scaleBaseTxt.Text == ""
                || scalePercentTxt.Text == ""
                || emailTxt.Text == ""
                || phoneNumberTxt.Text == ""
                || positionTxt.Text == ""
                || bankNameTxt.Text == ""
                || bankAcountNumberTxt.Text == ""
                || employeeStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please, fill all the fields..!");
            }
            else if (empID == null)
            {
                MessageBox.Show("Please, select an Employee for updating.!");
            }
            else
            {

                switch (emailAllowed)
                {
                    case true: //the email is correct, register employee
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = Home.DBconnection;

                       
                        string updateEmployee = "update employee set fname = '" + firstNameTxt.Text.ToUpper() + 
                            "', mname = '" + middleNameTxt.Text.ToUpper() +
                            "', lname = '" + lastNameTxt.Text.ToUpper() +
                            "', empCode = '" + empCodeTxt.Text.ToUpper() +
                            "', DOB = '" + dateOfBirth.Text +
                            "', salaryCategory = '" + salaryCategory.selectedValue +
                            "', scaleBase = '" + scaleBaseTxt.Text +
                            "', scalePercent = '" + scalePercentTxt.Text +
                            "', employeeEmail = '" + emailTxt.Text +
                            "', phoneNumber = '" + phoneNumberTxt.Text +
                            "', position = '" + positionTxt.Text.ToUpper() +
                            "', bankAccount = '" + bankAcountNumberTxt.Text.ToUpper() +
                            "', bankname = '" + bankNameTxt.Text.ToUpper() +
                            "', dateRegistered = '" + dateRegistered + 
                            "', statuse = '"+employeeStatus.Text.ToUpper()+"' where EmpID = '"+empID+"'";

                        MySqlCommand com = new MySqlCommand(updateEmployee, con);
                        MySqlDataReader rd;
                        try
                        {
                            con.Open();

                            //registering an employee
                            rd = com.ExecuteReader();
                            rd.Close();

                            Login.RecordUserActivity("Changed " + empname + " who had " + empCode + " as employee ID to " + empCodeTxt.Text);

                            clearFields();
                            LoadEmployee();
                            empID = null;
                            MessageBox.Show("Employee Updated Successful");

                           

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        con.Close();
                        break;
                    case false:
                        //the email is not correct
                        MessageBox.Show("Please, enter the valid email.");
                        break;
                }


            }

        }


        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (empID != null && MessageBox.Show("Are you sure you want to delete this Employee?","Alert",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

                string delete = "delete from employee where empID = '" + empID + "'";

                MySqlCommand com = new MySqlCommand(delete, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //delete an employee
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Deleted " + empname + " who had " + empCode + " as employee ID ");

                    clearFields();
                    LoadEmployee();
                    empID = null;
                    MessageBox.Show("Employee Deleted Successful");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                check = true;
            }

           if(empID == null && check == false)
                MessageBox.Show("Please, select the name of an employee before deletion!");
            
        }
    }
}
