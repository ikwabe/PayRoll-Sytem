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
    public partial class PayRollForm : Form
    {
        public PayRollForm()
        {
            this.ShowInTaskbar = false;
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

        private void generatePayRollBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = generatePayRollBtn.Left;
            lineSp.Width = generatePayRollBtn.Width;
            viewPayRollBtn.Textcolor = Color.LightGray;
            generatePayRollBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(generatePayRollTab.Instance);
            generatePayRollTab.Instance.Dock = DockStyle.Fill;
            generatePayRollTab.Instance.BringToFront();
            viewPayRollTab.Instance.Visible = false;
            generatePayRollTab.Instance.Visible = true;
        }

        private void viewPayRollBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = viewPayRollBtn.Left;
            lineSp.Width = viewPayRollBtn.Width;
            generatePayRollBtn.Textcolor = Color.LightGray;
            viewPayRollBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(viewPayRollTab.Instance);
            viewPayRollTab.Instance.Dock = DockStyle.Fill;
            viewPayRollTab.Instance.BringToFront();
            generatePayRollTab.Instance.Visible = false;
            viewPayRollTab.Instance.Visible = true;
        }

        private void PayRollForm_Load(object sender, EventArgs e)
        {
            lineSp.Left = generatePayRollBtn.Left;
            lineSp.Width = generatePayRollBtn.Width;
            viewPayRollBtn.Textcolor = Color.LightGray;
            generatePayRollBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(generatePayRollTab.Instance);
            generatePayRollTab.Instance.Dock = DockStyle.Fill;
            generatePayRollTab.Instance.BringToFront();
            viewPayRollTab.Instance.Visible = false;
            generatePayRollTab.Instance.Visible = true;
        }
    }
}
