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
    public partial class deductionTab : UserControl
    {

        public static deductionTab _instance;
        public static deductionTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new deductionTab();
                return _instance;
            }
        }
        public deductionTab()
        {
            InitializeComponent();
        }

        private void addDeductionBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = addDeductionBtn.Left;
            lineSp.Width = addDeductionBtn.Width;
            editDeductionBtn.Textcolor = Color.LightGray;
            addDeductionBtn.Textcolor = Color.Lime;

            //adding the child controls to the parent control
            panel2.Controls.Add(addDeductionTab.Instance);
            addDeductionTab.Instance.Dock = DockStyle.Fill;
            addDeductionTab.Instance.BringToFront();
            editDeductionTab.Instance.Visible = false;
            addDeductionTab.Instance.Visible = true;
        }

        private void editDeductionBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = editDeductionBtn.Left;
            lineSp.Width = editDeductionBtn.Width;
            addDeductionBtn.Textcolor = Color.LightGray;
            editDeductionBtn.Textcolor = Color.Lime;

            //adding the child controls to the parent control
            panel2.Controls.Add(editDeductionTab.Instance);
            editDeductionTab.Instance.Dock = DockStyle.Fill;
            editDeductionTab.Instance.BringToFront();
            addDeductionTab.Instance.Visible = false;
            editDeductionTab.Instance.Visible = true;
        }

        private void deductionTab_Load(object sender, EventArgs e)
        {
            lineSp.Left = addDeductionBtn.Left;
            lineSp.Width = addDeductionBtn.Width;
            editDeductionBtn.Textcolor = Color.LightGray;
            addDeductionBtn.Textcolor = Color.Lime;

            //adding the child controls to the parent control
            panel2.Controls.Add(addDeductionTab.Instance);
            addDeductionTab.Instance.Dock = DockStyle.Fill;
            addDeductionTab.Instance.BringToFront();
            editDeductionTab.Instance.Visible = false;
            addDeductionTab.Instance.Visible = true;
        }
    }
}
