using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            
            Console.WriteLine("Please enter your message and press enter");  //step3
            userInputString = Console.ReadLine();       //step4 user will enter their msg
                                                        //step5 assign the entered string
            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum = int.Parse(Console.ReadLine()); //step7 and 8 assign the entered string

            Console.WriteLine("For which character should I search in your original message?");
            char1 = char.Parse(Console.ReadLine());     //step13 assign the entered string


            Console.WriteLine(SearchChar(userInputString, char1));       //step14 call SearchChar method

            Console.WriteLine("Please enter your first name and press enter");  //step3
            fName = Console.ReadLine();                 //step15 user will enter their first name

            Console.WriteLine("Please enter your last name and press enter");  //step3
            lName = Console.ReadLine();                 //step16 user will enter their first name

            userFullName = ConcatNames(fName,lName);    //step 17
            Console.WriteLine(userFullName);

            //implement the required code here and within the methods below.
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            x = x.ToUpper();
            Console.WriteLine(x);
            return x;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            x = x.ToLower();
            Console.WriteLine(x);
            return x;
            //throw new NotImplementedException("StringToUpper method not implemented.");
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.

        // public static string StringTrim(string x){
           // x = x.String.Trim();
           // Console.WriteLine(x);
            //return x;
            //throw new NotImplementedException("StringTrim method not implemented.");

        //}
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        //public static string StringSubstring(string x, int elementNum){
            //string foundSubstring = x.String.Subtring(x);
            //Console.WriteLine(foundSubstring);
            //throw new NotImplementedException("StringSubstring method not implemented.");

        //}

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            int pos = userInputString.IndexOf(x);
            return pos;
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fN, string lN){
            string fullName = String.Concat(fN, lN);
            //Console.WriteLine(fullName);
            return fullName;
            //throw new NotImplementedException("ConcatNames method not implemented.");
        }
    }//end of program
}
