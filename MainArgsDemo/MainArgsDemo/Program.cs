using System;

namespace MainArgsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide an args");
                //quit app since argument is empty
                return;
            }
            else
            {
                Console.WriteLine("Hello " + args[0]);

            }
        }
    }
}
