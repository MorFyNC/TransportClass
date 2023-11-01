using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes
{
    class Bike: Transport
    {
        private int _id = 1;
        public override int Capacity { get => 0; }

        public override void AddCargo(int cargoWeight)
        {
            Console.WriteLine("Вы не можете добавить груз на велосипед.");
        }

        public Bike(string name, int speed, int cost)
        {
            Name = "велосипед " + name;
            this.speed = speed;
            Cost = cost;
        }
        public override int ID()
        {
            return _id;
        }
    }
}
