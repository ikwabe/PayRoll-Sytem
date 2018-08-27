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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
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

        private void sendReceiptBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = sendReceiptBtn.Left;
            lineSp.Width = sendReceiptBtn.Width;
            printReceiptBtn.Textcolor = Color.LightGray;
            sendReceiptBtn.Textcolor = Color.FromArgb(217, 164, 0);

           
            //adding the child control to the parent form
            panel4.Controls.Add(sendReceiptTab.Instance);
            sendReceiptTab.Instance.Dock = DockStyle.Fill;
            sendReceiptTab.Instance.BringToFront();
            printreceiptTab.Instance.Visible = false;
            sendReceiptTab.Instance.Visible = true;
        }

        private void printReceiptBtn_Click(object sender, EventArgs e)
        {
            lineSp.Left = printReceiptBtn.Left;
            lineSp.Width = printReceiptBtn.Width;
            sendReceiptBtn.Textcolor = Color.LightGray;
            printReceiptBtn.Textcolor = Color.FromArgb(217, 164, 0);

            //adding the child control to the parent form
            panel4.Controls.Add(printreceiptTab.Instance);
            printreceiptTab.Instance.Dock = DockStyle.Fill;
            printreceiptTab.Instance.BringToFront();
            sendReceiptTab.Instance.Visible = false;
            printreceiptTab.Instance.Visible = true;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lineSp.Left = sendReceiptBtn.Left;
            lineSp.Width = sendReceiptBtn.Width;
            printReceiptBtn.Textcolor = Color.LightGray;
            sendReceiptBtn.Textcolor = Color.FromArgb(217, 164, 0);


            //adding the child control to the parent form
            panel4.Controls.Add(sendReceiptTab.Instance);
            sendReceiptTab.Instance.Dock = DockStyle.Fill;
            sendReceiptTab.Instance.BringToFront();
            printreceiptTab.Instance.Visible = false;
            sendReceiptTab.Instance.Visible = true;
        }
    }
}
