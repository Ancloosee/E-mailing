using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Email
{
     class Serialize
    {

        public  void BinarySerialisation(List<Task> obj)
        {
            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(Settings.GetInstance().DirectoryPath + @"\UserBinary.txt", FileMode.Create);
            binary.Serialize(stream, obj);
            stream.Close();
        }
        public  void XmlSerialisation(List<Task> obj)
        {
            XmlSerializer xml = new XmlSerializer(obj.GetType());
            FileStream stream = new FileStream(Settings.GetInstance().DirectoryPath + @"\UserXml.xml", FileMode.Create);
            xml.Serialize(stream, obj);
            stream.Close();
        }
       public  List<Task> BinaryDeserialization()
        {
            List<Task> tmp = new List<Task>();
            BinaryFormatter binary = new BinaryFormatter();
            FileStream stream = new FileStream(Settings.GetInstance().DirectoryPath + @"\UserBinary.txt", FileMode.Open);
            tmp = (List<Task>)binary.Deserialize(stream);
            stream.Close();
            return tmp;
        }
        public  List<Task> XmlDeserialization()
        {
            List<Task> tmp = new List<Task>();
            XmlSerializer xml = new XmlSerializer(typeof(List<Task>));
            FileStream stream = new FileStream(Settings.GetInstance().DirectoryPath + @"\UserXml.xml", FileMode.Open);
            tmp = (List<Task>)xml.Deserialize(stream);
            stream.Close();
            return tmp;

        }


    }
}
