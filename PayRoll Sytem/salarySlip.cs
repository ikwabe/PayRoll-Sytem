using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Web;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
namespace PayRoll_Sytem
{
    class salarySlip
    {
        //the function to create the salary slip
        public static void PreapareSalarySlip(string name, string ID, string category,
            string position, string scale,
            string scaleBase, string yearOffService,
            string date, string basecSalary, string autoD, string Bicycle,
            string travelDleader, string travelClimit,
            string postageExp, string utilityAllaw,
            string totalInco, string taxableInc, string incmeTax,
            string titheE, string socialFund,
            string houseeRent, string maafaFud,
            string foodd, string saccos, string salaryAdd,
            string NBCLoans, string HESLB, string Furniture,
            string motorVehicle, string OnAccountDed, string personalSave,
            string NHIFs, string totalDedu, string IncBefore,
            string taxRef, string IncAft)
        {

            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\Shadrack Ikwabe\Pictures\LOGO\Church_logo.png");
            img.ScaleAbsolute(10f, 60f);


            //the table for image
            PdfPTable table = new PdfPTable(1);
            table.DefaultCell.BorderWidth = 0;
            table.WidthPercentage = 30;
            table.PaddingTop = 0;
            table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //table for Heading
            PdfPTable slp = new PdfPTable(1);
            slp.DefaultCell.BorderWidth = 0;
            slp.WidthPercentage = 100;
            slp.PaddingTop = 10;
            slp.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;


            //heading
            Chunk slptxt = new Chunk("SALARY SLIP", FontFactory.GetFont("Arial", 14, BaseColor.DARK_GRAY));
            slptxt.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            //table for Employee particulars
            PdfPTable table1 = new PdfPTable(3);
            table1.DefaultCell.BorderWidth = 0;
            table1.DefaultCell.Padding = 5;
            table1.WidthPercentage = 90;
            table1.PaddingTop = 0;
            table1.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            //table for separator
            PdfPTable Separator = new PdfPTable(1);
            Separator.DefaultCell.BorderWidth = 0;
            Separator.DefaultCell.Padding = 0;
            Separator.WidthPercentage = 90;
            Separator.PaddingTop = 0;
            Separator.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;



            //table for Tsh
            PdfPTable Tsh = new PdfPTable(3);
            Tsh.DefaultCell.BorderWidth = 0;
            Tsh.DefaultCell.Padding = 2;
            Tsh.DefaultCell.PaddingBottom = 4;
            Tsh.WidthPercentage = 90;
            Tsh.PaddingTop = 1;
            Tsh.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //table for income
            PdfPTable incomeTitle = new PdfPTable(1);
            incomeTitle.DefaultCell.BorderWidth = 0.5f;
            incomeTitle.DefaultCell.PaddingBottom = 4;
            incomeTitle.WidthPercentage = 90;
            incomeTitle.PaddingTop = 2;
            incomeTitle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable incomeTable = new PdfPTable(3);
            incomeTable.DefaultCell.BorderWidth = 0.5f;
            incomeTable.DefaultCell.Padding = 1;
            incomeTable.DefaultCell.PaddingBottom = 4;
            incomeTable.WidthPercentage = 90;
            incomeTable.DefaultCell.PaddingLeft = 20;
            incomeTable.PaddingTop = 0;
            incomeTable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable totaInc = new PdfPTable(3);
            totaInc.DefaultCell.BorderWidth = 0.5f;
            totaInc.DefaultCell.Padding = 1;
            totaInc.DefaultCell.PaddingBottom = 4;
            totaInc.DefaultCell.PaddingRight = 4;
            totaInc.WidthPercentage = 90;
            totaInc.PaddingTop = 0;

            totaInc.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;


            //table for tax Deduction
            PdfPTable taxDeductionTitle = new PdfPTable(1);
            taxDeductionTitle.DefaultCell.BorderWidth = 0.5f;
            taxDeductionTitle.DefaultCell.PaddingBottom = 4;
            taxDeductionTitle.WidthPercentage = 90;
            taxDeductionTitle.PaddingTop = 2;
            taxDeductionTitle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable taxDeduction = new PdfPTable(3);
            taxDeduction.DefaultCell.BorderWidth = 0.5f;
            taxDeduction.DefaultCell.Padding = 1;
            taxDeduction.DefaultCell.PaddingBottom = 4;
            taxDeduction.WidthPercentage = 90;
            taxDeduction.DefaultCell.PaddingLeft = 20;
            taxDeduction.PaddingTop = 0;
            taxDeduction.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;


            PdfPTable otherDeductionTitle = new PdfPTable(1);
            otherDeductionTitle.DefaultCell.BorderWidth = 0.5f;
            otherDeductionTitle.DefaultCell.PaddingBottom = 4;
            otherDeductionTitle.WidthPercentage = 90;
            otherDeductionTitle.PaddingTop = 2;
            otherDeductionTitle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable OtherDeduction = new PdfPTable(3);
            OtherDeduction.DefaultCell.BorderWidth = 0.5f;
            OtherDeduction.DefaultCell.Padding = 1;
            OtherDeduction.DefaultCell.PaddingBottom = 4;
            OtherDeduction.WidthPercentage = 90;
            OtherDeduction.DefaultCell.PaddingLeft = 20;
            OtherDeduction.PaddingTop = 0;
            OtherDeduction.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPTable totaDeduc = new PdfPTable(3);
            totaDeduc.DefaultCell.BorderWidth = 0.5f;
            totaDeduc.DefaultCell.Padding = 1;
            totaDeduc.DefaultCell.PaddingBottom = 4;
            totaDeduc.DefaultCell.PaddingRight = 4;
            totaDeduc.WidthPercentage = 90;
            totaDeduc.PaddingTop = 0;

            totaDeduc.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;


            //Tsh Chunk
            Chunk tsh = new Chunk("    ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            //Tsh Chunk
            Chunk tsh1 = new Chunk("Tsh", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            tsh1.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);
            //Separator line
            Chunk separator = new Chunk("--------------------------------------------------------------------------------------------------------------------------------", FontFactory.GetFont("Arial", 12, BaseColor.BLACK));

            //emp particulars
            Chunk Name = new Chunk("Name: " + name.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk accID = new Chunk("Acct ID: " + ID.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk Category = new Chunk("Category: " + category.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk Position = new Chunk("Position: " + position.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk Scale = new Chunk("Sacle%: " + scale.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk ScaleBase = new Chunk("ScaleBase: " + scaleBase.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk yearOfService = new Chunk("Year Of Service: " + yearOffService.ToUpper(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk Date = new Chunk("Date: " + DateTime.Now.ToShortDateString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK));

            //Income Paticulars
            Chunk income = new Chunk("INCOME: ", FontFactory.GetFont("Arial", 12, BaseColor.BLACK));
            income.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk basicSalary = new Chunk("Basic Salary", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk autoDepre = new Chunk("Auto Depreciation", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk bicycleAllowance = new Chunk("Bicycle Allowance", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk TravelClimit = new Chunk("Travel C/Limit", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk postageExps = new Chunk("Postage Exps", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk utilityAllowance = new Chunk("Utility Allowance", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk travelDLeader = new Chunk("Travel D/Leaders", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));

            Chunk totalIncome = new Chunk("TOTAL INCOME: ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            totalIncome.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);


            //Deduction Paticulars
            Chunk taxdeduction = new Chunk("TAX DEDUCTIONS: ", FontFactory.GetFont("Arial", 12, BaseColor.BLACK));
            taxdeduction.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk taxableIncome = new Chunk("Taxable Income", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk incomeTax = new Chunk("Income Tax", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));

            Chunk otherdeductionTitle = new Chunk("OTHER DEDUCTIONS: ", FontFactory.GetFont("Arial", 12, BaseColor.BLACK));
            otherdeductionTitle.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk tithe = new Chunk("Tithe ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk SocialFund = new Chunk("Social Fund", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk houseRent = new Chunk("House Rent", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk maafaFund = new Chunk("Maafa Fund", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk food = new Chunk("Food", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk SACCOS = new Chunk("SACCOS", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk salaryAdvance = new Chunk("Salary Advance", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk NBCLoan = new Chunk("NBC Loan", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk higherEducationLoan = new Chunk("Higher Education Loan (HESLB)", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk furnitureLoan = new Chunk("Furniture Loan", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk MotorVehicleLoan = new Chunk("Motor Vehicle Loan", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk OnAccountDeduction = new Chunk("On Account Deduction", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk personalServing = new Chunk("Personal Serving", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            Chunk NHIF = new Chunk("NHIF", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));

            Chunk totalDeduct = new Chunk("TOTAL DEDUCTIONS: ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            totalDeduct.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk netIncBefore = new Chunk("Net Income Before Tax Refund ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            netIncBefore.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk taxrefund = new Chunk("Tax Refund ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            taxrefund.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);

            Chunk netIncAfter = new Chunk("Net Income After Tax Refund ", FontFactory.GetFont("Arial", 10, BaseColor.BLACK));
            netIncAfter.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD);


            //adding Data to the tables
            table.AddCell(img);

            slp.AddCell(new Phrase(slptxt));

            table1.AddCell(new Phrase(Name));
            table1.AddCell(new Phrase(accID));
            table1.AddCell(new Phrase(Category));
            table1.AddCell(new Phrase(Position));
            table1.AddCell(new Phrase(Scale));
            table1.AddCell(new Phrase(ScaleBase));
            table1.AddCell(new Phrase(yearOfService));
            table1.AddCell(new Phrase(Date));
            table1.AddCell(new Phrase(" "));



            Tsh.AddCell(new Phrase(tsh));
            Tsh.AddCell(new Phrase(tsh1));
            Tsh.AddCell(new Phrase(tsh1));

            Separator.AddCell(new Phrase(separator));

            incomeTitle.AddCell(new Phrase(income));
            incomeTable.AddCell(new Phrase(basicSalary));
            incomeTable.AddCell(new Phrase(basecSalary));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(autoDepre));
            incomeTable.AddCell(new Phrase(autoD));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(bicycleAllowance));
            incomeTable.AddCell(new Phrase(Bicycle));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(travelDLeader));
            incomeTable.AddCell(new Phrase(travelDleader));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(TravelClimit));
            incomeTable.AddCell(new Phrase(travelClimit));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(postageExps));
            incomeTable.AddCell(new Phrase(postageExp));
            incomeTable.AddCell(new Phrase(" "));
            incomeTable.AddCell(new Phrase(utilityAllowance));
            incomeTable.AddCell(new Phrase(utilityAllaw));
            incomeTable.AddCell(new Phrase(" "));

            totaInc.AddCell(" ");
            totaInc.AddCell(new Phrase(totalIncome));
            totaInc.AddCell(new Phrase(totalInco));

            taxDeductionTitle.AddCell(new Phrase(taxdeduction));
            taxDeduction.AddCell(new Phrase(taxableIncome));
            taxDeduction.AddCell(new Phrase(taxableInc));
            taxDeduction.AddCell(new Phrase(" "));
            taxDeduction.AddCell(new Phrase(incomeTax));
            taxDeduction.AddCell(new Phrase(incmeTax));
            taxDeduction.AddCell(new Phrase(" "));

            otherDeductionTitle.AddCell(new Phrase(otherdeductionTitle));

            OtherDeduction.AddCell(new Phrase(tithe));
            OtherDeduction.AddCell(new Phrase(titheE));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(SocialFund));
            OtherDeduction.AddCell(new Phrase(socialFund));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(houseRent));
            OtherDeduction.AddCell(new Phrase(houseeRent));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(maafaFund));
            OtherDeduction.AddCell(new Phrase(maafaFud));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(food));
            OtherDeduction.AddCell(new Phrase(foodd));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(SACCOS));
            OtherDeduction.AddCell(new Phrase(saccos));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(salaryAdvance));
            OtherDeduction.AddCell(new Phrase(salaryAdd));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(NBCLoan));
            OtherDeduction.AddCell(new Phrase(NBCLoans));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(higherEducationLoan));
            OtherDeduction.AddCell(new Phrase(HESLB));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(furnitureLoan));
            OtherDeduction.AddCell(new Phrase(Furniture));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(MotorVehicleLoan));
            OtherDeduction.AddCell(new Phrase(motorVehicle));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(OnAccountDeduction));
            OtherDeduction.AddCell(new Phrase(OnAccountDed));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(personalServing));
            OtherDeduction.AddCell(new Phrase(personalSave));
            OtherDeduction.AddCell(new Phrase(" "));
            OtherDeduction.AddCell(new Phrase(NHIF));
            OtherDeduction.AddCell(new Phrase(NHIFs));
            OtherDeduction.AddCell(new Phrase(" "));

            totaDeduc.AddCell(" ");
            totaDeduc.AddCell(new Phrase(totalDeduct));
            totaDeduc.AddCell(new Phrase(totalDedu));

            totaDeduc.AddCell(" ");
            totaDeduc.AddCell(new Phrase(netIncBefore));
            totaDeduc.AddCell(new Phrase(IncBefore));

            totaDeduc.AddCell(" ");
            totaDeduc.AddCell(new Phrase(taxrefund));
            totaDeduc.AddCell(new Phrase(taxRef));

            totaDeduc.AddCell(" ");
            totaDeduc.AddCell(new Phrase(netIncAfter));
            totaDeduc.AddCell(new Phrase(IncAft));



            using (FileStream file = new FileStream("C:/Users/" + Environment.UserName + "/AppData/Roaming/SEC Payroll/Receipts/receipt.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(pdfDoc, file);

                pdfDoc.Open();
                pdfDoc.Add(table);
                pdfDoc.Add(slp);
                pdfDoc.Add(Separator);

                pdfDoc.Add(table1);
                pdfDoc.Add(Separator);
                pdfDoc.Add(Tsh);
                pdfDoc.Add(incomeTitle);
                pdfDoc.Add(incomeTable);
                pdfDoc.Add(totaInc);
                pdfDoc.Add(taxDeductionTitle);
                pdfDoc.Add(taxDeduction);
                pdfDoc.Add(otherDeductionTitle);
                pdfDoc.Add(OtherDeduction);
                pdfDoc.Add(totaDeduc);
                pdfDoc.Close();
                file.Close();
            }


        }
    }
}
