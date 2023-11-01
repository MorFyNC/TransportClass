using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes
{
    class Car: Transport
    {
        private int _id = 3;
        public override int Capacity { get => 1500; }
        public override string Category { get => "B"; }

        public Car(string name, int speed, int cost)
        {
            Name = "машина " + name;
            this.speed = speed;
            Cost = cost;
        }
        public override int ID()
        {
            return _id;
        }
    }
}
