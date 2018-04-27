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
        IPeople people = new IPeople();
        List<IPeople> iplist = new List<IPeople>();
        List<IPeople> ipl = new List<IPeople>();
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
                officerCmbo.Items.Add(LO[i].O_id);
            }

            for (int i = 0; i < LCT.Count; i++)
            {
                typeCmbo.Items.Add(LCT[i].T_name);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrimeType cType = new CrimeType();

            cType.T_name = textBox1.Text;
            List<CrimeType> list = cType.read();


            cType.T_id = list.Count.ToString();
            cType.write();
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
            bunifuMetroTextbox1.Text = off.O_name;
            bunifuMetroTextbox2.Text = off.assigNum.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LC.Count; i++)
            {
                if (LC[i].C_id == selectCmbo.Text)
                {
                    LC.RemoveAt(i);
                }
            }
            FileStream FS = new FileStream("Crime.xml", FileMode.Truncate);
            FS.Close();
            FS = new FileStream("Crime.xml", FileMode.Append);
            XmlSerializer ser = new XmlSerializer(LC.GetType());
            ser.Serialize(FS, LC);
            FS.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Crime crime = new Crime();
            string cName = typeCmbo.Text;
            for (int i = 0; i < LCT.Count; i++)
            {
                if (LCT[i].T_name == cName)
                {
                    crime.C_Tid = LCT[i].T_id;
                }
            }

            crime.C_offId = officerCmbo.Text;

            List<Crime> clist = crime.read();
            crime.C_id = clist.Count.ToString();

            crime.C_Area = areaCmbo.Text;

            string boolean = statusCmbo.Text;
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

            crime.C_IP = ipl;
            crime.write();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Officer off = new Officer();
            for (int i = 0; i < LO.Count; i++)
            {
                if (comboBox6.Text == LO[i].O_id)
                {
                    LO[i].O_name = bunifuMetroTextbox1.Text;
                    LO[i].assigNum = Int32.Parse(bunifuMetroTextbox2.Text);
                    break;
                }
            }
            FileStream FS = new FileStream("Officer.xml", FileMode.Truncate);
            FS.Close();
            FS = new FileStream("Officer.xml", FileMode.Append);
            XmlSerializer ser = new XmlSerializer(LO.GetType());
            ser.Serialize(FS, LO);
            FS.Close();
            MessageBox.Show("Updated");
        }

        private void TypesButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            TypesButton.IsTab = true;
            ManageButton.IsTab = false;
            CrimesButton.IsTab = false;
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            ManageButton.IsTab = true;
            TypesButton.IsTab = false;
            CrimesButton.IsTab = false;
        }

        private void CrimesButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            ManageButton.IsTab = false;
            TypesButton.IsTab = false;
            CrimesButton.IsTab = true;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (SideMenu.Width == 35)
            {
                SideMenu.Visible = false;
                SideMenu.Width = 135;
                BtnMenu.Location = new Point(108, 5);
                PanelAnimator.ShowSync(SideMenu);
                LogoAnimator.ShowSync(BtnMenu);
            }
            else
            {

                SideMenu.Visible = false;
                SideMenu.Width = 35;
                BtnMenu.Location = new Point(7, 5);
                PanelAnimator.ShowSync(SideMenu);
                LogoAnimator.ShowSync(BtnMenu);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Add crime type")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Add crime type";
                textBox1.ForeColor = Color.White;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            CrimeType ct = new CrimeType();
            for (int i = 0; i < LO.Count; i++)
            {
                if (selectCmbo.Text == LC[i].C_id)
                {
                    for (int j = 0; j < LCT.Count; j++)
                    {
                        if (LCT[j].T_name == typeCmbo.Text)
                        {
                            LC[i].C_Tid = LCT[j].T_id;
                            break;
                        }
                    }
                    LC[i].C_desc = textBox2.Text;
                    string b = statusCmbo.Text;
                    if (b == "true")
                    {
                        LC[i].C_Stat = true;
                    }
                    else
                    {
                        LC[i].C_Stat = false;
                    }
                    LC[i].C_offId = officerCmbo.Text;
                    LC[i].C_Area = areaCmbo.Text;
                    break;
                }
            }
            FileStream FS = new FileStream("Crime.xml", FileMode.Truncate);
            FS.Close();
            FS = new FileStream("Crime.xml", FileMode.Append);
            XmlSerializer ser = new XmlSerializer(LC.GetType());
            ser.Serialize(FS, LC);
            FS.Close();
            MessageBox.Show("Updated");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            people.IP_name = textBox4.Text;
            people.IP_age = Int32.Parse(ageCmbo.Text);
            people.IP_locatoin = locationCmbo.Text;
            string boolean2 = disputesCmbo.Text;
            if (boolean2 == "true")
            {
                people.IP_disp = true;
            }
            else
            {
                people.IP_disp = false;
            }

            iplist = people.read();
            people.IP_id = iplist.Count.ToString();
            people.write();
            if (!ipl.Contains(people))
            {
                ipl.Add(people);
            }
            textBox4.ResetText();
            ageCmbo.ResetText();
            locationCmbo.ResetText();
            disputesCmbo.ResetText();
        }
    }
}
