using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IResource, IGrazing {

        private Guid _id = Guid.NewGuid();
        private double _compost = 7.5; //compo

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        // public double Butcher () {
        //     return _compost;
        // }

        public override string ToString () {
            return $"Goat {this._shortId}. bleet!";
        }
    }
}