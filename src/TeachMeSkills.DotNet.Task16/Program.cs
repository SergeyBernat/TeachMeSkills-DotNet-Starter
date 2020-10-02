using System;

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter leght:");
            int length = Convert.ToInt32(Console.ReadLine());
            if (width != length)
            {
                for (int i = 1; i < width + 1; i++)
                {
                    for (int a = 1; a < length; ++a)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.Write("\n");
                }
    }
}
