using System;

namespace ChapterThree
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public abstract void Drive();

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand} ");
            Console.WriteLine($"Model: {Model}");
        }
    }

    public class Car : Vehicle
    {
        public Car(string brand, string model): base(brand, model){}

        public override void Drive()
        {
            Console.WriteLine("Driving a car!");
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string brand, string model): base(brand, model){}

        public override void Drive()
        {
            Console.WriteLine("Riding a bike!");
        }
    }

    public class Abstraction
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Car("asbsa", "bmw");
            Vehicle bike = new Bike("aszx", "asdas");
            car.Drive();
            car.Display();
            bike.Drive();
            bike.Display();
        }
    }
}
