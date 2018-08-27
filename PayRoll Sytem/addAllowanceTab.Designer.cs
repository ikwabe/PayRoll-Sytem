namespace PayRoll_Sytem
{
    partial class addAllowanceTab
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
            this.newAllowanceTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchResultDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addAllowanceBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAllowanceTxt
            // 
            this.newAllowanceTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.newAllowanceTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.newAllowanceTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newAllowanceTxt.BorderThickness = 1;
            this.newAllowanceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newAllowanceTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAllowanceTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.newAllowanceTxt.isPassword = false;
            this.newAllowanceTxt.Location = new System.Drawing.Point(157, 156);
            this.newAllowanceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.newAllowanceTxt.Name = "newAllowanceTxt";
            this.newAllowanceTxt.Size = new System.Drawing.Size(454, 39);
            this.newAllowanceTxt.TabIndex = 36;
            this.newAllowanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(279, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Type a New Allowance here";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 440);
            this.panel1.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchResultDataGrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 384);
            this.panel4.TabIndex = 2;
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
            this.searchResultDataGrid.Size = new System.Drawing.Size(316, 384);
            this.searchResultDataGrid.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 56);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Registered Allowance list";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.addAllowanceBtn);
            this.panel2.Controls.Add(this.newAllowanceTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 440);
            this.panel2.TabIndex = 32;
            // 
            // addAllowanceBtn
            // 
            this.addAllowanceBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.addAllowanceBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addAllowanceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAllowanceBtn.BorderRadius = 5;
            this.addAllowanceBtn.ButtonText = "Register New Allowance";
            this.addAllowanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAllowanceBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addAllowanceBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addAllowanceBtn.Iconimage = null;
            this.addAllowanceBtn.Iconimage_right = null;
            this.addAllowanceBtn.Iconimage_right_Selected = null;
            this.addAllowanceBtn.Iconimage_Selected = null;
            this.addAllowanceBtn.IconMarginLeft = 0;
            this.addAllowanceBtn.IconMarginRight = 0;
            this.addAllowanceBtn.IconRightVisible = true;
            this.addAllowanceBtn.IconRightZoom = 0D;
            this.addAllowanceBtn.IconVisible = true;
            this.addAllowanceBtn.IconZoom = 70D;
            this.addAllowanceBtn.IsTab = false;
            this.addAllowanceBtn.Location = new System.Drawing.Point(270, 215);
            this.addAllowanceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addAllowanceBtn.Name = "addAllowanceBtn";
            this.addAllowanceBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.addAllowanceBtn.OnHovercolor = System.Drawing.Color.Green;
            this.addAllowanceBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addAllowanceBtn.selected = false;
            this.addAllowanceBtn.Size = new System.Drawing.Size(240, 50);
            this.addAllowanceBtn.TabIndex = 38;
            this.addAllowanceBtn.Text = "Register New Allowance";
            this.addAllowanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAllowanceBtn.Textcolor = System.Drawing.Color.White;
            this.addAllowanceBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAllowanceBtn.Click += new System.EventHandler(this.addAllowanceBtn_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(316, 440);
            this.searchPanel.TabIndex = 31;
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
            this.refreshBtn.TabIndex = 51;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addAllowanceTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPanel);
            this.Name = "addAllowanceTab";
            this.Size = new System.Drawing.Size(1149, 440);
            this.Load += new System.EventHandler(this.addAllowanceTab_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox newAllowanceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResultDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel searchPanel;
        private Bunifu.Framework.UI.BunifuFlatButton addAllowanceBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
    }
}
