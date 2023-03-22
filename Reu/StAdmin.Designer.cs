namespace Reu
{
    partial class StAdmin
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
            System.Windows.Forms.Button Back;
            System.Windows.Forms.Button Send;
            System.Windows.Forms.Button Del;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StAdmin));
            this.TelephoneTxt = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.ComboBox();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.GroupLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.CauseLbl = new System.Windows.Forms.Label();
            this.FakLbl = new System.Windows.Forms.Label();
            this.TlNumberLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SNameLbl = new System.Windows.Forms.Label();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.CauseCbox = new System.Windows.Forms.ComboBox();
            this.FakultetCbox = new System.Windows.Forms.ComboBox();
            this.InfoTxt = new System.Windows.Forms.TextBox();
            this.GroupTxt = new System.Windows.Forms.TextBox();
            this.SNameTxt = new System.Windows.Forms.TextBox();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.StatusCl = new System.Windows.Forms.ComboBox();
            this.StAdminDataGrid = new System.Windows.Forms.DataGridView();
            this.WhyNotLbl = new System.Windows.Forms.Label();
            this.StatusNot = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.DateTxt = new System.Windows.Forms.MaskedTextBox();
            Back = new System.Windows.Forms.Button();
            Send = new System.Windows.Forms.Button();
            Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StAdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            Back.BackColor = System.Drawing.Color.MidnightBlue;
            Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Back.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Back.Location = new System.Drawing.Point(12, 406);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(100, 37);
            Back.TabIndex = 51;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = false;
            Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Send
            // 
            Send.BackColor = System.Drawing.Color.MidnightBlue;
            Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Send.Location = new System.Drawing.Point(1036, 409);
            Send.Name = "Send";
            Send.Size = new System.Drawing.Size(184, 37);
            Send.TabIndex = 50;
            Send.Text = "Отправить";
            Send.UseVisualStyleBackColor = false;
            Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Del
            // 
            Del.BackColor = System.Drawing.Color.MidnightBlue;
            Del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Del.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Del.Location = new System.Drawing.Point(728, 415);
            Del.Name = "Del";
            Del.Size = new System.Drawing.Size(121, 31);
            Del.TabIndex = 63;
            Del.Text = "удалить";
            Del.UseVisualStyleBackColor = false;
            Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // TelephoneTxt
            // 
            this.TelephoneTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.TelephoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelephoneTxt.Enabled = false;
            this.TelephoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneTxt.ForeColor = System.Drawing.Color.White;
            this.TelephoneTxt.Location = new System.Drawing.Point(780, 33);
            this.TelephoneTxt.Name = "TelephoneTxt";
            this.TelephoneTxt.Size = new System.Drawing.Size(186, 31);
            this.TelephoneTxt.TabIndex = 53;
            this.TelephoneTxt.Visible = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.MidnightBlue;
            this.Login.DisplayMember = "login";
            this.Login.Enabled = false;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.FormattingEnabled = true;
            this.Login.Location = new System.Drawing.Point(591, 91);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(186, 33);
            this.Login.TabIndex = 52;
            this.Login.ValueMember = "id";
            this.Login.Visible = false;
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.InfoLbl.Location = new System.Drawing.Point(780, 73);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(118, 16);
            this.InfoLbl.TabIndex = 48;
            this.InfoLbl.Text = "Объяснительная";
            this.InfoLbl.Visible = false;
            // 
            // GroupLbl
            // 
            this.GroupLbl.AutoSize = true;
            this.GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.GroupLbl.Location = new System.Drawing.Point(393, 74);
            this.GroupLbl.Name = "GroupLbl";
            this.GroupLbl.Size = new System.Drawing.Size(55, 16);
            this.GroupLbl.TabIndex = 47;
            this.GroupLbl.Text = "Группа";
            this.GroupLbl.Visible = false;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.DateLbl.Location = new System.Drawing.Point(585, 14);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(140, 16);
            this.DateLbl.TabIndex = 46;
            this.DateLbl.Text = "Дата подачи заявки";
            this.DateLbl.Visible = false;
            // 
            // CauseLbl
            // 
            this.CauseLbl.AutoSize = true;
            this.CauseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.CauseLbl.Location = new System.Drawing.Point(9, 72);
            this.CauseLbl.Name = "CauseLbl";
            this.CauseLbl.Size = new System.Drawing.Size(66, 16);
            this.CauseLbl.TabIndex = 45;
            this.CauseLbl.Text = "Причина";
            this.CauseLbl.Visible = false;
            // 
            // FakLbl
            // 
            this.FakLbl.AutoSize = true;
            this.FakLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FakLbl.Location = new System.Drawing.Point(201, 72);
            this.FakLbl.Name = "FakLbl";
            this.FakLbl.Size = new System.Drawing.Size(79, 16);
            this.FakLbl.TabIndex = 44;
            this.FakLbl.Text = "Факультет";
            this.FakLbl.Visible = false;
            // 
            // TlNumberLbl
            // 
            this.TlNumberLbl.AutoSize = true;
            this.TlNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TlNumberLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.TlNumberLbl.Location = new System.Drawing.Point(777, 14);
            this.TlNumberLbl.Name = "TlNumberLbl";
            this.TlNumberLbl.Size = new System.Drawing.Size(137, 16);
            this.TlNumberLbl.TabIndex = 43;
            this.TlNumberLbl.Text = "Телефонный номер";
            this.TlNumberLbl.Visible = false;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.NameLbl.Location = new System.Drawing.Point(201, 14);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(34, 16);
            this.NameLbl.TabIndex = 42;
            this.NameLbl.Text = "Имя";
            this.NameLbl.Visible = false;
            // 
            // SNameLbl
            // 
            this.SNameLbl.AutoSize = true;
            this.SNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.SNameLbl.Location = new System.Drawing.Point(393, 14);
            this.SNameLbl.Name = "SNameLbl";
            this.SNameLbl.Size = new System.Drawing.Size(71, 16);
            this.SNameLbl.TabIndex = 41;
            this.SNameLbl.Text = "Отчество";
            this.SNameLbl.Visible = false;
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNameLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FNameLbl.Location = new System.Drawing.Point(9, 14);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(67, 16);
            this.FNameLbl.TabIndex = 40;
            this.FNameLbl.Text = "Фамилия";
            this.FNameLbl.Visible = false;
            // 
            // CauseCbox
            // 
            this.CauseCbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.CauseCbox.DisplayMember = "name";
            this.CauseCbox.Enabled = false;
            this.CauseCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CauseCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseCbox.ForeColor = System.Drawing.Color.White;
            this.CauseCbox.FormattingEnabled = true;
            this.CauseCbox.Location = new System.Drawing.Point(12, 91);
            this.CauseCbox.Name = "CauseCbox";
            this.CauseCbox.Size = new System.Drawing.Size(186, 33);
            this.CauseCbox.TabIndex = 39;
            this.CauseCbox.ValueMember = "id";
            this.CauseCbox.Visible = false;
            // 
            // FakultetCbox
            // 
            this.FakultetCbox.BackColor = System.Drawing.Color.MidnightBlue;
            this.FakultetCbox.DisplayMember = "name";
            this.FakultetCbox.Enabled = false;
            this.FakultetCbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FakultetCbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakultetCbox.ForeColor = System.Drawing.Color.White;
            this.FakultetCbox.FormattingEnabled = true;
            this.FakultetCbox.Location = new System.Drawing.Point(204, 91);
            this.FakultetCbox.Name = "FakultetCbox";
            this.FakultetCbox.Size = new System.Drawing.Size(186, 33);
            this.FakultetCbox.TabIndex = 38;
            this.FakultetCbox.ValueMember = "id";
            this.FakultetCbox.Visible = false;
            // 
            // InfoTxt
            // 
            this.InfoTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.InfoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoTxt.Enabled = false;
            this.InfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTxt.ForeColor = System.Drawing.Color.White;
            this.InfoTxt.Location = new System.Drawing.Point(783, 92);
            this.InfoTxt.Multiline = true;
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoTxt.Size = new System.Drawing.Size(186, 33);
            this.InfoTxt.TabIndex = 37;
            this.InfoTxt.Visible = false;
            // 
            // GroupTxt
            // 
            this.GroupTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.GroupTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupTxt.Enabled = false;
            this.GroupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTxt.ForeColor = System.Drawing.Color.White;
            this.GroupTxt.Location = new System.Drawing.Point(396, 93);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(186, 31);
            this.GroupTxt.TabIndex = 36;
            this.GroupTxt.Visible = false;
            // 
            // SNameTxt
            // 
            this.SNameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.SNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SNameTxt.Enabled = false;
            this.SNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNameTxt.ForeColor = System.Drawing.Color.White;
            this.SNameTxt.Location = new System.Drawing.Point(396, 33);
            this.SNameTxt.Name = "SNameTxt";
            this.SNameTxt.Size = new System.Drawing.Size(186, 31);
            this.SNameTxt.TabIndex = 35;
            this.SNameTxt.Visible = false;
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxt.Enabled = false;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.ForeColor = System.Drawing.Color.White;
            this.NameTxt.Location = new System.Drawing.Point(204, 33);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(186, 31);
            this.NameTxt.TabIndex = 34;
            this.NameTxt.Visible = false;
            // 
            // FNameTxt
            // 
            this.FNameTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.FNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameTxt.Enabled = false;
            this.FNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNameTxt.ForeColor = System.Drawing.Color.White;
            this.FNameTxt.Location = new System.Drawing.Point(12, 33);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(186, 31);
            this.FNameTxt.TabIndex = 32;
            this.FNameTxt.Visible = false;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.UserLbl.Location = new System.Drawing.Point(591, 72);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(103, 16);
            this.UserLbl.TabIndex = 55;
            this.UserLbl.Text = "Пользователь";
            this.UserLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.StatusLbl.Location = new System.Drawing.Point(270, 394);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(103, 16);
            this.StatusLbl.TabIndex = 57;
            this.StatusLbl.Text = "Статус заявки";
            // 
            // StatusCl
            // 
            this.StatusCl.BackColor = System.Drawing.Color.MidnightBlue;
            this.StatusCl.DisplayMember = "login";
            this.StatusCl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatusCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusCl.ForeColor = System.Drawing.Color.White;
            this.StatusCl.FormattingEnabled = true;
            this.StatusCl.Items.AddRange(new object[] {
            "Принято",
            "Отказано"});
            this.StatusCl.Location = new System.Drawing.Point(270, 413);
            this.StatusCl.Name = "StatusCl";
            this.StatusCl.Size = new System.Drawing.Size(186, 33);
            this.StatusCl.TabIndex = 56;
            this.StatusCl.ValueMember = "id";
            this.StatusCl.SelectedIndexChanged += new System.EventHandler(this.StatusCl_SelectedIndexChanged);
            // 
            // StAdminDataGrid
            // 
            this.StAdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StAdminDataGrid.Location = new System.Drawing.Point(12, 12);
            this.StAdminDataGrid.Name = "StAdminDataGrid";
            this.StAdminDataGrid.ReadOnly = true;
            this.StAdminDataGrid.Size = new System.Drawing.Size(1208, 372);
            this.StAdminDataGrid.TabIndex = 58;
            this.StAdminDataGrid.SelectionChanged += new System.EventHandler(this.StAdminDataGrid_SelectionChanged);
            // 
            // WhyNotLbl
            // 
            this.WhyNotLbl.AutoSize = true;
            this.WhyNotLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhyNotLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.WhyNotLbl.Location = new System.Drawing.Point(462, 393);
            this.WhyNotLbl.Name = "WhyNotLbl";
            this.WhyNotLbl.Size = new System.Drawing.Size(176, 16);
            this.WhyNotLbl.TabIndex = 60;
            this.WhyNotLbl.Text = "Причина в случае отказа";
            // 
            // StatusNot
            // 
            this.StatusNot.BackColor = System.Drawing.Color.MidnightBlue;
            this.StatusNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusNot.ForeColor = System.Drawing.Color.White;
            this.StatusNot.Location = new System.Drawing.Point(462, 415);
            this.StatusNot.Name = "StatusNot";
            this.StatusNot.Size = new System.Drawing.Size(260, 31);
            this.StatusNot.TabIndex = 61;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.ForeColor = System.Drawing.Color.GhostWhite;
            this.id.Location = new System.Drawing.Point(12, 387);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 16);
            this.id.TabIndex = 62;
            this.id.Text = "id";
            this.id.Visible = false;
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.CountLbl.Location = new System.Drawing.Point(883, 391);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(135, 16);
            this.CountLbl.TabIndex = 65;
            this.CountLbl.Text = "Количество заявок";
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.Color.MidnightBlue;
            this.count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.count.ForeColor = System.Drawing.Color.White;
            this.count.Location = new System.Drawing.Point(883, 415);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(135, 31);
            this.count.TabIndex = 67;
            // 
            // DateTxt
            // 
            this.DateTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.DateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateTxt.ForeColor = System.Drawing.Color.White;
            this.DateTxt.Location = new System.Drawing.Point(588, 33);
            this.DateTxt.Mask = "00/00/0000";
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(186, 31);
            this.DateTxt.TabIndex = 68;
            this.DateTxt.Visible = false;
            // 
            // StAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.CountLbl);
            this.Controls.Add(Del);
            this.Controls.Add(this.id);
            this.Controls.Add(this.StatusNot);
            this.Controls.Add(this.WhyNotLbl);
            this.Controls.Add(this.StAdminDataGrid);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.StatusCl);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.TelephoneTxt);
            this.Controls.Add(this.Login);
            this.Controls.Add(Back);
            this.Controls.Add(Send);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.GroupLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.CauseLbl);
            this.Controls.Add(this.FakLbl);
            this.Controls.Add(this.TlNumberLbl);
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
            this.Controls.Add(this.DateTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр Заявок";
            ((System.ComponentModel.ISupportInitialize)(this.StAdminDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TelephoneTxt;
        public System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label GroupLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label CauseLbl;
        private System.Windows.Forms.Label FakLbl;
        private System.Windows.Forms.Label TlNumberLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SNameLbl;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.ComboBox CauseCbox;
        private System.Windows.Forms.ComboBox FakultetCbox;
        private System.Windows.Forms.TextBox InfoTxt;
        private System.Windows.Forms.TextBox GroupTxt;
        private System.Windows.Forms.TextBox SNameTxt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label StatusLbl;
        public System.Windows.Forms.ComboBox StatusCl;
        private System.Windows.Forms.DataGridView StAdminDataGrid;
        private System.Windows.Forms.Label WhyNotLbl;
        private System.Windows.Forms.TextBox StatusNot;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.MaskedTextBox DateTxt;
    }
}