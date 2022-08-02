using System;

namespace DealAnalyzerAPI.App
{

    public class ExitStrategy
    {

        // Fields
        public bool subMenuLoop = true;
        public string? choice2;
        public float iask {get; set;}
        public float irep {get; set;}
        public float iarv {get; set;}
        public string? markUp {get; set;}
        public float inputMarkUp {get; set;}

        // Constructor
        public ExitStrategy(float iask, float irep, float iarv)
        {
            this.iask = iask;
            this.irep = irep;
            this.iarv = iarv;
        }

        // Methods

        public static string? ExitStrategyMenu()
        {
             Console.Clear();

            // This is the Exit Strategy Menu
            Console.WriteLine("EXIT STRATEGY");

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("[1] Sell the property");
            Console.WriteLine("[2] Rehab then sell");
            Console.WriteLine("[3] Rent the property");
            Console.WriteLine("[4] Rehab then rent");
            Console.WriteLine("[5] Exit\n");
            Console.Write("Your selection: ");

            return Console.ReadLine();
        }

        public void ExitStrategyMethod(string userSelection2 = "")
        {
            choice2 = userSelection2;

            while (subMenuLoop)
            {
                choice2 = ExitStrategyMenu();

                switch (choice2)
                {
                    case "1":
                        Console.WriteLine("You chose to WHOLESALE the property as an Exit Strategy.");
                                                
                        float inputMarkUp;
                        float sellingPrice;
                        bool testMarkUp;

                        do 
                        {  
                            Console.Write("Enter Markup (in %): ");
                            string? markUp = Console.ReadLine();    
                            testMarkUp = float.TryParse(markUp, out inputMarkUp); 
                        } while (!testMarkUp);

                        sellingPrice = (iask*(inputMarkUp/100))+iask;
                        Console.WriteLine("You may sell the property for :");
                        Console.WriteLine("AT LEAST " + sellingPrice);
                        Console.WriteLine("AT MOST  " + iarv);                      
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("You chose to REHAB then SELL the property as an Exit Strategy.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        // Calls submenu

                        break;

                    case "3":
                        Console.WriteLine("You chose to RENT the property as an Exit Strategy.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        // Calls submenu

                        break;
                    case "4":
                        Console.WriteLine("You chose to REHAB then RENT the property as an Exit Strategy.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        // Calls submenu

                        break;
                    case "5":
                        subMenuLoop = false;
                        Console.WriteLine("Thank you for using this application.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
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
