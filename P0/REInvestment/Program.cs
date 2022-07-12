using System;

namespace REInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REAL ESTATE Property Investment");
            Console.WriteLine("(To Buy OR Not To Buy)\n");
            
            Console.Write("Enter Property Address:    ");
            string propertyAddress = Console.ReadLine();    // user inputs the property address

            int inputAskingPrice;
            bool testAskingPrice;
            do // run the loop at least once
            {
                Console.Write("Enter Asking Sales Price: $");
                string askingPrice = Console.ReadLine();    // user inputs the asking sales price
                testAskingPrice = int.TryParse(askingPrice, out inputAskingPrice); // converts string askingPrice to integer then tests it
                //Console.Write("Invalid entry. Please enter a number.");
            } while (!testAskingPrice); // while the test variable is false, keep looping
                      
            Console.WriteLine(" ");
            
            int inputRepairEstimate;
            bool testRepairEstimate;
            do // run the loop at least once
            {
                Console.Write("Enter Repair Estimate:    $");
                string repairEstimate = Console.ReadLine();    // user inputs the repair estimate
                testRepairEstimate = int.TryParse(repairEstimate, out inputRepairEstimate); // converts string repairEstimate to integer then tests it
                //Console.Write("Invalid entry. Please enter a number.");
            } while (!testRepairEstimate); // while the test variable is false, keep looping
  
            int inputArv;
            bool testArv;
            do // run the loop at least once
            {
                Console.Write("Enter Comparable ARV:     $");
                string afterRepairValue = Console.ReadLine();   // user inputs the comparable ARV (after repair value)
                testArv = int.TryParse(afterRepairValue, out inputArv); // converts string repairEstimate to integer then tests it
                //Console.Write("Invalid entry. Please enter a number.");
            } while (!testArv); // while the test variable is false, keep looping

            Console.WriteLine(" ");

            int projectCostPercentage;
            projectCostPercentage = (inputAskingPrice + inputRepairEstimate) / inputArv;
            string strPCP = Convert.ToString(projectCostPercentage);

            if (projectCostPercentage <= .70)
            {
                
                Console.WriteLine("Your Project Cost Percentage is: " + strPCP + "%");
                Console.WriteLine("BUY!");

            }
            else if (projectCostPercentage > .70)
            {
                Console.WriteLine("Your Project Cost Percentage is: " + strPCP + "%");
                Console.WriteLine("NOT TO BUY!");
            }   
        }
    }
}