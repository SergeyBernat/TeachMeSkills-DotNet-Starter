using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        public static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("enter R: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("enter h: ");
            double h = double.Parse(Console.ReadLine());
            ValueV(R,h,pi);
            Console.WriteLine("===================");
            ValueS(R,h,pi);
        }

        private static void ValueS(double R, double h, double pi)
        {
            Console.WriteLine("calculation of cylinder surface area: ");
            double x = 2 * pi * R * 2 * h + 2 * pi * R * 2;
            Console.WriteLine(x);
        }

        public static void ValueV(double R, double h, double pi)
        {
            Console.WriteLine("calculation of cylinder volume: ");
            double z = h * R * R * h;
            Console.WriteLine(z);
        }
    }
}
