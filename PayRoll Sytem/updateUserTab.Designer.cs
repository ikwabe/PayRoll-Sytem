namespace PayRoll_Sytem
{
    partial class updateUserTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateUserTab));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchResultDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.searchText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateUserBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passwordTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.firstNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.lastNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.userCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchResultDataGrid);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(316, 463);
            this.searchPanel.TabIndex = 29;
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
            this.searchResultDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchResultDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGrid.DoubleBuffered = true;
            this.searchResultDataGrid.EnableHeadersVisualStyles = false;
            this.searchResultDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.searchResultDataGrid.HeaderForeColor = System.Drawing.Color.DarkGray;
            this.searchResultDataGrid.Location = new System.Drawing.Point(0, 108);
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
            this.searchResultDataGrid.Size = new System.Drawing.Size(316, 355);
            this.searchResultDataGrid.TabIndex = 11;
            this.searchResultDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.searchResultDataGrid_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.searchText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 108);
            this.panel1.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(32, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(224, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Please Write here the User name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(113, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 19);
            this.label16.TabIndex = 7;
            this.label16.Text = "to search.";
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
            this.searchText.Location = new System.Drawing.Point(10, 56);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(288, 34);
            this.searchText.TabIndex = 3;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.OnValueChanged += new System.EventHandler(this.searchText_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Controls.Add(this.deleteUserBtn);
            this.panel2.Controls.Add(this.updateUserBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.userNameTxt);
            this.panel2.Controls.Add(this.passwordTxt);
            this.panel2.Controls.Add(this.firstNameTxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lastNameTxt);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.middleNameTxt);
            this.panel2.Controls.Add(this.userCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(316, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 463);
            this.panel2.TabIndex = 30;
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
            this.refreshBtn.Location = new System.Drawing.Point(22, 62);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.refreshBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.refreshBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshBtn.selected = false;
            this.refreshBtn.Size = new System.Drawing.Size(112, 28);
            this.refreshBtn.TabIndex = 50;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshBtn.Textcolor = System.Drawing.Color.White;
            this.refreshBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteUserBtn.BorderRadius = 5;
            this.deleteUserBtn.ButtonText = "Delete User";
            this.deleteUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteUserBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteUserBtn.Iconimage")));
            this.deleteUserBtn.Iconimage_right = null;
            this.deleteUserBtn.Iconimage_right_Selected = null;
            this.deleteUserBtn.Iconimage_Selected = null;
            this.deleteUserBtn.IconMarginLeft = 0;
            this.deleteUserBtn.IconMarginRight = 0;
            this.deleteUserBtn.IconRightVisible = true;
            this.deleteUserBtn.IconRightZoom = 0D;
            this.deleteUserBtn.IconVisible = true;
            this.deleteUserBtn.IconZoom = 80D;
            this.deleteUserBtn.IsTab = false;
            this.deleteUserBtn.Location = new System.Drawing.Point(121, 362);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.deleteUserBtn.OnHovercolor = System.Drawing.Color.Red;
            this.deleteUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteUserBtn.selected = false;
            this.deleteUserBtn.Size = new System.Drawing.Size(192, 48);
            this.deleteUserBtn.TabIndex = 7;
            this.deleteUserBtn.Text = "Delete User";
            this.deleteUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUserBtn.Textcolor = System.Drawing.Color.White;
            this.deleteUserBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // updateUserBtn
            // 
            this.updateUserBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.updateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.updateUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateUserBtn.BorderRadius = 5;
            this.updateUserBtn.ButtonText = "Update User Info";
            this.updateUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateUserBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateUserBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateUserBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateUserBtn.Iconimage")));
            this.updateUserBtn.Iconimage_right = null;
            this.updateUserBtn.Iconimage_right_Selected = null;
            this.updateUserBtn.Iconimage_Selected = null;
            this.updateUserBtn.IconMarginLeft = 0;
            this.updateUserBtn.IconMarginRight = 0;
            this.updateUserBtn.IconRightVisible = true;
            this.updateUserBtn.IconRightZoom = 0D;
            this.updateUserBtn.IconVisible = true;
            this.updateUserBtn.IconZoom = 70D;
            this.updateUserBtn.IsTab = false;
            this.updateUserBtn.Location = new System.Drawing.Point(330, 362);
            this.updateUserBtn.Name = "updateUserBtn";
            this.updateUserBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.updateUserBtn.OnHovercolor = System.Drawing.Color.Orange;
            this.updateUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateUserBtn.selected = false;
            this.updateUserBtn.Size = new System.Drawing.Size(192, 48);
            this.updateUserBtn.TabIndex = 6;
            this.updateUserBtn.Text = "Update User Info";
            this.updateUserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateUserBtn.Textcolor = System.Drawing.Color.White;
            this.updateUserBtn.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserBtn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(515, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Last Name";
            // 
            // userNameTxt
            // 
            this.userNameTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.userNameTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.userNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.userNameTxt.BorderThickness = 1;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.userNameTxt.isPassword = false;
            this.userNameTxt.Location = new System.Drawing.Point(270, 245);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(198, 34);
            this.userNameTxt.TabIndex = 4;
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.passwordTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.passwordTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.passwordTxt.BorderThickness = 1;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordTxt.isPassword = false;
            this.passwordTxt.Location = new System.Drawing.Point(519, 245);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(198, 34);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.firstNameTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.firstNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.firstNameTxt.BorderThickness = 1;
            this.firstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.firstNameTxt.isPassword = false;
            this.firstNameTxt.Location = new System.Drawing.Point(22, 131);
            this.firstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(198, 34);
            this.firstNameTxt.TabIndex = 0;
            this.firstNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(266, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Username";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.lastNameTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.lastNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.lastNameTxt.BorderThickness = 1;
            this.lastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lastNameTxt.isPassword = false;
            this.lastNameTxt.Location = new System.Drawing.Point(519, 131);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(198, 34);
            this.lastNameTxt.TabIndex = 2;
            this.lastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(515, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 47;
            this.label12.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(20, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "User Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(267, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Middle Name";
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.BorderColorFocused = System.Drawing.Color.DarkGray;
            this.middleNameTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.middleNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.middleNameTxt.BorderThickness = 1;
            this.middleNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.middleNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.middleNameTxt.isPassword = false;
            this.middleNameTxt.Location = new System.Drawing.Point(271, 131);
            this.middleNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(198, 34);
            this.middleNameTxt.TabIndex = 1;
            this.middleNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userCategory
            // 
            this.userCategory.BackColor = System.Drawing.Color.Transparent;
            this.userCategory.BorderRadius = 5;
            this.userCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userCategory.DisabledColor = System.Drawing.Color.Gray;
            this.userCategory.ForeColor = System.Drawing.Color.White;
            this.userCategory.Items = new string[] {
        "Treasurer",
        "Administrator",
        "Accountant"};
            this.userCategory.Location = new System.Drawing.Point(22, 244);
            this.userCategory.Name = "userCategory";
            this.userCategory.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.userCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.userCategory.selectedIndex = -1;
            this.userCategory.Size = new System.Drawing.Size(198, 35);
            this.userCategory.TabIndex = 3;
            // 
            // updateUserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchPanel);
            this.Name = "updateUserTab";
            this.Size = new System.Drawing.Size(851, 463);
            this.Load += new System.EventHandler(this.updateUserTab_Load);
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox userNameTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox firstNameTxt;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox lastNameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox middleNameTxt;
        private Bunifu.Framework.UI.BunifuDropdown userCategory;
        private Bunifu.Framework.UI.BunifuFlatButton updateUserBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteUserBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResultDataGrid;
        private Bunifu.Framework.UI.BunifuFlatButton refreshBtn;
    }
}
