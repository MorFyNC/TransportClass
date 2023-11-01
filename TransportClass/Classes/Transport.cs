using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportClass.Classes
{
    abstract class Transport
    {
        public int speed;
        public virtual string Category { get => "N/A"; }
        public int Cost { get; set; }
        public string Name {  get; set; }
        public abstract int Capacity { get; }
        public int workload;

        public override string ToString()
        {
            return Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{Name}, скорость: {speed}км/ч, водительские права: {Category}, загруженность: {workload}/{Capacity}кг, цена: {Cost} рублей");
        }

        public void GetCargo()
        {
            Console.WriteLine($"{Name} вмещает {Capacity}кг и загружен на {workload}кг.");
        }

        public virtual void AddCargo(int cargoWeight)
        {
            if (workload + cargoWeight <= Capacity)
            {
                workload += cargoWeight;
                Console.WriteLine($"Груз весом в {cargoWeight}кг был добавлен. " +
                    $"Текущая загруженность: {workload}кг");
            }
            else Console.WriteLine("Груз не вместится");
        }

        public abstract int ID();
    }
}
