using System.Xml.Serialization;

namespace FileInteraction
{

    public class Person
    {
        // Fields
        [XMLAttribute]
        public string? name { get; set; }
        public double? height { get; set; }
        public string? weight { get; set; }
    
        private XmlSerializer Serializer = new XmlSerializer(typeof(Person));
        public Person() {}
        // constructor

        public Person(string? name, decimal? height, decimal? weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }
        
    
        public string SerializeXML()
        {
            var stringWriter = new StringWriter();
            Serializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();

        }
    }
}