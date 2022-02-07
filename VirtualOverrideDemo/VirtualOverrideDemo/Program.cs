using System;

namespace VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{dog.Name} i {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
