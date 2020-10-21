using System;
using System.Text;

namespace _17102020dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("ЗАВДАННЯ:" +
                "\n1 Розробити один з класів, відповідно до варіанту (Варіант по списку)." +
                "\n2 Реалізувати не менше п'яти закритих полів (різних типів), що представляють  основні характеристики даного класу. " +
                "\n3 Створити не менше трьох методів управління класом і методи доступу до його закритих полів." +
                "\n4 Створити метод, в який передаються аргументи за посиланням." +
                "\n5 Створити не менше двох статичних полів (різних типів), що представляють спільні  характеристики об'єктів даного класу." +
                "\n6 Обов'язковою вимогою є реалізація декількох перевантажених конструкторів,  аргументи яких визначаються студентом, виходячи із специфіки реалізованого  класу, і так само реалізувати конструктор за замовчуванням." +
                "\nВаріант:" +
                "\n1. Автомобіль;");
            Console.WriteLine();
            Console.WriteLine("// Cars");

            //string Manufacturer, string Model, string Color, double Probeg, int Year_of_car, double Fuel, double RateFuel
            Console.WriteLine($"| Id  |Manufacturer|   Model  |  Color  |   Year   |    Probeg    | RateFuel | Fuel |");
            string str7 = new string('-', 85);
            Console.WriteLine(str7);
            Car Outback = new Car("Subaru", "Outback ", "black", 15, 2020, 50.00, 10.00);
            Outback.Print();
            Car Karma = new Car("Karma ", "white", 2536589.12, 2012, 55.00, 14);
            Karma.Print();
            Car Ram = new Car("gray", 3, 2021, 45.00, 13);
            Ram.Print();
            Car Ford = new Car(10, 2019, 40.00, 12);
            Ford.Print();
            Car Toyota = new Car(2015, 60.00, 14);
            Toyota.Print();
            Car Maserati = new Car(60.00, 15.00);
            Maserati.Print();
            Car Porsche911 = new Car(15.00);
            Porsche911.Print();
            Car Peugeot = new Car();
            Peugeot.Print();

            Car ToyotaRAV4 = new Car("Toyota", "RAV4", "black", 39, 2000, 50);
            ToyotaRAV4.Print();
            Car Bentley = new Car("Bentley", "Mulliner", "white", 39, 2000);
            Bentley.Print();
            Car Ferrari = new Car("Ferrari", "Roma", "white", 39);
            Ferrari.Print();
            Car MiniCountryman = new Car("Mazda", "CX-5", "yellow");
            MiniCountryman.Print();
            Car HondaCR_V = new Car("Honda", "CR - V");
            HondaCR_V.Print();
            Car KiaSportage = new Car("Kia");
            KiaSportage.Print();

            Console.WriteLine("\n// Аксесоры(set get)");
            string Name = "123";
            Console.WriteLine($"string Name =|{Name}|");
            Ram.manufacturer = Name;
            Console.WriteLine($"Ram.manufacturer =|{Ram.manufacturer}|");
            Console.WriteLine(str7);
            Console.WriteLine($"Ram.color = |{Ram.color}|");
            string col = Ram.color;
            Console.WriteLine($"string col = |{col}|");
            Console.WriteLine(str7);
            int year = 99;
            Console.WriteLine($"int year =|{year}|");
            Ram.Year_of_car = year;
            Console.WriteLine($"Ram.Year_of_car =|{Ram.Year_of_car}|");
            Console.WriteLine(str7);
            Console.WriteLine("// Method GO");
            Console.WriteLine($"| Id  |Manufacturer|   Model  |  Color  |   Year   |    Probeg    | RateFuel | Fuel |");
            Car KiaForte = new Car("Kia", "Forte", "black", 15, 2020, 35.00, 10.00);
            Outback.Print();
            Car ToyotaCorolla = new Car("Toyota", "Corolla", "yellow", 100, 2020, 60.00, 12.00);
            Outback.Print();
            Console.WriteLine(str7);
            int count = 0;
            while (KiaForte.Fuel >= KiaForte.RateFuel || ToyotaCorolla.Fuel >= ToyotaCorolla.RateFuel)
            {
                count += 100;
                Console.WriteLine(count + " километр");
                KiaForte.GO();
                ToyotaCorolla.GO();
            }
            Console.WriteLine(str7);
            Console.ReadLine();
        }
    }
}
