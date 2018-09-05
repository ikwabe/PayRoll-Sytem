namespace PayRoll_Sytem
{
    partial class ViewActivites
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewActivites));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.activityDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.viewActivityBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewAllActivitiesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activityDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoPhoto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 184);
            this.panel1.TabIndex = 9;
            // 
            // logoPhoto
            // 
            this.logoPhoto.Image = global::PayRoll_Sytem.Properties.Resources._Church_logo;
            this.logoPhoto.Location = new System.Drawing.Point(382, 25);
            this.logoPhoto.Name = "logoPhoto";
            this.logoPhoto.Size = new System.Drawing.Size(622, 95);
            this.logoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPhoto.TabIndex = 3;
            this.logoPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(487, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACTIVITIES DONE BY USER(S)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(868, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 184);
            this.panel2.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(3, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(33, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 4;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 308);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.viewAllActivitiesBtn);
            this.panel4.Controls.Add(this.viewActivityBtn);
            this.panel4.Controls.Add(this.activityDate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 171);
            this.panel4.TabIndex = 0;
            // 
            // activityDate
            // 
            this.activityDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.activityDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activityDate.Location = new System.Drawing.Point(78, 45);
            this.activityDate.Name = "activityDate";
            this.activityDate.Size = new System.Drawing.Size(356, 27);
            this.activityDate.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(74, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "You may specify by Select The Date here";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.activityDataGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 137);
            this.panel5.TabIndex = 1;
            // 
            // viewActivityBtn
            // 
            this.viewActivityBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.viewActivityBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.viewActivityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewActivityBtn.BorderRadius = 5;
            this.viewActivityBtn.ButtonText = "View Activitie(s)";
            this.viewActivityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewActivityBtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewActivityBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewActivityBtn.Iconimage = null;
            this.viewActivityBtn.Iconimage_right = null;
            this.viewActivityBtn.Iconimage_right_Selected = null;
            this.viewActivityBtn.Iconimage_Selected = null;
            this.viewActivityBtn.IconMarginLeft = 0;
            this.viewActivityBtn.IconMarginRight = 0;
            this.viewActivityBtn.IconRightVisible = true;
            this.viewActivityBtn.IconRightZoom = 0D;
            this.viewActivityBtn.IconVisible = true;
            this.viewActivityBtn.IconZoom = 70D;
            this.viewActivityBtn.IsTab = false;
            this.viewActivityBtn.Location = new System.Drawing.Point(457, 32);
            this.viewActivityBtn.Name = "viewActivityBtn";
            this.viewActivityBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.viewActivityBtn.OnHovercolor = System.Drawing.Color.Green;
            this.viewActivityBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewActivityBtn.selected = false;
            this.viewActivityBtn.Size = new System.Drawing.Size(181, 40);
            this.viewActivityBtn.TabIndex = 48;
            this.viewActivityBtn.Text = "View Activitie(s)";
            this.viewActivityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewActivityBtn.Textcolor = System.Drawing.Color.White;
            this.viewActivityBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewActivityBtn.Click += new System.EventHandler(this.viewActivityBtn_Click);
            // 
            // viewAllActivitiesBtn
            // 
            this.viewAllActivitiesBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.viewAllActivitiesBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.viewAllActivitiesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewAllActivitiesBtn.BorderRadius = 5;
            this.viewAllActivitiesBtn.ButtonText = "View All Activitie(s)";
            this.viewAllActivitiesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllActivitiesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewAllActivitiesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewAllActivitiesBtn.Iconimage = null;
            this.viewAllActivitiesBtn.Iconimage_right = null;
            this.viewAllActivitiesBtn.Iconimage_right_Selected = null;
            this.viewAllActivitiesBtn.Iconimage_Selected = null;
            this.viewAllActivitiesBtn.IconMarginLeft = 0;
            this.viewAllActivitiesBtn.IconMarginRight = 0;
            this.viewAllActivitiesBtn.IconRightVisible = true;
            this.viewAllActivitiesBtn.IconRightZoom = 0D;
            this.viewAllActivitiesBtn.IconVisible = true;
            this.viewAllActivitiesBtn.IconZoom = 70D;
            this.viewAllActivitiesBtn.IsTab = false;
            this.viewAllActivitiesBtn.Location = new System.Drawing.Point(12, 103);
            this.viewAllActivitiesBtn.Name = "viewAllActivitiesBtn";
            this.viewAllActivitiesBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.viewAllActivitiesBtn.OnHovercolor = System.Drawing.Color.Green;
            this.viewAllActivitiesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewAllActivitiesBtn.selected = false;
            this.viewAllActivitiesBtn.Size = new System.Drawing.Size(226, 49);
            this.viewAllActivitiesBtn.TabIndex = 49;
            this.viewAllActivitiesBtn.Text = "View All Activitie(s)";
            this.viewAllActivitiesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewAllActivitiesBtn.Textcolor = System.Drawing.Color.White;
            this.viewAllActivitiesBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllActivitiesBtn.Click += new System.EventHandler(this.viewAllActivitiesBtn_Click);
            // 
            // activityDataGrid
            // 
            this.activityDataGrid.AllowUserToAddRows = false;
            this.activityDataGrid.AllowUserToDeleteRows = false;
            this.activityDataGrid.AllowUserToResizeColumns = false;
            this.activityDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.activityDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.activityDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.activityDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.activityDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.activityDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activityDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.activityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activityDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.activityDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityDataGrid.DoubleBuffered = true;
            this.activityDataGrid.EnableHeadersVisualStyles = false;
            this.activityDataGrid.GridColor = System.Drawing.Color.Black;
            this.activityDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.activityDataGrid.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.activityDataGrid.Location = new System.Drawing.Point(0, 0);
            this.activityDataGrid.MultiSelect = false;
            this.activityDataGrid.Name = "activityDataGrid";
            this.activityDataGrid.ReadOnly = true;
            this.activityDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.activityDataGrid.RowHeadersVisible = false;
            this.activityDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.activityDataGrid.ShowEditingIcon = false;
            this.activityDataGrid.Size = new System.Drawing.Size(912, 137);
            this.activityDataGrid.TabIndex = 3;
            // 
            // ViewActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(912, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewActivites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewActivites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker activityDate;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton viewAllActivitiesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton viewActivityBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid activityDataGrid;
    }
}