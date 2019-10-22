using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20; 
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public int Count {
            get {
                return _animals.Count;
            } 
        }
        // public List AnimalType {
        //     get {
        //         foreach (IGrazing animal in _animals)
        //         {
        //          animal.
                    
        //         }
        //     } 
        // }

        public string GetAnimalType()
        {
            StringBuilder output = new StringBuilder();
           foreach (IGrazing animal in _animals)
            {
                // count += 1;
                int count = 0;
                if (animal.Type == animal.Type) {
                output.Append($"This field has {count} {animal.Type}(s) ");
                count ++;
                } else {
                output.Append($"This field has {count + 1} {animal.Type}(s) ");

                }
                // $"Grazing field {shortId} has {this._animals.Count} animals\n"
            }
            return output.ToString();

            // output.Append($"Grazing field {animalType} has {this._animals.Count} animals\n");
            // this._animals.ForEach(a => output.Append($"   {a}\n"));

        }


        
         

        
        public void AddResource (IGrazing animal)
        {
            this._animals.Add(animal);
        }

        public void AddResource (List<IGrazing> animals) 
        {
            
            // TODO: implement this...
            // throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}