using System.Xml.Serialization;

namespace DealAnalyzerAPI.App
{
    public class InvestorTransDTO
    {
        // fields
        [XmlAttribute]
        public string? UserName { get; set;}
        public string? PropertyAddress { get; set; }
        public float? AskingPrice { get; set; }
        public float? RepairEstimate { get; set; }
        public float? AfterRepairValue { get; set; }
        public float? ProjectCostPercentage { get; set; }

        

        // Constructor

        public InvestorTransDTO() {}

        public InvestorTransDTO(string? userName, string? propertyAddress, float? askingPrice, float? repairEstimate, float? afterRepairValue, float? projectCostPerentage)
        {
            this.UserName = userName;
            this.PropertyAddress = propertyAddress;
            this.AskingPrice = askingPrice;
            this.RepairEstimate = repairEstimate;
            this.AfterRepairValue = afterRepairValue;
        }

        // Methods

        public string SerializeXml()
        {
            XmlSerializer o2Serializer = new XmlSerializer(typeof(InvestorTransDTO));
            string path = @".\InvestorFile.txt";
            var oStringWriter = new StringWriter();     //this is an instance of the Stringwriter() class
            o2Serializer.Serialize(oStringWriter, this);
            oStringWriter.Close();
            Console.WriteLine(oStringWriter.ToString());
            return oStringWriter.ToString();
        }



    }
}