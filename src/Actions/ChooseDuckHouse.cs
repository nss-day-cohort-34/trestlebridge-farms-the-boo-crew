using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;


namespace Trestlebridge.Actions {
    public class ChooseDuckHouse {
        public static void CollectInput (Farm farm, IFeed animal) {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++) //need to be duckhouse list
            {
                Console.WriteLine ($"{i + 1}. Duck House");
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            try
            {
            int choice = Int32.Parse(Console.ReadLine ()); //take what the user enters
            int index = choice - 1; //-1 to stay within the range
            int count = farm.DuckHouses[index].Count; //get how many animals are in that field
            double capacity = farm.DuckHouses[index].Capacity; 
            if ( count < capacity ) {
            farm.DuckHouses[index].AddResource(animal);
            } else {
                Console.WriteLine("There is not enough room in the duck house, hit enter to select a different house.");
                Console.ReadLine();
                CollectInput(farm, animal);
            }
            }
            catch (ArgumentOutOfRangeException )
            {
                Console.WriteLine("Hit enter to select the correct facility dummy");
                Console.ReadLine();
                CollectInput(farm, animal);
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}