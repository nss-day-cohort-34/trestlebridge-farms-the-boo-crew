using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck: IResource, IGrazing, IMeatProducing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = .2;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double GrassPerDay { get; set; } = .8;   // FeedPerDay
        public string Type { get; } = "Duck";

        // Methods
        public void Graze () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of feed");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quaaaaaaaaaaaaack!";
        }
    }
}