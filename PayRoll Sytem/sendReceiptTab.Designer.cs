namespace PayRoll_Sytem
{
    partial class sendReceiptTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewPayRoll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.receiptDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailSendProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.sendReceiptBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.payRollDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.information = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ViewPayRoll);
            this.panel1.Controls.Add(this.receiptDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 146);
            this.panel1.TabIndex = 0;
            // 
            // ViewPayRoll
            // 
            this.ViewPayRoll.Activecolor = System.Drawing.Color.ForestGreen;
            this.ViewPayRoll.BackColor = System.Drawing.Color.ForestGreen;
            this.ViewPayRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewPayRoll.BorderRadius = 5;
            this.ViewPayRoll.ButtonText = "View Details";
            this.ViewPayRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPayRoll.DisabledColor = System.Drawing.Color.Gray;
            this.ViewPayRoll.Iconcolor = System.Drawing.Color.Transparent;
            this.ViewPayRoll.Iconimage = null;
            this.ViewPayRoll.Iconimage_right = null;
            this.ViewPayRoll.Iconimage_right_Selected = null;
            this.ViewPayRoll.Iconimage_Selected = null;
            this.ViewPayRoll.IconMarginLeft = 0;
            this.ViewPayRoll.IconMarginRight = 0;
            this.ViewPayRoll.IconRightVisible = true;
            this.ViewPayRoll.IconRightZoom = 0D;
            this.ViewPayRoll.IconVisible = true;
            this.ViewPayRoll.IconZoom = 70D;
            this.ViewPayRoll.IsTab = false;
            this.ViewPayRoll.Location = new System.Drawing.Point(19, 71);
            this.ViewPayRoll.Name = "ViewPayRoll";
            this.ViewPayRoll.Normalcolor = System.Drawing.Color.ForestGreen;
            this.ViewPayRoll.OnHovercolor = System.Drawing.Color.Green;
            this.ViewPayRoll.OnHoverTextColor = System.Drawing.Color.White;
            this.ViewPayRoll.selected = false;
            this.ViewPayRoll.Size = new System.Drawing.Size(254, 48);
            this.ViewPayRoll.TabIndex = 48;
            this.ViewPayRoll.Text = "View Details";
            this.ViewPayRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewPayRoll.Textcolor = System.Drawing.Color.White;
            this.ViewPayRoll.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPayRoll.Click += new System.EventHandler(this.ViewPayRoll_Click);
            // 
            // receiptDate
            // 
            this.receiptDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.receiptDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receiptDate.Location = new System.Drawing.Point(322, 92);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(284, 27);
            this.receiptDate.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(318, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Month";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emailSendProgressBar);
            this.panel2.Controls.Add(this.sendReceiptBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 54);
            this.panel2.TabIndex = 3;
            // 
            // emailSendProgressBar
            // 
            this.emailSendProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.emailSendProgressBar.BorderRadius = 5;
            this.emailSendProgressBar.Location = new System.Drawing.Point(19, 19);
            this.emailSendProgressBar.MaximumValue = 100;
            this.emailSendProgressBar.Name = "emailSendProgressBar";
            this.emailSendProgressBar.ProgressColor = System.Drawing.Color.Lime;
            this.emailSendProgressBar.Size = new System.Drawing.Size(184, 10);
            this.emailSendProgressBar.TabIndex = 34;
            this.emailSendProgressBar.Value = 0;
            this.emailSendProgressBar.Visible = false;
            // 
            // sendReceiptBtn
            // 
            this.sendReceiptBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.sendReceiptBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.sendReceiptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendReceiptBtn.BorderRadius = 5;
            this.sendReceiptBtn.ButtonText = "Send Receipt";
            this.sendReceiptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendReceiptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendReceiptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sendReceiptBtn.Iconimage = null;
            this.sendReceiptBtn.Iconimage_right = null;
            this.sendReceiptBtn.Iconimage_right_Selected = null;
            this.sendReceiptBtn.Iconimage_Selected = null;
            this.sendReceiptBtn.IconMarginLeft = 0;
            this.sendReceiptBtn.IconMarginRight = 0;
            this.sendReceiptBtn.IconRightVisible = true;
            this.sendReceiptBtn.IconRightZoom = 0D;
            this.sendReceiptBtn.IconVisible = true;
            this.sendReceiptBtn.IconZoom = 70D;
            this.sendReceiptBtn.IsTab = false;
            this.sendReceiptBtn.Location = new System.Drawing.Point(488, 6);
            this.sendReceiptBtn.Name = "sendReceiptBtn";
            this.sendReceiptBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.sendReceiptBtn.OnHovercolor = System.Drawing.Color.Green;
            this.sendReceiptBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendReceiptBtn.selected = false;
            this.sendReceiptBtn.Size = new System.Drawing.Size(230, 35);
            this.sendReceiptBtn.TabIndex = 33;
            this.sendReceiptBtn.Text = "Send Receipt";
            this.sendReceiptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendReceiptBtn.Textcolor = System.Drawing.Color.White;
            this.sendReceiptBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendReceiptBtn.Click += new System.EventHandler(this.sendReceiptBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 330);
            this.panel3.TabIndex = 4;
            // 
            // payRollDataGrid
            // 
            this.payRollDataGrid.AllowUserToAddRows = false;
            this.payRollDataGrid.AllowUserToDeleteRows = false;
            this.payRollDataGrid.AllowUserToResizeColumns = false;
            this.payRollDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.payRollDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.payRollDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.payRollDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payRollDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payRollDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payRollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.payRollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payRollDataGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.payRollDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payRollDataGrid.DoubleBuffered = true;
            this.payRollDataGrid.EnableHeadersVisualStyles = false;
            this.payRollDataGrid.GridColor = System.Drawing.Color.Black;
            this.payRollDataGrid.HeaderBgColor = System.Drawing.Color.White;
            this.payRollDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.payRollDataGrid.Location = new System.Drawing.Point(0, 0);
            this.payRollDataGrid.MultiSelect = false;
            this.payRollDataGrid.Name = "payRollDataGrid";
            this.payRollDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.payRollDataGrid.RowHeadersVisible = false;
            this.payRollDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.payRollDataGrid.ShowEditingIcon = false;
            this.payRollDataGrid.Size = new System.Drawing.Size(378, 330);
            this.payRollDataGrid.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.information);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(378, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 330);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.payRollDataGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 330);
            this.panel5.TabIndex = 5;
            // 
            // information
            // 
            this.information.AutoScroll = true;
            this.information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.information.Location = new System.Drawing.Point(0, 0);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(482, 328);
            this.information.TabIndex = 0;
            this.information.WrapContents = false;
            // 
            // sendReceiptTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sendReceiptTab";
            this.Size = new System.Drawing.Size(862, 530);
            this.Load += new System.EventHandler(this.sendReceiptTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton sendReceiptBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker receiptDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid payRollDataGrid;
        private Bunifu.Framework.UI.BunifuProgressBar emailSendProgressBar;
        private Bunifu.Framework.UI.BunifuFlatButton ViewPayRoll;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel information;
    }
}
