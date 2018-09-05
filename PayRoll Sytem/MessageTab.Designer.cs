namespace PayRoll_Sytem
{
    partial class MessageTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageTab));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.messageTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendMessageBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // messageTxt
            // 
            this.messageTxt.BackColor = System.Drawing.SystemColors.Info;
            this.messageTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.messageTxt.Location = new System.Drawing.Point(28, 51);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(745, 96);
            this.messageTxt.TabIndex = 0;
            this.messageTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message:";
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.ActiveBorderThickness = 1;
            this.sendMessageBtn.ActiveCornerRadius = 20;
            this.sendMessageBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.sendMessageBtn.ActiveForecolor = System.Drawing.Color.White;
            this.sendMessageBtn.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.sendMessageBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.sendMessageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sendMessageBtn.BackgroundImage")));
            this.sendMessageBtn.ButtonText = "Send";
            this.sendMessageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessageBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.sendMessageBtn.IdleBorderThickness = 1;
            this.sendMessageBtn.IdleCornerRadius = 20;
            this.sendMessageBtn.IdleFillColor = System.Drawing.Color.DimGray;
            this.sendMessageBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.sendMessageBtn.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.sendMessageBtn.Location = new System.Drawing.Point(219, 151);
            this.sendMessageBtn.Margin = new System.Windows.Forms.Padding(5);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(181, 45);
            this.sendMessageBtn.TabIndex = 3;
            this.sendMessageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.ActiveBorderThickness = 1;
            this.cancelBtn.ActiveCornerRadius = 20;
            this.cancelBtn.ActiveFillColor = System.Drawing.Color.SlateGray;
            this.cancelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelBtn.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelBtn.IdleBorderThickness = 1;
            this.cancelBtn.IdleCornerRadius = 20;
            this.cancelBtn.IdleFillColor = System.Drawing.Color.DimGray;
            this.cancelBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.cancelBtn.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.cancelBtn.Location = new System.Drawing.Point(410, 151);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(181, 45);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MessageTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(806, 210);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendMessageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.RichTextBox messageTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 sendMessageBtn;
        private System.Windows.Forms.Label label1;
    }
}