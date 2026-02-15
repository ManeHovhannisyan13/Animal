using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    //animal class
    abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public abstract void Eat();
        public string GetName()
        {
            return Name; 
            
        }
    }

    //dog class
    class Dog : Animal 
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name for the dog: ");
            string dogName = Console.ReadLine();

            if (dogName == "")
            {
                Console.WriteLine("You did not enter a name․ Using the default name: Dog");
                dogName = "Dog";
            }

            Dog dog = new Dog();
            dog.SetName(dogName);

            Console.WriteLine($"Dog's name: {dog.GetName()}");
            dog.Eat();
        }
    }
}
