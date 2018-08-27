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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
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

        // a button to register new user
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = addUserBtn.Left;
            lineSp.Width = addUserBtn.Width;
            updateUserBtn.Textcolor = Color.LightGray;
            addUserBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //ading the child contror to the panel
            panel4.Controls.Add(addNewUserTab.Instance);
            addNewUserTab.Instance.Dock = DockStyle.Fill;
            addNewUserTab.Instance.BringToFront();
            updateUserTab.Instance.Visible = false;
            addNewUserTab.Instance.Visible = true;
            

        }

        //A button to update registered users` information
        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = updateUserBtn.Left;
            lineSp.Width = updateUserBtn.Width;
            addUserBtn.Textcolor = Color.LightGray;
            updateUserBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //ading the child contror to the panel
            panel4.Controls.Add(updateUserTab.Instance);
            updateUserTab.Instance.Dock = DockStyle.Fill;
            updateUserTab.Instance.BringToFront();
            addNewUserTab.Instance.Visible = false;
            updateUserTab.Instance.Visible = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lineSp.Left = addUserBtn.Left;
            lineSp.Width = addUserBtn.Width;
            updateUserBtn.Textcolor = Color.LightGray;
            addUserBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //ading the child contror to the panel
            panel4.Controls.Add(addNewUserTab.Instance);
            addNewUserTab.Instance.Dock = DockStyle.Fill;
            addNewUserTab.Instance.BringToFront();
            updateUserTab.Instance.Visible = false;
            addNewUserTab.Instance.Visible = true;
        }
    }
}
