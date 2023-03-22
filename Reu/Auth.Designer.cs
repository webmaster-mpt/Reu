namespace Reu
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.AuthLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.AuthBtn = new System.Windows.Forms.Button();
            this.RegLbl = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.RefreshPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthLbl
            // 
            this.AuthLbl.AutoSize = true;
            this.AuthLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLbl.Location = new System.Drawing.Point(74, 43);
            this.AuthLbl.Name = "AuthLbl";
            this.AuthLbl.Size = new System.Drawing.Size(192, 34);
            this.AuthLbl.TabIndex = 8;
            this.AuthLbl.Text = "Авторизация";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxt.Location = new System.Drawing.Point(80, 159);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(171, 27);
            this.PasswordTxt.TabIndex = 7;
            this.PasswordTxt.Text = "Пароль";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(80, 112);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(171, 27);
            this.LoginTxt.TabIndex = 6;
            this.LoginTxt.Text = "Логин";
            // 
            // AuthBtn
            // 
            this.AuthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthBtn.Location = new System.Drawing.Point(80, 234);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(171, 31);
            this.AuthBtn.TabIndex = 5;
            this.AuthBtn.Text = "Вход";
            this.AuthBtn.UseVisualStyleBackColor = true;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.ForeColor = System.Drawing.Color.Blue;
            this.RegLbl.Location = new System.Drawing.Point(77, 268);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(72, 13);
            this.RegLbl.TabIndex = 9;
            this.RegLbl.Text = "Регистрация";
            this.RegLbl.Click += new System.EventHandler(this.RegLbl_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(12, 307);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(90, 31);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RefreshPassword
            // 
            this.RefreshPassword.AutoSize = true;
            this.RefreshPassword.ForeColor = System.Drawing.Color.Blue;
            this.RefreshPassword.Location = new System.Drawing.Point(160, 268);
            this.RefreshPassword.Name = "RefreshPassword";
            this.RefreshPassword.Size = new System.Drawing.Size(91, 13);
            this.RefreshPassword.TabIndex = 11;
            this.RefreshPassword.Text = "Забыли пароль?";
            this.RefreshPassword.Click += new System.EventHandler(this.RefreshPassword_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 350);
            this.Controls.Add(this.RefreshPassword);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.AuthLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.AuthBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AuthLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        public System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label RefreshPassword;
    }
}