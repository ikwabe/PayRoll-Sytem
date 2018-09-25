using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Sytem
{
    public partial class AllowanceAndDeductionForm : Form
    {
        public AllowanceAndDeductionForm()
        {
            this.ShowInTaskbar = false;
            InitializeComponent();
        }

        private void allowanceBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = allowanceBtn.Left;
            lineSp.Width = allowanceBtn.Width;
            deductionBtn.Textcolor = Color.LightGray;
            allowanceBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the allowance child control to this form
            panel4.Controls.Add(AllowanceTab.Instance);
            AllowanceTab.Instance.Dock = DockStyle.Fill;
            AllowanceTab.Instance.BringToFront();
            deductionTab.Instance.Visible = false;
            AllowanceTab.Instance.Visible = true;
            

        }

        private void deductionBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = deductionBtn.Left;
            lineSp.Width = deductionBtn.Width;
            allowanceBtn.Textcolor = Color.LightGray;
            deductionBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the allowance child control to this form
            panel4.Controls.Add(deductionTab.Instance);
            deductionTab.Instance.Dock = DockStyle.Fill;
            deductionTab.Instance.BringToFront();
            AllowanceTab.Instance.Visible = false;
            deductionTab.Instance.Visible = true;


        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //Application.Exit();
                this.Close();
        }

        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.WindowState = FormWindowState.Minimized;
        }

        private void AllowanceAndDeductionForm_Load(object sender, EventArgs e)
        {
            lineSp.Left = allowanceBtn.Left;
            lineSp.Width = allowanceBtn.Width;
            deductionBtn.Textcolor = Color.LightGray;
            allowanceBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the allowance child control to this form
            panel4.Controls.Add(AllowanceTab.Instance);
            AllowanceTab.Instance.Dock = DockStyle.Fill;
            AllowanceTab.Instance.BringToFront();
            deductionTab.Instance.Visible = false;
            AllowanceTab.Instance.Visible = true;
        }
    }
}
