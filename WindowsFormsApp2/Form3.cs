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
    public partial class Form3 : Form
    {

        string imgloc;
        List<Byte[]> Imgs = new List<byte[]>();
        List<Byte[]> ImgsUpdate = new List<byte[]>();
        Officer officer = new Officer();
        Crime c = new Crime();
        CrimeType cT = new CrimeType();
        List<Officer> LO = new List<Officer>();
        List<Crime> LC = new List<Crime>();
        List<CrimeType> LCT = new List<CrimeType>();
        IPeople people = new IPeople();
        List<string> itemsFound = new List<string>();

        int count;
        public struct involved
        {
            public string person;
            public int score;
        }
        public Form3(Officer o)
        {
            officer = o;
            count = 0;
            LO = officer.read();
            LC = c.read();
            LCT = cT.read();
            InitializeComponent();

            for (int i = 0; i < LC.Count; i++)
            {
                if (LC[i].C_offId == officer.O_id && LC[i].C_Stat == true)
                {
                    comboBox2.Items.Add(LC[i].C_id);
                    selectCmbo.Items.Add(LC[i].C_id);
                }
            }

            for (int i = 0; i < LCT.Count; i++)
            {
                typeCmbo.Items.Add(LCT[i].T_name);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            solveBtn.IsTab = true;
            LC = c.read();
            selectCmbo.Items.Clear();
            for (int i = 0; i < LC.Count; i++)
            {
                if (LC[i].C_offId == officer.O_id && LC[i].C_Stat == true)
                {
                    selectCmbo.Items.Add(LC[i].C_id);
                }
            }
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            ManageButton.IsTab = true;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < LC.Count; i++)
            {
                if (LC[i].C_id == comboBox2.Text)
                {
                    for(int j = 0; j < LC[i].C_IP.Count; j++)
                    {
                        if (LC[i].C_IP[j].IP_name == comboBox6.Text)
                        {
                            ageLbl.Text =  LC[i].C_IP[j].IP_age.ToString();
                            locationLbl.Text = LC[i].C_IP[j].IP_locatoin;
                            if (LC[i].C_IP[j].IP_disp)
                                disLbl.Text = "There are Disputes";
                            else
                                disLbl.Text = "There are no Disputes";
                            histLbl.Text = LC[i].C_IP[j].Pasthist;
                            MemoryStream ms = new MemoryStream(LC[i].C_IP[j].Image);
                            pictureBox3.Image = Image.FromStream(ms);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (selectCmbo.Text == "Select Crime ID")
            {
                MessageBox.Show("Please select crime.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Crime cs = new Crime();
                for (int i = 0; i < LC.Count; i++)
                {
                    if (selectCmbo.Text == LC[i].C_id)
                    {
                        cs = LC[i];
                        break;
                    }
                }
                List<involved> ListPeople = new List<involved>();
                for (int i = 0; i < cs.C_IP.Count; i++)
                {
                    involved pp = new involved();
                    pp.score = 0;
                    pp.person = cs.C_IP[i].IP_name;
                    if (cs.C_IP[i].IP_disp == true)
                    {
                        pp.score++;
                    }
                    for (int j = 0; j < LCT.Count; j++)
                    {
                        if (cs.C_Tid == LCT[i].T_id)
                        {
                            if (cs.C_IP[i].Pasthist == LCT[j].T_name)
                            {
                                pp.score++;
                                break;
                            }
                        }
                    }
                    if (cs.C_IP[i].IP_locatoin == cs.C_Area)
                    {
                        pp.score++;
                    }
                    ListPeople.Add(pp);
                }

                for (int i = 0; i < ListPeople.Count ; i++)
                {
                    for (int j = i; j < ListPeople.Count ; j++)
                    {
                        if (ListPeople[j].score < ListPeople[i].score)
                        {
                            involved tmp = ListPeople[j];
                            ListPeople[j] = ListPeople[i];
                            ListPeople[i] = tmp;
                        }
                    }
                }
                int max = ListPeople[ListPeople.Count - 1].score;
                label2.Text = "";
                label2.Visible = true;
                for (int i = 0; i < ListPeople.Count; i++)
                {
                    if (ListPeople[i].score == max && label2.Text == "")
                        label2.Text += ListPeople[i].person;
                    else if (ListPeople[i].score == max && label2.Text != "")
                        label2.Text += (" and " + ListPeople[i].person);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void selectCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrimeType ct = new CrimeType();
            for (int i = 0; i < LC.Count; i++)
            {
                if (comboBox2.Text == LC[i].C_id)
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
            areaCmbo.Text = c.C_Area;
            for (int i = 0; i < c.C_item.Count; i++)
            {
                itemsCmbo.Items.Add(c.C_item[i]);
            }
            comboBox6.Items.Clear();
            for (int i = 0; i < c.C_IP.Count; i++)
            {
                comboBox6.Items.Add(c.C_IP[i].IP_name);
            }
            ImgsUpdate = c.C_Imgs;
            count = 0;
            if (ImgsUpdate.Count != 0)
            {
                MemoryStream ms = new MemoryStream();
                ms = new MemoryStream(ImgsUpdate[0]);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            itemsFound.Add(textBox3.Text);
            textBox3.ResetText();
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
                    count = Imgs.Count - 1;
                MemoryStream ms = new MemoryStream(sceneimg);
                pictureBox1.Image = Image.FromStream(ms);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrimeType ct = new CrimeType();
            for (int i = 0; i < LC.Count; i++)
            {
                if (comboBox2.Text == LC[i].C_id)
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
                    for (int j = 0; j < itemsFound.Count; j++)
                    {
                        LC[i].C_item.Add(itemsFound[j]);
                    }
                    for (int j = 0; j < Imgs.Count; j++)
                    {
                        LC[i].C_Imgs.Add(Imgs[j]);
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
            itemsFound.Clear();
            Imgs.Clear();

            selectCmbo.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < LC.Count; i++)
            {
                if (LC[i].C_offId == officer.O_id && LC[i].C_Stat == true)
                {
                    comboBox2.Items.Add(LC[i].C_id);
                    selectCmbo.Items.Add(LC[i].C_id);
                }
            }
            MessageBox.Show("Updated");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (ImgsUpdate.Count != 0)
            {
                MemoryStream ms = new MemoryStream();
                if (count == 0)
                {
                    MessageBox.Show("This is the first photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    ms = new MemoryStream(ImgsUpdate[count]);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        { 
            if (ImgsUpdate.Count != 0)
            {
                MemoryStream ms = new MemoryStream();
                if (ImgsUpdate.Count - 1 == count)
                {
                    MessageBox.Show("This is the last photo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count++;
                    ms = new MemoryStream(ImgsUpdate[count]);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            this.Hide();
            s.Show();
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

        private void selectCmbo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}