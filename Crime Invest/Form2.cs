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
    }
}
