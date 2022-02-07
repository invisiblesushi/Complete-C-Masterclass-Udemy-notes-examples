using System;

namespace AverageChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;


            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Count: {0}", count);
                Console.WriteLine("Total: {0}", total);

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    //Calculate avg
                    //Console.WriteLine("Average int: " + total / count);
                    double avg = (double)total / (double)count;
                    Console.WriteLine("Average score: {0}", avg);
                }
                else if ((int.TryParse(input, out currentNumber)) && (currentNumber >= 0 && currentNumber <= 20))
                {
                    total += currentNumber;
                    count++;
                }
                else
                {
                    Console.WriteLine("Not a valid integer, or between 0 and 20");
                }




            }




        }
    }
}
