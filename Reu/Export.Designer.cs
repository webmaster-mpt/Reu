
namespace Reu
{
    partial class Export
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
            System.Windows.Forms.Button All;
            System.Windows.Forms.Button Submitted;
            System.Windows.Forms.Button Accepted;
            System.Windows.Forms.Button Denied;
            System.Windows.Forms.Button Back;
            System.Windows.Forms.Button ExportBtn;
            System.Windows.Forms.Button BackBtn;
            System.Windows.Forms.Button SortByFakBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.StAdminDataGrid = new System.Windows.Forms.DataGridView();
            this.FakLbl = new System.Windows.Forms.Label();
            this.FakultetCbox = new System.Windows.Forms.ComboBox();
            All = new System.Windows.Forms.Button();
            Submitted = new System.Windows.Forms.Button();
            Accepted = new System.Windows.Forms.Button();
            Denied = new System.Windows.Forms.Button();
            Back = new System.Windows.Forms.Button();
            ExportBtn = new System.Windows.Forms.Button();
            BackBtn = new System.Windows.Forms.Button();
            SortByFakBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StAdminDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // All
            // 
            All.BackColor = System.Drawing.Color.MidnightBlue;
            All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            All.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            All.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            All.Location = new System.Drawing.Point(706, 486);
            All.Name = "All";
            All.Size = new System.Drawing.Size(125, 37);
            All.TabIndex = 78;
            All.Text = "Все заявки";
            All.UseVisualStyleBackColor = false;
            All.Click += new System.EventHandler(this.All_Click);
            // 
            // Submitted
            // 
            Submitted.BackColor = System.Drawing.Color.MidnightBlue;
            Submitted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Submitted.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Submitted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Submitted.Location = new System.Drawing.Point(352, 486);
            Submitted.Name = "Submitted";
            Submitted.Size = new System.Drawing.Size(117, 37);
            Submitted.TabIndex = 77;
            Submitted.Text = "Подано";
            Submitted.UseVisualStyleBackColor = false;
            Submitted.Click += new System.EventHandler(this.Submitted_Click);
            // 
            // Accepted
            // 
            Accepted.BackColor = System.Drawing.Color.MidnightBlue;
            Accepted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Accepted.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Accepted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Accepted.Location = new System.Drawing.Point(603, 486);
            Accepted.Name = "Accepted";
            Accepted.Size = new System.Drawing.Size(97, 37);
            Accepted.TabIndex = 76;
            Accepted.Text = "Принято";
            Accepted.UseVisualStyleBackColor = false;
            Accepted.Click += new System.EventHandler(this.Accepted_Click);
            // 
            // Denied
            // 
            Denied.BackColor = System.Drawing.Color.MidnightBlue;
            Denied.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Denied.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Denied.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Denied.Location = new System.Drawing.Point(475, 486);
            Denied.Name = "Denied";
            Denied.Size = new System.Drawing.Size(122, 37);
            Denied.TabIndex = 75;
            Denied.Text = "Отказано";
            Denied.UseVisualStyleBackColor = false;
            Denied.Click += new System.EventHandler(this.Denied_Click);
            // 
            // Back
            // 
            Back.BackColor = System.Drawing.Color.MidnightBlue;
            Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Back.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Back.Location = new System.Drawing.Point(-122, 313);
            Back.Name = "Back";
            Back.Size = new System.Drawing.Size(100, 37);
            Back.TabIndex = 73;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = false;
            // 
            // ExportBtn
            // 
            ExportBtn.BackColor = System.Drawing.Color.MidnightBlue;
            ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ExportBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ExportBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            ExportBtn.Location = new System.Drawing.Point(995, 486);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new System.Drawing.Size(178, 37);
            ExportBtn.TabIndex = 79;
            ExportBtn.Text = "Экспортировать";
            ExportBtn.UseVisualStyleBackColor = false;
            ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // BackBtn
            // 
            BackBtn.BackColor = System.Drawing.Color.MidnightBlue;
            BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BackBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BackBtn.Location = new System.Drawing.Point(12, 486);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new System.Drawing.Size(100, 37);
            BackBtn.TabIndex = 80;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SortByFakBtn
            // 
            SortByFakBtn.BackColor = System.Drawing.Color.MidnightBlue;
            SortByFakBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            SortByFakBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SortByFakBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            SortByFakBtn.Location = new System.Drawing.Point(246, 447);
            SortByFakBtn.Name = "SortByFakBtn";
            SortByFakBtn.Size = new System.Drawing.Size(142, 32);
            SortByFakBtn.TabIndex = 87;
            SortByFakBtn.Text = "Сортировать";
            SortByFakBtn.UseVisualStyleBackColor = false;
            SortByFakBtn.Click += new System.EventHandler(this.SortByFakBtn_Click);
            // 
            // StAdminDataGrid
            // 
            this.StAdminDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.StAdminDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StAdminDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.StAdminDataGrid.GridColor = System.Drawing.Color.Green;
            this.StAdminDataGrid.Location = new System.Drawing.Point(12, 12);
            this.StAdminDataGrid.Name = "StAdminDataGrid";
            this.StAdminDataGrid.ReadOnly = true;
            this.StAdminDataGrid.Size = new System.Drawing.Size(1161, 413);
            this.StAdminDataGrid.TabIndex = 74;
            // 
            // FakLbl
            // 
            this.FakLbl.AutoSize = true;
            this.FakLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FakLbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.FakLbl.Location = new System.Drawing.Point(12, 428);
            this.FakLbl.Name = "FakLbl";
            this.FakLbl.Size = new System.Drawing.Size(79, 16);
            this.FakLbl.TabIndex = 82;
            this.FakLbl.Text = "Факультет";
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
            this.FakultetCbox.Location = new System.Drawing.Point(12, 447);
            this.FakultetCbox.Name = "FakultetCbox";
            this.FakultetCbox.Size = new System.Drawing.Size(228, 33);
            this.FakultetCbox.TabIndex = 81;
            this.FakultetCbox.ValueMember = "id";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1183, 535);
            this.Controls.Add(SortByFakBtn);
            this.Controls.Add(this.FakultetCbox);
            this.Controls.Add(this.FakLbl);
            this.Controls.Add(BackBtn);
            this.Controls.Add(ExportBtn);
            this.Controls.Add(All);
            this.Controls.Add(Submitted);
            this.Controls.Add(Accepted);
            this.Controls.Add(Denied);
            this.Controls.Add(this.StAdminDataGrid);
            this.Controls.Add(Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировка и Экспорт";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StAdminDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StAdminDataGrid;
        private System.Windows.Forms.Label FakLbl;
        private System.Windows.Forms.ComboBox FakultetCbox;
    }
}