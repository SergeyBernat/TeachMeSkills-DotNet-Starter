using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value:");
            int userInput = int.Parse(Console.ReadLine());
            int[] massive = new int[101];
            for (int i = 0; i<101; i++)
            {
                massive[i] = i;
            }
            if (userInput >= 0 && userInput < 15)
            {
                Console.WriteLine("0..14");
            }
            else if (userInput >= 15 && userInput <= 35)
            {
                Console.WriteLine("15..35");
            }
            else if (userInput >= 36 && userInput <= 50)
            {
                Console.WriteLine("36..50");
            }
            else if (userInput >= 50 && userInput <= 100)
            {
                Console.WriteLine("50..100");
            }
            else
            {
                Console.WriteLine("Enter data is incorrect..");
            }
        }
    }
}
