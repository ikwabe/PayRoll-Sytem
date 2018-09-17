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
    public partial class EditEmpDeductionAndAllowance : Form
    {
        public EditEmpDeductionAndAllowance()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Close();
                EmployeeAllawanceAndDeductionForm emp = new EmployeeAllawanceAndDeductionForm();
                emp.ShowDialog();
            }
            
        }

        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        private static string empCode = null;
        private void LoadEmployee()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadEmpNames = " select upper(CONCAT(fname,' ',mname, ' ',lname)) 'Employee Name' from employee where STATE = 'ACTIVE'";
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
            string search = " select upper(CONCAT(fname,' ',mname, ' ',lname)) 'Employee Name' from employee where fname like '" + searchText.Text + "%' or mname like '" + searchText.Text + "%' or lname like '" + searchText.Text + "%' or CONCAT(fname,' ',mname, ' ',lname) like '" + searchText.Text + "%' AND STATE = 'ACTIVE'";
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

        private static string empID = null;
        string EmployeeFullName = null;

        private void searchResultDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                int index = e.RowIndex;

                try
                {
                    DataGridViewRow selectedIndex = searchResultDataGrid.Rows[index];
                    EmployeeFullName = selectedIndex.Cells[0].Value.ToString();
                    panel5.Visible = true;
                    GetDetails(EmployeeFullName);

                }
                catch
                {
                    MessageBox.Show("Error on EmpId or Empcode.");
                }

            }
           
        }


        private void GetDetails(string EmpFullName)
        {
            try
            {

                deductionCombo.Text = "";
                deductionType.Text = "";
                allowanceCombo.Text = "";
                allowanceAmountTxt.Text = "";
                deductionAmountTxt.Text = "";
                percentageTxt.Text = "";


                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

                string loadEmpDetails = "select * from employee where CONCAT(fname,' ',mname, ' ',lname) = '" + EmpFullName + "' AND STATE = 'ACTIVE'";
                MySqlCommand com = new MySqlCommand(loadEmpDetails, con);
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
                        empID = table.Rows[0][0].ToString();
                        employeeNameLabel.Text = EmpFullName;
                        empCode = table.Rows[0][4].ToString();

                        //for Deduction
                        string getDeduction = "select deductionID from employeededuction where empCode = '" + empCode + "' and dateForDeduction = '" + deductionDate.Text + "'";
                        MySqlCommand com2 = new MySqlCommand(getDeduction, con);
                        da = new MySqlDataAdapter(com2);
                        DataTable tab1 = new DataTable();
                        da.Fill(tab1);
                        da.Dispose();
                        DataTable tab = new DataTable();

                        if (tab1.Rows.Count > 0)
                        {
                            deductionCombo.Items.Clear();

                            for (int i = 0; i < tab1.Rows.Count; i++)
                            {
                                string getDeductionName = "select deductionName from deduction where deductionID = '" + tab1.Rows[i][0] + "'";

                                MySqlCommand com3 = new MySqlCommand(getDeductionName, con);
                                da = new MySqlDataAdapter(com3);
                                da.Fill(tab);
                                da.Dispose();
                                deductionCombo.Items.Add(tab.Rows[i][0].ToString().ToUpper());
                            }
                        }
                        else
                        {
                            deductionCombo.Items.Clear();
                        }


                        //for allowance
                        string getAllowance = "select allowanceID from employeeallowance where empCode = '" + empCode + "'";
                        MySqlCommand comAll = new MySqlCommand(getAllowance, con);
                        da = new MySqlDataAdapter(comAll);
                        DataTable tab2 = new DataTable();
                        da.Fill(tab2);
                        da.Dispose();


                        DataTable tab3 = new DataTable();

                        if (tab2.Rows.Count > 0)
                        {
                            allowanceCombo.Items.Clear();

                            for (int i = 0; i < tab2.Rows.Count; i++)
                            {
                                string getAllowanceName = "select allowanceName from allowance where allowanceID = '" + tab2.Rows[i][0] + "'";

                                MySqlCommand com4 = new MySqlCommand(getAllowanceName, con);
                                da = new MySqlDataAdapter(com4);
                                da.Fill(tab3);
                                da.Dispose();
                                allowanceCombo.Items.Add(tab3.Rows[i][0].ToString().ToUpper());
                            }
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
                MessageBox.Show("Error on EmpId or Empcode.");
            }

        }


        private void EditEmpDeductionAndAllowance_Load(object sender, EventArgs e)
        {
            
            deductionDate.CustomFormat = "MMMM yyyy";
            LoadEmployee();


        }



        string AllowID = null;
        string dedID = null;
        string deductionamount = null;
        string allowanceamount = null;
        string percentage = null;
        private void allowanceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getAllowanceId = "select * from allowance where allowanceName = '" + allowanceCombo.Text + "'";
            MySqlCommand com = new MySqlCommand(getAllowanceId, con);
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
                    string getAllowanceID = "select * from employeeallowance where empCode = '" + empCode + "' and allowanceID = '" + table.Rows[0][0].ToString() + "'";

                    MySqlCommand com1 = new MySqlCommand(getAllowanceID, con);
                   
                    DataTable tab = new DataTable();

                    da = new MySqlDataAdapter(com1);
                    da.Fill(tab);
                    da.Dispose();

                    if(tab.Rows.Count > 0)
                    {
                        AllowID = tab.Rows[0][0].ToString();
                        allowanceAmountTxt.Text = tab.Rows[0][3].ToString();
                        allowanceamount = tab.Rows[0][3].ToString();
                    }


                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        
        private void deductionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getDeductionId = "select * from deduction where deductionName = '" + deductionCombo.Text + "'";
            MySqlCommand com = new MySqlCommand(getDeductionId, con);
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
                    string getDeductionID = "select * from employeededuction where empcode = '" + empCode + "' and deductionID = '" + table.Rows[0][0] + "' and dateForDeduction = '" + deductionDate.Text + "'";

                    MySqlCommand com2 = new MySqlCommand(getDeductionID, con);
                   
                    DataTable tab = new DataTable();
                    da = new MySqlDataAdapter(com2);
                    da.Fill(tab);
                    da.Dispose();

                    if(tab.Rows.Count > 0)
                    {
                        if(tab.Rows[0][5].ToString() == "YES")
                        {
                            label4.Visible = false;
                            deductionAmountTxt.Visible = false;
                            label11.Visible = true;
                            percentageTxt.Visible = true;

                            percentageTxt.Text = tab.Rows[0][7].ToString();
                            deductionType.Text = tab.Rows[0][4].ToString();
                            dedID = tab.Rows[0][0].ToString();
                            percentage = tab.Rows[0][7].ToString();

                        }
                        else
                        {
                            label11.Visible = false;
                            percentageTxt.Visible = false;
                            deductionAmountTxt.Visible = true;
                            label4.Visible = true;

                            deductionAmountTxt.Text = tab.Rows[0][3].ToString();
                            deductionType.Text = tab.Rows[0][4].ToString();
                            dedID = tab.Rows[0][0].ToString();
                            deductionamount = tab.Rows[0][3].ToString();
                        }
                    }


                }


                }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Clone();
        }

        private void deductionDate_ValueChanged(object sender, EventArgs e)
        {
            if(EmployeeFullName != null)
            {
                GetDetails(EmployeeFullName);
            }
            else
            {
                MessageBox.Show("Please Select Name from the list.");
            }
        }

        //update allowance for an Employee
        private void AllowUpdateBtn_Click(object sender, EventArgs e)
        {
            if(allowanceAmountTxt.Text != "" && allowanceCombo.Text != "" && AllowID != null)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;
                string update = "update employeeallowance set amount = '" + allowanceAmountTxt.Text + "' where ID = '" + AllowID + "' ";

                MySqlCommand com = new MySqlCommand(update, con);

                MySqlDataReader rd;

                try
                {
                    con.Open();

                    //update

                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed " + allowanceCombo.Text + " Allowance amount from " + allowanceamount + " to " + allowanceAmountTxt.Text + " for Employee " + EmployeeFullName + " of employeeID "+empCode+"");

                    MessageBox.Show("Update Successful!");

                    allowanceAmountTxt.Text = "";
                    allowanceCombo.Text = "";

                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the name from the list and select allowance from the list to perform this operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //delete allowance for an Employee
        private void AllowDeleteBtn_Click(object sender, EventArgs e)
        {
            if(AllowID != null && allowanceCombo.Text!= "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;
                string delete = "delete from employeeallowance where ID = '" + AllowID + "' ";

                MySqlCommand com = new MySqlCommand(delete, con);

                MySqlDataReader rd;

                try
                {
                    con.Open();

                    //update

                    if(MessageBox.Show("Are you sure you want to delete this allowance for "+EmployeeFullName,"Alart!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rd = com.ExecuteReader();
                        rd.Close();

                        Login.RecordUserActivity("Deleted " + allowanceCombo.Text + " Allowance for Employee " + EmployeeFullName + " of employeeID " + empCode + "");

                        MessageBox.Show("Delete Successful!");
                        allowanceCombo.Items.Clear();
                        GetDetails(EmployeeFullName);
                    }
                   

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the name from the list and select allowance from the list to perform this operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // update deduction for an employee
        private void DedUpdateBtn_Click(object sender, EventArgs e)
        {
            if(dedID != null && deductionAmountTxt.Text !="" && deductionAmountTxt.Visible == true && deductionType.Text !="" && deductionCombo.Text != "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

                string update = "update employeededuction set amountDeducted = '" + deductionAmountTxt.Text +
                    "', deductiontype = '" + deductionType.Text +
                    "', dateForDeduction = '" + deductionDate.Text + "' where ID = '"+dedID+"'";

                MySqlCommand com = new MySqlCommand(update, con);

                MySqlDataReader rd;

                try
                {
                    con.Open();

                    //update

                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed " + deductionCombo.Text + " Deduction amount from " + deductionamount + " to " + deductionAmountTxt.Text + " for Employee " + EmployeeFullName + " of employeeID " + empCode + "");

                    MessageBox.Show("Update Successful!");
                    deductionCombo.Items.Clear();
                    GetDetails(EmployeeFullName);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if(dedID != null && percentageTxt.Text != "" && percentageTxt.Visible == true && deductionCombo.Text !="" && deductionType.Text != "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;

                string update = "update employeededuction set percentage = '" + percentageTxt.Text +
                    "', deductiontype = '" + deductionType.Text +
                    "', dateForDeduction = '" + deductionDate.Text + "' where ID = '" + dedID + "'";

                MySqlCommand com = new MySqlCommand(update, con);

                MySqlDataReader rd;

                try
                {
                    con.Open();

                    //update

                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Changed " + deductionCombo.Text + " Deduction percentage from " + percentage + " to " + percentageTxt.Text + " for Employee " + EmployeeFullName + " of employeeID " + empCode + "");

                    MessageBox.Show("Update Successful!");
                    deductionCombo.Items.Clear();
                    GetDetails(EmployeeFullName);

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select the name from the list and select deduction from the list to perform this operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void DedDeleteBtn_Click(object sender, EventArgs e)
        {
            if(dedID != null && deductionCombo.Text != "")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;
                string delete = "delete from employeededuction where ID = '" + dedID + "'";
                MySqlCommand com = new MySqlCommand(delete, con);
                MySqlDataReader rd;

                try
                {
                    con.Open();

                    if (MessageBox.Show("Are you sure you want to delete this deduction for " + EmployeeFullName, "Alart!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        rd = com.ExecuteReader();
                        rd.Close();

                        Login.RecordUserActivity("Deleted " + deductionCombo.Text + " Deduction for Employee " + EmployeeFullName + " of employeeID " + empCode + "");
                        deductionCombo.Items.Clear();
                        GetDetails(EmployeeFullName);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select the name from the list and select deduction from the list to perform this operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
