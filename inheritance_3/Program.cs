using System;

namespace inheritance_3
{
    class Vehicle
    {
        public Tuple<int, int> Coordinates { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Release { get; set; }

        public virtual void Show()
        {
            Console.Write("Координаты - х: " + Coordinates.Item1 + ", у: " + Coordinates.Item2 + ". Цена - " 
                + Price + ". Скорость - " + Speed + ". Год выпуска - " + Release);
        }

        public Vehicle()
        {
            Coordinates = new Tuple<int, int>(0, 0);
            Price = new double();
            Speed = new double();
            Release = new int();
        }

        public Vehicle(int x, int y, double price, double speed, int release)
        {
            Coordinates = new Tuple<int, int>(x, y);
            Price = price;
            Speed = speed;
            Release = release;
        }
    }
    class Plane : Vehicle
    {
        public double Attitude { get; set; }
        public int NumOfPassengers { get; set; }

        public Plane() : base()
        {
            Attitude = 0;
            NumOfPassengers = 0;
        }
        public Plane(int x, int y, double price, double speed, int release, double attitude, int num) : base(x, y, price, speed, release)
        {
            Attitude = attitude;
            NumOfPassengers = num;
        }

        public override void Show()
        {
            base.Show();
            Console.Write(". Высота - " + Attitude + ". Количество пассажиров - " + NumOfPassengers);
        }
    }
    class Car : Vehicle
    {
        public Car() : base() { }
        public Car(int x, int y, double price, double speed, int release) : base(x, y, price, speed, release) { }
    }
    class Ship : Vehicle
    {
        public int NumOfPassengers { get; set; }
        public int HomePort { get; set; }
        public Ship() : base()
        {
            NumOfPassengers = 0;
            HomePort = 0;
        }
        public Ship(int x, int y, double price, double speed, int release, int port, int num) : base(x, y, price, speed, release)
        {
            HomePort = port;
            NumOfPassengers = num;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(". Количество пассажиров - " + NumOfPassengers + ". Порт приписки - " + HomePort);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите ввести информацию о самолёте(1), машине(2) или корабле(3)");
            int info = Convert.ToInt32(Console.ReadLine());
            if (info == 1)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:" +
                    "\nКоордината х$координата у$цена$скорость$Год выпуска$высота$количесво пассажиров.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Plane plane = new Plane(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]),
                        Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]), Convert.ToDouble(inp[5]), Convert.ToInt32(inp[6]));
                    plane.Show();
                }
                catch (Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else if (info == 2)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:" +
                    "\nКоордината х$координата у$цена$скорость$год выпуска.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Car car = new Car(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]),
                        Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]));
                    car.Show();
                }
                catch (Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else if (info == 3)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:" +
                    "\nКоордината х$координата у$цена$скорость$год выпуска$порт приписки$количесво пассажиров.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Ship ship = new Ship(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]),
                        Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]), Convert.ToInt32(inp[5]), Convert.ToInt32(inp[6]));
                    ship.Show();
                }
                catch (Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else Console.WriteLine("Вы ввели неверную информацию!");
            Console.ReadKey();
        }
    }
}
