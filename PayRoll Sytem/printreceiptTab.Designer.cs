namespace PayRoll_Sytem
{
    partial class printreceiptTab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.messagelabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sendEmailBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payRollDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkEmpReceiptBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.searchText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchResultDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 528);
            this.panel2.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.messagelabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1066, 466);
            this.panel6.TabIndex = 2;
            // 
            // messagelabel
            // 
            this.messagelabel.AutoEllipsis = true;
            this.messagelabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelabel.ForeColor = System.Drawing.Color.LightGray;
            this.messagelabel.Location = new System.Drawing.Point(114, 50);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(815, 382);
            this.messagelabel.TabIndex = 51;
            this.messagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sendEmailBtn);
            this.panel4.Controls.Add(this.employeeNameLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1066, 62);
            this.panel4.TabIndex = 0;
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.sendEmailBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.sendEmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendEmailBtn.BorderRadius = 5;
            this.sendEmailBtn.ButtonText = "Send Email";
            this.sendEmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendEmailBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendEmailBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sendEmailBtn.Iconimage = null;
            this.sendEmailBtn.Iconimage_right = null;
            this.sendEmailBtn.Iconimage_right_Selected = null;
            this.sendEmailBtn.Iconimage_Selected = null;
            this.sendEmailBtn.IconMarginLeft = 0;
            this.sendEmailBtn.IconMarginRight = 0;
            this.sendEmailBtn.IconRightVisible = true;
            this.sendEmailBtn.IconRightZoom = 0D;
            this.sendEmailBtn.IconVisible = true;
            this.sendEmailBtn.IconZoom = 70D;
            this.sendEmailBtn.IsTab = false;
            this.sendEmailBtn.Location = new System.Drawing.Point(843, 17);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.sendEmailBtn.OnHovercolor = System.Drawing.Color.Green;
            this.sendEmailBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendEmailBtn.selected = false;
            this.sendEmailBtn.Size = new System.Drawing.Size(151, 38);
            this.sendEmailBtn.TabIndex = 33;
            this.sendEmailBtn.Text = "Send Email";
            this.sendEmailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendEmailBtn.Textcolor = System.Drawing.Color.White;
            this.sendEmailBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.employeeNameLabel.Location = new System.Drawing.Point(190, 26);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(0, 29);
            this.employeeNameLabel.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.payRollDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkEmpReceiptBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 277);
            this.panel1.TabIndex = 8;
            // 
            // payRollDate
            // 
            this.payRollDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRollDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payRollDate.Location = new System.Drawing.Point(26, 48);
            this.payRollDate.Name = "payRollDate";
            this.payRollDate.Size = new System.Drawing.Size(284, 27);
            this.payRollDate.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(25, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Please select Employee name from the list";
            // 
            // checkEmpReceiptBtn
            // 
            this.checkEmpReceiptBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.checkEmpReceiptBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.checkEmpReceiptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkEmpReceiptBtn.BorderRadius = 5;
            this.checkEmpReceiptBtn.ButtonText = "Check Employee Receipt";
            this.checkEmpReceiptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEmpReceiptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.checkEmpReceiptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkEmpReceiptBtn.Iconimage = null;
            this.checkEmpReceiptBtn.Iconimage_right = null;
            this.checkEmpReceiptBtn.Iconimage_right_Selected = null;
            this.checkEmpReceiptBtn.Iconimage_Selected = null;
            this.checkEmpReceiptBtn.IconMarginLeft = 0;
            this.checkEmpReceiptBtn.IconMarginRight = 0;
            this.checkEmpReceiptBtn.IconRightVisible = true;
            this.checkEmpReceiptBtn.IconRightZoom = 0D;
            this.checkEmpReceiptBtn.IconVisible = true;
            this.checkEmpReceiptBtn.IconZoom = 70D;
            this.checkEmpReceiptBtn.IsTab = false;
            this.checkEmpReceiptBtn.Location = new System.Drawing.Point(23, 189);
            this.checkEmpReceiptBtn.Name = "checkEmpReceiptBtn";
            this.checkEmpReceiptBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.checkEmpReceiptBtn.OnHovercolor = System.Drawing.Color.Green;
            this.checkEmpReceiptBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkEmpReceiptBtn.selected = false;
            this.checkEmpReceiptBtn.Size = new System.Drawing.Size(284, 38);
            this.checkEmpReceiptBtn.TabIndex = 32;
            this.checkEmpReceiptBtn.Text = "Check Employee Receipt";
            this.checkEmpReceiptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEmpReceiptBtn.Textcolor = System.Drawing.Color.White;
            this.checkEmpReceiptBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmpReceiptBtn.Click += new System.EventHandler(this.checkEmpReceiptBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(124, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Select Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(47, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(241, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "You can seach Employee name here";
            // 
            // searchText
            // 
            this.searchText.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.searchText.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.searchText.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchText.BorderThickness = 1;
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchText.isPassword = false;
            this.searchText.Location = new System.Drawing.Point(23, 148);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(284, 34);
            this.searchText.TabIndex = 3;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.OnValueChanged += new System.EventHandler(this.searchText_OnValueChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.panel3);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(316, 528);
            this.searchPanel.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchResultDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 251);
            this.panel3.TabIndex = 9;
            // 
            // searchResultDataGrid
            // 
            this.searchResultDataGrid.AllowUserToAddRows = false;
            this.searchResultDataGrid.AllowUserToDeleteRows = false;
            this.searchResultDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            this.searchResultDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchResultDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchResultDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.searchResultDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResultDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchResultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchResultDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGrid.DoubleBuffered = true;
            this.searchResultDataGrid.EnableHeadersVisualStyles = false;
            this.searchResultDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.searchResultDataGrid.HeaderForeColor = System.Drawing.Color.DarkGray;
            this.searchResultDataGrid.Location = new System.Drawing.Point(0, 0);
            this.searchResultDataGrid.MultiSelect = false;
            this.searchResultDataGrid.Name = "searchResultDataGrid";
            this.searchResultDataGrid.ReadOnly = true;
            this.searchResultDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResultDataGrid.RowHeadersVisible = false;
            this.searchResultDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.searchResultDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.searchResultDataGrid.ShowEditingIcon = false;
            this.searchResultDataGrid.Size = new System.Drawing.Size(316, 251);
            this.searchResultDataGrid.TabIndex = 12;
            this.searchResultDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResultDataGrid_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printreceiptTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPanel);
            this.Name = "printreceiptTab";
            this.Size = new System.Drawing.Size(1382, 528);
            this.Load += new System.EventHandler(this.printreceiptTab_Load);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchText;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton checkEmpReceiptBtn;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label label1;
      
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResultDataGrid;
        private System.Windows.Forms.DateTimePicker payRollDate;
        private Bunifu.Framework.UI.BunifuFlatButton sendEmailBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label messagelabel;
    }
}
