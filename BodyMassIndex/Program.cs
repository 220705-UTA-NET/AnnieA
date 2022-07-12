using System;

namespace BodyMassIndex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("BMI Calculator\n");

            double weight;
            Console.Write ("Enter your weight in kilograms: ");
            weight = Convert.ToInt16(Console.ReadLine());

            double height;
            Console.Write ("Enter your height in centimeters: ");
            height = Convert.ToInt16(Console.ReadLine());

            double meter;
            meter = height / 100;

            Double BodyMassIndex;
            BodyMassIndex = weight / (meter*meter);
            Console.Write ("Your BMI is: ", BodyMassIndex);
            Console.WriteLine(BodyMassIndex.ToString("00.00"));


        }
    }
}
