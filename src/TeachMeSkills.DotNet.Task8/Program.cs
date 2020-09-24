using System;

namespace TeachMeSkills.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select and enter your word_ru only: ");
            Console.WriteLine("Солнечно, \nПасмурно, \nДождь, \nТуман, \nГроза, \nОблако, \nСнег, \nБуря, \nОсадки, \nЛужа");
            string userInput = Console.ReadLine().ToLowerInvariant();
            if (userInput != "солнечно" 
                & userInput != "пасмурно" 
                & userInput != "дождь" 
                & userInput != "туман" 
                & userInput != "гроза"
                &userInput != "облако"
                & userInput != "снег"
                & userInput != "буря"
                & userInput != "осадки"
                & userInput != "лужа")
            {
                Console.WriteLine("The entered data is incorrect..");
                Console.ReadKey();
            }
            switch (userInput)
            {
                case ("солнечно"):
                    Console.Write(" - Sunny");
                    break;
                case ("пасмурно"):
                    Console.Write(" - Light");
                    break;
                case ("дождь"):
                    Console.Write(" - Rain");
                    break;
                case ("туман"):
                    Console.Write(" - Fog");
                    break;
                case ("гроза"):
                    Console.Write(" - Tunderstorm");
                    break;
                case ("облако"):
                    Console.Write(" - Gloud");
                    break;
                case ("снег"):
                    Console.Write(" - Snow");
                    break;
                case ("буря"):
                    Console.Write(" - Storm");
                    break;
                case ("осадки"):
                    Console.Write(" - Precipitation");
                    break;
                case ("лужа"):
                    Console.Write(" - Puddle");
                    break;
            }
        }
    }
}