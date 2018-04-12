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
    public partial class Form2 : Form
    {
        CrimeType test;
        public Form2()
        {
            
            InitializeComponent();
            test = new CrimeType();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void UserStgTab_CheckedChanged(object sender, EventArgs e)
        {
            if (UserStgTab.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CrimeTypesTab_CheckedChanged(object sender, EventArgs e)
        {
            if (CrimeTypesTab.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void CrimesTab_CheckedChanged(object sender, EventArgs e)
        {
            if (CrimesTab.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                officersBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                button2.Visible = true;
                button2.Text = "add";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
  

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                officersBox.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                button2.Visible = true;
                button2.Text = "update";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                officersBox.Visible = true;
                button2.Visible = true;
                button2.Text = "delete";
                label2.Visible = false;
                label3.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
