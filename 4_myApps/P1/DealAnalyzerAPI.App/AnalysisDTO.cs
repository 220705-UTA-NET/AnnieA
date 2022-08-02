using System.Text.Json;

namespace DealAnalyzerAPI.App
{
    class AnalysisDTO
    {

        // This serializes a text file where the investors are stored and retrieved
        //string path = @".\InvestorFile.txt";       
        //public static readonly HttpClient oClient = new HttpClient();
        //public static string uri = "https://localhost:7230/api/Investor";
        //public static XmlSerializer o1Serializer = new XmlSerializer(typeof(InvestorDataDTO));
        public static readonly HttpClient Client = new HttpClient();
        public static string uri = "https://localhost:7230/api/Investor";

        // Fields
        public int TransId {get; set;}
        public string? TimeStamp {get; set;}
        public string? InvestorUsername {get; set;}
        public string? PropertyAddress {get; set;}
        public decimal? AskingPrice {get; set;}
        public decimal? RepairEstimate {get; set;}
        public decimal? AfterRepairValue {get; set;}
        public decimal? ProjectCostPercentage {get; set;}
        public string? ExitId {get; set;}        
        

        // Constructor
        public AnalysisDTO() {}

        public AnalysisDTO(int transId, string? timeStamp, string? investorUsername, string? propertyAddress, decimal? askingPrice, decimal? repairEstimate, decimal? afterRepairValue, decimal? projectCostPercentage, string? exitId)
        {
            this.TransId = transId;
            this.TimeStamp = timeStamp;
            this.InvestorUsername = investorUsername;
            this.PropertyAddress = propertyAddress;
            this.AskingPrice = askingPrice;
            this.RepairEstimate = repairEstimate;
            this.AfterRepairValue = afterRepairValue;
            this.ProjectCostPercentage = projectCostPercentage;
            this.ExitId = exitId;
        }

        // Methods
        public override string ToString()
        {
            return $"{TransId} {TimeStamp} {InvestorUsername} {PropertyAddress} {AskingPrice} {RepairEstimate} {AfterRepairValue} {ProjectCostPercentage} {ExitId}";
        }
 
        public static async Task DeserializeXML()
        {
            Client.BaseAddress = new Uri(uri);
            HttpResponseMessage analysisList = await Client.GetAsync("Investors/allinvestors");
            Console.WriteLine(Client.BaseAddress + "Investors/allinvestors");
            string response = await Client.GetStringAsync("Investors/allinvestors");
            Console.WriteLine(response);
            List<AnalysisDTO>? analyses = JsonSerializer.Deserialize<List<AnalysisDTO>>(response);
            foreach(var inv in analyses)
            {
               Console.WriteLine(inv.TransId);
               Console.WriteLine(inv.TimeStamp);
               Console.WriteLine(inv.InvestorUsername);
               Console.WriteLine(inv.PropertyAddress);
               Console.WriteLine(inv.AskingPrice);
               Console.WriteLine(inv.RepairEstimate);
               Console.WriteLine(inv.AfterRepairValue);
               Console.WriteLine(inv.ProjectCostPercentage);
               Console.WriteLine(inv.ExitId);

            }
        }
    }
}
