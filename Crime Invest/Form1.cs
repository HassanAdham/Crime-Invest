using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_Invest
{
    public partial class LoginForm : Form
    {
        Officer o;
        Admin a;
        public LoginForm()
        {
            InitializeComponent();
            o = new Officer();
            a = new Admin();
        }

        private void username_txt_Enter(object sender, EventArgs e)
        {
            if (username_txt.Text == "ID#Username")
            {
                username_txt.Text = "";
                username_txt.ForeColor = Color.White;
            }
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            if (username_txt.Text == "")
            {
                username_txt.Text = "ID#Username";
                username_txt.ForeColor = Color.FromArgb(200, 0, 50);
            }
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            if (password_txt.Text == "Password")
            {
                password_txt.Text = "";
                password_txt.ForeColor = Color.White;
                password_txt.isPassword = true;
            }
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.Text == "")
            {
                password_txt.Text = "Password";
                password_txt.ForeColor = Color.FromArgb(200, 0, 50);
                password_txt.isPassword = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void username_txt_OnValueChanged(object sender, EventArgs e)
        {
            /*if (username_txt.Text == "")
            { }
            else
            {
                int n = username_txt.Text.Length;
                string s = username_txt.Text;
                if (s[n - 1] >= 48 && s[n - 1] <= 57)
                { }
                else
                {
                    s.Insert(n - 2, "#");
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                }
            }

            for (int i = 0; i < LA.Count; i++)
            {
                if (name == LA[i].A_name && id == LA[i].A_id && password_txt.Text == LA[i].A_Password)
                {
                    isA = true;
                }
            }

            if (isA)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (isO)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }   
}
