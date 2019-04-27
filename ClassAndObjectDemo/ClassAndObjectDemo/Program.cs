using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjectDemo
{
    class Car
    {
        int Door;
        int Light;
        int Wheel;
        int Motor;
        int Fuel;
        string Brand;
        string Model;

        // Constructor
        public Car()
        {
            Door = 4;
            Light = 4;
            Wheel = 4;
            Motor = 100;
            Fuel = 0;
            Brand = "N/A";
            Model = "N/A";
        }

        public Car (int door, int light, int wheel, 
            int motor, string brand, string model)
        {
            Door = door;
            Light = light;
            Wheel = wheel;
            Motor = motor;
            Fuel = 0;
            Brand = brand;
            Model = model;
        }

        public void Display()
        {
            Console.WriteLine("Door: {0}", Door);
            Console.WriteLine("Light: {0}", Light);
            Console.WriteLine("Wheel: {0}", Wheel);
            Console.WriteLine("Fuel: {0}", Fuel);
            Console.WriteLine("Motor: {0}", Motor);
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Model: {0}", Model);
        }

        public void setBrand(string input)
        {
            Brand = input;
        }

        public void setModel(string input)
        {
            Model = input;
        }

        public void SetFuel(int fuel)
        {
            Fuel = fuel;
        }

        public int GetFuel()
        {
            return Fuel;
        }

        public void Run()
        {
            Fuel = Fuel - 100;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Display();
            Console.WriteLine("=============");
            myCar.setBrand("Toyota");
            myCar.Display();

            Console.WriteLine("=============");
            Car yourCar = new Car(10, 8, 1, 50, "Vinfast", "Model 1");
            yourCar.SetFuel(1000);
            Console.WriteLine("Current fuel of yourCar: {0}", yourCar.GetFuel());
            yourCar.Run();
            Console.WriteLine("Current fuel of yourCar after Run: {0}", yourCar.GetFuel());
            //yourCar.Display();
            Console.ReadLine();

        }
    }
}
