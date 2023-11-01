using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes.Fabrics
{
    static class CarFabric
    {
        public static Car Create(string name, int speed, int cost)
        {
            return new Car(name, speed, cost);
        }
    }
}
