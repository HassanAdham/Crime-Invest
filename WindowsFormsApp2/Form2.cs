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
        string imgloc;
        Image DefaultImage;
        List<Byte[]> Imgs = new List<byte[]>();
        List<Byte[]> ImgsUpdate = new List<byte[]>();
        Officer o=new Officer();
        Crime c = new Crime();
        CrimeType cT = new CrimeType();
        List<Officer> LO = new List<Officer>();
        List<Crime> LC = new List<Crime>();
        List<CrimeType> LCT= new List<CrimeType>();
        List<IPeople> iplist = new List<IPeople>();
        List<IPeople> ipl = new List<IPeople>();
        Admin admin = new Admin();
        int count;
        List<string> itemsFound = new List<string>();
        public Form2(Admin a)
        {
            count = 0;
            admin = a;
            LO = o.read();
            LC = c.read();
            LCT = cT.read();
            InitializeComponent();
            DefaultImage = pictureBox1.Image;
            for (int i = 0; i < LO.Count; i++)
            {
                comboBox6.Items.Add(LO[i].O_id);
            }

            for (int i = 0; i < LC.Count; i++)
            {
                selectCmbo.Items.Add(LC[i].C_id);
            }

            for (int i = 0; i < LO.Count; i++)
            {
                if(LO[i].assigNum<10)
                officerCmbo.Items.Add(LO[i].O_id);
            }

            for (int i = 0; i < LCT.Count; i++)
            {
                typeCmbo.Items.Add(LCT[i].T_name);
                comboBox9.Items.Add(LCT[i].T_name);
                listBox1.Items.Add(LCT[i].T_name);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;
            foreach(CrimeType CT in LCT)
            {
                if (CT.T_name == textBox1.Text)
                    b = false;
            }
            if (b)
            {
                CrimeType CT = new CrimeType();
                CT.T_name = textBox1.Text;
                CT.T_id = LCT.Count.ToString();
                CT.write();
                if (!LCT.Contains(CT))
                    LCT.Add(CT);
                listBox1.Items.Add(CT.T_name);
                comboBox9.Items.Add(CT.T_name);
                typeCmbo.Items.Add(CT.T_name);
            }
            else
            {
                MessageBox.Show("Already exist");
            }
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
            label1.Text = "No. of assigned crimes: " + off.assigNum.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void TypesButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            TypesButton.IsTab = true;
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            ManageButton.IsTab = true;
            radioButton1.Checked = true;
        }

        private void CrimesButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
            CrimesButton.IsTab = true;

            radioButton6.Checked = true;
            c.read();
            if(c.C_Imgs.Count > 0)
            {
                MemoryStream ms = new MemoryStream(c.C_Imgs[0]);
                pictureBox1.Image = Image.FromStream(ms);
            }
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IPeople people = new IPeople();
            people.IP_name = textBox4.Text;
            people.IP_age = Int32.Parse(ageCmbo.Text);
            people.IP_locatoin = locationCmbo.Text;
            people.Pasthist = comboBox9.Text;
            string boolean2 = disputesCmbo.Text;
            if (boolean2 == "Yes")
            {
                people.IP_disp = true;
            }
            else
            {
                people.IP_disp = false;
            }

            if (imgloc != null)
            {
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                people.Image = br.ReadBytes((int)fs.Length);
            }
            else
            {
                MessageBox.Show("Please insert image");
            }
            iplist = people.read();
            people.IP_id = iplist.Count.ToString();
            people.write();
            
            ipl.Add(people);
            textBox4.ResetText();
            ageCmbo.ResetText();
            locationCmbo.ResetText();
            disputesCmbo.ResetText();
            comboBox9.ResetText();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            doneBtn.Text = "Add";
            if (radioButton6.Checked)
            {
                radioButton6.BackColor = Color.FromArgb(46, 12, 14);
                radioButton6.ForeColor = Color.White;

                radioButton5.BackColor = Color.DarkGray;
                radioButton5.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton4.BackColor = Color.DarkGray;
                radioButton4.ForeColor = Color.FromArgb(67, 72, 76);

                selectCmbo.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                ageCmbo.Visible = true;
                areaCmbo.Visible = true;
                disputesCmbo.Visible = true;
                locationCmbo.Visible = true;
                officerCmbo.Visible = true;
                statusCmbo.Visible = true;
                typeCmbo.Visible = true;
                comboBox9.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                doneBtn.Visible = true;
                backBtn.Visible = true;
                nextBtn.Visible = true;
                button9.Visible = true;
                addimgBtn.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;

            }
            else
            {
                radioButton6.BackColor = Color.DarkGray;
                radioButton6.ForeColor = Color.FromArgb(67, 72, 76);
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(doneBtn.Text == "Add")
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
                for (int j = 0; j < LO.Count; j++)
                {
                    if (officerCmbo.Text == LO[j].O_id)
                    {
                        LO[j].assigNum++;
                    }
                }
                List<Crime> clist = crime.read();
                crime.C_id = clist.Count.ToString();

                crime.C_Area = areaCmbo.Text;

                string boolean = statusCmbo.Text;
                if (boolean == "Opened")
                {
                    crime.C_Stat = true;
                }
                else
                {
                    crime.C_Stat = false;
                }
                crime.C_desc = textBox2.Text;
                crime.C_item = itemsFound;
                crime.C_Imgs = Imgs;
                crime.C_IP = ipl;
                crime.write();
                LC.Add(crime);
                ipl.Clear();
                itemsFound.Clear();
                Imgs.Clear();
                FileStream FS = new FileStream("Officer.xml", FileMode.Truncate);
                FS.Close();
                FS = new FileStream("Officer.xml", FileMode.Append);
                XmlSerializer ser = new XmlSerializer(LO.GetType());
                ser.Serialize(FS, LO);
                FS.Close();
                pictureBox1.Image = DefaultImage;
                MessageBox.Show("Added");
                
            }
            else if(doneBtn.Text == "Delete")
            {
                for (int i = 0; i < LC.Count; i++)
                {
                    if (LC[i].C_id == selectCmbo.Text)
                    {
                        for (int j = 0; j < LO.Count; j++)
                        {
                            if (LC[i].C_offId == LO[j].O_id)
                            {
                                LO[j].assigNum--;
                            }
                        }
                        LC.RemoveAt(i);
                    }
                }
                FileStream fS = new FileStream("Officer.xml", FileMode.Truncate);
                fS.Close();
                fS = new FileStream("Officer.xml", FileMode.Append);
                XmlSerializer Ser = new XmlSerializer(LO.GetType());
                Ser.Serialize(fS, LO);
                fS.Close();

                FileStream FS = new FileStream("Crime.xml", FileMode.Truncate);
                FS.Close();
                FS = new FileStream("Crime.xml", FileMode.Append);
                XmlSerializer ser = new XmlSerializer(LC.GetType());
                ser.Serialize(FS, LC);
                FS.Close();
                MessageBox.Show("Deleted");

            }
            else if(doneBtn.Text== "Update")
            {
                CrimeType ct = new CrimeType();
                for (int i = 0; i < LC.Count; i++)
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
                        if (b == "Opened")
                        {
                            LC[i].C_Stat = true;
                        }
                        else
                        {
                            LC[i].C_Stat = false;
                        }
                        for (int j = 0; j < LO.Count; j++)
                        {
                            if (LC[i].C_offId == LO[j].O_id)
                            {
                                LO[j].assigNum--;
                            }
                        }
                        for (int j = 0; j < itemsFound.Count; j++)
                        {
                            LC[i].C_item.Add(itemsFound[j]);
                        }
                        for (int j = 0; j < Imgs.Count; j++)
                        {
                            LC[i].C_Imgs.Add(Imgs[j]);
                        }
                        for (int j = 0; j < ipl.Count; j++)
                        {
                            LC[i].C_IP.Add(ipl[j]);
                        }
                        LC[i].C_offId = officerCmbo.Text;
                        for(int j=0; j < LO.Count; j++)
                        {
                            if (LC[i].C_offId == LO[j].O_id)
                            {
                                LO[j].assigNum++;
                            }
                        }
                        LC[i].C_Area = areaCmbo.Text;
                        break;
                    }
                }
                FileStream fS = new FileStream("Officer.xml", FileMode.Truncate);
                fS.Close();
                fS = new FileStream("Officer.xml", FileMode.Append);
                XmlSerializer Ser = new XmlSerializer(LO.GetType());
                Ser.Serialize(fS, LO);
                fS.Close();

                FileStream FS = new FileStream("Crime.xml", FileMode.Truncate);
                FS.Close();
                FS = new FileStream("Crime.xml", FileMode.Append);
                XmlSerializer ser = new XmlSerializer(LC.GetType());
                ser.Serialize(FS, LC);
                FS.Close();
                MessageBox.Show("Updated");
                ipl.Clear();
                itemsFound.Clear();
                Imgs.Clear();
            }
            officerCmbo.Items.Clear();
            comboBox6.Items.Clear();
            selectCmbo.Items.Clear();

            for (int i = 0; i < LO.Count; i++)
            {
                if (LO[i].assigNum < 10)
                    officerCmbo.Items.Add(LO[i].O_id);
            }
            for (int i = 0; i < LO.Count; i++)
            {
                comboBox6.Items.Add(LO[i].O_id);
            }

            for (int i = 0; i < LC.Count; i++)
            {
                selectCmbo.Items.Add(LC[i].C_id);
            }

        }

        private void addimgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrimeType ct = new CrimeType();
            for (int i = 0; i < LC.Count; i++)
            {
                if (selectCmbo.Text == LC[i].C_id)
                {
                    c = LC[i];
                }
            }
            for (int i = 0; i < LCT.Count; i++)
            {
                if (c.C_Tid == LCT[i].T_id)
                {
                    ct = LCT[i];
                }
            }
            typeCmbo.Text = ct.T_name;
            textBox2.Text = c.C_desc;
            statusCmbo.Text = c.C_Stat.ToString();
            officerCmbo.Text = c.C_offId;
            areaCmbo.Text = c.C_Area;
            ImgsUpdate = c.C_Imgs;
            count = 0;
            if (ImgsUpdate.Count != 0)
            {
                MemoryStream ms = new MemoryStream(ImgsUpdate[0]);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            doneBtn.Text = "Delete";
            if (radioButton5.Checked)
            {
                radioButton5.BackColor = Color.FromArgb(46, 12, 14);
                radioButton5.ForeColor = Color.White;

                radioButton6.BackColor = Color.DarkGray;
                radioButton6.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton4.BackColor = Color.DarkGray;
                radioButton4.ForeColor = Color.FromArgb(67, 72, 76);

                selectCmbo.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                ageCmbo.Visible = false;
                areaCmbo.Visible = false;
                disputesCmbo.Visible = false;
                locationCmbo.Visible = false;
                officerCmbo.Visible = false;
                statusCmbo.Visible = false;
                typeCmbo.Visible = false;
                comboBox9.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                doneBtn.Visible = true;
                backBtn.Visible = false;
                nextBtn.Visible = false;
                button9.Visible = false;
                addimgBtn.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                radioButton5.BackColor = Color.DarkGray;
                radioButton5.ForeColor = Color.FromArgb(67, 72, 76);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            doneBtn.Text = "Update";
            pictureBox1.Image = DefaultImage;
            if (radioButton4.Checked)
            {
                radioButton4.BackColor = Color.FromArgb(46, 12, 14);
                radioButton4.ForeColor = Color.White;

                radioButton5.BackColor = Color.DarkGray;
                radioButton5.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton6.BackColor = Color.DarkGray;
                radioButton6.ForeColor = Color.FromArgb(67, 72, 76);

                selectCmbo.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                ageCmbo.Visible = true;
                areaCmbo.Visible = true;
                disputesCmbo.Visible = true;
                locationCmbo.Visible = true;
                officerCmbo.Visible = true;
                statusCmbo.Visible = true;
                typeCmbo.Visible = true;
                comboBox9.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                doneBtn.Visible = true;
                backBtn.Visible = true;
                nextBtn.Visible = true;
                button9.Visible = true;
                addimgBtn.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                pictureBox1.Visible = true;
            }
            else
            {
                radioButton4.BackColor = Color.DarkGray;
                radioButton4.ForeColor = Color.FromArgb(67, 72, 76);
            }
            LC = c.read();
            selectCmbo.Items.Clear();
            for (int i = 0; i < LC.Count; i++)
            {
                selectCmbo.Items.Add(LC[i].C_id);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button7.Text = "Add";
            if (radioButton1.Checked)
            {
                radioButton1.BackColor = Color.FromArgb(46, 12, 14);
                radioButton1.ForeColor = Color.White;

                radioButton2.BackColor = Color.DarkGray;
                radioButton2.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton3.BackColor = Color.DarkGray;
                radioButton3.ForeColor = Color.FromArgb(67, 72, 76);

                comboBox6.Visible = false;
                bunifuMetroTextbox1.Visible = true;
                bunifuMetroTextbox3.Visible = true;
                label1.Visible = false;
                bunifuMetroTextbox1.Location = new Point(40, 69);
                bunifuMetroTextbox3.Location = new Point(38, 122);
                button7.Location = new Point(40, 174);

            }
            else
            {
                radioButton1.BackColor = Color.DarkGray;
                radioButton1.ForeColor = Color.FromArgb(67, 72, 76);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button7.Text = "Delete";
            if (radioButton2.Checked)
            {
                radioButton2.BackColor = Color.FromArgb(46, 12, 14);
                radioButton2.ForeColor = Color.White;

                radioButton1.BackColor = Color.DarkGray;
                radioButton1.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton3.BackColor = Color.DarkGray;
                radioButton3.ForeColor = Color.FromArgb(67, 72, 76);

                comboBox6.Visible = true;
                bunifuMetroTextbox1.Visible = false;
                label1.Visible = false;
                bunifuMetroTextbox3.Visible = false;
                button7.Location = new Point(40, 105);
            }
            else
            {
                radioButton2.BackColor = Color.DarkGray;
                radioButton2.ForeColor = Color.FromArgb(67, 72, 76);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button7.Text = "Update";
            if (radioButton3.Checked)
            {
                radioButton3.BackColor = Color.FromArgb(46, 12, 14);
                radioButton3.ForeColor = Color.White;

                radioButton2.BackColor = Color.DarkGray;
                radioButton2.ForeColor = Color.FromArgb(67, 72, 76);

                radioButton1.BackColor = Color.DarkGray;
                radioButton1.ForeColor = Color.FromArgb(67, 72, 76);

                comboBox6.Visible = true;
                bunifuMetroTextbox1.Visible = true;
                label1.Visible = true;
                label1.Location = new Point(40, 157);
                bunifuMetroTextbox3.Visible = false;
                button7.Location = new Point(40, 185);
                label1.Text = "No. of assigned crimes: ";
                bunifuMetroTextbox1.Location = new Point(38, 105);
                bunifuMetroTextbox3.Location = new Point(38, 157);
            }
            else
            {
                radioButton3.BackColor = Color.DarkGray;
                radioButton3.ForeColor = Color.FromArgb(67, 72, 76);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Add")
            {
                Officer officer = new Officer();
                officer.O_id = LO.Count.ToString();
                officer.O_name = bunifuMetroTextbox1.Text;
                officer.assigNum = 0;
                officer.O_Password = bunifuMetroTextbox3.Text;
                officer.write();
                LO.Add(officer);
                MessageBox.Show("Added");
            }
            else if (button7.Text == "Delete")
            {
                Officer officer = new Officer();
                Crime crime = new Crime();
                foreach (Crime obj in LC)
                {
                    if (obj.C_offId == comboBox6.Text)
                    {
                        obj.C_offId = "";
                    }
                }
                foreach (Officer item in LO)
                {
                    if (item.O_id == comboBox6.Text)
                    {
                        LO.Remove(item);
                        break;
                    }
                }
                FileStream FS = new FileStream("Officer.xml", FileMode.Truncate);
                XmlSerializer ser = new XmlSerializer(LO.GetType());
                ser.Serialize(FS, LO);
                FS.Close();

                FileStream fS = new FileStream("Crime.xml", FileMode.Truncate);
                fS.Close();
                fS = new FileStream("Crime.xml", FileMode.Append);
                XmlSerializer Ser = new XmlSerializer(LC.GetType());
                Ser.Serialize(fS, LC);
                fS.Close();
                MessageBox.Show("Deleted");
            }
            else if (button7.Text == "Update")
            {
                for (int i = 0; i < LO.Count; i++)
                {
                    if (comboBox6.Text == LO[i].O_id)
                    {
                        LO[i].O_name = bunifuMetroTextbox1.Text;
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
            comboBox6.Items.Clear();
            officerCmbo.Items.Clear();
            for (int i = 0; i < LO.Count; i++)
            {
                if (LO[i].assigNum < 10)
                    officerCmbo.Items.Add(LO[i].O_id);
                comboBox6.Items.Add(LO[i].O_id);
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_Enter(object sender, EventArgs e)
        {
        }

        private void bunifuMetroTextbox2_Leave(object sender, EventArgs e)
        {
        }

        private void bunifuMetroTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox3.Text == "Password")
            {
                bunifuMetroTextbox3.Text = "";
                bunifuMetroTextbox3.ForeColor = Color.White;
                bunifuMetroTextbox3.isPassword = true;
            }
        }

        private void bunifuMetroTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox3.Text == "")
            {
                bunifuMetroTextbox3.Text = "Password";
                bunifuMetroTextbox3.ForeColor = Color.DarkGray;
                bunifuMetroTextbox3.isPassword = false;
            }
        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {
        }

        private void radioButton2_MouseHover(object sender, EventArgs e)
        {
        }

        private void radioButton3_MouseHover(object sender, EventArgs e)
        {
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "Officer Name")
            {
                bunifuMetroTextbox1.Text = "";
                bunifuMetroTextbox1.ForeColor = Color.White;
            }
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "")
            {
                bunifuMetroTextbox1.Text = "Officer Name";
                bunifuMetroTextbox1.ForeColor = Color.DarkGray;
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
                textBox1.ForeColor = Color.DarkGray;
            }

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            this.Hide();
            s.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                }
                byte[] sceneimg = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                sceneimg = br.ReadBytes((int)fs.Length);
                Imgs.Add(sceneimg);
                if (doneBtn.Text == "Update")
                {
                    ImgsUpdate.Add(sceneimg);
                    count = ImgsUpdate.Count - 1;
                }
                else
                count = Imgs.Count-1;
                MemoryStream ms = new MemoryStream(sceneimg);
                pictureBox1.Image = Image.FromStream(ms);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (Imgs.Count != 0&& doneBtn.Text == "Add")
            {
                if (Imgs.Count-1 == count)
                {
                    MessageBox.Show("This is the last photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count++;
                    MemoryStream ms = new MemoryStream(Imgs[count]);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else if(ImgsUpdate.Count != 0 && doneBtn.Text == "Update")
            {
                if (ImgsUpdate.Count -1 == count)
                {
                    MessageBox.Show("This is the last photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count++;
                    MemoryStream ms = new MemoryStream(ImgsUpdate[count]);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }   
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (Imgs.Count != 0 && doneBtn.Text == "Add")
            {
                if (count == 0)
                {
                    MessageBox.Show("This is the frist photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    MemoryStream ms = new MemoryStream(Imgs[count]);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else if (ImgsUpdate.Count != 0 && doneBtn.Text == "Update")
            {
                if (count == 0)
                {
                    MessageBox.Show("This is the first photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    MemoryStream ms = new MemoryStream(ImgsUpdate[count]);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            itemsFound.Add(textBox3.Text);
            textBox3.ResetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

