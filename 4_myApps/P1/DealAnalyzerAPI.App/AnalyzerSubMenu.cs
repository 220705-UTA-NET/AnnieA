using System;

namespace DealAnalyzerAPI.App
{

    public class AnalyzerSubMenu
    {

        // Fields
        public bool aMenuLoop = true;
        public string? choice4;
        public float iAsking {get; set;}
        public float iRepairs {get; set;}
        public float iArv {get; set;}


        // Constructor


        // Methods
        public static string? AnalysisMenu()
        {
 
            Console.Clear();

            // This is the Analysis Menu
            Console.WriteLine("ANALYSIS MENU");

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("[1] Start A New Deal Analysis");
            Console.WriteLine("[2] View All Archived Deal Analysis");
            Console.WriteLine("[3] Exit\n");
            Console.Write("Your selection: ");

            return Console.ReadLine();
        }

        public void AnalyzerMethod(string userSelection4 = "")
        {
            while (aMenuLoop)
            {
                choice4 = AnalysisMenu();

                switch (choice4)
                {
                    case "1":
                        Console.WriteLine("You chose to START a NEW Deal Analysis.");
                        // Calls the project cost object and its method to calculate cost%
                        ProjectCost o1ProjectCost = new ProjectCost();
                        o1ProjectCost.ProjectCostPercentage();
                        break;

                    case "2":
                        Console.WriteLine("You chose to LOWER your repair budget.");
                        double newRepairEstimate = (iArv * .70) - iAsking;
                        Console.WriteLine("After Repair Value: " + this.iArv);
                        Console.WriteLine("     Repair Budget: " + newRepairEstimate);
                        Console.WriteLine("      Asking Price: " + this.iAsking);
                        Console.WriteLine("These are the ideal numbers to make the deal PROFITABLE. Press any key to continue.");
                        Console.ReadLine();

                        break;

                    case "3":
                        aMenuLoop = false;
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
