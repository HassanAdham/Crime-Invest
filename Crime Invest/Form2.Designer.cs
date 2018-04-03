namespace Crime_Invest
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CrimeTypesTab = new System.Windows.Forms.RadioButton();
            this.UserStgTab = new System.Windows.Forms.RadioButton();
            this.CrimesTab = new System.Windows.Forms.RadioButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrimeTypesTab
            // 
            this.CrimeTypesTab.Appearance = System.Windows.Forms.Appearance.Button;
            this.CrimeTypesTab.AutoSize = true;
            this.CrimeTypesTab.Location = new System.Drawing.Point(28, 60);
            this.CrimeTypesTab.Name = "CrimeTypesTab";
            this.CrimeTypesTab.Size = new System.Drawing.Size(75, 23);
            this.CrimeTypesTab.TabIndex = 0;
            this.CrimeTypesTab.TabStop = true;
            this.CrimeTypesTab.Text = "Crime Types";
            this.CrimeTypesTab.UseVisualStyleBackColor = true;
            // 
            // UserStgTab
            // 
            this.UserStgTab.Appearance = System.Windows.Forms.Appearance.Button;
            this.UserStgTab.AutoSize = true;
            this.UserStgTab.Location = new System.Drawing.Point(28, 89);
            this.UserStgTab.Name = "UserStgTab";
            this.UserStgTab.Size = new System.Drawing.Size(80, 23);
            this.UserStgTab.TabIndex = 0;
            this.UserStgTab.TabStop = true;
            this.UserStgTab.Text = "User Settings";
            this.UserStgTab.UseVisualStyleBackColor = true;
            // 
            // CrimesTab
            // 
            this.CrimesTab.Appearance = System.Windows.Forms.Appearance.Button;
            this.CrimesTab.AutoSize = true;
            this.CrimesTab.Location = new System.Drawing.Point(28, 118);
            this.CrimesTab.Name = "CrimesTab";
            this.CrimesTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CrimesTab.Size = new System.Drawing.Size(48, 23);
            this.CrimesTab.TabIndex = 0;
            this.CrimesTab.TabStop = true;
            this.CrimesTab.Text = "Crimes";
            this.CrimesTab.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(90, 175);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(240, 150);
            this.bunifuCustomDataGrid1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel1.Location = new System.Drawing.Point(167, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 419);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "new type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CrimesTab);
            this.Controls.Add(this.UserStgTab);
            this.Controls.Add(this.CrimeTypesTab);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CrimeTypesTab;
        private System.Windows.Forms.RadioButton UserStgTab;
        private System.Windows.Forms.RadioButton CrimesTab;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}