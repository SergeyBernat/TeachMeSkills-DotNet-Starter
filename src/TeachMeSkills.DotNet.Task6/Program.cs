using System;
using System.Diagnostics.CodeAnalysis;

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var operand1 = 10;
            var operand2 = 2;
            Console.WriteLine("Enter operator");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    var sum = operand1 + operand2;
                    Console.WriteLine(sum);
                    break;
                case "-":
                    var sub = operand1 - operand2;
                    Console.WriteLine(sub);
                    break;
                case ("/"):
                    if (operand2 != 0)
                    {
                        var div = operand1 / operand2;
                        Console.WriteLine(div);
                    }
                    else
                    {
                        Console.WriteLine("Error: cannot be divisible by 0");
                    }
                    break;
                case "*":
                    var mul = operand1 * operand2;
                    Console.WriteLine(mul);
                    break;
                case "%":
                    var rem = operand1 % operand2;
                    Console.WriteLine(rem);
                    break;
            }
        }
    }
}
