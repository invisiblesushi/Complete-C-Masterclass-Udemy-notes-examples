using System;

namespace AbstractClassesC
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                // as keyword, as a specific class/data type
                // create a variable as a certain type
                Cube iceCube = shape as Cube;
                if (iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                // if a variable is of a certain type
                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                // create a object that is cube
                // cast cube1 into cube
                // will only work if cube1 is a cube
                // its a object that contains a cube
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume()); 



            }
        }
    }
}
