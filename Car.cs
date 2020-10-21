using System;

namespace _17102020dz
{
    class Car
    {
        private static int Count; // счетчик ++ для поля Id
        private readonly int Id;
        public string Manufacturer; // марка автомобиля
        public string Model; // модель автомобиля
        public string Color; // цвет автомобиля
        public double Probeg { get; set; } = 0.00; // автосвойство // пробег автомобиля
        public int Year_of_car { get; set; } = 0; // автосвойство // год выпуска автомобиля
        public double Fuel { get; set; } = 0.00; // автосвойство // Топлива в баке
        public double RateFuel { get; set; } = 0.00; // автосвойство // Расход топлива
        static Car() { Count = 1; } // статичний конструктор(ініціалізує статичні поля нашого класу), викликається як тільки виникає взаємодія з класом

        public Car(string Manufacturer, string Model, string Color, double Probeg, int Year_of_car, double Fuel, double RateFuel) // дефолтний конструктор
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Color = Color;
            this.Probeg = Probeg;
            this.Year_of_car = Year_of_car;
            this.Fuel = Fuel;
            this.RateFuel = RateFuel;
            Id = Count++;
        }

        public Car() : this("-//-", "-//-", "-//-", 0.00, 0, 0.00, 0.00) { } // виклик конструктора класу
        public Car(string Manufacturer) : this(Manufacturer, "-//-", "-//-", 0.00, 0, 0.00, 0.00) { }// виклик конструктора класу
        public Car(string Manufacturer, string Model) : this(Manufacturer, Model, "-//-", 0.00, 0, 0.00, 0.00) { }// виклик конструктора класу
        public Car(string Manufacturer, string Model, string Color) : this(Manufacturer, Model, Color, 0.00, 0, 0.00, 0.00) { }// виклик конструктора класу
        public Car(string Manufacturer, string Model, string Color, double Probeg) : this(Manufacturer, Model, Color, Probeg, 0, 0.00, 0.00) { }// виклик конструктора класу
        public Car(string Manufacturer, string Model, string Color, double Probeg, int Year_of_car) : this(Manufacturer, Model, Color, Probeg, Year_of_car, 0.00, 0.00) { }// виклик конструктора класу
        public Car(string Manufacturer, string Model, string Color, double Probeg, int Year_of_car, double Fuel) : this(Manufacturer, Model, Color, Probeg, Year_of_car, Fuel, 0.00) { }// виклик конструктора класу

        public Car(double RateFuel) : this("-//-", "-//-", "-//-", 0.00, 0, 0.00, RateFuel) { } // виклик конструктора класу
        public Car(double RateFuel, double Fuel) : this("-//-", "-//-", "-//-", 0.00, 0, Fuel, RateFuel) { } // виклик конструктора класу
        public Car(int Year_of_car, double RateFuel, double Fuel) : this("-//-", "-//-", "-//-", 0.00, Year_of_car, Fuel, RateFuel) { } // виклик конструктора класу
        public Car(double Probeg, int Year_of_car, double RateFuel, double Fuel) : this("-//-", "-//-", "-//-", Probeg, Year_of_car, Fuel, RateFuel) { } // виклик конструктора класу
        public Car(string Color, double Probeg, int Year_of_car, double RateFuel, double Fuel) : this("-//-", "-//-", Color, Probeg, Year_of_car, Fuel, RateFuel) { } // виклик конструктора класу
        public Car(string Model, string Color, double Probeg, int Year_of_car, double RateFuel, double Fuel) : this("-//-", Model, Color, Probeg, Year_of_car, Fuel, RateFuel) { } // виклик конструктора класу

        public string manufacturer
        {
            get
            {
                return Manufacturer;
            }
            set
            {
                Manufacturer = value;
            }
        } // Аксесоры(set get)
        public string model
        {
            get
            {
                return Model;
            }
            set
            {
                Model = value;
            }
        }
        public string color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }

        public void Print() { Console.WriteLine(this); }

        public override string ToString() // перегрузкаd
        {
            return $"| {Id,3:d3} | {Manufacturer,10} | {Model,8} | {Color,8}| {Year_of_car,8} | {Probeg,12:n2} | {RateFuel,8} | {Fuel,4} |";
        }
        //Метод GO имитирует движение автомобиля, если топлива не достаточно, он не поедет, в противном случае метод сработает и из запаса топлива будет вычтено значение расход топлива.
        public void GO()//движение автомобиля
        {
            if (Fuel < RateFuel)//если топлива в баке меньше, чем расход автомобиля
            {
                Console.WriteLine("В автомобиле " + "'" + Manufacturer + ' ' + Model + "' закончился запас топлива.");
            }
            else //Если топлива достаточно
            {
                Fuel = Fuel - RateFuel;
                Console.WriteLine("В автомобиле " + "'" + Manufacturer + ' ' + Model + "' осталось " + Fuel + " ед.топлива.");
            }
        }
    }
}
