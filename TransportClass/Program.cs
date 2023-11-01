using TransportClass.Classes;
using TransportClass.Classes.Fabrics;

int choice = 0;
bool trigger = true;

Car car1 = CarFabric.Create("Рено Логан", 120, 500000);
Car car2 = CarFabric.Create("Гелик", 150, 5000000);

Boat boat1 = BoatFabric.Create("Страйкер", 50, 75000);
Boat boat2 = BoatFabric.Create("Путник", 65, 100000);

Bike bike1 = BikeFabric.Create("STELS", 30, 15000);
Bike bike2 = BikeFabric.Create("Победа", 20, 10000);

Truck truck1 = TruckFabric.Create("MAN", 110, 7500000);
Truck truck2 = TruckFabric.Create("CAT", 130, 8000000);

List<Transport> TransportList = new List<Transport> { car1, boat2, car2, boat1, truck1, bike1, truck2, bike2 };

do
{
    Console.WriteLine("Выберите действие: \n1. Вывести список автомобилей; " +
        "\n2. Сортировать список автомобилей; " +
        "\n3. Добавить груз в машину; " +
        "\n4. Посмотреть подробности о транспорте;" +
        "\n5. Выход из программы.");
    
    string action = Console.ReadLine();
    Console.Clear();
    switch(action)
    {
        case "1":
            ActionSeparator(18, "Список транспорта");

            Print();
            Separator();
            break;

        case "2": 
            Sort();

            ActionSeparator(23, "Список был отсортирован");

            break;

        case "3": 
            Sort();

            ActionSeparator(13, "Добавить груз");

            Print();
            Separator();

            Console.WriteLine("Выберите транспорт");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            ActionSeparator(13, "Добавить груз");

            TransportList[choice - 1].GetCargo();
            Console.WriteLine("Введите размер добавляемого груза");
            int cargo = Convert.ToInt32(Console.ReadLine());

            Separator();
            TransportList[choice - 1].AddCargo(cargo);
            Separator();
            break;

        case "4":
            ActionSeparator(34, "Просмотр подробностей о транспорте");

            Print();
            Separator();
            Console.WriteLine("Выберите транспорт");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            ActionSeparator(11, "Подробности");

            TransportList[choice - 1].PrintDetails();
            Separator();
            break;

        case "5": 
            trigger = false;

            ActionSeparator(12,"До свидания!");
            break;
    }

} while (trigger);

void Print()
{
    int i = 1;
    foreach(Transport transport in TransportList)
    {

        Console.WriteLine($"{i}. {transport}");
        i++;
    }
}

void Sort()
{
    List<Transport> temp = new List<Transport>();
    int MaxId = 0;
    
    foreach(Transport transport in TransportList)
    {
        if(transport.ID() > MaxId)
        {
            MaxId = transport.ID();
        }
    }

    for(int i = 0; i <= MaxId; i++)
    {
        foreach(Transport transport in TransportList)
        {
            if (transport.ID() == i)
            {
                temp.Add(transport);
            }
        }
    }
    TransportList = temp;
}
void Separator()
{
    Console.WriteLine("\n\t*** *** ***\n");
}
void ActionSeparator(int num, string action)
{
    string sep = "";
    for(int i = 0; i < num; i++)
    {
        sep += "_";
    }
    Console.WriteLine($"\t{sep}\n" + $"\n\t{action}\n" + $"\t{sep}\n");
}