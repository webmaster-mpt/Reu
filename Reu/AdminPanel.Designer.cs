namespace Reu
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.Fak = new System.Windows.Forms.Button();
            this.StAdmin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.BackAuth = new System.Windows.Forms.Button();
            this.SortAndExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fak
            // 
            this.Fak.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fak.Location = new System.Drawing.Point(39, 94);
            this.Fak.Name = "Fak";
            this.Fak.Size = new System.Drawing.Size(233, 53);
            this.Fak.TabIndex = 0;
            this.Fak.Text = "Факультеты";
            this.Fak.UseVisualStyleBackColor = true;
            this.Fak.Click += new System.EventHandler(this.Fak_Click);
            // 
            // StAdmin
            // 
            this.StAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StAdmin.Location = new System.Drawing.Point(39, 166);
            this.StAdmin.Name = "StAdmin";
            this.StAdmin.Size = new System.Drawing.Size(233, 53);
            this.StAdmin.TabIndex = 1;
            this.StAdmin.Text = "Заявки";
            this.StAdmin.UseVisualStyleBackColor = true;
            this.StAdmin.Click += new System.EventHandler(this.StAdmin_Click);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(39, 20);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(233, 54);
            this.user.TabIndex = 2;
            this.user.Text = "Пользователи";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // BackAuth
            // 
            this.BackAuth.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackAuth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackAuth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackAuth.Location = new System.Drawing.Point(100, 349);
            this.BackAuth.Name = "BackAuth";
            this.BackAuth.Size = new System.Drawing.Size(99, 31);
            this.BackAuth.TabIndex = 4;
            this.BackAuth.Text = "Назад";
            this.BackAuth.UseVisualStyleBackColor = false;
            this.BackAuth.Click += new System.EventHandler(this.BackAuth_Click);
            // 
            // SortAndExport
            // 
            this.SortAndExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortAndExport.Location = new System.Drawing.Point(39, 234);
            this.SortAndExport.Name = "SortAndExport";
            this.SortAndExport.Size = new System.Drawing.Size(233, 95);
            this.SortAndExport.TabIndex = 5;
            this.SortAndExport.Text = "Сортировка и Экспорт";
            this.SortAndExport.UseVisualStyleBackColor = true;
            this.SortAndExport.Click += new System.EventHandler(this.SortAndExport_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 392);
            this.Controls.Add(this.SortAndExport);
            this.Controls.Add(this.BackAuth);
            this.Controls.Add(this.user);
            this.Controls.Add(this.StAdmin);
            this.Controls.Add(this.Fak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель Администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fak;
        private System.Windows.Forms.Button StAdmin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button BackAuth;
        private System.Windows.Forms.Button SortAndExport;
    }
}