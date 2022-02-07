using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 15;
            do
            {
                //Code that always executes at least once or multiple
                Console.WriteLine("do: " + counter);
                counter++;
            } 
            //Executes code above if condition is met
            while (counter < 5);

            Console.Read();
        }
    }
}
