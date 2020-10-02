using System;

namespace TeachMeSkills.DotNet.Task21
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
            var (_num1, _num2, _num3) = Calculate(num1, num2, num3);
            Console.WriteLine($"First answer: {_num1}");
            Console.WriteLine($"Second answer: {_num2}");
            Console.WriteLine($"Third answer: {_num3}");
        }

        private static (double _num1, double _num2, double _num3) Calculate(double num1, double num2, double num3)
        {
            var result = (_num1: num1 / 5, _num2: num2 / 5, _num3: num3 / 5);
            return result;
        }
    }
}
