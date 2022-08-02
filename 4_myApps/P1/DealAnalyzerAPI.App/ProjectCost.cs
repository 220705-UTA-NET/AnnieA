using System;

namespace DealAnalyzerAPI.App
{
    public class ProjectCost 
    {
        // Fields
        public string? propertyAddress {get; set;}
        public string? askingPrice {get; set;}
        public string? repairEstimate {get; set;}
        public string? afterRepairValue {get; set;}
        public string? projectCostPercentage {get; set;}
        public float inputAskingPrice {get; set;}
        public float inputRepairEstimate {get; set;}
        public float inputAfterRepairValue {get; set;}
        public float inputProjectCostPercentage {get; set;}

        // Constructor
        public ProjectCost()
        {
            this.propertyAddress = propertyAddress;
            this.askingPrice = askingPrice;
            this.repairEstimate = repairEstimate;
            this.afterRepairValue = afterRepairValue;
            this.projectCostPercentage = projectCostPercentage;
        }

        // Methods
        public void ProjectCostPercentage()
        {
            Console.WriteLine("START A NEW DEAL ANALYSIS\n");
 
            Console.Write("Enter Property Address:    ");
            string? propertyAddress = Console.ReadLine();    

            float inputAskingPrice;
            bool testAskingPrice;
            
            do 
            {   Console.Write("Enter Asking Sales Price: $");
                string? askingPrice = Console.ReadLine();    
                testAskingPrice = float.TryParse(askingPrice, out inputAskingPrice); 
            } while (!testAskingPrice); 
                      
            Console.WriteLine(" ");
            float inputRepairEstimate;
            bool testRepairEstimate;
            
            do 
            {   Console.Write("Enter Repair Estimate:    $");
                string? repairEstimate = Console.ReadLine();    
                testRepairEstimate = float.TryParse(repairEstimate, out inputRepairEstimate); 
            } while (!testRepairEstimate); 
  
            float inputArv;
            bool testArv;
            do 
            {
                Console.Write("Enter Comparable ARV:     $");
                string? afterRepairValue = Console.ReadLine();   
                testArv = float.TryParse(afterRepairValue, out inputArv);
            } while (!testArv); 

            Console.WriteLine(" ");
            
            inputProjectCostPercentage = (inputAskingPrice + inputRepairEstimate) / inputArv;
            
            string strPCP = Convert.ToString(inputProjectCostPercentage*100);


            if (inputProjectCostPercentage <= .70)
            {
                Console.WriteLine("Your Project Cost Percentage is: " + strPCP + "%\n");
                Console.WriteLine("BUY!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                ExitStrategy oSubMenu = new ExitStrategy(inputAskingPrice, inputRepairEstimate, inputArv);
                oSubMenu.ExitStrategyMethod();
            }
            else if (inputProjectCostPercentage > .70)
            {
                Console.WriteLine("Your Project Cost Percentage is: " + strPCP + "%\n");
                Console.WriteLine("NOT TO BUY!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Reanalyzer oLastMenu = new Reanalyzer(inputAskingPrice, inputRepairEstimate, inputArv);
                oLastMenu.ReanalyzerMethod();
            } 
        }
    }
}