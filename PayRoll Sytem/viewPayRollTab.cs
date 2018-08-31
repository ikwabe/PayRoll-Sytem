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
    public partial class viewPayRollTab : UserControl
    {
        public static viewPayRollTab _instance;
        public static viewPayRollTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new viewPayRollTab();
                return _instance;
            }
        }
        public viewPayRollTab()
        {
            InitializeComponent();
        }

        private void viewPayRollTab_Load(object sender, EventArgs e)
        {
            payRollDate.CustomFormat = "MMMM yyyy";
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
                           "payNet 'Pay Net',position Position,email 'Employee Email' from payroll where dateGenerated = '" + payRollDate.Text + "'";

            MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

            MySqlDataAdapter da;

            System.Data.DataTable payRollTable = new System.Data.DataTable();

            try
            {

                da = new MySqlDataAdapter(payroll);
                da.Fill(payRollTable);
                da.Dispose();


                if(payRollTable.Rows.Count > 0)
                {

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
                    Login.RecordUserActivity("Viewed the payroll");

                }
                else
                {

                    MessageBox.Show("The Payroll is not Found.");

                }
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            }


        }



        private void viewPayRollBtn_Click(object sender, EventArgs e)
        {

            getGeneratedPayRoll();
            
        }

        //save to excel function

        SaveFileDialog save;
        private void SavePayRoll()
        {
            save = new SaveFileDialog();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            string loadPayRoll = "select empFullName,empCode,deptCode,salaryCategory," +
                "scaleBase,Scalepercent,bankAccount,bankNAme,salaryBasic,allowanceAutoDepr," +
                "allowanceBicycle,LeaderTravelAll,cLimitTravel,postageExps,allowanceUtility," +
                "incomeTotal,incomeTaxable, tithe, itax,socialsecurityFund,HouseRent,MaafaFund," +
                "food, saccos, cashAndSalaryAdvance,NBC,motorvehicleLoan,furnitureLoan,HESLB," +
                "deductionOnReport, personalServing,NHIF,totalDeduction, SalaryNet, refunditax," +
                "paynet,position,email from payroll where dateGenerated = '" + payRollDate.Text + "'";

            MySqlCommand payroll = new MySqlCommand(loadPayRoll, con);

            MySqlDataAdapter da;

            System.Data.DataTable payRollTable = new System.Data.DataTable();

            try
            {
                con.Open();
                da = new MySqlDataAdapter(payroll);
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
        private void saveAsPayRollBtn_Click(object sender, EventArgs e)
        {
            SavePayRoll();
        }
    }
}
