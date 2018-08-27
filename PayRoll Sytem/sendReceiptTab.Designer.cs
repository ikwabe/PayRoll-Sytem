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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toSomeEmployeeOption = new System.Windows.Forms.RadioButton();
            this.toAllEmployeeOption = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.searchText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendReceiptBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.payRollDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CheckedName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailSendProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.receiptDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toSomeEmployeeOption);
            this.panel1.Controls.Add(this.toAllEmployeeOption);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 146);
            this.panel1.TabIndex = 0;
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
            // toSomeEmployeeOption
            // 
            this.toSomeEmployeeOption.AutoSize = true;
            this.toSomeEmployeeOption.BackColor = System.Drawing.Color.Transparent;
            this.toSomeEmployeeOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toSomeEmployeeOption.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSomeEmployeeOption.ForeColor = System.Drawing.Color.Orange;
            this.toSomeEmployeeOption.Location = new System.Drawing.Point(32, 93);
            this.toSomeEmployeeOption.Name = "toSomeEmployeeOption";
            this.toSomeEmployeeOption.Size = new System.Drawing.Size(171, 27);
            this.toSomeEmployeeOption.TabIndex = 18;
            this.toSomeEmployeeOption.TabStop = true;
            this.toSomeEmployeeOption.Text = "To Some Employee";
            this.toSomeEmployeeOption.UseVisualStyleBackColor = false;
            this.toSomeEmployeeOption.CheckedChanged += new System.EventHandler(this.toSomeEmployeeOption_CheckedChanged);
            // 
            // toAllEmployeeOption
            // 
            this.toAllEmployeeOption.AutoSize = true;
            this.toAllEmployeeOption.BackColor = System.Drawing.Color.Transparent;
            this.toAllEmployeeOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toAllEmployeeOption.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAllEmployeeOption.ForeColor = System.Drawing.Color.Orange;
            this.toAllEmployeeOption.Location = new System.Drawing.Point(32, 51);
            this.toAllEmployeeOption.Name = "toAllEmployeeOption";
            this.toAllEmployeeOption.Size = new System.Drawing.Size(147, 27);
            this.toAllEmployeeOption.TabIndex = 17;
            this.toAllEmployeeOption.TabStop = true;
            this.toAllEmployeeOption.Text = "To All Employee";
            this.toAllEmployeeOption.UseVisualStyleBackColor = false;
            this.toAllEmployeeOption.CheckedChanged += new System.EventHandler(this.toAllEmployeeOption_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(28, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Options for sending Receipt(s)";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.label15);
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 146);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(862, 93);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(28, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 23);
            this.label15.TabIndex = 24;
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
            this.searchText.Location = new System.Drawing.Point(32, 42);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(492, 34);
            this.searchText.TabIndex = 23;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.OnValueChanged += new System.EventHandler(this.searchText_OnValueChanged);
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
            this.panel3.Controls.Add(this.payRollDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 237);
            this.panel3.TabIndex = 4;
            // 
            // payRollDataGrid
            // 
            this.payRollDataGrid.AllowUserToAddRows = false;
            this.payRollDataGrid.AllowUserToDeleteRows = false;
            this.payRollDataGrid.AllowUserToResizeColumns = false;
            this.payRollDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.payRollDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.payRollDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.payRollDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payRollDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payRollDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payRollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payRollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payRollDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckedName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payRollDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.payRollDataGrid.Size = new System.Drawing.Size(862, 237);
            this.payRollDataGrid.TabIndex = 3;
            // 
            // CheckedName
            // 
            this.CheckedName.HeaderText = "Check";
            this.CheckedName.Name = "CheckedName";
            this.CheckedName.Visible = false;
            this.CheckedName.Width = 61;
            // 
            // emailSendProgressBar
            // 
            this.emailSendProgressBar.BackColor = System.Drawing.Color.Silver;
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
            // sendReceiptTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel1);
            this.Name = "sendReceiptTab";
            this.Size = new System.Drawing.Size(862, 530);
            this.Load += new System.EventHandler(this.sendReceiptTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton toSomeEmployeeOption;
        private System.Windows.Forms.RadioButton toAllEmployeeOption;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchText;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton sendReceiptBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker receiptDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid payRollDataGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckedName;
        private Bunifu.Framework.UI.BunifuProgressBar emailSendProgressBar;
    }
}
