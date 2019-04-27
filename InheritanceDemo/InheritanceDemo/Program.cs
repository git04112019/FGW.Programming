using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Bike
    {
        int Wheel;
        int Chair;
        string Brand;
        string Model;

        public Bike(int wheel, int chair, string brand, string model)
        {
            Wheel = wheel;
            Chair = chair;
            Brand = brand;
            Model = model;
        }

        public virtual void Run()
        {
            Console.WriteLine("Bike runs 15 km/h");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!!!");
        }

        public virtual void Display()
        {
            Console.WriteLine("My Transportation -----");
            Console.WriteLine("Wheel: {0}", Wheel);
            Console.WriteLine("Chair: {0}", Chair);
            Console.WriteLine("Brand: {0}", Brand);
            Console.WriteLine("Model: {0}", Model);
        }
    }

    class MotorBike : Bike
    {
        int Fuel;
        int Motor;

        public MotorBike(int wheel, int chair, string brand, string model, int fuel, int motor) 
            : base(wheel, chair, brand, model)
        {
            Fuel = fuel;
            Motor = motor;
        }

        public override void Run()
        {
            Console.WriteLine("Motorbike runs 50 km/h");
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Fuel: {0}", Fuel);
            Console.WriteLine("Motor: {0}", Motor);
        }

        public void setFuel(int fuel)
        {
            if (fuel > 0) Fuel = Fuel + fuel;
            else Fuel = Fuel;
        }
    }

    class Car
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike(2, 3, "Vinfast", "T Model");
            myBike.Display();
            myBike.Run();
            myBike.Stop();

            MotorBike myMotorBike = new MotorBike(3, 4, "Suzuki", "GSX", 3, 125);
            myMotorBike.Display();
            myMotorBike.Run();
            myMotorBike.Stop();

            myMotorBike.setFuel(1000);

            Console.Read();
        }
    }
}
