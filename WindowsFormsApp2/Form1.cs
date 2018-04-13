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
            o = new Officer();
            a = new Admin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Officer officer = new Officer();
            Admin admin = new Admin();
            /*  List<Officer> LO = o.read();
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
              }*/
            Form2 form2 = new Form2(admin);
            form2.Show();
        }
    }
}
