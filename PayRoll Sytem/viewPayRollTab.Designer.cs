namespace PayRoll_Sytem
{
    partial class viewPayRollTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPayRollTab));
            this.payRollDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.viewPayRollBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveAsPayRollBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payRollDate = new System.Windows.Forms.DateTimePicker();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payRollDataGrid
            // 
            this.payRollDataGrid.AllowUserToAddRows = false;
            this.payRollDataGrid.AllowUserToDeleteRows = false;
            this.payRollDataGrid.AllowUserToResizeColumns = false;
            this.payRollDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.payRollDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.payRollDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.payRollDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payRollDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.payRollDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payRollDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payRollDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.payRollDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.payRollDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.payRollDataGrid.TabIndex = 1;
            // 
            // viewPayRollBtn
            // 
            this.viewPayRollBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.viewPayRollBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.viewPayRollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewPayRollBtn.BorderRadius = 5;
            this.viewPayRollBtn.ButtonText = "View Pay-Roll Now";
            this.viewPayRollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPayRollBtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewPayRollBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewPayRollBtn.Iconimage = null;
            this.viewPayRollBtn.Iconimage_right = null;
            this.viewPayRollBtn.Iconimage_right_Selected = null;
            this.viewPayRollBtn.Iconimage_Selected = null;
            this.viewPayRollBtn.IconMarginLeft = 0;
            this.viewPayRollBtn.IconMarginRight = 0;
            this.viewPayRollBtn.IconRightVisible = true;
            this.viewPayRollBtn.IconRightZoom = 0D;
            this.viewPayRollBtn.IconVisible = true;
            this.viewPayRollBtn.IconZoom = 70D;
            this.viewPayRollBtn.IsTab = false;
            this.viewPayRollBtn.Location = new System.Drawing.Point(113, 105);
            this.viewPayRollBtn.Name = "viewPayRollBtn";
            this.viewPayRollBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.viewPayRollBtn.OnHovercolor = System.Drawing.Color.Green;
            this.viewPayRollBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewPayRollBtn.selected = false;
            this.viewPayRollBtn.Size = new System.Drawing.Size(356, 48);
            this.viewPayRollBtn.TabIndex = 31;
            this.viewPayRollBtn.Text = "View Pay-Roll Now";
            this.viewPayRollBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewPayRollBtn.Textcolor = System.Drawing.Color.White;
            this.viewPayRollBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPayRollBtn.Click += new System.EventHandler(this.viewPayRollBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(109, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Please Select The Date here to View the Pay-Roll";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.payRollDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 308);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveAsPayRollBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 73);
            this.panel2.TabIndex = 4;
            // 
            // saveAsPayRollBtn
            // 
            this.saveAsPayRollBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.saveAsPayRollBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.saveAsPayRollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveAsPayRollBtn.BorderRadius = 5;
            this.saveAsPayRollBtn.ButtonText = "SaveAs Pay-Roll";
            this.saveAsPayRollBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAsPayRollBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveAsPayRollBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveAsPayRollBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("saveAsPayRollBtn.Iconimage")));
            this.saveAsPayRollBtn.Iconimage_right = null;
            this.saveAsPayRollBtn.Iconimage_right_Selected = null;
            this.saveAsPayRollBtn.Iconimage_Selected = null;
            this.saveAsPayRollBtn.IconMarginLeft = 0;
            this.saveAsPayRollBtn.IconMarginRight = 0;
            this.saveAsPayRollBtn.IconRightVisible = true;
            this.saveAsPayRollBtn.IconRightZoom = 0D;
            this.saveAsPayRollBtn.IconVisible = true;
            this.saveAsPayRollBtn.IconZoom = 70D;
            this.saveAsPayRollBtn.IsTab = false;
            this.saveAsPayRollBtn.Location = new System.Drawing.Point(463, 6);
            this.saveAsPayRollBtn.Name = "saveAsPayRollBtn";
            this.saveAsPayRollBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.saveAsPayRollBtn.OnHovercolor = System.Drawing.Color.Green;
            this.saveAsPayRollBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveAsPayRollBtn.selected = false;
            this.saveAsPayRollBtn.Size = new System.Drawing.Size(230, 48);
            this.saveAsPayRollBtn.TabIndex = 31;
            this.saveAsPayRollBtn.Text = "SaveAs Pay-Roll";
            this.saveAsPayRollBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveAsPayRollBtn.Textcolor = System.Drawing.Color.White;
            this.saveAsPayRollBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsPayRollBtn.Click += new System.EventHandler(this.saveAsPayRollBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.payRollDate);
            this.panel1.Controls.Add(this.viewPayRollBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 179);
            this.panel1.TabIndex = 3;
            // 
            // payRollDate
            // 
            this.payRollDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.payRollDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payRollDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payRollDate.Location = new System.Drawing.Point(113, 37);
            this.payRollDate.Name = "payRollDate";
            this.payRollDate.Size = new System.Drawing.Size(356, 27);
            this.payRollDate.TabIndex = 46;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 5;
            this.deleteBtn.ButtonText = "Delete Employee";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = null;
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 80D;
            this.deleteBtn.IsTab = false;
            this.deleteBtn.Location = new System.Drawing.Point(475, 30);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteBtn.OnHovercolor = System.Drawing.Color.Red;
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(146, 34);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "Delete Employee";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewPayRollTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(84)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "viewPayRollTab";
            this.Size = new System.Drawing.Size(936, 560);
            this.Load += new System.EventHandler(this.viewPayRollTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payRollDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid payRollDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton saveAsPayRollBtn;
        private Bunifu.Framework.UI.BunifuFlatButton viewPayRollBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker payRollDate;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
    }
}
