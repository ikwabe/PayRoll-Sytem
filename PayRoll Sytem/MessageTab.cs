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
    public partial class MessageTab : Form
    {
        public MessageTab()
        {
            InitializeComponent();
        }

        private void cancelBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            //close if the file is opened
            foreach (var process in System.Diagnostics.Process.GetProcesses(Environment.MachineName))
            {
                if (process.MainWindowTitle.Contains("receipt.pdf"))
                {
                    process.Kill();
                    break;
                }
            }

            if (MessageBox.Show("Sending Message?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(sendReceiptTab.swich == true)
                {
                    sendReceiptTab.message = messageTxt.Text;
                    sendReceiptTab.check = true;
                    this.Close();
                }

                if(printreceiptTab.swich == true)
                {
                    printreceiptTab.message = messageTxt.Text;
                    printreceiptTab.check = true;
                    this.Close();
                }
                

            }
            
        }
    }
}
