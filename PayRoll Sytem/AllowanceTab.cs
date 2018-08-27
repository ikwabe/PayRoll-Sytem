using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Sytem
{
    public partial class AllowanceTab : UserControl
    {

        public static AllowanceTab _instance;
        public static AllowanceTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AllowanceTab();
                return _instance;
            }
        }
        public AllowanceTab()
        {
            InitializeComponent();
        }

        private void addAllowanceBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = addAllowanceBtn.Left;
            lineSp.Width = addAllowanceBtn.Width;
            editAllowanceBtn.Textcolor = Color.LightGray;
            addAllowanceBtn.Textcolor = Color.Lime;

            //adding the child to the parent form
            panel2.Controls.Add(addAllowanceTab.Instance);
            addAllowanceTab.Instance.Dock = DockStyle.Fill;
            addAllowanceTab.Instance.BringToFront();
            editAllowanceTb.Instance.Visible = false;
            addAllowanceTab.Instance.Visible = true;
        }

        private void editAllowanceBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = editAllowanceBtn.Left;
            lineSp.Width = editAllowanceBtn.Width;
            addAllowanceBtn.Textcolor = Color.LightGray;
            editAllowanceBtn.Textcolor = Color.Lime;

            //adding the child to the parent form
            panel2.Controls.Add(editAllowanceTb.Instance);
            editAllowanceTb.Instance.Dock = DockStyle.Fill;
            editAllowanceTb.Instance.BringToFront();
            addAllowanceTab.Instance.Visible = false;
            editAllowanceTb.Instance.Visible = true;
        }

        private void AllowanceTab_Load(object sender, EventArgs e)
        {
            lineSp.Left = addAllowanceBtn.Left;
            lineSp.Width = addAllowanceBtn.Width;
            editAllowanceBtn.Textcolor = Color.LightGray;
            addAllowanceBtn.Textcolor = Color.Lime;

            //adding the child to the parent form
            panel2.Controls.Add(addAllowanceTab.Instance);
            addAllowanceTab.Instance.Dock = DockStyle.Fill;
            addAllowanceTab.Instance.BringToFront();
            editAllowanceTb.Instance.Visible = false;
            addAllowanceTab.Instance.Visible = true;
        }
    }
}
