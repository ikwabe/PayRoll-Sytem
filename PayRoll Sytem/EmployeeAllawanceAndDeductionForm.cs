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
    public partial class EmployeeAllawanceAndDeductionForm : Form
    {
        public EmployeeAllawanceAndDeductionForm()
        {
            InitializeComponent();
        }

        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //Application.Exit();
                this.Close();
        }
        int  allow = 0;
        int deduct = 0;
        private void allowanceBtn_Click(object sender, EventArgs e)
        {
            if(empID != null)
            {
                if (allow % 2 == 0)
                {
                    allow++;
                    LoadAllowance();
                    allowanceGroupBox.Visible = true;
                }
                else
                {
                   
                    allowanceGroupBox.Visible = false;
                    allow = 0;
                }
            }
            else if(check == true)
            {
                if (allow % 2 == 0)
                {
                    allow++;
                    LoadAllowance();
                    allowanceGroupBox.Visible = true;
                }
                else
                {
                   
                    allowanceGroupBox.Visible = false;
                    allow = 0;
                    
                }
            }
            else
            {
                MessageBox.Show("Please, select Employee`s name from the list or Tick the Allowance for All Staff Members.");
            }
        }

        private void deductionBtn_Click(object sender, EventArgs e)
        {

            if (empID != null)
            {
                if (deduct%2 == 0)
            {

                    deduct++;
                    LoadDeduction();
                    deductionGroupBox.Visible = true;
            }
            else
            {
               
                deductionGroupBox.Visible = false;
                    deduct = 0;
                }
            }
            else if (check == true)
            {
                if (deduct % 2 == 0)
                {

                    deduct++;
                    LoadDeduction();
                    deductionGroupBox.Visible = true;
                }
                else
                {
                    deduct++;
                    deductionGroupBox.Visible = false;
                    deduct = 0;
                }
            }
            else
            {
                MessageBox.Show("Please, select Employee`s name from the list or Tick the Allowance for All Staff Members.");
            }
        }

        private static string empCode = null;
        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select upper(CONCAT(fname,' ',mname, ' ',lname)) 'Employee Name' from employee";
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
            string search = " select upper(CONCAT(fname,' ',mname, ' ',lname)) 'Employee Name' from employee where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%' or CONCAT(fname,' ',mname, ' ',lname) like '" + searchText.Text + "%'";
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

        //a function to load Allowances
        private void LoadAllowance()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string allowances = " select upper(allowanceName) from allowance ";

            MySqlCommand com = new MySqlCommand(allowances, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(allowances, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                allowanceCombo.DisplayMember = "upper(allowanceName)";
                allowanceCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        //a function to load Deduction
        private void LoadDeduction()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;
            string deductions = " select upper(deductionName) from deduction ";

            MySqlCommand com = new MySqlCommand(deductions, con);

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(deductions, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Select");
                com.ExecuteNonQuery();
                deductionCombo.DisplayMember = "upper(deductionName)";
                deductionCombo.DataSource = ds.Tables["Select"];
                da.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        Timer successTimer;
        bool ded = false;
        bool all = false;
        int wait = 0;
        private void EmployeeAllawanceAndDeductionForm_Load(object sender, EventArgs e)
        {
            deductionDate.CustomFormat = "MMMM yyyy";
            deductionDate.MinDate = DateTime.Now;
            successTimer = new Timer();
            successTimer.Tick += new EventHandler(successTimer_Tick);
            successTimer.Interval = 100;
            LoadEmployee();
            
        }
        
        private void successTimer_Tick(object sender, EventArgs e)
        {
            
            if(wait < 30 && ded == true)
            {
                label10.Visible = true;
                wait++;
            }
            else if(wait < 30 && all == true)
            {
                label8.Visible = true;
                wait++;
            }
            else
            {
                successTimer.Stop();
                label8.Visible = false;
                label10.Visible = false;
                wait = 0;
            }
        }
        private static string empID = null;
        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string EmployeeFullName;
            if (e.Button == MouseButtons.Left && check == false)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();


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
                            employeeNameLabel.Text = EmployeeFullName;
                            empCode = table.Rows[0][4].ToString();
                           
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
                    MessageBox.Show("Error on EmpId or Empcode.");
                }

            }
            else
            {
                MessageBox.Show("Uncheck the Allocation for All Staffs to select the name.");
            }
        }

        private static string allowanceID = null;

        string yes = null;
        private void allowanceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadAlowance = "select allowanceID from allowance where allowanceName = '" + allowanceCombo.Text + "'";
            MySqlCommand com = new MySqlCommand(loadAlowance, con);
            MySqlDataAdapter da;
            DataTable table = new DataTable();

            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    allowanceID = table.Rows[0][0].ToString();
                  
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void deductioType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           if(deductionType.Text == "DISTINCTION")
            {
                label6.Visible = true;
                deductionDate.Visible = true;
            }
            else
            {
                label6.Visible = false;
                deductionDate.Visible = false;
            }
        }

        private static string deductionID = null;
        bool putYes = false;
        private void deductionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadDeduction = "select deductionID from deduction where deductionName = '" + deductionCombo.Text + "'";
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
                    deductionID = table.Rows[0][0].ToString();
                    if (deductionCombo.Text == "SOCIAL SECURITY FUND" || deductionCombo.Text == "HOUSE RENT" || deductionCombo.Text == "DEDUCTION ON ACCOUNT" || deductionCombo.Text == "HESLB LOAN 15%" || deductionCombo.Text == "NHIF")
                    {
                        deductionAmountTxt.Visible = false;
                        label4.Visible = false;
                        label11.Visible = true;
                        percentageTxt.Visible = true;
                        deductionType.SelectedIndex = 2;
                        yes = "YES";
                        putYes = true;

                    }
                    else
                    {
                        putYes = false;
                        label11.Visible = false;
                        percentageTxt.Visible = false;
                        deductionAmountTxt.Visible = true;
                        label4.Visible = true;
                        deductionType.SelectedIndex = 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void addAllowanceBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            if(check == true)
            {
                AllowanceAllocateForStaff();
            }
            else
            {
                if (allowanceID != null && empCode != null && allowanceAmountTxt.Text != "")
                {
                    string checkAllowance = "select * from employeeallowance where empCode = '" + empCode + "' and allowanceID = '" + allowanceID + "'";

                    string insert = "insert into employeeallowance(empCode,allowanceID,amount) " +
                        " values('" + empCode + "','" + allowanceID + "','" + allowanceAmountTxt.Text + "')";
                    MySqlCommand com = new MySqlCommand(insert, con);

                    MySqlCommand comCheck = new MySqlCommand(checkAllowance, con);

                    MySqlDataReader rd;
                    DataTable tab = new DataTable();
                    try
                    {
                        con.Open();

                        rd = comCheck.ExecuteReader();
                        tab.Load(rd);
                        rd.Close();

                        if(tab.Rows.Count > 0)
                        {
                            MessageBox.Show("This Allowance is Aready Added for this Employee.");
                        }
                        else
                        {
                            rd = com.ExecuteReader();
                            rd.Close();

                            Login.RecordUserActivity("Added Allowance " + allowanceCombo.Text + " of amount " + allowanceAmountTxt.Text + " to employee " + empCode);

                            allowanceAmountTxt.Text = "";
                            all = true;
                            ded = false;
                            successTimer.Start();
                        }
                       
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("EmpCode or AllowanceID or Empty amount Error ");
                }
            }
        }

        private void allowanceAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        //a function to insert allawance for staffs only
        private void AllowanceAllocateForStaff()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadStaffId = "select empCode from employee where statuse = 'STAFF'";

            MySqlCommand com = new MySqlCommand(loadStaffId, con);

            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();

                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();

                if (allowanceID != null && allowanceAmountTxt.Text != "")
                {
                    for(int i = 0; i<table.Rows.Count; i++)
                    {
                        string checkAllowance = "select * from employeeallowance where empCode = '" + table.Rows[i][0].ToString() + "' and allowanceID = '" + allowanceID + "'";

                        string insert = "insert into employeeallowance(empCode,allowanceID,amount) " +
                        " values('" + table.Rows[i][0].ToString() + "','" + allowanceID + "','" + allowanceAmountTxt.Text + "')";
                        MySqlCommand com1 = new MySqlCommand(insert, con);
                        MySqlCommand com2 = new MySqlCommand(checkAllowance, con);
                        MySqlDataReader rd;

                        DataTable tab = new DataTable();

                        rd = com2.ExecuteReader();
                        tab.Load(rd);
                        rd.Close();

                        if(tab.Rows.Count > 0)
                        {
                           
                        }
                        else
                        {
                            rd = com1.ExecuteReader();
                            rd.Close();

                            Login.RecordUserActivity("Added Allowance " + allowanceCombo.Text + " of amount " + allowanceAmountTxt.Text + " to employee " + table.Rows[i][0].ToString());
                        }    
                    }

                    
                    allowanceAmountTxt.Text = "";
                    all = true;
                    ded = false;
                    successTimer.Start();

                }
                else
                {
                    MessageBox.Show("EmpCode or AllowanceID or Empty amount Error ");
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // a function to insert all deduction for staffs only

        private void DeductionAllocateForStaff()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadStaffId = "select empCode from employee where statuse = 'STAFF'";

            MySqlCommand com = new MySqlCommand(loadStaffId, con);

            MySqlDataAdapter da;
            DataTable table = new DataTable();
            try
            {
                con.Open();

                da = new MySqlDataAdapter(com);
                da.Fill(table);
                da.Dispose();


                if (putYes == true && deductionID != null && percentageTxt.Text !="")
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string insert = "insert into employeededuction(empCode,deductionID,deductionType,statuse,dateForDeduction,percentage) " +
                    " values('" + table.Rows[i][0].ToString() + "','" + deductionID + "','" + deductionType.Text + "','" + yes + "','" + deductionDate.Text + "','"+percentageTxt.Text+"')";

                        string checkDeduction = "select * from employeededuction where empCode = '" + table.Rows[i][0].ToString() + "' and deductionID = '" + deductionID + "'";
                        MySqlCommand com1 = new MySqlCommand(insert, con);

                        MySqlCommand com2 = new MySqlCommand(checkDeduction, con);

                       
                        MySqlDataReader rd;
                        DataTable tab = new DataTable();

                        rd = com2.ExecuteReader();
                        tab.Load(rd);
                        rd.Close();

                        if (tab.Rows.Count > 0)
                        {

                        }
                        else
                        {
                            rd = com1.ExecuteReader();
                            rd.Close();

                            percentageTxt.Text = "";
                            Login.RecordUserActivity("Added deduction " + deductionCombo.Text + " to employee " + table.Rows[i][0].ToString());

                        }

                        
                    }
                }
                else
                {

                    if (deductionID != null && deductionAmountTxt.Text != "" && deductionType.Text !="")
                    {
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            string insert = "insert into employeededuction(empCode,deductionID,amountDeducted,deductionType,dateForDeduction) " +
                        " values('" + table.Rows[i][0].ToString() + "','" + deductionID + "','" + deductionAmountTxt.Text + ",'" + deductionType.Text + "','" + deductionDate.Text + "')";
                            string checkDeduction = "select * from employeededuction where empCode = '" + table.Rows[i][0].ToString() + "' and deductionID = '" + deductionID + "'";
                            MySqlCommand com1 = new MySqlCommand(insert, con);

                            MySqlCommand com2 = new MySqlCommand(checkDeduction, con);


                            MySqlDataReader rd;
                            DataTable tab = new DataTable();

                            rd = com2.ExecuteReader();
                            tab.Load(rd);
                            rd.Close();

                            if (tab.Rows.Count > 0)
                            {

                            }
                            else
                            {
                                rd = com1.ExecuteReader();
                                rd.Close();

                                Login.RecordUserActivity("Added deduction " + deductionCombo.Text + " of amount " + deductionAmountTxt.Text + " to employee " + table.Rows[i][0].ToString());
                            }

                            
                        }
                        deductionAmountTxt.Text = "";
                        ded = true;
                        all = false;
                        successTimer.Start();
                    }
                    else
                    {
                        MessageBox.Show("EmpCode or AllowanceID or Empty amount Error ");
                    }

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
          
         
            if(check == true)
            {
                DeductionAllocateForStaff();
            }
            else
            {
                if(putYes == true && deductionID != null && empCode != null && percentageTxt.Text !="")
                {
                    deductionDate.CustomFormat = "MMMM yyyy";

                    string insert = "insert into employeededuction(empCode,deductionID,deductionType,statuse,dateForDeduction,percentage) " +
                        " values('" + empCode + "','" + deductionID + "','" + deductionType.Text + "','"+yes+"','" + deductionDate.Text + "','"+percentageTxt.Text+"')";

                    string checkDeduction = "select * from employeededuction where empCode = '" + empCode + "' and deductionID = '" + deductionID + "' and dateForDeduction = '"+deductionDate.Text+"'";
                    MySqlCommand com = new MySqlCommand(insert, con);

                    MySqlCommand com1 = new MySqlCommand(checkDeduction, con);

                    MySqlDataReader rd;
                    DataTable tab = new DataTable();
                    try
                    {
                        con.Open();

                        rd = com1.ExecuteReader();
                        tab.Load(rd);
                        rd.Close();

                        if(tab.Rows.Count > 0)
                        {
                            MessageBox.Show("This deduction on this date arleady exist for this employee");
                        }
                        else
                        {
                            rd = com.ExecuteReader();
                            rd.Close();

                            percentageTxt.Text = "";
                            Login.RecordUserActivity("Added deduction " + deductionCombo.Text + " to employee " + empCode);

                            deductionAmountTxt.Text = "";
                            ded = true;
                            all = false;
                            successTimer.Start();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    //for distinct deductions
                    if (deductionID != null && empCode != null && deductionAmountTxt.Text != "" && deductionType.SelectedIndex != 0)
                    {
                        deductionDate.CustomFormat = "MMMM yyyy";

                        string insert = "insert into employeededuction(empCode,deductionID,amountDeducted,deductionType,dateForDeduction) " +
                            " values('" + empCode + "','" + deductionID + "','" + deductionAmountTxt.Text + "','" + deductionType.Text + "','" + deductionDate.Text + "')";
                        string checkDeduction = "select * from employeededuction where empCode = '" + empCode + "' and deductionID = '" + deductionID + "' and dateForDeduction = '" + deductionDate.Text + "'";
                        MySqlCommand com = new MySqlCommand(insert, con);

                        MySqlCommand com1 = new MySqlCommand(checkDeduction, con);

                        MySqlDataReader rd;
                        DataTable tab = new DataTable();
                        try
                        {
                            con.Open();
                            rd = com1.ExecuteReader();
                            tab.Load(rd);
                            rd.Close();

                            if (tab.Rows.Count > 0)
                            {
                                MessageBox.Show("This deduction on this date arleady exist for this employee");
                            }
                            else
                            {
                                rd = com.ExecuteReader();
                                rd.Close();

                                Login.RecordUserActivity("Added deduction " + deductionCombo.Text + " of amount " + deductionAmountTxt.Text + " to employee " + empCode);

                                deductionAmountTxt.Text = "";
                                ded = true;
                                all = false;
                                successTimer.Start();
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    //for constant deductions
                    else if (deductionID != null && empCode != null && deductionAmountTxt.Text != "" && deductionDate.Visible != true && deductionType.SelectedIndex !=0)
                    {
                        deductionDate.CustomFormat = "MMMM yyyy";

                        string insert = "insert into employeededuction(empCode,deductionID,amountDeducted,deductionType) " +
                            " values('" + empCode + "','" + deductionID + "','" + deductionAmountTxt.Text + "','" + deductionType.Text + "')";


                        string checkDeduction = "select * from employeededuction where empCode = '" + empCode + "' and deductionID = '" + deductionID + "' and deductionType = '"+deductionType.Text+"'";
                        MySqlCommand com = new MySqlCommand(insert, con);

                        MySqlCommand com1 = new MySqlCommand(checkDeduction, con);

                        MySqlDataReader rd;
                        DataTable tab = new DataTable();
                        try
                        {


                            con.Open();
                            rd = com1.ExecuteReader();
                            tab.Load(rd);
                            rd.Close();

                            if (tab.Rows.Count > 0)
                            {
                                MessageBox.Show("This deduction arleady exist for this employee");
                            }
                            else
                            {
                                rd = com.ExecuteReader();
                                rd.Close();

                                Login.RecordUserActivity("Added deduction " + deductionCombo.Text + " of amount " + deductionAmountTxt.Text + " to employee " + empCode);

                                deductionAmountTxt.Text = "";
                                ded = true;
                                all = false;
                                successTimer.Start();
                            }

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        MessageBox.Show("EmpCode or deductionID or Empty amount or DeductionType Error ");
                    }
                }
               
            }
            
        }

        bool check = false;
        private void markAllD_CheckedChanged(object sender, EventArgs e)
        {
            if(markAllD.Checked == true)
            {
                employeeNameLabel.Text = "ALL STAFF MEMBERS";
                check = true;
                empID = null;
            }
            else
            {
                employeeNameLabel.Text = "";
                check = false;
                if(allowanceGroupBox.Visible == true || deductionGroupBox.Visible == true)
                {
                    allowanceGroupBox.Visible = false;
                    deductionGroupBox.Visible = false;
                    allow = 0;
                    deduct = 0;
                } 
                
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            EditEmpDeductionAndAllowance edit = new EditEmpDeductionAndAllowance();
            edit.ShowDialog();
        }
    }
}
