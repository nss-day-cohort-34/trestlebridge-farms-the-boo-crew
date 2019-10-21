using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("You created a grazing field!");
                    Console.WriteLine("Press enter to return to the main menu.");
                    Console.ReadKey();
                    break;
                case 2:
                    // farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("You created a plowed field!");
                    Console.WriteLine("Press enter to return to the main menu.");
                    Console.ReadKey();
                    break;
                case 3:
                    // farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("You created a natural field!");
                    Console.WriteLine("Press enter to return to the main menu.");
                    Console.ReadKey();
                    break;
                case 4:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("You created a chicken house!");
                    Console.WriteLine("Press enter to return to the main menu.");
                    Console.ReadKey();
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("You created a duck house!");
                    Console.WriteLine("Press enter to return to the main menu.");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}