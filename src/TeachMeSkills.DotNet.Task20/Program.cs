using System;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            var num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            var num3 = double.Parse(Console.ReadLine());
            double result = Calculate(num1, num2, num3);
            Console.WriteLine(result);
        }

        private static double Calculate(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
    }
}