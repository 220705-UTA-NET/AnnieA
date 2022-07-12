using System;
using System.IO;
using System.XML.Serialization;

namespace FileInteraction
{
    class Program
    {
        // fields
        
        static void Main ()
        {
            
            Console.WriteLine("Application running....");
            
            string[] text = {"Hello All","Goodbye"};  // use {} if declaring arrays

            string path = @".\TextFile.txt";  // file path. We dont have the file yet just the path!

            //public XmlSerializer Serializer { get; } = new XmlSerializer(typeOf(Person));

            //Person p = new Person("James", 6.2m, 180m);  // use serialization to write to file

            //Console.WriteLine(p.SerializeAsXML());

            bool loop = true;

            while(loop)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Read from file.");
                Console.WriteLine("2. Write to file.");
                Console.WriteLine("3. Create an XML Record");
                Console.WriteLine("4. Read from XML Record");
                Console.WriteLine("0. Exit.");

                string? choice = Console.ReadLine();  // makes it nullable

                switch (choice)
                {
                    case "1":  // if (choice == "1")  similar command

                        Console.WriteLine("Reading from File...");
                        if (!File.Exists(path))
                        {
                            Console.WriteLine("File does not exist.");
                        }
                        else
                        { 
                            string[] readText = File.ReadAllLines(path);  // read all lines from the file, store in string array
                            foreach (string s in readText)  // loop through the string array
                            {
                                Console.WriteLine(s); // print each line
                            }
                            Console.WriteLine("Task Complete.");
                        }
                        break;

                    case "2":
                        Person p = new Person("James", 12.34 , 56.78)
                        if (!File.Exists(path))
                        {
                            Console.WriteLine("File does not exist. Creating file.");
                            File.WriteAllLines(path, text); // create the file and also dump the contents. If file exsts, it'll overwrite.
                        }
                        else
                        { 
                            Console.WriteLine("Serializing write to File...");
                            File.AppendAllLines(path,text);  // append all lines to the file
                            foreach (string s in text)  // loop through the string array
                            {
                                Console.WriteLine(s); // print each line
                            }
                            Console.WriteLine("Task Complete.");
                        }
                        break;

                    case "3":

                        if (!File.Exists(path))
                        {
                            Console.WriteLine("File does not exist. Creating an XML Record.");
                            File.WriteAllText(path, P.SerializeXml()); // create the file and also dump the contents. If file exsts, it'll overwrite.
                        }
                        else
                        { 
                            Console.WriteLine("Appending to File...");
                            File.AppendAllText(path, P.SerializeXml());  // append all lines to the file
                            
                        }
                        Console.WriteLine("Task Complete.");
                        break;
                    
                    case "4":  

                        Console.WriteLine("Reading from XML File...");
                        Person Q = DeserializeXML();
                        Console.WriteLine(Q.name);
                        Console.WriteLine(Q.height);
                        Console.WriteLine(Q.weight);
                        Console.WriteLine("Task Complete.");
                        break;

                    case "0":

                        loop = false;
                        Console.WriteLine("Exiting..");
                        break;

                    default:

                        Console.WriteLine("Invalid choice. Please try again... ");
                        break;
                }
            }

        private static Person DeserializeXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            string path = @" .\TextFile.txt";
            Person P = new Person();


            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
            }
            else
            { 
                using StreamReader reader = new StreamReader(path);
                char record = (Person)serializer.Desearialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                    return null;
                }
                else
                {
                    P = record;               
                }
            }
            return P;
        }
    }
}
