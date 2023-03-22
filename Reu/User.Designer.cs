namespace Reu
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.UserDtGrid = new System.Windows.Forms.DataGridView();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.RoleEditCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdUser = new System.Windows.Forms.Button();
            this.DelPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleDelTxt = new System.Windows.Forms.TextBox();
            this.DelUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Function = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDtGrid)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.DelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDtGrid
            // 
            this.UserDtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDtGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserDtGrid.Location = new System.Drawing.Point(229, 64);
            this.UserDtGrid.Name = "UserDtGrid";
            this.UserDtGrid.ReadOnly = true;
            this.UserDtGrid.Size = new System.Drawing.Size(452, 302);
            this.UserDtGrid.TabIndex = 5;
            this.UserDtGrid.SelectionChanged += new System.EventHandler(this.UserDtGrid_SelectionChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.RoleEditCbx);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.EdUser);
            this.EditPanel.Location = new System.Drawing.Point(11, 64);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(212, 80);
            this.EditPanel.TabIndex = 7;
            this.EditPanel.Visible = false;
            // 
            // RoleEditCbx
            // 
            this.RoleEditCbx.BackColor = System.Drawing.Color.Cornsilk;
            this.RoleEditCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleEditCbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleEditCbx.FormattingEnabled = true;
            this.RoleEditCbx.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.RoleEditCbx.Location = new System.Drawing.Point(6, 26);
            this.RoleEditCbx.Name = "RoleEditCbx";
            this.RoleEditCbx.Size = new System.Drawing.Size(121, 21);
            this.RoleEditCbx.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Роль";
            // 
            // EdUser
            // 
            this.EdUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EdUser.Location = new System.Drawing.Point(134, 54);
            this.EdUser.Name = "EdUser";
            this.EdUser.Size = new System.Drawing.Size(75, 23);
            this.EdUser.TabIndex = 0;
            this.EdUser.Text = "Изменить";
            this.EdUser.UseVisualStyleBackColor = true;
            this.EdUser.Click += new System.EventHandler(this.EdUser_Click);
            // 
            // DelPanel
            // 
            this.DelPanel.Controls.Add(this.label3);
            this.DelPanel.Controls.Add(this.RoleDelTxt);
            this.DelPanel.Controls.Add(this.DelUser);
            this.DelPanel.Location = new System.Drawing.Point(11, 150);
            this.DelPanel.Name = "DelPanel";
            this.DelPanel.Size = new System.Drawing.Size(212, 80);
            this.DelPanel.TabIndex = 8;
            this.DelPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Роль";
            // 
            // RoleDelTxt
            // 
            this.RoleDelTxt.BackColor = System.Drawing.Color.Cornsilk;
            this.RoleDelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoleDelTxt.ForeColor = System.Drawing.Color.Black;
            this.RoleDelTxt.Location = new System.Drawing.Point(3, 27);
            this.RoleDelTxt.Name = "RoleDelTxt";
            this.RoleDelTxt.Size = new System.Drawing.Size(142, 20);
            this.RoleDelTxt.TabIndex = 3;
            // 
            // DelUser
            // 
            this.DelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelUser.Location = new System.Drawing.Point(134, 54);
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(75, 23);
            this.DelUser.TabIndex = 0;
            this.DelUser.Text = "Удалить";
            this.DelUser.UseVisualStyleBackColor = true;
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выбор функции";
            // 
            // Function
            // 
            this.Function.BackColor = System.Drawing.Color.Cornsilk;
            this.Function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Function.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function.FormattingEnabled = true;
            this.Function.Items.AddRange(new object[] {
            "Изменение",
            "Удаление"});
            this.Function.Location = new System.Drawing.Point(11, 35);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(121, 21);
            this.Function.TabIndex = 11;
            this.Function.SelectedIndexChanged += new System.EventHandler(this.Function_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(606, 33);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Location = new System.Drawing.Point(148, 43);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(29, 13);
            this.login.TabIndex = 3;
            this.login.Text = "login";
            this.login.Visible = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.password.Location = new System.Drawing.Point(183, 43);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 13);
            this.password.TabIndex = 4;
            this.password.Text = "password";
            this.password.Visible = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(693, 378);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.UserDtGrid);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.DelPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.UserDtGrid)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.DelPanel.ResumeLayout(false);
            this.DelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UserDtGrid;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EdUser;
        private System.Windows.Forms.Panel DelPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoleDelTxt;
        private System.Windows.Forms.Button DelUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Function;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.ComboBox RoleEditCbx;
    }
}