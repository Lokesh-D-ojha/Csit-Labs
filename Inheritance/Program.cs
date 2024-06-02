using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark(); 
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animals Eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
