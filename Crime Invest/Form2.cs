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
    }
}
