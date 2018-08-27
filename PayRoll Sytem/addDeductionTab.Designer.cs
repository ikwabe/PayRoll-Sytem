namespace PayRoll_Sytem
{
    partial class addDeductionTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.newDeductionTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addDeductionBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchResultDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // newDeductionTxt
            // 
            this.newDeductionTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.newDeductionTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.newDeductionTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newDeductionTxt.BorderThickness = 1;
            this.newDeductionTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newDeductionTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDeductionTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.newDeductionTxt.isPassword = false;
            this.newDeductionTxt.Location = new System.Drawing.Point(157, 156);
            this.newDeductionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.newDeductionTxt.Name = "newDeductionTxt";
            this.newDeductionTxt.Size = new System.Drawing.Size(454, 39);
            this.newDeductionTxt.TabIndex = 36;
            this.newDeductionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(279, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Type a New Deduction here";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 509);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.addDeductionBtn);
            this.panel2.Controls.Add(this.newDeductionTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 509);
            this.panel2.TabIndex = 34;
            // 
            // addDeductionBtn
            // 
            this.addDeductionBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.addDeductionBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addDeductionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDeductionBtn.BorderRadius = 5;
            this.addDeductionBtn.ButtonText = "Register New Deduction";
            this.addDeductionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDeductionBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addDeductionBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addDeductionBtn.Iconimage = null;
            this.addDeductionBtn.Iconimage_right = null;
            this.addDeductionBtn.Iconimage_right_Selected = null;
            this.addDeductionBtn.Iconimage_Selected = null;
            this.addDeductionBtn.IconMarginLeft = 0;
            this.addDeductionBtn.IconMarginRight = 0;
            this.addDeductionBtn.IconRightVisible = true;
            this.addDeductionBtn.IconRightZoom = 0D;
            this.addDeductionBtn.IconVisible = true;
            this.addDeductionBtn.IconZoom = 70D;
            this.addDeductionBtn.IsTab = false;
            this.addDeductionBtn.Location = new System.Drawing.Point(270, 215);
            this.addDeductionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addDeductionBtn.Name = "addDeductionBtn";
            this.addDeductionBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.addDeductionBtn.OnHovercolor = System.Drawing.Color.Green;
            this.addDeductionBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addDeductionBtn.selected = false;
            this.addDeductionBtn.Size = new System.Drawing.Size(240, 50);
            this.addDeductionBtn.TabIndex = 38;
            this.addDeductionBtn.Text = "Register New Deduction";
            this.addDeductionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDeductionBtn.Textcolor = System.Drawing.Color.White;
            this.addDeductionBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeductionBtn.Click += new System.EventHandler(this.addDeductionBtn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchResultDataGrid);
            this.searchPanel.Controls.Add(this.panel3);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(316, 509);
            this.searchPanel.TabIndex = 33;
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
            this.searchResultDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGrid.DoubleBuffered = true;
            this.searchResultDataGrid.EnableHeadersVisualStyles = false;
            this.searchResultDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.searchResultDataGrid.HeaderForeColor = System.Drawing.Color.DarkGray;
            this.searchResultDataGrid.Location = new System.Drawing.Point(0, 56);
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
            this.searchResultDataGrid.Size = new System.Drawing.Size(316, 453);
            this.searchResultDataGrid.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 56);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Registered Deductions list";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.BorderRadius = 5;
            this.refreshBtn.ButtonText = "Refresh";
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.DisabledColor = System.Drawing.Color.Gray;
            this.refreshBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshBtn.Iconimage = null;
            this.refreshBtn.Iconimage_right = null;
            this.refreshBtn.Iconimage_right_Selected = null;
            this.refreshBtn.Iconimage_Selected = null;
            this.refreshBtn.IconMarginLeft = 0;
            this.refreshBtn.IconMarginRight = 0;
            this.refreshBtn.IconRightVisible = true;
            this.refreshBtn.IconRightZoom = 0D;
            this.refreshBtn.IconVisible = true;
            this.refreshBtn.IconZoom = 70D;
            this.refreshBtn.IsTab = false;
            this.refreshBtn.Location = new System.Drawing.Point(19, 28);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.refreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshBtn.selected = false;
            this.refreshBtn.Size = new System.Drawing.Size(112, 28);
            this.refreshBtn.TabIndex = 52;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addDeductionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPanel);
            this.Name = "addDeductionTab";
            this.Size = new System.Drawing.Size(885, 509);
            this.Load += new System.EventHandler(this.addDeductionTab_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox newDeductionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton addDeductionBtn;
        private System.Windows.Forms.Panel searchPanel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResultDataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
    }
}
