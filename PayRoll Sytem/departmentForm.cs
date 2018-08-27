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
    public partial class departmentForm : Form
    {
        public departmentForm()
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

        private void registerDeptBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = registerDeptBtn.Left;
            lineSp.Width = registerDeptBtn.Width;
            editDepartmentBtn.Textcolor = Color.LightGray;
            registerDeptBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(registerDepartmentTab.Instance);
            registerDepartmentTab.Instance.Dock = DockStyle.Fill;
            registerDepartmentTab.Instance.BringToFront();
            editDepartmentTab.Instance.Visible = false;
            registerDepartmentTab.Instance.Visible = true;
        }

        private void editDepartmentBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = editDepartmentBtn.Left;
            lineSp.Width = editDepartmentBtn.Width;
            registerDeptBtn.Textcolor = Color.LightGray;
            editDepartmentBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(editDepartmentTab.Instance);
            editDepartmentTab.Instance.Dock = DockStyle.Fill;
            editDepartmentTab.Instance.BringToFront();
            registerDepartmentTab.Instance.Visible = false;
            editDepartmentTab.Instance.Visible = true;
        }

        private void departmentForm_Load(object sender, EventArgs e)
        {
            lineSp.Left = registerDeptBtn.Left;
            lineSp.Width = registerDeptBtn.Width;
            editDepartmentBtn.Textcolor = Color.LightGray;
            registerDeptBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(registerDepartmentTab.Instance);
            registerDepartmentTab.Instance.Dock = DockStyle.Fill;
            registerDepartmentTab.Instance.BringToFront();
            editDepartmentTab.Instance.Visible = false;
            registerDepartmentTab.Instance.Visible = true;
        }
    }
}
