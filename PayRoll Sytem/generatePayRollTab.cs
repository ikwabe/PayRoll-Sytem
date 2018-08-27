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
            payRollDate.MinDate = DateTime.Now;
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
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string getEmployeeDetails = "select * from employee";

            //checking if the payroll is present
            string checkThePayroll = "select dateGenerated from payRoll where dateGenerated = '" + payRollDate.Text + "'";
            MySqlCommand CheckPayrol = new MySqlCommand(checkThePayroll, con);
           
            DataTable tab = new DataTable();

            MySqlCommand EmployeeCom = new MySqlCommand(getEmployeeDetails, con);
            
            MySqlDataAdapter da;

            MySqlDataReader rd;
            DataTable Emptable = new DataTable();
            
            try
            {
                con.Open();

                da = new MySqlDataAdapter(CheckPayrol);
                da.Fill(tab);
                da.Dispose();

                if (tab.Rows.Count > 0)
                {
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
                            salaryBasic = double.Parse(Emptable.Rows[i][8].ToString()) * (double.Parse(Emptable.Rows[i][9].ToString()) / 100);
                            allowanceUtility = salaryBasic * 1.5 / 12;

                            //geting the allowances for the employee
                            string getAllowance = "select * from employeeallowance where empCode = '" + Emptable.Rows[i][4] + "'";
                            MySqlCommand allowCom = new MySqlCommand(getAllowance, con);

                            DataTable allowTable = new DataTable();
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

                                DataTable allowTable1 = new DataTable();
                                da = new MySqlDataAdapter(allowCom1);
                                da.Fill(allowTable1);
                                da.Dispose();

                                //for Auto Depreciation
                                if (allowTable1.Rows[j][0].ToString() == "AUTO DEPRECIATION")
                                    allowanceAutDepr = (double)allowTable.Rows[j][3];
                                //Travel D/Leaders
                                if(allowTable1.Rows[j][0].ToString() == "TRAVEL D/LEADER")
                                    travelDLeaders = (double)allowTable.Rows[j][3];
                                //Travel C/Limit
                                if (allowTable1.Rows[j][0].ToString() == "TRAVEL C/LIMIT")
                                    travelCLimit = (double)allowTable.Rows[j][3];
                                //Postage Exps
                                if (allowTable1.Rows[j][0].ToString() == "POSTAGE EXPS")
                                    postageExps = (double)allowTable.Rows[j][3];
                                //Bicycle Allowance
                                if (allowTable1.Rows[j][0].ToString() == "BICYCLE ALLOWANCE")
                                    bicycleAllowance = (double)allowTable.Rows[j][3];

                            }


                            incomeTotal = salaryBasic + allowanceTotal + allowanceUtility;

                            //geting the deductions for the employee
                            string getDeduction = "select * from employeededuction where empCode = '" + Emptable.Rows[i][4] + "' and dateForDeduction = '"+payRollDate.Text+ "' or deductiontype = 'CONSTANT'";
                            MySqlCommand deductionCom = new MySqlCommand(getDeduction, con);

                            DataTable deductionTable = new DataTable();
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

                                DataTable deductionTable1 = new DataTable();
                                da = new MySqlDataAdapter(deductionCom1);
                                da.Fill(deductionTable1);
                                da.Dispose();


                                for(int y = 0; y< deductionTable1.Rows.Count; y++)
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

                            string checkStatusForDEduction = "select deductionID,percentage from employeededuction where statuse = 'YES' and dateForDeduction = '" + payRollDate.Text + "' ";

                            MySqlCommand deductionCom2 = new MySqlCommand(checkStatusForDEduction, con);

                            DataTable deductionTableStatus = new DataTable();
                            da = new MySqlDataAdapter(deductionCom2);
                            da.Fill(deductionTableStatus);
                            da.Dispose();

                           
                            if(deductionTableStatus.Rows.Count > 0)
                            {
                                for(int s =0; s< deductionTableStatus.Rows.Count; s++)
                                {
                                    //get the name of deduction
                                    string getDeductionName2 = "select deductionname from deduction where deductionID = '" + deductionTableStatus.Rows[s][0].ToString() + "'";

                                    MySqlCommand deductionCom12 = new MySqlCommand(getDeductionName2, con);

                                    DataTable deductionTable12 = new DataTable();
                                    da = new MySqlDataAdapter(deductionCom12);
                                    da.Fill(deductionTable12);
                                    da.Dispose();
                                    for(int p = 0; p< deductionTable12.Rows.Count; p++)
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

                            tithe = incomeTotal * 0.1;

                           
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
                                "', '" + Emptable.Rows[i][14] + "','" + salaryBasic + "','"+allowanceAutDepr+"','"+bicycleAllowance+"','"+travelDLeaders+"','"+travelCLimit+"','"+postageExps+
                                "','" + allowanceUtility + "','"+incomeTotal+"','" + incomeTaxable + "','" + tithe +
                                "','" + i_Tax + "','"+socialSecurityFund+"','" + houseRent + "','"+maafaFund+"','"+food+"','"+SACCOS+"','"+salaryAdvance+"','"+NBCLoan+
                                "','"+motorVehicleLoan+"','"+furnitureLoan+"','" + HESLBLoan + "','"+deductionOnAccount+"','"+personalSaving+"','" + NHIF + "','" + salaryNet +
                                "','" + refund_iTax + "','" + payNet + "','" + Emptable.Rows[i][12] + "', '" + Emptable.Rows[i][10] + "','"+deductionTotal+"')";
                            string insertPayRoll = "insert into payRoll(dateGenerated,empFullName,empCode," +
                               " deptCode,salaryCategory,ScaleBase,scalePercent,bankAccount,bankName,salaryBasic," +
                               "allowanceAutoDepr,allowanceBicycle,LeadertravelAll,cLimitTravel,postageExps," +
                               "allowanceUtility,incomeTotal,incomeTaxable,tithe,iTax,socialSecurityFund,Houserent," +
                               "MaafaFund,food,SACCOS,cashAndSalaryAdvance,NBC,motorVehicleLoan,furnitureLoan," +
                               "HESLB,deductionOnReport,personalServing,NHIF,salaryNet,refunDiTax," +
                               "payNet,position,email,totalDeduction) " + values;

                            MySqlCommand generatePayR = new MySqlCommand(insertPayRoll, con);

                            rd = generatePayR.ExecuteReader();
                            rd.Close();
                            Login.RecordUserActivity("Genarated the payroll");
                            resetVariables();
                        }

                        //show the Pay-Roll
                        getGeneratedPayRoll();
                    }
                    
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void getGeneratedPayRoll()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadPayRoll = "select empFullName 'Employee Name',empCode 'Employee ID'," +
                           " deptCode 'Depertment ID',salaryCategory 'Salary Category',ScaleBase 'Scale Base',scalePercent 'Scale Percent',bankAccount 'Bank Account',bankName 'Bank Name',salaryBasic 'Salary Basic'," +
                           "allowanceAutoDepr 'Allowance Depression',allowanceBicycle 'Allowance Bicycle',LeadertravelAll 'Leader Travel Allowance',cLimitTravel 'Travel C/Limit', postageExps 'Postage Exps'," +
                           "allowanceUtility 'Allowance Utility',IncomeTaxable 'Income Taxable',tithe 'Tithe',iTax 'i/Tax',socialSecurityFund 'Social Security Fund',Houserent 'House Rent'," +
                           "MaafaFund 'Maafa Fund',food 'Food',SACCOS,cashAndSalaryAdvance 'Cash/Salary Advance',NBC,motorVehicleLoan 'Motor Vehicle Loan',furnitureLoan 'Furniture Loan'," +
                           "HESLB 'HESLB 15%',deductionOnReport 'Deduction on Report',personalServing 'Personal Serving',NHIF,salaryNet 'Sarary Net',refunDiTax 'Refund Tax'," +
                           "payNet 'Pay Net',position Position,email 'Employee Email' from payroll where dateGenerated = '"+payRollDate.Text+"'";

            MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

            MySqlDataAdapter da;

            DataTable payRollTable = new DataTable();

            try
            {
                da = new MySqlDataAdapter(payroll);
                da.Fill(payRollTable);
                da.Dispose();

                for(int i = 0; i< payRollTable.Columns.Count; i++)
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void generatePayRollBtn_Click(object sender, EventArgs e)
        {
            
            calculationAndGeneration();   
        }
    }
}
