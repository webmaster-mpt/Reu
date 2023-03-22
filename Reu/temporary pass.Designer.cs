namespace Reu
{
    partial class temporary_pass
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
            System.Windows.Forms.Button SendEmail;
            System.Windows.Forms.Button BackToPanelUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temporary_pass));
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            SendEmail = new System.Windows.Forms.Button();
            BackToPanelUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendEmail
            // 
            SendEmail.BackColor = System.Drawing.Color.MidnightBlue;
            SendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            SendEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SendEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SendEmail.Location = new System.Drawing.Point(71, 112);
            SendEmail.Name = "SendEmail";
            SendEmail.Size = new System.Drawing.Size(157, 37);
            SendEmail.TabIndex = 26;
            SendEmail.Text = "Получить";
            SendEmail.UseVisualStyleBackColor = false;
            SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // BackToPanelUser
            // 
            BackToPanelUser.BackColor = System.Drawing.Color.MidnightBlue;
            BackToPanelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BackToPanelUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackToPanelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BackToPanelUser.Location = new System.Drawing.Point(71, 155);
            BackToPanelUser.Name = "BackToPanelUser";
            BackToPanelUser.Size = new System.Drawing.Size(157, 37);
            BackToPanelUser.TabIndex = 33;
            BackToPanelUser.Text = "Назад";
            BackToPanelUser.UseVisualStyleBackColor = false;
            BackToPanelUser.Click += new System.EventHandler(this.BackToPanelUser_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.MidnightBlue;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(12, 57);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(276, 31);
            this.Email.TabIndex = 31;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLbl.ForeColor = System.Drawing.Color.Black;
            this.EmailLbl.Location = new System.Drawing.Point(12, 38);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(68, 16);
            this.EmailLbl.TabIndex = 32;
            this.EmailLbl.Text = "Эл.почта";
            // 
            // temporary_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 198);
            this.Controls.Add(BackToPanelUser);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.Email);
            this.Controls.Add(SendEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "temporary_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Временный пропуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailLbl;
    }
}