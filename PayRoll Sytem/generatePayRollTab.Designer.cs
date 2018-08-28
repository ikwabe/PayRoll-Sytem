namespace PayRoll_Sytem
{
    partial class generatePayRollTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generatePayRollTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payRollDate = new System.Windows.Forms.DateTimePicker();
            this.generatePayRollBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savePayRollBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.payRollDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.payRollDate);
            this.panel1.Controls.Add(this.generatePayRollBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 179);
            this.panel1.TabIndex = 0;
            // 
            // payRollDate
            // 
            this.payRollDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRollDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payRollDate.Location = new System.Drawing.Point(113, 37);
            this.payRollDate.Name = "payRollDate";
            this.payRollDate.Size = new System.Drawing.Size(356, 27);
            this.payRollDate.TabIndex = 45;
            // 
            // generatePayRollBtn
            // 
            this.generatePayRollBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.generatePayRollBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.generatePayRollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generatePayRollBtn.BorderRadius = 5;
            this.generatePayRollBtn.ButtonText = "Generate Pay-Roll Now";
            this.generatePayRollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePayRollBtn.DisabledColor = System.Drawing.Color.Gray;
            this.generatePayRollBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.generatePayRollBtn.Iconimage = null;
            this.generatePayRollBtn.Iconimage_right = null;
            this.generatePayRollBtn.Iconimage_right_Selected = null;
            this.generatePayRollBtn.Iconimage_Selected = null;
            this.generatePayRollBtn.IconMarginLeft = 0;
            this.generatePayRollBtn.IconMarginRight = 0;
            this.generatePayRollBtn.IconRightVisible = true;
            this.generatePayRollBtn.IconRightZoom = 0D;
            this.generatePayRollBtn.IconVisible = true;
            this.generatePayRollBtn.IconZoom = 70D;
            this.generatePayRollBtn.IsTab = false;
            this.generatePayRollBtn.Location = new System.Drawing.Point(113, 105);
            this.generatePayRollBtn.Name = "generatePayRollBtn";
            this.generatePayRollBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.generatePayRollBtn.OnHovercolor = System.Drawing.Color.Green;
            this.generatePayRollBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.generatePayRollBtn.selected = false;
            this.generatePayRollBtn.Size = new System.Drawing.Size(356, 48);
            this.generatePayRollBtn.TabIndex = 31;
            this.generatePayRollBtn.Text = "Generate Pay-Roll Now";
            this.generatePayRollBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generatePayRollBtn.Textcolor = System.Drawing.Color.White;
            this.generatePayRollBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePayRollBtn.Click += new System.EventHandler(this.generatePayRollBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(109, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Please Select The Date here For Generatint the Pay-Roll";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.savePayRollBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 73);
            this.panel2.TabIndex = 1;
            // 
            // savePayRollBtn
            // 
            this.savePayRollBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.savePayRollBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.savePayRollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savePayRollBtn.BorderRadius = 5;
            this.savePayRollBtn.ButtonText = "Save Pay-Roll";
            this.savePayRollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePayRollBtn.DisabledColor = System.Drawing.Color.Gray;
            this.savePayRollBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.savePayRollBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("savePayRollBtn.Iconimage")));
            this.savePayRollBtn.Iconimage_right = null;
            this.savePayRollBtn.Iconimage_right_Selected = null;
            this.savePayRollBtn.Iconimage_Selected = null;
            this.savePayRollBtn.IconMarginLeft = 0;
            this.savePayRollBtn.IconMarginRight = 0;
            this.savePayRollBtn.IconRightVisible = true;
            this.savePayRollBtn.IconRightZoom = 0D;
            this.savePayRollBtn.IconVisible = true;
            this.savePayRollBtn.IconZoom = 70D;
            this.savePayRollBtn.IsTab = false;
            this.savePayRollBtn.Location = new System.Drawing.Point(463, 6);
            this.savePayRollBtn.Name = "savePayRollBtn";
            this.savePayRollBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.savePayRollBtn.OnHovercolor = System.Drawing.Color.Green;
            this.savePayRollBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.savePayRollBtn.selected = false;
            this.savePayRollBtn.Size = new System.Drawing.Size(230, 48);
            this.savePayRollBtn.TabIndex = 31;
            this.savePayRollBtn.Text = "Save Pay-Roll";
            this.savePayRollBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savePayRollBtn.Textcolor = System.Drawing.Color.White;
            this.savePayRollBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePayRollBtn.Click += new System.EventHandler(this.savePayRollBtn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.payRollDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 308);
            this.panel3.TabIndex = 2;
            // 
            // payRollDataGrid
            // 
            this.payRollDataGrid.AllowUserToAddRows = false;
            this.payRollDataGrid.AllowUserToDeleteRows = false;
            this.payRollDataGrid.AllowUserToResizeColumns = false;
            this.payRollDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.payRollDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.payRollDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.payRollDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payRollDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.payRollDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payRollDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payRollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.payRollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payRollDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.payRollDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payRollDataGrid.DoubleBuffered = true;
            this.payRollDataGrid.EnableHeadersVisualStyles = false;
            this.payRollDataGrid.GridColor = System.Drawing.Color.Black;
            this.payRollDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.payRollDataGrid.Location = new System.Drawing.Point(0, 0);
            this.payRollDataGrid.MultiSelect = false;
            this.payRollDataGrid.Name = "payRollDataGrid";
            this.payRollDataGrid.ReadOnly = true;
            this.payRollDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.payRollDataGrid.RowHeadersVisible = false;
            this.payRollDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.payRollDataGrid.ShowEditingIcon = false;
            this.payRollDataGrid.Size = new System.Drawing.Size(936, 308);
            this.payRollDataGrid.TabIndex = 2;
            // 
            // generatePayRollTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "generatePayRollTab";
            this.Size = new System.Drawing.Size(936, 560);
            this.Load += new System.EventHandler(this.generatePayRollTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton generatePayRollBtn;
        private Bunifu.Framework.UI.BunifuFlatButton savePayRollBtn;
        private System.Windows.Forms.DateTimePicker payRollDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid payRollDataGrid;
    }
}
