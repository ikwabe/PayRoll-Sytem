namespace PayRoll_Sytem
{
    partial class VerifyLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyLogin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.verifyBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // password
            // 
            this.password.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.password.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.password.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.password.BorderThickness = 1;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gainsboro;
            this.password.isPassword = true;
            this.password.Location = new System.Drawing.Point(27, 122);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(312, 36);
            this.password.TabIndex = 2;
            this.password.Text = "zege";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Verify if it is you!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Enter Your Password";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.employeeNameLabel.Location = new System.Drawing.Point(31, 56);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(0, 26);
            this.employeeNameLabel.TabIndex = 50;
            // 
            // verifyBtn
            // 
            this.verifyBtn.Activecolor = System.Drawing.Color.ForestGreen;
            this.verifyBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.verifyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verifyBtn.BorderRadius = 5;
            this.verifyBtn.ButtonText = "Verify Me";
            this.verifyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifyBtn.DisabledColor = System.Drawing.Color.Gray;
            this.verifyBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.verifyBtn.Iconimage = null;
            this.verifyBtn.Iconimage_right = null;
            this.verifyBtn.Iconimage_right_Selected = null;
            this.verifyBtn.Iconimage_Selected = null;
            this.verifyBtn.IconMarginLeft = 0;
            this.verifyBtn.IconMarginRight = 0;
            this.verifyBtn.IconRightVisible = true;
            this.verifyBtn.IconRightZoom = 0D;
            this.verifyBtn.IconVisible = true;
            this.verifyBtn.IconZoom = 70D;
            this.verifyBtn.IsTab = false;
            this.verifyBtn.Location = new System.Drawing.Point(27, 165);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Normalcolor = System.Drawing.Color.ForestGreen;
            this.verifyBtn.OnHovercolor = System.Drawing.Color.Green;
            this.verifyBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.verifyBtn.selected = false;
            this.verifyBtn.Size = new System.Drawing.Size(312, 36);
            this.verifyBtn.TabIndex = 51;
            this.verifyBtn.Text = "Verify Me";
            this.verifyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.verifyBtn.Textcolor = System.Drawing.Color.White;
            this.verifyBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(345, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 18);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 52;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // VerifyLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(374, 226);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerifyLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerifyLogin";
            this.Load += new System.EventHandler(this.VerifyLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label employeeNameLabel;
        private Bunifu.Framework.UI.BunifuFlatButton verifyBtn;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
    }
}