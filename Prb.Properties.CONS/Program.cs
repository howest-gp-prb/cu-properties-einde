using System;
using Prb.Properties.CORE;

namespace Prb.Properties.CONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar;
            firstCar = new Car();

            firstCar.Color = "zwart";
            firstCar.Brand = "Hyundai";
            firstCar.Price = 15000M;
            // firstCar.topSpeed = -190;
            // firstCar.SetTopSpeed(-190);
            firstCar.TopSpeed = -190;

            Car secondCar;
            secondCar = new Car();

            secondCar.Color = "wit";
            secondCar.Brand = "Ford";
            secondCar.Price = 9000M;

            Car thirdCar = new Car("Audi", "blauw", 25000M);

            decimal priceDifference = Car.PriceDifference(firstCar, thirdCar);

            Console.WriteLine($"De nieuwe auto is een {firstCar.Brand}, is {firstCar.Color} van kleur en kost {firstCar.Price}");
            Console.WriteLine("============");
            Console.WriteLine($"Deze nieuwe auto heeft een topsnelheid van {firstCar.TopSpeed}");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {secondCar.Brand}, is {secondCar.Color} van kleur en kost {secondCar.Price}");
            Console.WriteLine("============");
            Console.WriteLine($"De derde auto is een {thirdCar.Brand}, is {thirdCar.Color} van kleur en kost {thirdCar.Price}");
            Console.WriteLine("============");
            Console.WriteLine($"We hebben nu {Car.CarCount} auto's");

            Console.WriteLine("============");
            Console.WriteLine($"Prijsverschil tussen {firstCar.Price} en {thirdCar.Price} is {priceDifference}");

            Console.ReadLine();
        }
    }
}
