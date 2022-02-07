using System;

namespace PropertiesBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 10);
            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);
            Console.ReadKey();
        }
    }
}
