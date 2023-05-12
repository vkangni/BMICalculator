using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BMI Calculator");
            Console.WriteLine("==========================\n");

            while (true)
            {
                Console.Write("Enter your first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter your city: ");
                string city = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 15)
                {
                    Console.WriteLine("\nSorry, BMI cannot be calculated for users below 15 years of age.");
                    continue;
                }

                Console.Write("Enter your email address: ");
                string email = Console.ReadLine();

                Console.Write("\nEnter your weight in kilograms: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Enter your height in meters: ");
                double height = double.Parse(Console.ReadLine());

                double bmi = CalculateBMI(weight, height);

                Console.WriteLine("\nYour BMI is: " + bmi.ToString("F2"));

                if (bmi < 18.5)
                {
                    Console.WriteLine("You are underweight.");
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    Console.WriteLine("You are normal weight.");
                }
                else if (bmi >= 25 && bmi <= 29.9)
                {
                    Console.WriteLine("You are overweight.");
                }
                else
                {
                    Console.WriteLine("You are obese.");
                }

                Console.WriteLine("Do you want to calculate another BMI? (Y/N)");

                if (Console.ReadLine().ToUpper() != "Y")
                {
                    break;
                }
            }
        }

        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
