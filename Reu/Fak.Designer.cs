namespace Reu
{
    partial class Fak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fak));
            this.FakDtGrid = new System.Windows.Forms.DataGridView();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.NameFakToEd = new System.Windows.Forms.Label();
            this.NameEdTxt = new System.Windows.Forms.TextBox();
            this.EdFak = new System.Windows.Forms.Button();
            this.DelPanel = new System.Windows.Forms.Panel();
            this.NameFakToDel = new System.Windows.Forms.Label();
            this.NameDelTxt = new System.Windows.Forms.TextBox();
            this.DelFak = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Function = new System.Windows.Forms.ComboBox();
            this.UseToFunction = new System.Windows.Forms.Label();
            this.AddFak = new System.Windows.Forms.Button();
            this.NameAddTxt = new System.Windows.Forms.TextBox();
            this.NameFakToAdd = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FakDtGrid)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.DelPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FakDtGrid
            // 
            this.FakDtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FakDtGrid.Location = new System.Drawing.Point(231, 76);
            this.FakDtGrid.Name = "FakDtGrid";
            this.FakDtGrid.ReadOnly = true;
            this.FakDtGrid.Size = new System.Drawing.Size(225, 251);
            this.FakDtGrid.TabIndex = 0;
            this.FakDtGrid.SelectionChanged += new System.EventHandler(this.FakDtGrid_SelectionChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.NameFakToEd);
            this.EditPanel.Controls.Add(this.NameEdTxt);
            this.EditPanel.Controls.Add(this.EdFak);
            this.EditPanel.Location = new System.Drawing.Point(13, 161);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(212, 80);
            this.EditPanel.TabIndex = 2;
            this.EditPanel.Visible = false;
            // 
            // NameFakToEd
            // 
            this.NameFakToEd.AutoSize = true;
            this.NameFakToEd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameFakToEd.Location = new System.Drawing.Point(0, 8);
            this.NameFakToEd.Name = "NameFakToEd";
            this.NameFakToEd.Size = new System.Drawing.Size(145, 13);
            this.NameFakToEd.TabIndex = 3;
            this.NameFakToEd.Text = "Наименование факультета";
            // 
            // NameEdTxt
            // 
            this.NameEdTxt.BackColor = System.Drawing.Color.Cornsilk;
            this.NameEdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameEdTxt.ForeColor = System.Drawing.Color.Black;
            this.NameEdTxt.Location = new System.Drawing.Point(3, 27);
            this.NameEdTxt.Name = "NameEdTxt";
            this.NameEdTxt.Size = new System.Drawing.Size(145, 20);
            this.NameEdTxt.TabIndex = 2;
            // 
            // EdFak
            // 
            this.EdFak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EdFak.Location = new System.Drawing.Point(134, 54);
            this.EdFak.Name = "EdFak";
            this.EdFak.Size = new System.Drawing.Size(75, 23);
            this.EdFak.TabIndex = 0;
            this.EdFak.Text = "Изменить";
            this.EdFak.UseVisualStyleBackColor = true;
            this.EdFak.Click += new System.EventHandler(this.EdFak_Click);
            // 
            // DelPanel
            // 
            this.DelPanel.Controls.Add(this.NameFakToDel);
            this.DelPanel.Controls.Add(this.NameDelTxt);
            this.DelPanel.Controls.Add(this.DelFak);
            this.DelPanel.Location = new System.Drawing.Point(13, 247);
            this.DelPanel.Name = "DelPanel";
            this.DelPanel.Size = new System.Drawing.Size(212, 80);
            this.DelPanel.TabIndex = 3;
            this.DelPanel.Visible = false;
            // 
            // NameFakToDel
            // 
            this.NameFakToDel.AutoSize = true;
            this.NameFakToDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameFakToDel.Location = new System.Drawing.Point(0, 8);
            this.NameFakToDel.Name = "NameFakToDel";
            this.NameFakToDel.Size = new System.Drawing.Size(145, 13);
            this.NameFakToDel.TabIndex = 4;
            this.NameFakToDel.Text = "Наименование факультета";
            // 
            // NameDelTxt
            // 
            this.NameDelTxt.BackColor = System.Drawing.Color.Cornsilk;
            this.NameDelTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameDelTxt.ForeColor = System.Drawing.Color.Black;
            this.NameDelTxt.Location = new System.Drawing.Point(3, 27);
            this.NameDelTxt.Name = "NameDelTxt";
            this.NameDelTxt.Size = new System.Drawing.Size(142, 20);
            this.NameDelTxt.TabIndex = 3;
            // 
            // DelFak
            // 
            this.DelFak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelFak.Location = new System.Drawing.Point(134, 54);
            this.DelFak.Name = "DelFak";
            this.DelFak.Size = new System.Drawing.Size(75, 23);
            this.DelFak.TabIndex = 0;
            this.DelFak.Text = "Удалить";
            this.DelFak.UseVisualStyleBackColor = true;
            this.DelFak.Click += new System.EventHandler(this.DelFak_Click);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Location = new System.Drawing.Point(381, 47);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Function
            // 
            this.Function.BackColor = System.Drawing.Color.Cornsilk;
            this.Function.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Function.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Function.FormattingEnabled = true;
            this.Function.Items.AddRange(new object[] {
            "Добавления",
            "Изменение",
            "Удаление"});
            this.Function.Location = new System.Drawing.Point(16, 46);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(121, 21);
            this.Function.TabIndex = 4;
            this.Function.SelectedIndexChanged += new System.EventHandler(this.Function_SelectedIndexChanged);
            // 
            // UseToFunction
            // 
            this.UseToFunction.AutoSize = true;
            this.UseToFunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UseToFunction.Location = new System.Drawing.Point(17, 30);
            this.UseToFunction.Name = "UseToFunction";
            this.UseToFunction.Size = new System.Drawing.Size(86, 13);
            this.UseToFunction.TabIndex = 3;
            this.UseToFunction.Text = "Выбор функции";
            // 
            // AddFak
            // 
            this.AddFak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFak.Location = new System.Drawing.Point(134, 54);
            this.AddFak.Name = "AddFak";
            this.AddFak.Size = new System.Drawing.Size(75, 23);
            this.AddFak.TabIndex = 0;
            this.AddFak.Text = "Добавить";
            this.AddFak.UseVisualStyleBackColor = true;
            this.AddFak.Click += new System.EventHandler(this.AddFak_Click);
            // 
            // NameAddTxt
            // 
            this.NameAddTxt.BackColor = System.Drawing.Color.Cornsilk;
            this.NameAddTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameAddTxt.ForeColor = System.Drawing.Color.Black;
            this.NameAddTxt.Location = new System.Drawing.Point(3, 27);
            this.NameAddTxt.Name = "NameAddTxt";
            this.NameAddTxt.Size = new System.Drawing.Size(146, 20);
            this.NameAddTxt.TabIndex = 1;
            // 
            // NameFakToAdd
            // 
            this.NameFakToAdd.AutoSize = true;
            this.NameFakToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NameFakToAdd.Location = new System.Drawing.Point(0, 8);
            this.NameFakToAdd.Name = "NameFakToAdd";
            this.NameFakToAdd.Size = new System.Drawing.Size(145, 13);
            this.NameFakToAdd.TabIndex = 2;
            this.NameFakToAdd.Text = "Наименование факультета";
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.NameFakToAdd);
            this.AddPanel.Controls.Add(this.NameAddTxt);
            this.AddPanel.Controls.Add(this.AddFak);
            this.AddPanel.Location = new System.Drawing.Point(13, 75);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(212, 80);
            this.AddPanel.TabIndex = 1;
            this.AddPanel.Visible = false;
            // 
            // Fak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(464, 333);
            this.Controls.Add(this.UseToFunction);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DelPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.FakDtGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факультеты";
            ((System.ComponentModel.ISupportInitialize)(this.FakDtGrid)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.DelPanel.ResumeLayout(false);
            this.DelPanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FakDtGrid;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label NameFakToEd;
        private System.Windows.Forms.TextBox NameEdTxt;
        private System.Windows.Forms.Button EdFak;
        private System.Windows.Forms.Panel DelPanel;
        private System.Windows.Forms.Label NameFakToDel;
        private System.Windows.Forms.TextBox NameDelTxt;
        private System.Windows.Forms.Button DelFak;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Function;
        private System.Windows.Forms.Label UseToFunction;
        private System.Windows.Forms.Button AddFak;
        private System.Windows.Forms.TextBox NameAddTxt;
        private System.Windows.Forms.Label NameFakToAdd;
        private System.Windows.Forms.Panel AddPanel;
    }
}