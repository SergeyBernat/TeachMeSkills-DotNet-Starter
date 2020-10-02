using System;

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity RUB:");
            var Rubl = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter conversion rade of RUB to USD: ");
            decimal Conv = decimal.Parse(Console.ReadLine());
            decimal Doll = Rubl / Conv;
            Console.WriteLine($"{Rubl} RUB is {Doll} USD");
        }
    }
}
