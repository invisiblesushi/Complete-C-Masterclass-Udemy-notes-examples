using System;
using System.Threading;

namespace ThreadJoiningE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            // New thread that calls Thread1Function
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            thread1.Start();
            thread2.Start();

            /*
            //Blocks main thread untill thread1&2 terminates
            thread1.Join();
            Console.WriteLine("Thread1Function done");
            thread2.Join();
            Console.WriteLine("Thread2Function done");
            */

            // Going to wait 1000ms for thread1, if not finished it will continue
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread1Function done");
            }
            else
            {
                Console.WriteLine("Thread1Function wasn't done within 1 se ");
            }



            //Check if thread1 is still alive
            for (int i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread1 is till doing stuff");
                    Thread.Sleep(300);
                }
                else
                {
                    Console.WriteLine("Thread1 completed");
                }
            }



            //Blocks main thread untill thread2 terminates
            thread2.Join();
            Console.WriteLine("Thread2Function done");


            Console.WriteLine("Main Thread ended");
        }


        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(3000);
            Console.WriteLine("Thread1Function coming back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
