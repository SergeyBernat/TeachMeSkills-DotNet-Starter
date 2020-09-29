using System;

namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("your salary 1000");
            Console.WriteLine("Enter how many years you have been working: ");
            int money = 1000;
            int userInput = int.Parse(Console.ReadLine());
            if (userInput < 5)
            {
                Console.WriteLine("Your bonus is 10 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 10);
            }
            else if (userInput >= 5 && userInput <10)
            {
                Console.WriteLine("Your bonus is 15 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 15);
            }
            else if (userInput >=10 && userInput <15 )
            {
                Console.WriteLine("Your bonus is 25 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 25);
            }
            else if (userInput >= 15 && userInput < 20)
            {
                Console.WriteLine("Your bonus is 35 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 35);
            }
            else if (userInput >= 20 && userInput < 25)
            {
                Console.WriteLine("Your bonus is 45 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 45);
            }
            else if (userInput >= 25 )
            {
                Console.WriteLine("Your bonus is 50 % of salary");
                Console.WriteLine("Your bonus size: " + money / 100 * 50);
            }
        }
    }
}
