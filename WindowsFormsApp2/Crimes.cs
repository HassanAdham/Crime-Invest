using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp2
{
    [Serializable]
    [XmlRoot("CrimeType")]
    public class CrimeType
    {
        [XmlElement("TypeId")]
        public string T_id { set; get; }

        [XmlElement("TypeName")]
        public string T_name { set; get; }


        public CrimeType() { }
        public CrimeType(string id, string name)
        {
            T_id = id;
            T_name = name;
        }
        public void write()
        {

            FileStream FS = new FileStream("CrimeType.xml", FileMode.Append);
            List<CrimeType> list = new List<CrimeType>();
            if (FS.Length != 0)
            {
                FS.Close();
                list = read();
            }
            list.Add(this);
            FS.Close();
            FS = new FileStream("CrimeType.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(FS, list);
            FS.Close();
        }
        public List<CrimeType> read()
        {
            List<CrimeType> list = new List<CrimeType>();
            FileStream fs = new FileStream("CrimeType.xml", FileMode.OpenOrCreate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<CrimeType>)ser.Deserialize(fs);
            fs.Close();
            return list;
        }
    }
    [Serializable]
    [XmlRoot("Officer")]
    public class Officer
    {
        [XmlElement("OfficerId")]
        public string O_id { set; get; }

        [XmlElement("OfficerName")]
        public string O_name { set; get; }

        [XmlElement("#assigCrime")]
        public int assigNum { set; get; }

        [XmlElement("CrimeList")]
        public List<Crime> O_Clist { set; get; }

        [XmlElement("Password")]
        public string O_Password { set; get; }

        public void write()
        {

            FileStream FS = new FileStream("Officer.xml", FileMode.Append);
            List<Officer> list = new List<Officer>();
            if (FS.Length != 0)
            {
                FS.Close();
                list = read();
            }
            list.Add(this);
            FS.Close();
            FS = new FileStream("Officer.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(FS, list);
            FS.Close();
        }
        public List<Officer> read()
        {
            List<Officer> list = new List<Officer>();
            FileStream fs = new FileStream("Officer.xml", FileMode.OpenOrCreate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<Officer>)ser.Deserialize(fs);
            fs.Close();
            return list;
        }
    }
    [Serializable]
    [XmlRoot("InvolvedPeople")]
    public class IPeople
    {
        [XmlElement("IPid")]
        public string IP_id { set; get; }

        [XmlElement("IPName")]
        public string IP_name { set; get; }

        [XmlElement("IPLocation")]
        public string IP_locatoin { set; get; }

        [XmlElement("Age")]
        public int IP_age { set; get; }

        [XmlElement("IPDisputes")]
        public bool IP_disp { set; get; }

        public void write()
        {

            FileStream FS = new FileStream("IPeople.xml", FileMode.Append);
            List<IPeople> list = new List<IPeople>();
            if (FS.Length != 0)
            {
                FS.Close();
                list = read();
            }
            list.Add(this);
            FS.Close();
            FS = new FileStream("IPeople.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(FS, list);
            FS.Close();
        }
        public List<IPeople> read()
        {
            List<IPeople> list = new List<IPeople>();
            FileStream fs = new FileStream("IPeople.xml", FileMode.OpenOrCreate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<IPeople>)ser.Deserialize(fs);
            fs.Close();
            return list;
        }

    }
    [Serializable]
    [XmlRoot("Admin")]
    public class Admin
    {
        [XmlElement("AdminID")]
        public string A_id { set; get; }

        [XmlElement("AdminName")]
        public string A_name { set; get; }

        [XmlElement("Password")]
        public string A_Password { set; get; }

        public void write()
        {

            FileStream FS = new FileStream("Admin.xml", FileMode.Append);
            List<Admin> list = new List<Admin>();
            if (FS.Length != 0)
            {
                FS.Close();
                list = read();
            }
            list.Add(this);
            FS.Close();
            FS = new FileStream("Admin.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(FS, list);
            FS.Close();
        }
        public List<Admin> read()
        {
            List<Admin> list = new List<Admin>();
            FileStream fs = new FileStream("Admin.xml", FileMode.OpenOrCreate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<Admin>)ser.Deserialize(fs);
            fs.Close();
            return list;
        }

    }


    [Serializable]
    [XmlRoot("Crime")]
    public class Crime
    {
        [XmlElement("CrimeID")]
        public string C_id { set; get; }

        [XmlElement("CrimeArea")]
        public string C_Area { set; get; }

        [XmlElement("TypeId")]
        public string C_Tid { set; get; }

        [XmlElement("Description")]
        public string C_desc { set; get; }

        [XmlElement("CrimeStatus")]
        public bool C_Stat { set; get; }

        [XmlElement("ItemsFound")]
        public List<string> C_item { set; get; }

        [XmlElement("InvolvedPersonID")]
        public List<IPeople> C_IP { set; get; }

        [XmlElement("OfficerId")]
        public string C_offId { set; get; }

        public void write()
        {

            FileStream FS = new FileStream("Crime.xml", FileMode.Append);
            List<Crime> list = new List<Crime>();
            if (FS.Length != 0)
            {
                FS.Close();
                list = read();
            }
            list.Add(this);
            FS.Close();
            FS = new FileStream("Crime.xml", FileMode.Truncate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            ser.Serialize(FS, list);
            FS.Close();
        }
        public List<Crime> read()
        {
            List<Crime> list = new List<Crime>();
            FileStream fs = new FileStream("Crime.xml", FileMode.OpenOrCreate);
            XmlSerializer ser = new XmlSerializer(list.GetType());
            list = (List<Crime>)ser.Deserialize(fs);
            fs.Close();
            return list;
        }
    }
}
