using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership_23
{
    public class Car
    {
        //Fields are private class members
        //Think of fields as a local variable that exist throughout your class
        //These fields will have access to the methods and constructors in your class
        //Fields are where the actual data is being stored

        private double price;
        private int year;
        private string model;
        private string make;
        private string color;
        private double discount;

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0) price = value; // General variable built into VS
            }
        }

        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public string Color { get; set; }

        public double Discount { get; set; }

        //declare fields as private
        //provide public properties with get set methods to access and update that private field
        //Create Constructor
        //Think of a property as a combination of a variable and a method that has Get and Set methods
        //The get method returns the value of the variable
        //the set method assigns the value


        public Car(double price, int year, string model, string make, string color)
        {
            Price = price;
            Year = year;
            Model= model;
            Make = make;
            Color = color;
        }

        public Car(double price)
        {
            Price = price;
        }

        //Discount 30 percent off in winter, 20 in the fall, 10 in the summer, 5 in the spring

        public void SetPrice(double price, string season)
        {
            switch (season)
            {
                case "fall":
                    discount = .20;
                    break;
                case "winter":
                    discount = .30;
                    break;
                case "summer":
                    discount = .10;
                    break;
                case "spring":
                    discount = .05;
                    break;
                default:
                    Console.WriteLine("Enter a valid season");
                    break;
            }

            Price = price - (price * discount);
        }
    }
}
