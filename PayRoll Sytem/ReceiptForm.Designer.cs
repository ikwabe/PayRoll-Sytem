namespace PayRoll_Sytem
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lineSp = new Bunifu.Framework.UI.BunifuSeparator();
            this.printReceiptBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sendReceiptBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.miniMizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPhoto = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1370, 590);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lineSp);
            this.panel3.Controls.Add(this.printReceiptBtn);
            this.panel3.Controls.Add(this.sendReceiptBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 72);
            this.panel3.TabIndex = 14;
            // 
            // lineSp
            // 
            this.lineSp.BackColor = System.Drawing.Color.Transparent;
            this.lineSp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.lineSp.LineThickness = 4;
            this.lineSp.Location = new System.Drawing.Point(481, 61);
            this.lineSp.Name = "lineSp";
            this.lineSp.Size = new System.Drawing.Size(188, 10);
            this.lineSp.TabIndex = 0;
            this.lineSp.Transparency = 255;
            this.lineSp.Vertical = false;
            // 
            // printReceiptBtn
            // 
            this.printReceiptBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.printReceiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.printReceiptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.printReceiptBtn.BorderRadius = 0;
            this.printReceiptBtn.ButtonText = "Print Receipt";
            this.printReceiptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printReceiptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.printReceiptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.printReceiptBtn.Iconimage = null;
            this.printReceiptBtn.Iconimage_right = null;
            this.printReceiptBtn.Iconimage_right_Selected = null;
            this.printReceiptBtn.Iconimage_Selected = null;
            this.printReceiptBtn.IconMarginLeft = 0;
            this.printReceiptBtn.IconMarginRight = 0;
            this.printReceiptBtn.IconRightVisible = true;
            this.printReceiptBtn.IconRightZoom = 0D;
            this.printReceiptBtn.IconVisible = true;
            this.printReceiptBtn.IconZoom = 90D;
            this.printReceiptBtn.IsTab = false;
            this.printReceiptBtn.Location = new System.Drawing.Point(677, 6);
            this.printReceiptBtn.Name = "printReceiptBtn";
            this.printReceiptBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.printReceiptBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.printReceiptBtn.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.printReceiptBtn.selected = false;
            this.printReceiptBtn.Size = new System.Drawing.Size(178, 49);
            this.printReceiptBtn.TabIndex = 1;
            this.printReceiptBtn.Text = "Print Receipt";
            this.printReceiptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printReceiptBtn.Textcolor = System.Drawing.Color.LightGray;
            this.printReceiptBtn.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptBtn.Click += new System.EventHandler(this.printReceiptBtn_Click);
            // 
            // sendReceiptBtn
            // 
            this.sendReceiptBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.sendReceiptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.sendReceiptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendReceiptBtn.BorderRadius = 0;
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
            this.sendReceiptBtn.IconZoom = 90D;
            this.sendReceiptBtn.IsTab = false;
            this.sendReceiptBtn.Location = new System.Drawing.Point(484, 6);
            this.sendReceiptBtn.Name = "sendReceiptBtn";
            this.sendReceiptBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.sendReceiptBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.sendReceiptBtn.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.sendReceiptBtn.selected = false;
            this.sendReceiptBtn.Size = new System.Drawing.Size(187, 49);
            this.sendReceiptBtn.TabIndex = 0;
            this.sendReceiptBtn.Text = "Send Receipt";
            this.sendReceiptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendReceiptBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.sendReceiptBtn.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendReceiptBtn.Click += new System.EventHandler(this.sendReceiptBtn_Click);
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
            this.headerPanel.TabIndex = 13;
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
            this.label1.Location = new System.Drawing.Point(589, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECEIPTS";
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
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel3.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniMizeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuSeparator lineSp;
        private Bunifu.Framework.UI.BunifuFlatButton printReceiptBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sendReceiptBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton miniMizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPhoto;
    }
}