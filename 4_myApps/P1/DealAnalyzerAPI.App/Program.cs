using System.Text.Json;

namespace DealAnalyzerAPI.App
{
    class Program
    {
        // Fields
        //public static readonly HttpClient Client = new HttpClient();
        //public static string uri = "https://localhost:7230/api/";



        // Constructors

        // Methods
        static async Task Main()
        {
            
            //Client.BaseAddress = new Uri(uri);
            //HttpResponseMessage investorList = await Client.GetAsync("Investors/allinvestors");
            // Console.WriteLine(Client.BaseAddress + "Investors/allinvestors");
            //string response = await Client.GetStringAsync("Investors/allinvestors");
            //Console.WriteLine(response);
            //List<InvestorDataDTO>? investors = JsonSerializer.Deserialize<List<InvestorDataDTO>>(response);
            // //investorList = JsonSerializer.Deserialize<List<InvestorDataDTO>>(await investorList.Content.ReadAsStringAsync())
            // // if(investorList.IsSuccessStatusCode) {
            // //     Console.WriteLine("OK");

            // // } else {
            // //     Console.WriteLine("Bad");
            // // }
            
            //foreach(var inv in investors) {
            //   Console.WriteLine(inv.id);
            //   Console.WriteLine(inv.username);
            //   Console.WriteLine(inv.name);
            //}
            
            AnalyzerMainMenu oAnalyzer = new AnalyzerMainMenu();
            oAnalyzer.StartNewDealAnalysis();

        }
    }
}
