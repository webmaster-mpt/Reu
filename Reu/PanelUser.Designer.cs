namespace Reu
{
    partial class PanelUser
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
            System.Windows.Forms.Button Propusk;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lk = new System.Windows.Forms.Button();
            this.BackAuth = new System.Windows.Forms.Button();
            Propusk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Propusk
            // 
            Propusk.BackColor = System.Drawing.Color.MidnightBlue;
            Propusk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Propusk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Propusk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Propusk.Location = new System.Drawing.Point(94, 273);
            Propusk.Name = "Propusk";
            Propusk.Size = new System.Drawing.Size(230, 57);
            Propusk.TabIndex = 1;
            Propusk.Text = "Оформить заявку на пропуск";
            Propusk.UseVisualStyleBackColor = false;
            Propusk.Click += new System.EventHandler(this.Propusk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lk
            // 
            this.Lk.BackColor = System.Drawing.Color.MidnightBlue;
            this.Lk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lk.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lk.Location = new System.Drawing.Point(94, 336);
            this.Lk.Name = "Lk";
            this.Lk.Size = new System.Drawing.Size(230, 54);
            this.Lk.TabIndex = 2;
            this.Lk.Text = "Перейти в личный кабинет";
            this.Lk.UseVisualStyleBackColor = false;
            this.Lk.Click += new System.EventHandler(this.Lk_Click);
            // 
            // BackAuth
            // 
            this.BackAuth.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackAuth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackAuth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackAuth.Location = new System.Drawing.Point(12, 407);
            this.BackAuth.Name = "BackAuth";
            this.BackAuth.Size = new System.Drawing.Size(99, 31);
            this.BackAuth.TabIndex = 3;
            this.BackAuth.Text = "Назад";
            this.BackAuth.UseVisualStyleBackColor = false;
            this.BackAuth.Click += new System.EventHandler(this.BackAuth_Click);
            // 
            // PanelUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.BackAuth);
            this.Controls.Add(this.Lk);
            this.Controls.Add(Propusk);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Lk;
        private System.Windows.Forms.Button BackAuth;
    }
}