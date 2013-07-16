using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SubcarrierAllocation2
{
    public static class XmlSerializer
    {
        public static T Deserialize<T>(string filename)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                return (T)serializer.Deserialize(fs);
            }
        }

        public static void Serialize<T>(string filename, T t)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (Stream writer = new FileStream(filename, FileMode.Create))
            {
                serializer.Serialize(writer, t);
            }
        }
    }
}
