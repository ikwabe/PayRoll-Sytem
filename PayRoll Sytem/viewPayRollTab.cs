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

            DataTable payRollTable = new DataTable();

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
    }
}
