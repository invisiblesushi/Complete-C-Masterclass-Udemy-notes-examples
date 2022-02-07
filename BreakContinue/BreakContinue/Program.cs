using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Break
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 3)
                {
                    Console.WriteLine("At 3 we stop");
                    //Stops the loop
                    break;
                }
            }
            
            //Continue
            for (int j = 0; j < 10; j++)
            {
                if (j %2 == 0)
                {
                    Console.WriteLine("Now comes an odd number");
                    continue;
                }
                Console.WriteLine(j);
            }
        }
    }
}
