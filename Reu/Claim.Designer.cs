namespace Reu
{
    partial class Claim
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
            System.Windows.Forms.Button Send;
            System.Windows.Forms.Button Back;
            System.Windows.Forms.Button Save;
            System.Windows.Forms.Button SendEmail;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Claim));
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SNameTxt = new System.Windows.Forms.TextBox();
            this.InfoTxt = new System.Windows.Forms.TextBox();
            this.GroupTxt = new System.Windows.Forms.TextBox();
            this.FakultetCbox = new System.Windows.Forms.ComboBox();
            this.CauseCbox = new System.Windows.Forms.ComboBox();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.SNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.TeleNumberLbl = new System.Windows.Forms.Label();
            this.FakLbl = new System.Windows.Forms.Label();
            this.CauseLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.PictrureUser = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.ComboBox();
            this.PanelSave = new System.Windows.Forms.Panel();
            this.DateTxt = new System.Windows.Forms.MaskedTextBox();
            this.TelephoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.ComboBox();
            Send = new System.Windows.Forms.Button();
            Back = new System.Windows.Forms.Button();
            Save = new System.Windows.Forms.Button();
            SendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictrureUser)).BeginInit();
            this.PanelSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // Send
            // 
            Send.BackColor = System.Drawing.Color.MidnightBlue;
            Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Send.Location = new System.Drawing.Point(763, 401);
            Send.Name = "Send";
            Send.Size = new System.Drawing.Size(184, 37);
            Send.TabIndex = 25;
            Send.Text = "Отправить заявку";
            Send.UseVisualStyleBackColor = false;
            Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Back
            // 
            Back.BackColor = System.Drawing.Color.MidnightBlue;
            Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Back.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Back.Location = new System.Drawing.Point(12, 401);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(100, 37);
            Back.TabIndex = 26;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = false;
            Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            Save.BackColor = System.Drawing.Color.MidnightBlue;
            Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Save.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Save.Location = new System.Drawing.Point(9, 11);
            Save.Name = "Save";
            Save.Size = new System.Drawing.Size(172, 37);
            Save.TabIndex = 32;
            Save.Text = "сохранить на пк";
            Save.UseVisualStyleBackColor = false;
            Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SendEmail
            // 
            SendEmail.BackColor = System.Drawing.Color.MidnightBlue;
            SendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            SendEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SendEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SendEmail.Location = new System.Drawing.Point(187, 11);
            SendEmail.Name = "SendEmail";
            SendEmail.Size = new System.Drawing.Size(186, 37);
            SendEmail.TabIndex = 33;
            SendEmail.Text = "получить на почту";
            SendEmail.UseVisualStyleBackColor = false;
            SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // FNameTxt
            // 
            this.FNameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.FNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNameTxt.ForeColor = System.Drawing.Color.White;
            this.FNameTxt.Location = new System.Drawing.Point(218, 94);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(210, 31);
            this.FNameTxt.TabIndex = 0;
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.ForeColor = System.Drawing.Color.White;
            this.NameTxt.Location = new System.Drawing.Point(218, 153);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(210, 31);
            this.NameTxt.TabIndex = 6;
            // 
            // SNameTxt
            // 
            this.SNameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.SNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNameTxt.ForeColor = System.Drawing.Color.White;
            this.SNameTxt.Location = new System.Drawing.Point(218, 206);
            this.SNameTxt.Name = "SNameTxt";
            this.SNameTxt.Size = new System.Drawing.Size(210, 31);
            this.SNameTxt.TabIndex = 7;
            // 
            // InfoTxt
            // 
            this.InfoTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.InfoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTxt.ForeColor = System.Drawing.Color.White;
            this.InfoTxt.Location = new System.Drawing.Point(434, 206);
            this.InfoTxt.Multiline = true;
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.Size = new System.Drawing.Size(515, 175);
            this.InfoTxt.TabIndex = 11;
            // 
            // GroupTxt
            // 
            this.GroupTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.GroupTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTxt.ForeColor = System.Drawing.Color.White;
            this.GroupTxt.Location = new System.Drawing.Point(218, 258);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(210, 31);
            this.GroupTxt.TabIndex = 9;
            // 
            // FakultetCbox
            // 
            this.FakultetCbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.FakultetCbox.DisplayMember = "name";
            this.FakultetCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakultetCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakultetCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakultetCbox.ForeColor = System.Drawing.Color.White;
            this.FakultetCbox.FormattingEnabled = true;
            this.FakultetCbox.Location = new System.Drawing.Point(434, 151);
            this.FakultetCbox.Name = "FakultetCbox";
            this.FakultetCbox.Size = new System.Drawing.Size(323, 33);
            this.FakultetCbox.TabIndex = 13;
            this.FakultetCbox.ValueMember = "id";
            // 
            // CauseCbox
            // 
            this.CauseCbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.CauseCbox.DisplayMember = "name";
            this.CauseCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CauseCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CauseCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseCbox.ForeColor = System.Drawing.Color.White;
            this.CauseCbox.FormattingEnabled = true;
            this.CauseCbox.Location = new System.Drawing.Point(434, 92);
            this.CauseCbox.Name = "CauseCbox";
            this.CauseCbox.Size = new System.Drawing.Size(323, 33);
            this.CauseCbox.TabIndex = 14;
            this.CauseCbox.ValueMember = "id";
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FNameLbl.Location = new System.Drawing.Point(215, 75);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(67, 16);
            this.FNameLbl.TabIndex = 15;
            this.FNameLbl.Text = "Фамилия";
            // 
            // SNameLbl
            // 
            this.SNameLbl.AutoSize = true;
            this.SNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.SNameLbl.Location = new System.Drawing.Point(215, 187);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(71, 16);
            this.SNameLbl.TabIndex = 16;
            this.SNameLbl.Text = "Отчество";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.NameLbl.Location = new System.Drawing.Point(215, 134);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(34, 16);
            this.NameLbl.TabIndex = 17;
            this.NameLbl.Text = "Имя";
            // 
            // TeleNumberLbl
            // 
            this.TeleNumberLbl.AutoSize = true;
            this.TeleNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeleNumberLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.TeleNumberLbl.Location = new System.Drawing.Point(760, 132);
            this.TeleNumberLbl.Name = "TeleNumberLbl";
            this.TeleNumberLbl.Size = new System.Drawing.Size(137, 16);
            this.TeleNumberLbl.TabIndex = 18;
            this.TeleNumberLbl.Text = "Телефонный номер";
            // 
            // FakLbl
            // 
            this.FakLbl.AutoSize = true;
            this.FakLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FakLbl.Location = new System.Drawing.Point(431, 132);
            this.FakLbl.Name = "FakLbl";
            this.FakLbl.Size = new System.Drawing.Size(79, 16);
            this.FakLbl.TabIndex = 19;
            this.FakLbl.Text = "Факультет";
            // 
            // CauseLbl
            // 
            this.CauseLbl.AutoSize = true;
            this.CauseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.CauseLbl.Location = new System.Drawing.Point(431, 73);
            this.CauseLbl.Name = "CauseLbl";
            this.CauseLbl.Size = new System.Drawing.Size(66, 16);
            this.CauseLbl.TabIndex = 20;
            this.CauseLbl.Text = "Причина";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.DateLbl.Location = new System.Drawing.Point(760, 77);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(98, 16);
            this.DateLbl.TabIndex = 21;
            this.DateLbl.Text = "Текущая дата";
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.GroupLbl.Location = new System.Drawing.Point(215, 239);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(55, 16);
            this.GroupLbl.TabIndex = 22;
            this.GroupLbl.Text = "Группа";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.InfoLbl.Location = new System.Drawing.Point(431, 187);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(118, 16);
            this.InfoLbl.TabIndex = 23;
            this.InfoLbl.Text = "Объяснительная";
            // 
            // PictrureUser
            // 
            this.PictrureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictrureUser.Image = ((System.Drawing.Image)(resources.GetObject("PictrureUser.Image")));
            this.PictrureUser.Location = new System.Drawing.Point(12, 12);
            this.PictrureUser.Name = "PictrureUser";
            this.PictrureUser.Size = new System.Drawing.Size(190, 217);
            this.PictrureUser.TabIndex = 24;
            this.PictrureUser.TabStop = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.MidnightBlue;
            this.Login.DisplayMember = "login";
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.FormattingEnabled = true;
            this.Login.Location = new System.Drawing.Point(218, 348);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(186, 33);
            this.Login.TabIndex = 29;
            this.Login.ValueMember = "id";
            this.Login.Visible = false;
            // 
            // PanelSave
            // 
            this.PanelSave.Controls.Add(SendEmail);
            this.PanelSave.Controls.Add(Save);
            this.PanelSave.Location = new System.Drawing.Point(220, 387);
            this.PanelSave.Name = "PanelSave";
            this.PanelSave.Size = new System.Drawing.Size(376, 51);
            this.PanelSave.TabIndex = 34;
            this.PanelSave.Visible = false;
            // 
            // DateTxt
            // 
            this.DateTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.DateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateTxt.ForeColor = System.Drawing.Color.White;
            this.DateTxt.Location = new System.Drawing.Point(763, 94);
            this.DateTxt.Mask = "0000/00/00";
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(186, 31);
            this.DateTxt.TabIndex = 35;
            // 
            // TelephoneTxt
            // 
            this.TelephoneTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.TelephoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TelephoneTxt.ForeColor = System.Drawing.Color.White;
            this.TelephoneTxt.Location = new System.Drawing.Point(763, 151);
            this.TelephoneTxt.Mask = "7-(000)-000-00-00";
            this.TelephoneTxt.Name = "TelephoneTxt";
            this.TelephoneTxt.Size = new System.Drawing.Size(186, 31);
            this.TelephoneTxt.TabIndex = 36;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.MidnightBlue;
            this.Email.DisplayMember = "email";
            this.Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.FormattingEnabled = true;
            this.Email.Location = new System.Drawing.Point(218, 309);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(186, 33);
            this.Email.TabIndex = 37;
            this.Email.ValueMember = "id";
            this.Email.Visible = false;
            // 
            // Claim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelephoneTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.PanelSave);
            this.Controls.Add(this.Login);
            this.Controls.Add(Back);
            this.Controls.Add(Send);
            this.Controls.Add(this.PictrureUser);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.CauseLbl);
            this.Controls.Add(this.FakLbl);
            this.Controls.Add(this.TeleNumberLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SNameLbl);
            this.Controls.Add(this.FNameLbl);
            this.Controls.Add(this.CauseCbox);
            this.Controls.Add(this.FakultetCbox);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.GroupTxt);
            this.Controls.Add(this.SNameTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.FNameTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Claim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заявок";
            this.Load += new System.EventHandler(this.Claim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictrureUser)).EndInit();
            this.PanelSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SNameTxt;
        private System.Windows.Forms.TextBox InfoTxt;
        private System.Windows.Forms.TextBox GroupTxt;
        private System.Windows.Forms.ComboBox FakultetCbox;
        private System.Windows.Forms.ComboBox CauseCbox;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.Label SNameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label TeleNumberLbl;
        private System.Windows.Forms.Label FakLbl;
        private System.Windows.Forms.Label CauseLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.PictureBox PictrureUser;
        public System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.Panel PanelSave;
        private System.Windows.Forms.MaskedTextBox DateTxt;
        private System.Windows.Forms.MaskedTextBox TelephoneTxt;
        public System.Windows.Forms.ComboBox Email;
    }
}