namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doneBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCmbo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.histLbl = new System.Windows.Forms.Label();
            this.disLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusCmbo = new System.Windows.Forms.ComboBox();
            this.areaCmbo = new System.Windows.Forms.ComboBox();
            this.typeCmbo = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.itemsCmbo = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.AboutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ManageButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.solveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMenu = new System.Windows.Forms.PictureBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.doneBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.selectCmbo);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(35, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 430);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.doneBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.doneBtn, BunifuAnimatorNS.DecorationType.None);
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(262, 92);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(163, 58);
            this.doneBtn.TabIndex = 16;
            this.doneBtn.Text = "Solve";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Crime Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // selectCmbo
            // 
            this.selectCmbo.BackColor = System.Drawing.Color.DarkGray;
            this.selectCmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.selectCmbo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.selectCmbo, BunifuAnimatorNS.DecorationType.None);
            this.selectCmbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectCmbo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCmbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.selectCmbo.FormattingEnabled = true;
            this.selectCmbo.Location = new System.Drawing.Point(279, 56);
            this.selectCmbo.Name = "selectCmbo";
            this.selectCmbo.Size = new System.Drawing.Size(129, 25);
            this.selectCmbo.TabIndex = 5;
            this.selectCmbo.Text = "Select Crime ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Salmon;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.histLbl);
            this.panel2.Controls.Add(this.disLbl);
            this.panel2.Controls.Add(this.locationLbl);
            this.panel2.Controls.Add(this.ageLbl);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.statusCmbo);
            this.panel2.Controls.Add(this.areaCmbo);
            this.panel2.Controls.Add(this.typeCmbo);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.itemsCmbo);
            this.panel2.Controls.Add(this.comboBox6);
            this.panel2.Controls.Add(this.comboBox2);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(35, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 430);
            this.panel2.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(105, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 43);
            this.button6.TabIndex = 35;
            this.button6.Text = "Add Item";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Items Found";
            // 
            // histLbl
            // 
            this.histLbl.AutoSize = true;
            this.histLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.histLbl, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.histLbl, BunifuAnimatorNS.DecorationType.None);
            this.histLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histLbl.ForeColor = System.Drawing.Color.White;
            this.histLbl.Location = new System.Drawing.Point(194, 347);
            this.histLbl.Name = "histLbl";
            this.histLbl.Size = new System.Drawing.Size(79, 17);
            this.histLbl.TabIndex = 33;
            this.histLbl.Text = "Past history";
            // 
            // disLbl
            // 
            this.disLbl.AutoSize = true;
            this.disLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.disLbl, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.disLbl, BunifuAnimatorNS.DecorationType.None);
            this.disLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disLbl.ForeColor = System.Drawing.Color.White;
            this.disLbl.Location = new System.Drawing.Point(194, 330);
            this.disLbl.Name = "disLbl";
            this.disLbl.Size = new System.Drawing.Size(61, 17);
            this.disLbl.TabIndex = 33;
            this.disLbl.Text = "Disputes";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.locationLbl, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.locationLbl, BunifuAnimatorNS.DecorationType.None);
            this.locationLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.Color.White;
            this.locationLbl.Location = new System.Drawing.Point(194, 313);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(65, 17);
            this.locationLbl.TabIndex = 33;
            this.locationLbl.Text = "Location";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.ageLbl, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ageLbl, BunifuAnimatorNS.DecorationType.None);
            this.ageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.ForeColor = System.Drawing.Color.White;
            this.ageLbl.Location = new System.Drawing.Point(194, 296);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(34, 17);
            this.ageLbl.TabIndex = 33;
            this.ageLbl.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(193, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Involved People";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(504, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 58);
            this.button1.TabIndex = 32;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(376, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.nextBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.nextBtn, BunifuAnimatorNS.DecorationType.None);
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(412, 195);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(50, 30);
            this.nextBtn.TabIndex = 28;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.button9, BunifuAnimatorNS.DecorationType.None);
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(243, 195);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 30);
            this.button9.TabIndex = 29;
            this.button9.Text = "Add Image";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.backBtn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.backBtn, BunifuAnimatorNS.DecorationType.None);
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(187, 195);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 30);
            this.backBtn.TabIndex = 30;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogoAnimator.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(488, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 117);
            this.textBox2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Crime Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Crime Area";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Crime Type";
            // 
            // statusCmbo
            // 
            this.statusCmbo.BackColor = System.Drawing.Color.DarkGray;
            this.statusCmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.statusCmbo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.statusCmbo, BunifuAnimatorNS.DecorationType.None);
            this.statusCmbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCmbo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.statusCmbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.statusCmbo.FormattingEnabled = true;
            this.statusCmbo.Items.AddRange(new object[] {
            "Opened",
            "Closed"});
            this.statusCmbo.Location = new System.Drawing.Point(31, 134);
            this.statusCmbo.Name = "statusCmbo";
            this.statusCmbo.Size = new System.Drawing.Size(121, 25);
            this.statusCmbo.TabIndex = 21;
            // 
            // areaCmbo
            // 
            this.areaCmbo.BackColor = System.Drawing.Color.DarkGray;
            this.areaCmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.areaCmbo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.areaCmbo, BunifuAnimatorNS.DecorationType.None);
            this.areaCmbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.areaCmbo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.areaCmbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.areaCmbo.FormattingEnabled = true;
            this.areaCmbo.Location = new System.Drawing.Point(31, 193);
            this.areaCmbo.Name = "areaCmbo";
            this.areaCmbo.Size = new System.Drawing.Size(121, 25);
            this.areaCmbo.TabIndex = 20;
            // 
            // typeCmbo
            // 
            this.typeCmbo.BackColor = System.Drawing.Color.DarkGray;
            this.typeCmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.typeCmbo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.typeCmbo, BunifuAnimatorNS.DecorationType.None);
            this.typeCmbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeCmbo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.typeCmbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.typeCmbo.FormattingEnabled = true;
            this.typeCmbo.Location = new System.Drawing.Point(31, 78);
            this.typeCmbo.Name = "typeCmbo";
            this.typeCmbo.Size = new System.Drawing.Size(121, 25);
            this.typeCmbo.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogoAnimator.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.textBox3, BunifuAnimatorNS.DecorationType.None);
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.textBox3.Location = new System.Drawing.Point(31, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 22);
            this.textBox3.TabIndex = 14;
            // 
            // itemsCmbo
            // 
            this.itemsCmbo.BackColor = System.Drawing.Color.DarkGray;
            this.itemsCmbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.itemsCmbo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.itemsCmbo, BunifuAnimatorNS.DecorationType.None);
            this.itemsCmbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsCmbo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsCmbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.itemsCmbo.FormattingEnabled = true;
            this.itemsCmbo.Location = new System.Drawing.Point(31, 256);
            this.itemsCmbo.Name = "itemsCmbo";
            this.itemsCmbo.Size = new System.Drawing.Size(121, 25);
            this.itemsCmbo.TabIndex = 7;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.comboBox6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.comboBox6, BunifuAnimatorNS.DecorationType.None);
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.White;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(197, 268);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(165, 25);
            this.comboBox6.TabIndex = 7;
            this.comboBox6.Text = "Name";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 25);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Select Crime ID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.LogoAnimator.SetDecoration(this.splitter1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.splitter1, BunifuAnimatorNS.DecorationType.None);
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(720, 50);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.LogoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.LogoutButton, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LogoutButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(645, 0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 50);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SideMenu.Controls.Add(this.AboutButton);
            this.SideMenu.Controls.Add(this.ExitButton);
            this.SideMenu.Controls.Add(this.ManageButton);
            this.SideMenu.Controls.Add(this.solveBtn);
            this.SideMenu.Controls.Add(this.BtnMenu);
            this.PanelAnimator.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.SideMenu, BunifuAnimatorNS.DecorationType.None);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 50);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(35, 430);
            this.SideMenu.TabIndex = 12;
            // 
            // AboutButton
            // 
            this.AboutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.AboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutButton.BorderRadius = 0;
            this.AboutButton.ButtonText = "About";
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.AboutButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.AboutButton, BunifuAnimatorNS.DecorationType.None);
            this.AboutButton.DisabledColor = System.Drawing.Color.Gray;
            this.AboutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AboutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("AboutButton.Iconimage")));
            this.AboutButton.Iconimage_right = null;
            this.AboutButton.Iconimage_right_Selected = null;
            this.AboutButton.Iconimage_Selected = null;
            this.AboutButton.IconMarginLeft = 0;
            this.AboutButton.IconMarginRight = 0;
            this.AboutButton.IconRightVisible = true;
            this.AboutButton.IconRightZoom = 0D;
            this.AboutButton.IconVisible = true;
            this.AboutButton.IconZoom = 35D;
            this.AboutButton.IsTab = true;
            this.AboutButton.Location = new System.Drawing.Point(0, 361);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.AboutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.AboutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.AboutButton.selected = false;
            this.AboutButton.Size = new System.Drawing.Size(136, 35);
            this.AboutButton.TabIndex = 20;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutButton.Textcolor = System.Drawing.Color.White;
            this.AboutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ExitButton
            // 
            this.ExitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "Exit";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.ExitButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ExitButton, BunifuAnimatorNS.DecorationType.None);
            this.ExitButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ExitButton.Iconimage")));
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 35D;
            this.ExitButton.IsTab = true;
            this.ExitButton.Location = new System.Drawing.Point(0, 396);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ExitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(136, 35);
            this.ExitButton.TabIndex = 21;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Textcolor = System.Drawing.Color.White;
            this.ExitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManageButton
            // 
            this.ManageButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ManageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ManageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManageButton.BorderRadius = 0;
            this.ManageButton.ButtonText = "Manage";
            this.ManageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.ManageButton, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ManageButton, BunifuAnimatorNS.DecorationType.None);
            this.ManageButton.DisabledColor = System.Drawing.Color.Gray;
            this.ManageButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ManageButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ManageButton.Iconimage")));
            this.ManageButton.Iconimage_right = null;
            this.ManageButton.Iconimage_right_Selected = null;
            this.ManageButton.Iconimage_Selected = null;
            this.ManageButton.IconMarginLeft = 0;
            this.ManageButton.IconMarginRight = 0;
            this.ManageButton.IconRightVisible = true;
            this.ManageButton.IconRightZoom = 0D;
            this.ManageButton.IconVisible = true;
            this.ManageButton.IconZoom = 65D;
            this.ManageButton.IsTab = true;
            this.ManageButton.Location = new System.Drawing.Point(0, 69);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ManageButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.ManageButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ManageButton.selected = false;
            this.ManageButton.Size = new System.Drawing.Size(136, 35);
            this.ManageButton.TabIndex = 22;
            this.ManageButton.Text = "Manage";
            this.ManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManageButton.Textcolor = System.Drawing.Color.White;
            this.ManageButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.solveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.solveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.solveBtn.BorderRadius = 0;
            this.solveBtn.ButtonText = "Solve";
            this.solveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.solveBtn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.solveBtn, BunifuAnimatorNS.DecorationType.None);
            this.solveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.solveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.solveBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("solveBtn.Iconimage")));
            this.solveBtn.Iconimage_right = null;
            this.solveBtn.Iconimage_right_Selected = null;
            this.solveBtn.Iconimage_Selected = null;
            this.solveBtn.IconMarginLeft = 0;
            this.solveBtn.IconMarginRight = 0;
            this.solveBtn.IconRightVisible = true;
            this.solveBtn.IconRightZoom = 0D;
            this.solveBtn.IconVisible = true;
            this.solveBtn.IconZoom = 80D;
            this.solveBtn.IsTab = true;
            this.solveBtn.Location = new System.Drawing.Point(0, 34);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.solveBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.solveBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.solveBtn.selected = false;
            this.solveBtn.Size = new System.Drawing.Size(136, 35);
            this.solveBtn.TabIndex = 25;
            this.solveBtn.Text = "Solve";
            this.solveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solveBtn.Textcolor = System.Drawing.Color.White;
            this.solveBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(7, 9);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(20, 20);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMenu.TabIndex = 19;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel SideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton AboutButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        private Bunifu.Framework.UI.BunifuFlatButton ManageButton;
        private Bunifu.Framework.UI.BunifuFlatButton solveBtn;
        private System.Windows.Forms.PictureBox BtnMenu;
        private System.Windows.Forms.ComboBox selectCmbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusCmbo;
        private System.Windows.Forms.ComboBox areaCmbo;
        private System.Windows.Forms.ComboBox typeCmbo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox itemsCmbo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label disLbl;
        private System.Windows.Forms.Label histLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
    }
}