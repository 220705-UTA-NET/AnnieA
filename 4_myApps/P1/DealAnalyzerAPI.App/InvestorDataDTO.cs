using System.Text.Json;
using System.Xml.Serialization;


namespace DealAnalyzerAPI.App
{
    class InvestorDataDTO
    {

        // This serializes a text file where the investors are stored and retrieved
        //string path = @".\InvestorFile.txt";       
        //public static readonly HttpClient oClient = new HttpClient();
        //public static string uri = "https://localhost:7230/api/Investor";
        //public static XmlSerializer o1Serializer = new XmlSerializer(typeof(InvestorDataDTO));
        public static readonly HttpClient Client = new HttpClient();
        public static string uri = "https://localhost:7230/api/Investor";

        // Fields
        public int id {get; set;}
        public string? username {get; set;}
        public string? name {get; set;}
        public string? email {get; set;}

        // Constructor
        public InvestorDataDTO() {}

        public InvestorDataDTO(int id, string? username, string? name, string? email)
        {
            this.id = id;
            this.username = username;
            this.name = name;
            this.email = email;
        }

        // Methods
        public override string ToString()
        {
            return $"{id} {username} {name} {email}";
        }
        
 

        /*
        public void SerializeInvestorDataXML(string? userName, string? name, string? email)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, SerializeXml());
            }
            else
            {
                File.AppendAllText(path, SerializeXml());    
            }
        }
        public string SerializeXml()
        {
            XmlSerializer o2Serializer = new XmlSerializer(typeof(InvestorDataDTO));
            string path = @".\InvestorFile.txt";
            var oStringWriter = new StringWriter();     //this is an instance of the Stringwriter() class
            o2Serializer.Serialize(oStringWriter, this);
            oStringWriter.Close();
            Console.WriteLine(oStringWriter.ToString());
            return oStringWriter.ToString();
        }

        public static async Task DeserializeXMLInvestorData()
        {
            // Deserialize XML record
            //InvestorTransDTO U = DeserializeXml();
            //Console.WriteLine(U.Name);

            string response = await oClient.GetStringAsync(uri);

            List<InvestorDataDTO> investors = JsonSerializer.Deserialize<List<InvestorDataDTO>>(response);

            foreach (var item in investors)
            {
                Console.WriteLine(item.ToString());
            }
        }
        */
        public static async Task DeserializeXML()
        {
            Client.BaseAddress = new Uri(uri);
            HttpResponseMessage investorList = await Client.GetAsync("Investors/allinvestors");
            Console.WriteLine(Client.BaseAddress + "Investors/allinvestors");
            string response = await Client.GetStringAsync("Investors/allinvestors");
            Console.WriteLine(response);
            List<InvestorDataDTO>? investors = JsonSerializer.Deserialize<List<InvestorDataDTO>>(response);
            foreach(var inv in investors)
            {
               Console.WriteLine(inv.id);
               Console.WriteLine(inv.username);
               Console.WriteLine(inv.name);
               Console.WriteLine(inv.email);
            }
        }

        /*public static InvestorDataDTO DeserializeXML()
        {
            XmlSerializer o3Serializer = new XmlSerializer(typeof(InvestorDataDTO));
            string path = @".\InvestorFile.txt";
            InvestorDataDTO oI = new InvestorDataDTO();       // creates an instance of Investor class
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exists.");
                return null;
            }
            else
            {
                using StreamReader oReader = new StreamReader(path);
                var record = (InvestorDataDTO)o3Serializer.Deserialize(oReader);
                if (record is null)
                {
                    throw new InvalidDataException();
                    return null;
                }
                else
                {
                    oI = record;
                }
            }
            return oI;
        } */   
    }
}
