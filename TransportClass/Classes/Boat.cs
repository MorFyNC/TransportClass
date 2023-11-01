using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes
{
    class Boat: Transport
    {
        private int _id = 2;
        public override int Capacity { get => 300; }

        public Boat(string name, int speed, int cost)
        {
            Name = "лодка " + name;
            this.speed = speed;
            Cost = cost;
        }
        public override int ID()
        {
            return _id;
        }
    }
}
