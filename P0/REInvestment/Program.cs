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
            string propertyAddress = Console.ReadLine();    

            float inputAskingPrice;
            bool testAskingPrice;
            
            do 
            {   Console.Write("Enter Asking Sales Price: $");
                string askingPrice = Console.ReadLine();    
                testAskingPrice = float.TryParse(askingPrice, out inputAskingPrice); 
                Console.WriteLine(inputAskingPrice);
            } while (!testAskingPrice); 
                      
            Console.WriteLine(" ");
            float inputRepairEstimate;
            bool testRepairEstimate;
            
            do 
            {   Console.Write("Enter Repair Estimate:    $");
                string repairEstimate = Console.ReadLine();    
                testRepairEstimate = float.TryParse(repairEstimate, out inputRepairEstimate); 
                Console.WriteLine(inputRepairEstimate);
            } while (!testRepairEstimate); 
  
            float inputArv;
            bool testArv;
            do 
            {
                Console.Write("Enter Comparable ARV:     $");
                string afterRepairValue = Console.ReadLine();   
                testArv = float.TryParse(afterRepairValue, out inputArv);
                Console.WriteLine(inputArv);
            } while (!testArv); 

            Console.WriteLine(" ");

            float projectCostPercentage;
            projectCostPercentage = (inputAskingPrice + inputRepairEstimate) / inputArv;
            Console.WriteLine(projectCostPercentage*100);
            string strPCP = Convert.ToString(projectCostPercentage*100);

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