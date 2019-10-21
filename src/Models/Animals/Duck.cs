using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck: IResource, IFeed, IMeatProducing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = .2;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public string Type { get; } = "Duck";
        public double FeedPerDay { get; set; } = .8;

        // Methods
        public void Graze () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quaaaaaaaaaaaaack!";
        }
    }
}