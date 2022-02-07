using System;

namespace ParamsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(5, 1, -11, 40, 1337, 42, 69, 4);
            Console.WriteLine("The minimun is: {0}", min);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }  
    }
}
