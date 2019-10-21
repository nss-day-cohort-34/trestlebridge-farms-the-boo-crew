using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Actions;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IFeed>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IFeed> _chickens = new List<IFeed>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int Count
        {
            get
            {
                return _chickens.Count;
            }
        }




        public void AddResource(IFeed chicken)
        {
            this._chickens.Add(chicken);
        }

        public void AddResource(List<IGrazing> chickens)
        {

            // TODO: implement this...
            // throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._chickens.Count} chickens\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}