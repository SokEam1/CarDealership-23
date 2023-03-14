using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

Dog dog = new Dog("Skippy");

dog.GetName();
dog.Display();
dog.Eat();

namespace CarDealership_23
{


    public class Animal
    {
        //IS a relationship
        //Apple is a fruit
        //Dog is an animal
        //fields and methods
        //Encapsulation is data and the programs that manipulate that data are bound together and their complexity is hidden
        private string name;
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("I am an animal");
        }

        public void Eat()
        {
            Console.WriteLine("I eat!");
        }


    }

    class Dog : Animal //derived from our Animal class. Called a child class or subclass. Inherits all methods and fields from animal class
    {
        public Dog(string name): base(name) //cannot inherit constructors, need to extend using keyword base
        {

        }

        public ovveride void Eat()
        {
            Console.WriteLine("I eat dog food")
        }

        public void GetName()
        {
            Console.WriteLine("I am a " + Name);
        }
    }

   /* Dog dog = new Dog("Skippy");
    dog.GetName();
dog.Display();
dog.Eat();
class Animal
    {

        private string name;
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("I am an animal");
        }
        public virtual void Eat() //Need the keyword virtual to override base class methods
        {
            Console.WriteLine("I eat!");
        }

    }

   class Dog : Animal //derived from our Animal class. Called a Child Class or SubClass. Inherits
                       //all methods and fields from animal class
    {
        public Dog(string name) : base(name) //cannot inherit constructors, need to extend using keyword base
        {

        }
        public override void Eat()
        {
            Console.WriteLine("I eat dog food");
        }
        public void GetName()
        {
            Console.WriteLine("I am a " + Name);
        }
    }*/

    

