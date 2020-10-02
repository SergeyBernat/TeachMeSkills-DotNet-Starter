using System;

namespace TeachMeSkills.DotNet.Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(massive);
            foreach (int i in massive)
            {
                Console.WriteLine(i);
            }

        }
    }
}
