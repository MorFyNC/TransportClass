using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes.Fabrics
{
    static class BikeFabric
    {
        public static Bike Create(string name, int speed, int cost)
        {
            return new Bike(name, speed, cost);
        }
    }
}
