using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Officer o=new Officer();
        Crime c = new Crime();
        CrimeType cT = new CrimeType();
        List<Officer> LO = new List<Officer>();
        List<Crime> LC = new List<Crime>();
        List<CrimeType> LCT= new List<CrimeType>();
        Admin admin = new Admin();
        public Form2(Admin a)
        {
            admin = a;
            LO = o.read();
           // LC = c.read();
            LCT = cT.read();
            InitializeComponent();
            for (int i = 0; i < LO.Count; i++)
            {
                comboBox6.Items.Add(LO[i].O_id);
            }

            //for (int i = 0; i < LC.Count; i++)
            //{
            //    comboBox1.Items.Add(LC[i].C_id);
            //}

            for (int i = 0; i < LO.Count; i++)
            {
                comboBox5.Items.Add(LO[i].O_id);
            }

            for (int i = 0; i < LCT.Count; i++)
            {
                comboBox2.Items.Add(LCT[i].T_name);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrimeType cType = new CrimeType();

            cType.T_name = textBox1.Text;
            List<CrimeType> list = cType.read();


            cType.T_id = list.Count.ToString();
            cType.write();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Officer off = new Officer();
            for (int i = 0; i < LO.Count; i++)
            {
                if (comboBox6.Text == LO[i].O_id)
                {
                    off = LO[i];
                }
            }
            textBox5.Text = off.O_name;
            textBox6.Text = off.assigNum.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i =0; i < LC.Count; i++)
            {
                if (LC[i].C_id == comboBox1.Text)
                {
                    LC.RemoveAt(i);
                }
            }
           FileStream FS = new FileStream("Crime.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(LC.GetType());
            ser.Serialize(FS, LC);
            FS.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crime crime = new Crime();

            string cName = comboBox2.Text;


            CrimeType cType = new CrimeType();



            for (int i = 0; i < LCT.Count; i++)
            {
                if (cType.T_name == cName)
                {
                    crime.C_Tid = cType.T_id;
                }
            }


            crime.C_offId = comboBox5.Text;

            List<Crime> clist = crime.read();
            crime.C_id = clist.Count.ToString();

            crime.C_Area = comboBox3.Text;

            string boolean = comboBox4.Text;
            if (boolean == "true")
            {
                crime.C_Stat = true;
            }
            else
            {
                crime.C_Stat = false;
            }
            crime.C_desc = textBox2.Text;
            string str = textBox3.Text;
            string[] arr = str.Split('-');
            for (int i = 0; i < crime.C_item.Count; i++)
            {
                crime.C_item.Add(arr[i]);
            }
            IPeople people = new IPeople();
            people.IP_name = textBox4.Text;
            people.IP_age = Int32.Parse(agecombo.Text);
            people.IP_locatoin = loccombo.Text;
            string boolean2 = IsDispcombo.Text;
            if (boolean2 == "true")
            {
                people.IP_disp = true;
            }
            else
            {
                people.IP_disp = false;
            }

            List<IPeople> plist = people.read();
            people.IP_id = plist.Count.ToString();
            people.write();
            crime.C_IP.Add(people);



            crime.write();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Officer off = new Officer();
            for (int i = 0; i < LO.Count; i++)
            {
                if (comboBox6.Text == LO[i].O_id)
                {
                    off = LO[i];
                }
            }
            off.O_name = textBox5.Text;
            off.assigNum = Int32.Parse(textBox6.Text);
            MessageBox.Show("Updated");
        }
    }
}
