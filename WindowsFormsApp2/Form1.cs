using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Officer o;
        Admin a;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(label1);
            label1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(label2);
            label2.BackColor = Color.Transparent;
            o = new Officer();
            a = new Admin();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Officer officer = new Officer();
            Admin admin = new Admin();
            List<Officer> LO = o.read();
            List<Admin> LA = a.read();
            string[] results = username_txt.Text.Split('#');
            string id = results[0];
            string name = results[1];
            bool isO = false, isA = false;
            for (int i = 0; i < LO.Count; i++)
            {
                if (name == LO[i].O_name && id == LO[i].O_id && password_txt.Text == LO[i].O_Password)
                {
                    isO = true;
                    officer = LO[i];
                }
            }

            for (int i = 0; i < LA.Count; i++)
            {
                if (name == LA[i].A_name && id == LA[i].A_id && password_txt.Text == LA[i].A_Password)
                {
                    isA = true;
                    admin = LA[i];
                }
            }

            if (isA)
            {
                Form2 form2 = new Form2(admin);
                form2.Show();
            }
            else if (isO)
            {
                Form3 form3 = new Form3(officer);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            //Form2 form2 = new Form2(admin);
            //form2.Show();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = username_txt.Text;
            int n = username_txt.Text.Length;
            bool f = false;
            if (username_txt.Text == "")
            {
                f = true;
            }
            else
            {
                try
                {
                    if (!(s[n - 1] >= 48 && s[n - 1] <= 57) && (s[n - 2] >= 48 && s[n - 2] <= 57) && f == false)
                    {
                        s = s.Insert(n - 1, "#");
                        username_txt.Text = s;
                        username_txt.SelectionStart = username_txt.Text.Length ;
                        f = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Please Write Your ID First");
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            usernameTxt.LineIdleColor = Color.FromArgb(234, 63, 79);
            usernameTxt.LineFocusedColor = Color.FromArgb(234, 63, 79);
            if (username_txt.Text == "ID#Officer Name")
            {
                username_txt.Text = "";
                username_txt.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            usernameTxt.LineIdleColor = Color.DarkGray;
            usernameTxt.LineFocusedColor = Color.DarkGray;
            if (username_txt.Text == "")
            {
                username_txt.Text = "ID#Officer Name";
                username_txt.ForeColor = Color.DarkGray;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            pwTxt.LineIdleColor = Color.FromArgb(234, 63, 79);
            pwTxt.LineFocusedColor = Color.FromArgb(234, 63, 79);
            if (password_txt.Text == "Password")
            {
                password_txt.Text = "";
                password_txt.ForeColor = Color.White;
                password_txt.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            pwTxt.LineIdleColor = Color.DarkGray;
            pwTxt.LineFocusedColor = Color.DarkGray;
            if (password_txt.Text == "")
            {
                password_txt.Text = "Password";
                password_txt.ForeColor = Color.DarkGray;
                password_txt.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
