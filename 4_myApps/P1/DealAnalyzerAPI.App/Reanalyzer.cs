using System;

namespace DealAnalyzerAPI.App
{

    public class Reanalyzer
    {

        // Fields
        public bool lastMenuLoop = true;
        public string? choice3;
        public float iAsking {get; set;}
        public float iRepairs {get; set;}
        public float iArv {get; set;}


        // Constructor
        public Reanalyzer(float iAsking, float iRepairs, float iArv)
        {
            this.iAsking = iAsking;
            this.iRepairs = iRepairs;
            this.iArv = iArv;

        }

        // Methods

        public static string? ReanalyzerMenu()
        {
 
            Console.Clear();

            // This is the Reanalyzer Menu
            Console.WriteLine("ReANALYZER MENU");

            Console.WriteLine("Please choose an option: ");
            Console.WriteLine("[1] Lower the Offer to Seller (Asking Price)");
            Console.WriteLine("[2] Lower the Repair Budget");
            Console.WriteLine("[3] Increase the After Repair Value");
            Console.WriteLine("[4] Exit\n");
            Console.Write("Your selection: ");

            return Console.ReadLine();
        }

        public void ReanalyzerMethod(string userSelection3 = "")
        {
            while (lastMenuLoop)
            {
                choice3 = ReanalyzerMenu();

                switch (choice3)
                {
                    case "1":
                        Console.WriteLine("You chose to LOWER the OFFER to the seller.");

                        double newAskingPrice = (iArv * .70) - iRepairs;
                        Console.WriteLine("After Repair Value: " + this.iArv);
                        Console.WriteLine("     Repair Budget: " + this.iRepairs);
                        Console.WriteLine("      Asking Price: " + newAskingPrice);
                        Console.WriteLine("These are the ideal numbers to make the deal PROFITABLE. Press any key to continue.");
                        Console.ReadLine();
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
                        Console.WriteLine("You chose to INCREASE your After Repair Value.");
                        double newArv = (iAsking + iRepairs) / .70;
                        Console.WriteLine("After Repair Value: " + newArv);
                        Console.WriteLine("     Repair Budget: " + this.iRepairs);
                        Console.WriteLine("      Asking Price: " + this.iAsking);
                        Console.WriteLine("These are the ideal numbers to make the deal PROFITABLE. Press any key to continue.");
                        Console.ReadLine();
                        break;

                    case "4":
                        lastMenuLoop = false;
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
