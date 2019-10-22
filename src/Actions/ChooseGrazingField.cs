using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;


namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].Capacity > farm.GrazingFields[i].Count)
                {
                    Console.WriteLine($"{i + 1}. grazing field ({farm.GrazingFields[i].Count} existing animals)");
                    foreach (IGrazing type in farm.GrazingFields)
                    {
                        // Console.WriteLine($"{farm.GrazingFields[i].}");
                    } 
                } else
                    {
                        Console.WriteLine($"{i + 1}. grazing field is at capacity with ({farm.GrazingFields[i].Count}) animals");
                    }
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                if (farm.GrazingFields.Count >= 1)
                {
                    Console.WriteLine($"Place the animal where?");
                    Console.Write("> ");
                    try
                    {
                        int choice = Int32.Parse(Console.ReadLine()); //take what the user enters
                        int index = choice - 1; //-1 to stay within the range
                        int count = farm.GrazingFields[index].Count; //get how many animals are in that field
                        double capacity = farm.GrazingFields[index].Capacity;
                        if (count < capacity)
                        {
                            farm.GrazingFields[index].AddResource(animal);
                        }
                        else
                        {
                            Console.WriteLine("There is not enough room in this field, hit enter to select a different field.");
                            Console.ReadLine();
                            CollectInput(farm, animal);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Hit enter to select the correct facility dummy");
                        Console.ReadLine();
                        CollectInput(farm, animal);
                    }
                }
                else
                {
                    Console.WriteLine("You must create a grazing field before purchasing a chicken. Press enter to return to the main menu");
                    Console.ReadLine();
                    // CollectInput (farm, animal);
                }


                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);

            }
        }
    }