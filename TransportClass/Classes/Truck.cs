using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes
{
    class Truck: Transport
    {
        private int _id = 4;
        public override int Capacity { get => 5000; }
        public override string Category { get => "C"; }

        public Truck(string name, int speed, int cost)
        {
            Name = "грузовик " + name;
            this.speed = speed;
            Cost = cost;
        }

        public override int ID() 
        {
            return _id;
        }
    }
}
