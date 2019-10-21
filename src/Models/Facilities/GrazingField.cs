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

        public void AddResource (IGrazing animal)
        {
            if (_animals.Count <= Capacity) {
            this._animals.Add(animal);
            
            } else {
                Console.WriteLine("There is not enough room in this field, please select another facility!");
                // ChooseGrazingField.CollectInput(Farm, animal);
                //  foreach (var field in GrazingFields)
                //     {
                //         Console.WriteLine(animal);
                //     }
            }
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