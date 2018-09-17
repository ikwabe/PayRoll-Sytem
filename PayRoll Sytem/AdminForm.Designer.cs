namespace PayRoll_Sytem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.miniMizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPhoto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lineSp = new Bunifu.Framework.UI.BunifuSeparator();
            this.updateUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkActivityBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.removedEmployeeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.panel2);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1370, 110);
            this.headerPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.miniMizeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1285, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 110);
            this.panel2.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(42, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(33, 28);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // miniMizeBtn
            // 
            this.miniMizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.miniMizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniMizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("miniMizeBtn.Image")));
            this.miniMizeBtn.ImageActive = null;
            this.miniMizeBtn.Location = new System.Drawing.Point(3, 12);
            this.miniMizeBtn.Name = "miniMizeBtn";
            this.miniMizeBtn.Size = new System.Drawing.Size(33, 28);
            this.miniMizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.miniMizeBtn.TabIndex = 1;
            this.miniMizeBtn.TabStop = false;
            this.miniMizeBtn.Zoom = 10;
            this.miniMizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.miniMizeBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(482, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoPhoto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 110);
            this.panel1.TabIndex = 0;
            // 
            // logoPhoto
            // 
            this.logoPhoto.Image = global::PayRoll_Sytem.Properties.Resources._1497134779090_320x320;
            this.logoPhoto.Location = new System.Drawing.Point(12, 12);
            this.logoPhoto.Name = "logoPhoto";
            this.logoPhoto.Size = new System.Drawing.Size(117, 95);
            this.logoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPhoto.TabIndex = 0;
            this.logoPhoto.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lineSp);
            this.panel3.Controls.Add(this.updateUserBtn);
            this.panel3.Controls.Add(this.addUserBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 72);
            this.panel3.TabIndex = 2;
            // 
            // lineSp
            // 
            this.lineSp.BackColor = System.Drawing.Color.Transparent;
            this.lineSp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.lineSp.LineThickness = 4;
            this.lineSp.Location = new System.Drawing.Point(361, 61);
            this.lineSp.Name = "lineSp";
            this.lineSp.Size = new System.Drawing.Size(180, 10);
            this.lineSp.TabIndex = 0;
            this.lineSp.Transparency = 255;
            this.lineSp.Vertical = false;
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.updateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.updateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateUserBtn.BorderRadius = 0;
            this.updateUserBtn.ButtonText = "Update User Informations";
            this.updateUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateUserBtn.Iconimage = null;
            this.updateUserBtn.Iconimage_right = null;
            this.updateUserBtn.Iconimage_right_Selected = null;
            this.updateUserBtn.Iconimage_Selected = null;
            this.updateUserBtn.IconMarginLeft = 0;
            this.updateUserBtn.IconMarginRight = 0;
            this.updateUserBtn.IconRightVisible = true;
            this.updateUserBtn.IconRightZoom = 0D;
            this.updateUserBtn.IconVisible = true;
            this.updateUserBtn.IconZoom = 90D;
            this.updateUserBtn.IsTab = false;
            this.updateUserBtn.Location = new System.Drawing.Point(549, 6);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.updateUserBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.updateUserBtn.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.updateUserBtn.selected = false;
            this.updateUserBtn.Size = new System.Drawing.Size(317, 49);
            this.updateUserBtn.TabIndex = 1;
            this.updateUserBtn.Text = "Update User Informations";
            this.updateUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateUserBtn.Textcolor = System.Drawing.Color.LightGray;
            this.updateUserBtn.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserBtn.BorderRadius = 0;
            this.addUserBtn.ButtonText = "Register User";
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addUserBtn.Iconimage = null;
            this.addUserBtn.Iconimage_right = null;
            this.addUserBtn.Iconimage_right_Selected = null;
            this.addUserBtn.Iconimage_Selected = null;
            this.addUserBtn.IconMarginLeft = 0;
            this.addUserBtn.IconMarginRight = 0;
            this.addUserBtn.IconRightVisible = true;
            this.addUserBtn.IconRightZoom = 0D;
            this.addUserBtn.IconVisible = true;
            this.addUserBtn.IconZoom = 90D;
            this.addUserBtn.IsTab = false;
            this.addUserBtn.Location = new System.Drawing.Point(361, 6);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.addUserBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.addUserBtn.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.addUserBtn.selected = false;
            this.addUserBtn.Size = new System.Drawing.Size(182, 49);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Register User";
            this.addUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUserBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.addUserBtn.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // checkActivityBtn
            // 
            this.checkActivityBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.checkActivityBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.checkActivityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkActivityBtn.BorderRadius = 5;
            this.checkActivityBtn.ButtonText = "Check User Activitie(s)";
            this.checkActivityBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkActivityBtn.DisabledColor = System.Drawing.Color.Gray;
            this.checkActivityBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkActivityBtn.Iconimage = null;
            this.checkActivityBtn.Iconimage_right = null;
            this.checkActivityBtn.Iconimage_right_Selected = null;
            this.checkActivityBtn.Iconimage_Selected = null;
            this.checkActivityBtn.IconMarginLeft = 0;
            this.checkActivityBtn.IconMarginRight = 0;
            this.checkActivityBtn.IconRightVisible = true;
            this.checkActivityBtn.IconRightZoom = 0D;
            this.checkActivityBtn.IconVisible = true;
            this.checkActivityBtn.IconZoom = 70D;
            this.checkActivityBtn.IsTab = false;
            this.checkActivityBtn.Location = new System.Drawing.Point(32, 60);
            this.checkActivityBtn.Name = "checkActivityBtn";
            this.checkActivityBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.checkActivityBtn.OnHovercolor = System.Drawing.Color.Green;
            this.checkActivityBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkActivityBtn.selected = false;
            this.checkActivityBtn.Size = new System.Drawing.Size(226, 49);
            this.checkActivityBtn.TabIndex = 50;
            this.checkActivityBtn.Text = "Check User Activitie(s)";
            this.checkActivityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkActivityBtn.Textcolor = System.Drawing.Color.White;
            this.checkActivityBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActivityBtn.Click += new System.EventHandler(this.checkActivityBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.removedEmployeeBtn);
            this.panel5.Controls.Add(this.checkActivityBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1082, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 590);
            this.panel5.TabIndex = 51;
            // 
            // removedEmployeeBtn
            // 
            this.removedEmployeeBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.removedEmployeeBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.removedEmployeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removedEmployeeBtn.BorderRadius = 5;
            this.removedEmployeeBtn.ButtonText = "Removed Employee(s)";
            this.removedEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removedEmployeeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.removedEmployeeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.removedEmployeeBtn.Iconimage = null;
            this.removedEmployeeBtn.Iconimage_right = null;
            this.removedEmployeeBtn.Iconimage_right_Selected = null;
            this.removedEmployeeBtn.Iconimage_Selected = null;
            this.removedEmployeeBtn.IconMarginLeft = 0;
            this.removedEmployeeBtn.IconMarginRight = 0;
            this.removedEmployeeBtn.IconRightVisible = true;
            this.removedEmployeeBtn.IconRightZoom = 0D;
            this.removedEmployeeBtn.IconVisible = true;
            this.removedEmployeeBtn.IconZoom = 70D;
            this.removedEmployeeBtn.IsTab = false;
            this.removedEmployeeBtn.Location = new System.Drawing.Point(32, 132);
            this.removedEmployeeBtn.Name = "removedEmployeeBtn";
            this.removedEmployeeBtn.Normalcolor = System.Drawing.Color.SeaGreen;
            this.removedEmployeeBtn.OnHovercolor = System.Drawing.Color.Green;
            this.removedEmployeeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.removedEmployeeBtn.selected = false;
            this.removedEmployeeBtn.Size = new System.Drawing.Size(226, 49);
            this.removedEmployeeBtn.TabIndex = 51;
            this.removedEmployeeBtn.Text = "Removed Employee(s)";
            this.removedEmployeeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removedEmployeeBtn.Textcolor = System.Drawing.Color.White;
            this.removedEmployeeBtn.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removedEmployeeBtn.Click += new System.EventHandler(this.removedEmployeeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1082, 590);
            this.panel4.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "OTHER OPERATIONS";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton miniMizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPhoto;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton updateUserBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addUserBtn;
        private Bunifu.Framework.UI.BunifuSeparator lineSp;
        private Bunifu.Framework.UI.BunifuFlatButton checkActivityBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton removedEmployeeBtn;
        private System.Windows.Forms.Label label2;
    }
}