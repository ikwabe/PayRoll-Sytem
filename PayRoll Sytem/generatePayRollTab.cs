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
using Microsoft.Office.Interop.Excel;


namespace PayRoll_Sytem
{
    public partial class generatePayRollTab : UserControl
    {
        public static generatePayRollTab _instance;
        public static generatePayRollTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new generatePayRollTab();
                return _instance;
            }
        }
        public generatePayRollTab()
        {
            InitializeComponent();
        }

        private void generatePayRollTab_Load(object sender, EventArgs e)
        {
            payRollDate.CustomFormat = "MMMM yyyy";
            //payRollDate.MinDate = DateTime.Now;   
        }

        //calculated variable for payroll
        double salaryBasic = 0.00; //=Scale base * scale percentage
        double allowanceUtility = 0.00; //=Salary basic * 1.5/12
        double incomeTotal = 0.00; //= Salary Basic + Allowance Auto Depression + Allowance Bicycle + D/Leader travel + C/Limit travel + Expenses Postage + Allowance Utility
        double socialSecurityFund = 0.00; // income Total * 0.1
        double incomeTaxable = 0.00; //=Salary Basic + Allowance utility – Social Security Fund
        double tithe = 0.00; //=Income total * 0.1
        double i_Tax = 0.00;//IF(Income Taxable<170000,0)
                            //IF(Income Taxable<360000,9%*(Income Taxable-170000))
                            //IF(Income Taxable<540000,17100+20%*(Income Taxable-360000))
                            //IF(Income Taxable<720000,53100+25%*(Income Taxable-540000))
                            //Else (98100+30%*(Income Taxable-720000))
        double houseRent = 0.00; //=Salary basic * 0.075
        double deductionOnAccount = 0.00; //=Salary Basic *0.05
        double NHIF = 0.00; //Salary Basic * 0.03
        double HESLBLoan = 0.00; //Salary Basic * 0.15
        double deductionTotal = 0.00; //= Tithe + i/Tax + Social Security Fund + House Rent + 
                                      //Maafa Fund + Food + SACCOS + Cash and Salary Advance + 
                                      //NBC Loan + Motor Vehicle Loan + Furniture + HESLB Loan 15% + 
                                      //Deduction On Account + Saving P/ Service + NHIF
        double salaryNet = 0.00;//Income total – Deduction Total
        double refund_iTax = 0.00; //i/Tax * 0.9
        double payNet = 0.00; //Salary Net + Refund i/Tax

        //direct variables for allowace
        double allowanceAutDepr = 0.00;
        double bicycleAllowance = 0.00;
        double travelDLeaders = 0.00;
        double travelCLimit = 0.00;
        double postageExps = 0.00;

        //direct variable for deduction
        double maafaFund = 0.00;
        double food = 0.00;
        double SACCOS = 0.00;
        double salaryAdvance = 0.00;
        double NBCLoan = 0.00;
        double furnitureLoan = 0.00;
        double motorVehicleLoan = 0.00;
        double personalSaving = 0.00;


        private void resetVariables()
        {
            //Reset variable for payroll
             salaryBasic = 0.00; //=Scale base * scale percentage
             allowanceUtility = 0.00; //=Salary basic * 1.5/12
             incomeTotal = 0.00; //= Salary Basic + Allowance Auto Depression + Allowance Bicycle + D/Leader travel + C/Limit travel + Expenses Postage + Allowance Utility
             socialSecurityFund = 0.00; // income Total * 0.1
             incomeTaxable = 0.00; //=Salary Basic + Allowance utility – Social Security Fund
             tithe = 0.00; //=Income total * 0.1
             i_Tax = 0.00;//IF(Income Taxable<170000,0)
                                //IF(Income Taxable<360000,9%*(Income Taxable-170000))
                                //IF(Income Taxable<540000,17100+20%*(Income Taxable-360000))
                                //IF(Income Taxable<720000,53100+25%*(Income Taxable-540000))
                                //Else (98100+30%*(Income Taxable-720000))
             houseRent = 0.00; //=Salary basic * 0.075
             deductionOnAccount = 0.00; //=Salary Basic *0.05
             NHIF = 0.00; //Salary Basic * 0.03
             HESLBLoan = 0.00; //Salary Basic * 0.15
             deductionTotal = 0.00; //= Tithe + i/Tax + Social Security Fund + House Rent + 
                                          //Maafa Fund + Food + SACCOS + Cash and Salary Advance + 
                                          //NBC Loan + Motor Vehicle Loan + Furniture + HESLB Loan 15% + 
                                          //Deduction On Account + Saving P/ Service + NHIF
             salaryNet = 0.00;//Income total – Deduction Total
             refund_iTax = 0.00; //i/Tax * 0.9
             payNet = 0.00; //Salary Net + Refund i/Tax

            //direct variables for allowace
             allowanceAutDepr = 0.00;
             bicycleAllowance = 0.00;
             travelDLeaders = 0.00;
             travelCLimit = 0.00;
             postageExps = 0.00;

            //direct variable for deduction
             maafaFund = 0.00;
             food = 0.00;
             SACCOS = 0.00;
             salaryAdvance = 0.00;
             NBCLoan = 0.00;
             furnitureLoan = 0.00;
             motorVehicleLoan = 0.00;
             personalSaving = 0.00;
        }
        private void calculationAndGeneration()
        {
            using (MySqlConnection con = new MySqlConnection())
            {


                con.ConnectionString = Home.DBconnection;

                string getEmployeeDetails = "select * from employee where  STATE = 'ACTIVE'";

                //checking if the payroll is present
                string checkThePayroll = "select dateGenerated from payRoll where dateGenerated = '" + payRollDate.Text + "'";
                MySqlCommand CheckPayrol = new MySqlCommand(checkThePayroll, con);

                System.Data.DataTable tab = new System.Data.DataTable();

                MySqlCommand EmployeeCom = new MySqlCommand(getEmployeeDetails, con);

                MySqlDataAdapter da;

                MySqlDataReader rd;
                System.Data.DataTable Emptable = new System.Data.DataTable();

                try
                {
                    con.Open();

                    da = new MySqlDataAdapter(CheckPayrol);
                    da.Fill(tab);
                    da.Dispose();

                    if (tab.Rows.Count > 0)
                    {
                        payRollDataGrid.DataSource = null;
                        MessageBox.Show("The Pay-Roll already existed.");
                    }
                    else
                    {


                        //table for Employees
                        da = new MySqlDataAdapter(EmployeeCom);
                        da.Fill(Emptable);
                        da.Dispose();

                        if (Emptable.Rows.Count > 0)
                        {
                            for (int i = 0; i < Emptable.Rows.Count; i++)
                            {
                                resetVariables();
                                salaryBasic = double.Parse(Emptable.Rows[i][8].ToString()) * (double.Parse(Emptable.Rows[i][9].ToString()) / 100);
                                allowanceUtility = salaryBasic * 1.5 / 12;

                                //geting the allowances for the employee
                                string getAllowance = "select * from employeeallowance where empCode = '" + Emptable.Rows[i][4] + "'";
                                MySqlCommand allowCom = new MySqlCommand(getAllowance, con);

                                System.Data.DataTable allowTable = new System.Data.DataTable();
                                da = new MySqlDataAdapter(allowCom);
                                da.Fill(allowTable);
                                da.Dispose();

                                double allowanceTotal = 0.00;

                                //total allowance calculations
                                for (int j = 0; j < allowTable.Rows.Count; j++)
                                {

                                    allowanceTotal += double.Parse(allowTable.Rows[j][3].ToString());

                                    //Get the Name of the allowance
                                    string selectAllowance = "select allowanceName from allowance where allowanceID = '" + allowTable.Rows[j][2] + "' ";

                                    MySqlCommand allowCom1 = new MySqlCommand(selectAllowance, con);

                                    System.Data.DataTable allowTable1 = new System.Data.DataTable();
                                    da = new MySqlDataAdapter(allowCom1);
                                    da.Fill(allowTable1);
                                    da.Dispose();


                                    for (int x = 0; x < allowTable1.Rows.Count; x++)
                                    {
                                        //for Auto Depreciation
                                        if (allowTable1.Rows[x][0].ToString() == "AUTO DEPRECIATION")
                                            allowanceAutDepr = (double)allowTable.Rows[j][3];
                                        //Travel D/Leaders
                                        if (allowTable1.Rows[x][0].ToString() == "TRAVEL D/LEADER")
                                            travelDLeaders = (double)allowTable.Rows[j][3];
                                        //Travel C/Limit
                                        if (allowTable1.Rows[x][0].ToString() == "TRAVEL C/LIMIT")
                                            travelCLimit = (double)allowTable.Rows[j][3];
                                        //Postage Exps
                                        if (allowTable1.Rows[x][0].ToString() == "POSTAGE EXPS")
                                            postageExps = (double)allowTable.Rows[j][3];
                                        //Bicycle Allowance
                                        if (allowTable1.Rows[x][0].ToString() == "BICYCLE ALLOWANCE")
                                            bicycleAllowance = (double)allowTable.Rows[j][3];
                                    }

                                }


                                incomeTotal = salaryBasic + allowanceTotal + allowanceUtility;



                                //geting the deductions for the employee
                                string getDeduction = "select * from employeededuction where empCode = '" + Emptable.Rows[i][4].ToString() + "' and dateForDeduction = '" + payRollDate.Text + "' and statuse <> 'YES'";
                                MySqlCommand deductionCom = new MySqlCommand(getDeduction, con);

                                System.Data.DataTable deductionTable = new System.Data.DataTable();
                                da = new MySqlDataAdapter(deductionCom);
                                da.Fill(deductionTable);
                                da.Dispose();

                                double dductionTotal = 0.00;

                                for (int k = 0; k < deductionTable.Rows.Count; k++)
                                {
                                    dductionTotal += double.Parse(deductionTable.Rows[k][3].ToString());

                                    //get the name of deduction
                                    string getDeductionName = "select deductionname from deduction where deductionID = '" + deductionTable.Rows[k][2].ToString() + "'";

                                    MySqlCommand deductionCom1 = new MySqlCommand(getDeductionName, con);

                                    System.Data.DataTable deductionTable1 = new System.Data.DataTable();
                                    da = new MySqlDataAdapter(deductionCom1);
                                    da.Fill(deductionTable1);
                                    da.Dispose();


                                    for (int y = 0; y < deductionTable1.Rows.Count; y++)
                                    {
                                        if (deductionTable1.Rows[y][0].ToString() == "Maafa Fund")
                                            maafaFund = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "Food")
                                            food = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "SACCOS")
                                            SACCOS = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "Cash and Salary Advance")
                                            salaryAdvance = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "NBC Loan")
                                            NBCLoan = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "Motor Vehicle Loan")
                                            motorVehicleLoan = (double)deductionTable.Rows[k][3];

                                        if (deductionTable1.Rows[y][0].ToString() == "Furniture Loan")
                                            furnitureLoan = (double)deductionTable.Rows[k][3];


                                        if (deductionTable1.Rows[y][0].ToString() == "Saving P/ Service")
                                            personalSaving = (double)deductionTable.Rows[k][3];

                                    }

                                }



                                //check if an employee has social security fund, house rent and HESLB deduction

                                string checkStatusForDEduction = "select deductionID,percentage from employeededuction where statuse = 'YES' and dateForDeduction = '" + payRollDate.Text + "' and empCode = '" + Emptable.Rows[i][4].ToString() + "'";

                                //string checkStatusForDEduction = "select concat(fname,' ',lname),deductionID,percentage from employee join employeededuction on employee.empCode = employeededuction.empCode where employeededuction.statuse = 'YES' and employeededuction.dateForDeduction = '"+ payRollDate.Text + "'";
                                MySqlCommand deductionCom2 = new MySqlCommand(checkStatusForDEduction, con);

                                System.Data.DataTable deductionTableStatus = new System.Data.DataTable();
                                da = new MySqlDataAdapter(deductionCom2);
                                da.Fill(deductionTableStatus);
                                da.Dispose();


                                if (deductionTableStatus.Rows.Count > 0)
                                {
                                    for (int s = 0; s < deductionTableStatus.Rows.Count; s++)
                                    {
                                        //get the name of deduction
                                        string getDeductionName2 = "select deductionname from deduction where deductionID = '" + deductionTableStatus.Rows[s][0].ToString() + "'";

                                        MySqlCommand deductionCom12 = new MySqlCommand(getDeductionName2, con);

                                        System.Data.DataTable deductionTable12 = new System.Data.DataTable();
                                        da = new MySqlDataAdapter(deductionCom12);
                                        da.Fill(deductionTable12);
                                        da.Dispose();
                                        for (int p = 0; p < deductionTable12.Rows.Count; p++)
                                        {
                                            switch (deductionTable12.Rows[p][0].ToString())
                                            {

                                                case "Social Security Fund":

                                                    socialSecurityFund = incomeTotal * (double.Parse(deductionTableStatus.Rows[s][1].ToString()) / 100);

                                                    break;

                                                case "House Rent":
                                                    houseRent = salaryBasic * (double.Parse(deductionTableStatus.Rows[s][1].ToString()) / 100);
                                                    break;

                                                case "HESLB Loan 15%":
                                                    HESLBLoan = salaryBasic * (double.Parse(deductionTableStatus.Rows[s][1].ToString()) / 100);
                                                    break;

                                                case "Deduction On Account":

                                                    deductionOnAccount = salaryBasic * (double.Parse(deductionTableStatus.Rows[s][1].ToString()) / 100);
                                                    break;

                                                case "NHIF":
                                                    NHIF = salaryBasic * (double.Parse(deductionTableStatus.Rows[s][1].ToString()) / 100);
                                                    break;

                                                default:

                                                    break;
                                            }

                                        }

                                    }
                                }

                                incomeTaxable = salaryBasic + allowanceUtility - socialSecurityFund;
                                if (Emptable.Rows[i][17].ToString() == "TOTAL INCOME")
                                    tithe = incomeTotal * 0.1;
                                else
                                    tithe = salaryBasic * 0.1;

                                if (incomeTaxable < 170000)
                                    i_Tax = 0;
                                if (incomeTaxable < 360000)
                                    i_Tax = 0.09 * (incomeTaxable - 170000);
                                if (incomeTaxable < 540000)
                                    i_Tax = 17100 + 0.2 * (incomeTaxable - 360000);
                                if (incomeTaxable < 720000)
                                    i_Tax = 53100 + 0.25 * (incomeTaxable - 540000);
                                else
                                    i_Tax = 98100 + 0.3 * (incomeTaxable - 720000);


                                deductionTotal = dductionTotal + socialSecurityFund + deductionOnAccount + HESLBLoan + houseRent + NHIF + tithe + i_Tax;

                                salaryNet = incomeTotal - deductionTotal;

                                refund_iTax = i_Tax * 0.9;

                                payNet = salaryNet + refund_iTax;

                                string empFullName = Emptable.Rows[i][1] + " " + Emptable.Rows[i][2] + " " + Emptable.Rows[i][3];
                                string values = "values('" + payRollDate.Text + "','" + empFullName + "','" + Emptable.Rows[i][4] + "','" + Emptable.Rows[i][5] +
                                    "', '" + Emptable.Rows[i][7] + "','" + Emptable.Rows[i][8].ToString() + "','" + Emptable.Rows[i][9].ToString() + "','" + Emptable.Rows[i][13] +
                                    "', '" + Emptable.Rows[i][14] + "','" + salaryBasic + "','" + allowanceAutDepr + "','" + bicycleAllowance + "','" + travelDLeaders + "','" + travelCLimit + "','" + postageExps +
                                    "','" + allowanceUtility + "','" + incomeTotal + "','" + incomeTaxable + "','" + tithe +
                                    "','" + i_Tax + "','" + socialSecurityFund + "','" + houseRent + "','" + maafaFund + "','" + food + "','" + SACCOS + "','" + salaryAdvance + "','" + NBCLoan +
                                    "','" + motorVehicleLoan + "','" + furnitureLoan + "','" + HESLBLoan + "','" + deductionOnAccount + "','" + personalSaving + "','" + NHIF + "','" + salaryNet +
                                    "','" + refund_iTax + "','" + payNet + "','" + Emptable.Rows[i][12] + "', '" + Emptable.Rows[i][10] + "','" + deductionTotal + "')";
                                string insertPayRoll = "insert into payRoll(dateGenerated,empFullName,empCode," +
                                   " deptCode,salaryCategory,ScaleBase,scalePercent,bankAccount,bankName,salaryBasic," +
                                   "allowanceAutoDepr,allowanceBicycle,LeadertravelAll,cLimitTravel,postageExps," +
                                   "allowanceUtility,incomeTotal,incomeTaxable,tithe,iTax,socialSecurityFund,Houserent," +
                                   "MaafaFund,food,SACCOS,cashAndSalaryAdvance,NBC,motorVehicleLoan,furnitureLoan," +
                                   "HESLB,deductionOnReport,personalServing,NHIF,salaryNet,refunDiTax," +
                                   "payNet,position,email,totalDeduction) " + values;

                                using (MySqlCommand generatePayR = new MySqlCommand(insertPayRoll, con))
                                {
                                    rd = generatePayR.ExecuteReader();
                                    rd.Close();
                                }
                            }

                            Login.RecordUserActivity("Genarated the payroll");
                            //show the Pay-Roll
                            getGeneratedPayRoll();
                        }

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Clone();
            }

        }

        private void getGeneratedPayRoll()
        {
            using (MySqlConnection con = new MySqlConnection())
            {


                con.ConnectionString = Home.DBconnection;

                string loadPayRoll = "select empFullName 'Employee Name',empCode 'Employee ID'," +
                               " deptCode 'Depertment ID',salaryCategory 'Salary Category',ScaleBase 'Scale Base',scalePercent 'Scale Percent',bankAccount 'Bank Account',bankName 'Bank Name',salaryBasic 'Salary Basic'," +
                               "allowanceAutoDepr 'Allowance Depression',allowanceBicycle 'Allowance Bicycle',LeadertravelAll 'Leader Travel Allowance',cLimitTravel 'Travel C/Limit', postageExps 'Postage Exps'," +
                               "allowanceUtility 'Allowance Utility',IncomeTaxable 'Income Taxable',tithe 'Tithe',iTax 'i/Tax',socialSecurityFund 'Social Security Fund',Houserent 'House Rent'," +
                               "MaafaFund 'Maafa Fund',food 'Food',SACCOS,cashAndSalaryAdvance 'Cash/Salary Advance',NBC,motorVehicleLoan 'Motor Vehicle Loan',furnitureLoan 'Furniture Loan'," +
                               "HESLB 'HESLB 15%',deductionOnReport 'Deduction on Report',personalServing 'Personal Serving',NHIF,salaryNet 'Sarary Net',refunDiTax 'Refund Tax'," +
                               "payNet 'Pay Net',position Position,email 'Employee Email' from payroll where dateGenerated = '" + payRollDate.Text + "'";

                MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

               

                System.Data.DataTable payRollTable = new System.Data.DataTable();

                try
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(payroll))
                    {
                        da.Fill(payRollTable);
                        da.Dispose();

                        for (int i = 0; i < payRollTable.Columns.Count; i++)
                        {
                            try
                            {
                                payRollDataGrid.Columns[i].DefaultCellStyle.Format = "N2";
                            }
                            catch
                            {

                            }

                        }

                        payRollDataGrid.DataSource = payRollTable;

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }

        }
        private void generatePayRollBtn_Click(object sender, EventArgs e)
        {
            
            calculationAndGeneration();   
        }


        //save to excel function

        SaveFileDialog save;
        private void SavePayRoll()
        {
            save = new SaveFileDialog();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = Home.DBconnection;

                string loadPayRoll = "select empFullName,empCode,deptCode,salaryCategory," +
                    "scaleBase,Scalepercent,bankAccount,bankNAme,salaryBasic,allowanceAutoDepr," +
                    "allowanceBicycle,LeaderTravelAll,cLimitTravel,postageExps,allowanceUtility," +
                    "incomeTotal,incomeTaxable, tithe, itax,socialsecurityFund,HouseRent,MaafaFund," +
                    "food, saccos, cashAndSalaryAdvance,NBC,motorvehicleLoan,furnitureLoan,HESLB," +
                    "deductionOnReport, personalServing,NHIF,totalDeduction, SalaryNet, refunditax," +
                    "paynet,position,email from payroll where dateGenerated = '" + payRollDate.Text + "'";

                MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

               

                System.Data.DataTable payRollTable = new System.Data.DataTable();

                try
                {
                    con.Open();
                    using (MySqlDataAdapter da = new MySqlDataAdapter(payroll))
                    {

                        da.Fill(payRollTable);
                        da.Dispose();

                        if (payRollTable.Rows.Count > 0)
                        {
                            save.FileName = payRollDate.Text + " PayRoll";
                            save.DefaultExt = ".xlsx";
                            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SEC PayRoll Records";

                            if (save.ShowDialog() == DialogResult.OK)
                            {
                                ws.Cells[1, 1] = "Employee Name";
                                ws.Cells[1, 2] = "Employee ID";
                                ws.Cells[1, 3] = "Depertment ID";
                                ws.Cells[1, 4] = "Salary Category";
                                ws.Cells[1, 5] = "Scale Base";
                                ws.Cells[1, 6] = "Scale Percent";
                                ws.Cells[1, 7] = "Bank Account";
                                ws.Cells[1, 8] = "Bank Name";
                                ws.Cells[1, 9] = "Salary Basic";
                                ws.Cells[1, 10] = "Allowance Depression";
                                ws.Cells[1, 11] = "Allowance Bicycle";
                                ws.Cells[1, 12] = "Leader Travel Allowance";
                                ws.Cells[1, 13] = "Travel C/Limit";
                                ws.Cells[1, 14] = "Postage Exps";
                                ws.Cells[1, 15] = "Allowance Utility";
                                ws.Cells[1, 16] = "Income Total";
                                ws.Cells[1, 17] = "Income Taxable";
                                ws.Cells[1, 18] = "Tithe";
                                ws.Cells[1, 19] = "i/Tax";
                                ws.Cells[1, 20] = "Social Security Fund";
                                ws.Cells[1, 21] = "House Rent";
                                ws.Cells[1, 22] = "Maafa Fund";
                                ws.Cells[1, 23] = "Food";
                                ws.Cells[1, 24] = "SACCOS";
                                ws.Cells[1, 25] = "Cash/Salary Advance";
                                ws.Cells[1, 26] = "NBC Loan";
                                ws.Cells[1, 27] = "Motor Vehicle Loan";
                                ws.Cells[1, 28] = "Furniture Loan";
                                ws.Cells[1, 29] = "HESLB Loan";
                                ws.Cells[1, 30] = "Deduction On Report";
                                ws.Cells[1, 31] = "Personal Serving";
                                ws.Cells[1, 32] = "NHIF";
                                ws.Cells[1, 33] = "Total Deductions";
                                ws.Cells[1, 34] = "Salary Net";
                                ws.Cells[1, 35] = "Refund i/Tax";
                                ws.Cells[1, 36] = "Pay Net";
                                ws.Cells[1, 37] = "Position";
                                ws.Cells[1, 38] = "Employee Email";

                                //to insert the data to the sheet
                                for (int row = 1; row <= payRollTable.Rows.Count; row++)
                                {
                                    for (int col = 0; col < payRollTable.Columns.Count; col++)
                                    {
                                        ws.Cells[row + 1, col + 1] = payRollTable.Rows[row - 1][col].ToString();
                                    }

                                }
                                ws.SaveAs(save.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                                excel.Quit();

                            }

                        }
                        else
                        {
                            MessageBox.Show("Sorry, Something Went Wrong.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();

            }
            
        }


        private void savePayRollBtn_Click(object sender, EventArgs e)
        {
            SavePayRoll();
        }


    }
}
