using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes.Fabrics
{
    static class TruckFabric
    {
        public static Truck Create(string name, int speed, int cost)
        {
            return new Truck(name, speed, cost);
        }
    }
}
