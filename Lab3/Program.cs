using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblHeight, dblWeight, dblBMI;
            dblHeight = Utils.GetNumber("Enter Height in inches: ");
            dblWeight = Utils.GetNumber("Enter Weight in pounds: ");
            double temp = Math.Pow(dblHeight, 2);
            dblBMI = dblWeight * 703 / temp;
            Console.WriteLine("Your BMI is: " + dblBMI);
            if (dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
            else if (dblBMI <= 24.9)
            {
                Console.WriteLine("BMI  between 18.5 and 24.9 – Normal");
            }
            else if (dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 – Overweight");
            }
            else
            {
                Console.WriteLine("BMI > = 30  - Obese");
            }
        }
    }
}
