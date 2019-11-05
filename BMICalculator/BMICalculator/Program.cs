using System;
using System.ComponentModel.Design;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter your weight in (kg): ");
            var kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in (m) : ");
            var height = Convert.ToDouble(Console.ReadLine());
            
            var results = kg / height * height;

            if (results >= 25.0)
            {
                Console.WriteLine("OverWeight");
            }
            else if (results >= 18.5 && results <=24.9)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("UnderWeight");
            }

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
