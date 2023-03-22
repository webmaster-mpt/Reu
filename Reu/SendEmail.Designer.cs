namespace Reu
{
    partial class SendEmail
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
            System.Windows.Forms.Button BackToLk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.EmailLbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            Send = new System.Windows.Forms.Button();
            BackToLk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send
            // 
            Send.BackColor = System.Drawing.Color.MidnightBlue;
            Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Send.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Send.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Send.Location = new System.Drawing.Point(70, 112);
            Send.Name = "Send";
            Send.Size = new System.Drawing.Size(157, 37);
            Send.TabIndex = 33;
            Send.Text = "Получить";
            Send.UseVisualStyleBackColor = false;
            Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BackToLk
            // 
            BackToLk.BackColor = System.Drawing.Color.MidnightBlue;
            BackToLk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BackToLk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackToLk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BackToLk.Location = new System.Drawing.Point(70, 155);
            BackToLk.Name = "BackToLk";
            BackToLk.Size = new System.Drawing.Size(157, 37);
            BackToLk.TabIndex = 36;
            BackToLk.Text = "Назад";
            BackToLk.UseVisualStyleBackColor = false;
            BackToLk.Click += new System.EventHandler(this.BackToLk_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLbl.ForeColor = System.Drawing.Color.Black;
            this.EmailLbl.Location = new System.Drawing.Point(11, 38);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(68, 16);
            this.EmailLbl.TabIndex = 35;
            this.EmailLbl.Text = "Эл.почта";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.MidnightBlue;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(11, 57);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(276, 31);
            this.Email.TabIndex = 34;
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 204);
            this.Controls.Add(BackToLk);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.Email);
            this.Controls.Add(Send);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Получить заявку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox Email;
    }
}