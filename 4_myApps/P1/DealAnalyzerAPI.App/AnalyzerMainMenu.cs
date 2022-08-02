namespace DealAnalyzerAPI.App
{
    public class AnalyzerMainMenu
    {
        // Fields
        public string? NewInvestor { get; set; }
        public string? OldInvestor { get; set; }
        public bool mainMenuLoop = true;
        public string? choice;
        public object? oI;

        // Constructor


        // Methods

        public string? MainMenu()
        {
            Console.Clear();
    
            // This is the Main Menu
            Console.WriteLine("Welcome to Real Estate Investing - Deal Analyzer");
            Console.WriteLine("(To BUY or NOT to BUY)\n");
            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("[1] New User");
            Console.WriteLine("[2] Returning User");
            Console.WriteLine("[3] Exit\n");
            Console.Write("Your selection: ");

            return Console.ReadLine();
        }

        public void StartNewDealAnalysis( string userSelection = "")
        {
            choice = userSelection;
            while (mainMenuLoop)
            {
                choice = MainMenu();
                switch (choice)
                {
                    case "1":
                        // Calls the object and its method add investor to database
                        InvestorData o1InvestorData = new InvestorData();
                        o1InvestorData.AddInvestorToDatabase();

                        // Calls the object and its method analyzer submenu
                        AnalyzerSubMenu oAnalyzerSubmenu = new AnalyzerSubMenu();
                        oAnalyzerSubmenu.AnalyzerMethod();
                        break;

                    case "2":  

                        // Calls the object and its method add trans to database
                        InvestorData o2InvestorsData = new InvestorData();
                        o2InvestorsData.CheckIfInvestorExists();
                        
                        // calls submenu oAnalyzer.ExitStrategy();
                        break;

                    case "3":
                        mainMenuLoop = false;
                        Console.WriteLine("Thank you for using this application.");
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }   
    }
}
