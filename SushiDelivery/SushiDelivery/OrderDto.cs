using System.IO;
using System.Xml.Serialization;

namespace SushiDelivery
{
   
    public class OrderDto
    {
        private static readonly XmlSerializer Xml = new XmlSerializer(typeof(OrderInformation));
        public static void WriteToFile(string fileName, OrderInformation data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xml.Serialize(fileStream, data);
            }
        }

        public static OrderInformation LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (OrderInformation)Xml.Deserialize(fileStream);
            }
        }
        public static OrderInformation LoadFromStream(Stream file)
        {
            return (OrderInformation)Xml.Deserialize(file);
        }
    }
}
