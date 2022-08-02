using System.IO;
using System.Text.Json;

namespace DealAnalyzerAPI.App
{
    public class InvestorData 
    {
        // fields
        public int id {get; set;}
        public string? userName {get; set;}
        public string? newInvestorName {get; set;}
        public string? oldInvestorName {get; set;}
        public string? email {get; set;}
        public string? readUserName {get; set;}

        // constructor
        public InvestorData()
        {
            this.id = id;
            this.userName = userName;
            this.newInvestorName = newInvestorName;
            this.oldInvestorName = oldInvestorName;
            this.email = email;
        }

        // Methods

//=========== Start of Method AddInvestorToDatabase ==========//       
        public void AddInvestorToDatabase()
        {
            Console.WriteLine("CREATE A NEW ACCOUNT\n");
 
            Console.Write("Please Create Your Username: ");
            string? addUserName = Console.ReadLine();
            Console.Write("Is this correct? [y/n] : ");
            string? yn1 = Console.ReadLine();
            userName = yn1.ToLower() == ("y") ? addUserName : null;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.Write("Enter First and Last Name: ");  
            newInvestorName = Console.ReadLine();
            Console.Write("              Enter Email: ");
            email = Console.ReadLine();

            Console.WriteLine("A new account has been created for you, " + newInvestorName +".");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            // calls the object ans its method to serialize new investor data

            InvestorDataDTO oI = new InvestorDataDTO(id, userName, newInvestorName, email);
        }
//=========== End of Method AddInvestorToDatabase ==========//

        public bool CheckIfInvestorExists()
        {
            bool OldInvestorBool = true;

            // Get user input then compare it with existing record
             Console.Write("Please Enter Your Username: ");
            string? readUserName = Console.ReadLine();
            Console.Write("Is this correct? [y/n] : ");
            string? yn2 = Console.ReadLine();
            readUserName = yn2.ToLower() == ("y") ? readUserName : null;
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine("Welcome Back: " + readUserName);  
            //oldInvestorName = Console.ReadLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();

            // Deserialize XML record so it can be compared with user input
            InvestorDataDTO Q = new InvestorDataDTO();
            InvestorDataDTO.DeserializeXML();
            userName = Q.username; 

            if (readUserName == userName)
            {
                ProjectCost o2ProjectCost = new ProjectCost();
                o2ProjectCost.ProjectCostPercentage();
                OldInvestorBool = true;
                return OldInvestorBool;
            }
            else
            {
                Console.Write("Record not found. Please register and create a new account. ");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                OldInvestorBool = false;
                return OldInvestorBool;                        
            }
        }
    }
}