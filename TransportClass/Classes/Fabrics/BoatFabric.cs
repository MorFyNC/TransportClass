using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes.Fabrics
{
    static class BoatFabric
    {
        public static Boat Create(string name, int speed, int cost)
        {
            return new Boat(name, speed, cost);
        }
    }
}
