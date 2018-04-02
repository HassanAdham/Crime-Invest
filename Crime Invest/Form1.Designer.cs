namespace Crime_Invest
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.password_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.BorderColorFocused = System.Drawing.Color.White;
            this.username_txt.BorderColorIdle = System.Drawing.Color.White;
            this.username_txt.BorderColorMouseHover = System.Drawing.Color.White;
            this.username_txt.BorderThickness = 1;
            this.username_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.username_txt.isPassword = false;
            this.username_txt.Location = new System.Drawing.Point(281, 52);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(189, 34);
            this.username_txt.TabIndex = 0;
            this.username_txt.Text = "ID#Username";
            this.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username_txt.OnValueChanged += new System.EventHandler(this.username_txt_OnValueChanged);
            this.username_txt.Enter += new System.EventHandler(this.username_txt_Enter);
            this.username_txt.Leave += new System.EventHandler(this.username_txt_Leave);
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.White;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(281, 96);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(189, 34);
            this.bunifuMetroTextbox2.TabIndex = 0;
            this.bunifuMetroTextbox2.Text = "ID#Username";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.DarkRed;
            this.password_txt.BorderColorFocused = System.Drawing.Color.White;
            this.password_txt.BorderColorIdle = System.Drawing.Color.White;
            this.password_txt.BorderColorMouseHover = System.Drawing.Color.White;
            this.password_txt.BorderThickness = 1;
            this.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.password_txt.isPassword = false;
            this.password_txt.Location = new System.Drawing.Point(281, 96);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(189, 34);
            this.password_txt.TabIndex = 0;
            this.password_txt.Text = "Password";
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(240, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.Activecolor = System.Drawing.Color.Transparent;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.BorderRadius = 0;
            this.exit_btn.ButtonText = "";
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.DisabledColor = System.Drawing.Color.Gray;
            this.exit_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.exit_btn.Iconimage = null;
            this.exit_btn.Iconimage_right = null;
            this.exit_btn.Iconimage_right_Selected = null;
            this.exit_btn.Iconimage_Selected = null;
            this.exit_btn.IconMarginLeft = 0;
            this.exit_btn.IconMarginRight = 0;
            this.exit_btn.IconRightVisible = true;
            this.exit_btn.IconRightZoom = 0D;
            this.exit_btn.IconVisible = true;
            this.exit_btn.IconZoom = 90D;
            this.exit_btn.IsTab = false;
            this.exit_btn.Location = new System.Drawing.Point(468, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.exit_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.exit_btn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.exit_btn.selected = false;
            this.exit_btn.Size = new System.Drawing.Size(30, 30);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Textcolor = System.Drawing.Color.White;
            this.exit_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.username_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime Investigator";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox username_txt;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox password_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton exit_btn;
        private System.Windows.Forms.Button button1;
    }
}

