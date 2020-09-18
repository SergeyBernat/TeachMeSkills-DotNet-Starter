using System;

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = double.Parse(Console.ReadLine());
            var S = pi * r * r;
            Console.WriteLine(S);


        }
    }
}
