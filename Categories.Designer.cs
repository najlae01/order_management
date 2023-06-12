namespace GestionCommerciale
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CategorieList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CategorieList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(110, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "log out";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(57, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "providers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(57, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(57, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "articles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label7.Location = new System.Drawing.Point(653, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "categories list";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CategorieList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CategorieList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategorieList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CategorieList.ColumnHeadersHeight = 4;
            this.CategorieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategorieList.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategorieList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategorieList.Location = new System.Drawing.Point(239, 310);
            this.CategorieList.Name = "CategorieList";
            this.CategorieList.RowHeadersVisible = false;
            this.CategorieList.RowHeadersWidth = 62;
            this.CategorieList.RowTemplate.Height = 28;
            this.CategorieList.Size = new System.Drawing.Size(939, 293);
            this.CategorieList.TabIndex = 39;
            this.CategorieList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CategorieList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CategorieList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CategorieList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CategorieList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CategorieList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CategorieList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategorieList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CategorieList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CategorieList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorieList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CategorieList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CategorieList.ThemeStyle.HeaderStyle.Height = 4;
            this.CategorieList.ThemeStyle.ReadOnly = false;
            this.CategorieList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CategorieList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CategorieList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorieList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.IndianRed;
            this.CategorieList.ThemeStyle.RowsStyle.Height = 28;
            this.CategorieList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CategorieList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CategorieList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategorieList_CellContentClick);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.LightCoral;
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ModifierBtn.Location = new System.Drawing.Point(372, 224);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(143, 45);
            this.ModifierBtn.TabIndex = 38;
            this.ModifierBtn.Text = "edit";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.LightCoral;
            this.SupprimerBtn.FlatAppearance.BorderSize = 0;
            this.SupprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBtn.ForeColor = System.Drawing.Color.DimGray;
            this.SupprimerBtn.Location = new System.Drawing.Point(886, 224);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(143, 45);
            this.SupprimerBtn.TabIndex = 37;
            this.SupprimerBtn.Text = "delete";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BackColor = System.Drawing.Color.LightCoral;
            this.EnregistrerBtn.FlatAppearance.BorderSize = 0;
            this.EnregistrerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnregistrerBtn.ForeColor = System.Drawing.Color.DimGray;
            this.EnregistrerBtn.Location = new System.Drawing.Point(634, 224);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(143, 45);
            this.EnregistrerBtn.TabIndex = 36;
            this.EnregistrerBtn.Text = "save";
            this.EnregistrerBtn.UseVisualStyleBackColor = false;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(61, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "billing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(584, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Comments";
            // 
            // RemTb
            // 
            this.RemTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemTb.DefaultText = "";
            this.RemTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RemTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RemTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RemTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RemTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemTb.Location = new System.Drawing.Point(589, 102);
            this.RemTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemTb.Name = "RemTb";
            this.RemTb.PasswordChar = '\0';
            this.RemTb.PlaceholderText = "";
            this.RemTb.SelectedText = "";
            this.RemTb.Size = new System.Drawing.Size(616, 114);
            this.RemTb.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(219, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "category name";
            // 
            // NomTb
            // 
            this.NomTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NomTb.DefaultText = "";
            this.NomTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NomTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NomTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NomTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NomTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NomTb.Location = new System.Drawing.Point(219, 102);
            this.NomTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomTb.Name = "NomTb";
            this.NomTb.PasswordChar = '\0';
            this.NomTb.PlaceholderText = "";
            this.NomTb.SelectedText = "";
            this.NomTb.Size = new System.Drawing.Size(303, 38);
            this.NomTb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 52);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 615);
            this.panel1.TabIndex = 24;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 615);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CategorieList);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.CategorieList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView CategorieList;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox RemTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NomTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}