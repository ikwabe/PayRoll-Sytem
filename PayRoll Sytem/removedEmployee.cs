using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;

namespace PayRoll_Sytem
{
    public partial class removedEmployee : Form
    {
        public removedEmployee()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
           
                this.Close();
            
        }
        Label lab;
        BunifuSeparator line;
        BunifuFlatButton btn;
        FlowLayoutPanel panel;
        Panel pan;
        private void getRemovedEmployees()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = Home.DBconnection;

            MySqlCommand com = new MySqlCommand("select empID, upper(CONCAT(fname,' ',mname, ' ',lname)) from employee where state = 'DEACTIVE'", con);

            MySqlDataAdapter da;
            DataTable tab = new DataTable();
            try
            {
                con.Open();
                da = new MySqlDataAdapter(com);
                da.Fill(tab);
                da.Dispose();

                if(tab.Rows.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();

                    lab = new Label();
                    lab.ForeColor = Color.LightGray;
                    lab.Font = new Font("Calibri", 14,FontStyle.Bold);
                    lab.AutoSize = true;
                   
                    lab.Text = tab.Rows[0][1].ToString();

                    //create a line
                    line = new BunifuSeparator();
                    line.Height = 1;

                    //create a white space

                    pan = new Panel();
                    pan.Height = 1;
                    pan.Width = 300;
                    //create a button
                    btn = new BunifuFlatButton();
                    btn.Iconimage = null;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Size = new Size(100, 20);
                    btn.TextFont = new Font("Calibri", 10);
                    btn.BorderRadius = 5;
                    btn.Text = "Restore";
                    btn.Left = 300;
                    btn.OnHovercolor = Color.Orange;
                    btn.Normalcolor = Color.FromArgb(217, 164, 0);
                    btn.Activecolor = Color.FromArgb(217, 164, 0);
                    btn.Cursor = Cursors.Hand;
                    btn.Name = tab.Rows[0][0].ToString();
                    btn.Click += new EventHandler(btn_Click);

                    panel = new FlowLayoutPanel();
                    panel.FlowDirection = FlowDirection.LeftToRight;
                    panel.WrapContents = false;
                    panel.AutoSize = true;
                    panel.Padding = new Padding(0, 0, 0, 0);

                    panel.Controls.Add(lab);
                    panel.Controls.Add(pan);
                    panel.Controls.Add(btn);
                    flowLayoutPanel1.Controls.Add(panel);
                    flowLayoutPanel1.Controls.Add(line);



                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var button = sender as BunifuFlatButton;

            if (MessageBox.Show("Are you sure you want to restore this Employee?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = Home.DBconnection;


           
                string restore = "SET foreign_key_checks = 0;" +
                   " UPDATE employee set state = 'ACTIVE'" +
                   " WHERE empID = '" + button.Name + "';" +
                   " SET foreign_key_checks = 1;";
                MySqlCommand com = new MySqlCommand(restore, con);
                MySqlDataReader rd;
                try
                {
                    con.Open();

                    //RESTORE an employee
                    rd = com.ExecuteReader();
                    rd.Close();

                    Login.RecordUserActivity("Activated employee of empID "+button.Name+" ");
      
                    //REFRESH THE PAGE
                    getRemovedEmployees();
                    MessageBox.Show("Employee Restored Successful");

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                
            }

        }
        private void miniMizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
           
                this.WindowState = FormWindowState.Minimized;
            
        }

        private void refreshBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                getRemovedEmployees();
            
        }

        private void removedEmployee_Load(object sender, EventArgs e)
        {
            getRemovedEmployees();
        }
    }
}
