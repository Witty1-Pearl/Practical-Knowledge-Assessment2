using System;

namespace AnimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dog Name: ");
            string name = Console.ReadLine();
            Dog dog = new Dog();
            dog.SetName(name);
            Console.WriteLine ($"The dog name is {dog.GetName()}");
            dog.Eat();
        }
    }
}
