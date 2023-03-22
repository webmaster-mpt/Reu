namespace Reu
{
    partial class Lk
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
            System.Windows.Forms.Button SaveDocx;
            System.Windows.Forms.Button Back;
            System.Windows.Forms.Button Se;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lk));
            this.LkDataGrid = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.TextBox();
            this.TelephoneTxt = new System.Windows.Forms.TextBox();
            this.Grouplbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.CauseLbl = new System.Windows.Forms.Label();
            this.Faklbl = new System.Windows.Forms.Label();
            this.TlNumlbl = new System.Windows.Forms.Label();
            this.InfoTxt = new System.Windows.Forms.TextBox();
            this.GroupTxt = new System.Windows.Forms.TextBox();
            this.OtTxt = new System.Windows.Forms.TextBox();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.FIOLbl = new System.Windows.Forms.Label();
            this.CauseTxt = new System.Windows.Forms.TextBox();
            this.FakTxt = new System.Windows.Forms.TextBox();
            this.DateTxt = new System.Windows.Forms.MaskedTextBox();
            this.Email = new System.Windows.Forms.ComboBox();
            SaveDocx = new System.Windows.Forms.Button();
            Back = new System.Windows.Forms.Button();
            Se = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LkDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveDocx
            // 
            SaveDocx.BackColor = System.Drawing.Color.MidnightBlue;
            SaveDocx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            SaveDocx.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SaveDocx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SaveDocx.Location = new System.Drawing.Point(962, 326);
            SaveDocx.Name = "SaveDocx";
            SaveDocx.Size = new System.Drawing.Size(189, 36);
            SaveDocx.TabIndex = 4;
            SaveDocx.Text = "Сохранить на пк";
            SaveDocx.UseVisualStyleBackColor = false;
            SaveDocx.Click += new System.EventHandler(this.SaveDocx_Click);
            // 
            // Back
            // 
            Back.BackColor = System.Drawing.Color.MidnightBlue;
            Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Back.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Back.Location = new System.Drawing.Point(12, 447);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(100, 37);
            Back.TabIndex = 52;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = false;
            Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Se
            // 
            Se.BackColor = System.Drawing.Color.MidnightBlue;
            Se.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Se.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Se.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Se.Location = new System.Drawing.Point(962, 373);
            Se.Name = "Se";
            Se.Size = new System.Drawing.Size(189, 83);
            Se.TabIndex = 53;
            Se.Text = "Получить документ на почту";
            Se.UseVisualStyleBackColor = false;
            Se.Click += new System.EventHandler(this.Se_Click);
            // 
            // LkDataGrid
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.LkDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LkDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.LkDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.LkDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LkDataGrid.Location = new System.Drawing.Point(12, 12);
            this.LkDataGrid.Name = "LkDataGrid";
            this.LkDataGrid.ReadOnly = true;
            this.LkDataGrid.Size = new System.Drawing.Size(1139, 308);
            this.LkDataGrid.TabIndex = 2;
            this.LkDataGrid.SelectionChanged += new System.EventHandler(this.LkDataGrid_SelectionChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(545, 413);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(150, 20);
            this.Login.TabIndex = 6;
            this.Login.Visible = false;
            // 
            // TelephoneTxt
            // 
            this.TelephoneTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.TelephoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelephoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneTxt.ForeColor = System.Drawing.Color.White;
            this.TelephoneTxt.Location = new System.Drawing.Point(11, 402);
            this.TelephoneTxt.Name = "TelephoneTxt";
            this.TelephoneTxt.Size = new System.Drawing.Size(186, 31);
            this.TelephoneTxt.TabIndex = 48;
            this.TelephoneTxt.Visible = false;
            // 
            // Grouplbl
            // 
            this.Grouplbl.AutoSize = true;
            this.Grouplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Grouplbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.Grouplbl.Location = new System.Drawing.Point(371, 383);
            this.Grouplbl.Name = "Grouplbl";
            this.Grouplbl.Size = new System.Drawing.Size(55, 16);
            this.Grouplbl.TabIndex = 46;
            this.Grouplbl.Text = "Группа";
            this.Grouplbl.Visible = false;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datelbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.Datelbl.Location = new System.Drawing.Point(371, 326);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(98, 16);
            this.Datelbl.TabIndex = 45;
            this.Datelbl.Text = "Текущая дата";
            this.Datelbl.Visible = false;
            // 
            // CauseLbl
            // 
            this.CauseLbl.AutoSize = true;
            this.CauseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.CauseLbl.Location = new System.Drawing.Point(200, 326);
            this.CauseLbl.Name = "CauseLbl";
            this.CauseLbl.Size = new System.Drawing.Size(66, 16);
            this.CauseLbl.TabIndex = 44;
            this.CauseLbl.Text = "Причина";
            this.CauseLbl.Visible = false;
            // 
            // Faklbl
            // 
            this.Faklbl.AutoSize = true;
            this.Faklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Faklbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.Faklbl.Location = new System.Drawing.Point(200, 383);
            this.Faklbl.Name = "Faklbl";
            this.Faklbl.Size = new System.Drawing.Size(79, 16);
            this.Faklbl.TabIndex = 43;
            this.Faklbl.Text = "Факультет";
            this.Faklbl.Visible = false;
            // 
            // TlNumlbl
            // 
            this.TlNumlbl.AutoSize = true;
            this.TlNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TlNumlbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.TlNumlbl.Location = new System.Drawing.Point(8, 383);
            this.TlNumlbl.Name = "TlNumlbl";
            this.TlNumlbl.Size = new System.Drawing.Size(137, 16);
            this.TlNumlbl.TabIndex = 42;
            this.TlNumlbl.Text = "Телефонный номер";
            this.TlNumlbl.Visible = false;
            // 
            // InfoTxt
            // 
            this.InfoTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.InfoTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTxt.ForeColor = System.Drawing.Color.White;
            this.InfoTxt.Location = new System.Drawing.Point(545, 345);
            this.InfoTxt.Multiline = true;
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.Size = new System.Drawing.Size(150, 31);
            this.InfoTxt.TabIndex = 36;
            this.InfoTxt.Visible = false;
            // 
            // GroupTxt
            // 
            this.GroupTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.GroupTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTxt.ForeColor = System.Drawing.Color.White;
            this.GroupTxt.Location = new System.Drawing.Point(374, 402);
            this.GroupTxt.Name = "GroupTxt";
            this.GroupTxt.Size = new System.Drawing.Size(165, 31);
            this.GroupTxt.TabIndex = 35;
            this.GroupTxt.Visible = false;
            // 
            // OtTxt
            // 
            this.OtTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.OtTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtTxt.ForeColor = System.Drawing.Color.White;
            this.OtTxt.Location = new System.Drawing.Point(12, 345);
            this.OtTxt.Name = "OtTxt";
            this.OtTxt.Size = new System.Drawing.Size(186, 31);
            this.OtTxt.TabIndex = 32;
            this.OtTxt.Visible = false;
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.InfoLbl.Location = new System.Drawing.Point(542, 326);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(118, 16);
            this.InfoLbl.TabIndex = 47;
            this.InfoLbl.Text = "Объяснительная";
            this.InfoLbl.Visible = false;
            // 
            // FIOLbl
            // 
            this.FIOLbl.AutoSize = true;
            this.FIOLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FIOLbl.Location = new System.Drawing.Point(9, 326);
            this.FIOLbl.Name = "FIOLbl";
            this.FIOLbl.Size = new System.Drawing.Size(25, 16);
            this.FIOLbl.TabIndex = 39;
            this.FIOLbl.Text = "От";
            this.FIOLbl.Visible = false;
            // 
            // CauseTxt
            // 
            this.CauseTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.CauseTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CauseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CauseTxt.ForeColor = System.Drawing.Color.White;
            this.CauseTxt.Location = new System.Drawing.Point(203, 345);
            this.CauseTxt.Name = "CauseTxt";
            this.CauseTxt.Size = new System.Drawing.Size(165, 31);
            this.CauseTxt.TabIndex = 50;
            this.CauseTxt.Visible = false;
            // 
            // FakTxt
            // 
            this.FakTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.FakTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FakTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakTxt.ForeColor = System.Drawing.Color.White;
            this.FakTxt.Location = new System.Drawing.Point(203, 402);
            this.FakTxt.Name = "FakTxt";
            this.FakTxt.Size = new System.Drawing.Size(165, 31);
            this.FakTxt.TabIndex = 51;
            this.FakTxt.Visible = false;
            // 
            // DateTxt
            // 
            this.DateTxt.BackColor = System.Drawing.Color.MidnightBlue;
            this.DateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateTxt.ForeColor = System.Drawing.Color.White;
            this.DateTxt.Location = new System.Drawing.Point(374, 344);
            this.DateTxt.Mask = "00/00/0000";
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(165, 31);
            this.DateTxt.TabIndex = 54;
            this.DateTxt.Visible = false;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.MidnightBlue;
            this.Email.DisplayMember = "email";
            this.Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.FormattingEnabled = true;
            this.Email.Location = new System.Drawing.Point(701, 342);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(186, 33);
            this.Email.TabIndex = 55;
            this.Email.ValueMember = "id";
            this.Email.Visible = false;
            // 
            // Lk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1163, 490);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(Se);
            this.Controls.Add(Back);
            this.Controls.Add(this.FakTxt);
            this.Controls.Add(this.CauseTxt);
            this.Controls.Add(this.TelephoneTxt);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.Grouplbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.CauseLbl);
            this.Controls.Add(this.Faklbl);
            this.Controls.Add(this.TlNumlbl);
            this.Controls.Add(this.FIOLbl);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.GroupTxt);
            this.Controls.Add(this.OtTxt);
            this.Controls.Add(this.Login);
            this.Controls.Add(SaveDocx);
            this.Controls.Add(this.LkDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.LkDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LkDataGrid;
        public System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox TelephoneTxt;
        private System.Windows.Forms.Label Grouplbl;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label CauseLbl;
        private System.Windows.Forms.Label Faklbl;
        private System.Windows.Forms.Label TlNumlbl;
        private System.Windows.Forms.TextBox InfoTxt;
        private System.Windows.Forms.TextBox GroupTxt;
        private System.Windows.Forms.TextBox OtTxt;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label FIOLbl;
        private System.Windows.Forms.TextBox CauseTxt;
        private System.Windows.Forms.TextBox FakTxt;
        private System.Windows.Forms.MaskedTextBox DateTxt;
        public System.Windows.Forms.ComboBox Email;
    }
}