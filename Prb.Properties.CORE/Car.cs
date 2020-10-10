using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Properties.CORE
{
    public class Car
    {
        //public string brand;
        //public string color;
        //public decimal price;
        //public static int carCount;

        public string Brand { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public static int CarCount { get; set; }

        private int topSpeed;
        public int TopSpeed
        {
            get { return topSpeed; }
            set
            {
                if (value < 0)
                    topSpeed = 0;
                else
                    topSpeed = value;
            }
        }

        //public void SetTopSpeed(int topSpeed)
        //{
        //    if (topSpeed < 0)
        //        this.topSpeed = 0;
        //    //throw new Exception("Topsnelheid kan niet kleiner zijn dan 0");
        //    else
        //        this.topSpeed = topSpeed;
        //}
        //public int GetTopSpeed()
        //{
        //    return topSpeed;
        //}

        public Car() // Default constructor
        {
            //brand = null;
            //color = null;
            //price = 0;
            //carCount++;
            Brand = null;
            Color = null;
            Price = 0;
            CarCount++;
        }

        public Car(string brand) : this() // Constructor ontvangt 1 parameter
        {
            //this.brand = brand;
            Brand = brand;
        }

        public Car(string brand, string color) : this() // Constructor ontvangt 2 parameters
        {
            //this.brand = brand;
            //this.color = color; 
            Brand = brand;
            Color = color;
        }

        public Car(string brand, string color, decimal price) : this() // Constructor ontvangt 3 parameters
        {
            //this.brand = brand;
            //this.color = color;
            //this.price = price;
            Brand = brand;
            Color = color;
            Price = price;
        }

        public decimal PriceDifference(Car wagen)
        {
            //return Math.Abs(this.price - wagen.price);
            return Math.Abs(this.Price - wagen.Price);
        }

        public static decimal PriceDifference(Car wagen1, Car wagen2)
        {
            //return Math.Abs(wagen1.price - wagen2.price);
            return Math.Abs(wagen1.Price - wagen2.Price);
        }

        public override string ToString()
        {
            //return $"{brand} - {color}";
            return $"{Brand} - {Color}";
        }
    }
}
