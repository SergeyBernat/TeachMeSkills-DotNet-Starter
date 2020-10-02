using System;

namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            for (int i = firstNumber + 1; i < secondNumber; i++)
            {
                summ += i;
            }
            Console.WriteLine(summ);

            Console.WriteLine("==============================");

            Console.WriteLine("Enter first number:");
            int _firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secong number:");
            int _secondNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = _firstNumber; i < _secondNumber; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
