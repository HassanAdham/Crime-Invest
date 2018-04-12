namespace Crime_Invest
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrimeTypesTab = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(139, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 437);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // CrimeTypesTab
            // 
            this.CrimeTypesTab.Appearance = System.Windows.Forms.Appearance.Button;
            this.CrimeTypesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.CrimeTypesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrimeTypesTab.FlatAppearance.BorderSize = 0;
            this.CrimeTypesTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrimeTypesTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrimeTypesTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.CrimeTypesTab.Location = new System.Drawing.Point(12, 12);
            this.CrimeTypesTab.Name = "CrimeTypesTab";
            this.CrimeTypesTab.Size = new System.Drawing.Size(119, 50);
            this.CrimeTypesTab.TabIndex = 5;
            this.CrimeTypesTab.TabStop = true;
            this.CrimeTypesTab.Text = "Assigned crimes";
            this.CrimeTypesTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CrimeTypesTab.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(84, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 394);
            this.listBox1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1041, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CrimeTypesTab);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton CrimeTypesTab;
        private System.Windows.Forms.ListBox listBox1;
    }
}