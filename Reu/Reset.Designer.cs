
namespace Reu
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.ResetLbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetLbl
            // 
            this.ResetLbl.AutoSize = true;
            this.ResetLbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetLbl.Location = new System.Drawing.Point(105, 22);
            this.ResetLbl.Name = "ResetLbl";
            this.ResetLbl.Size = new System.Drawing.Size(207, 34);
            this.ResetLbl.TabIndex = 9;
            this.ResetLbl.Text = "Сброс пароля";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(111, 129);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(201, 27);
            this.Email.TabIndex = 11;
            this.Email.Text = "Введите почту";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(111, 82);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(201, 27);
            this.LoginTxt.TabIndex = 10;
            this.LoginTxt.Text = "Введите логин";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.Location = new System.Drawing.Point(128, 179);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(163, 31);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Отправить";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Code
            // 
            this.Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Code.CausesValidation = false;
            this.Code.Cursor = System.Windows.Forms.Cursors.No;
            this.Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Code.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Code.Location = new System.Drawing.Point(12, -25);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(10, 10);
            this.Code.TabIndex = 19;
            this.Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Code.Visible = false;
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(15, 221);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(90, 31);
            this.Back.TabIndex = 20;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(414, 257);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.ResetLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сброс пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResetLbl;
        private System.Windows.Forms.TextBox Email;
        public System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Button Back;
    }
}