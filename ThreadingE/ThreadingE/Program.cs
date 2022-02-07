using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World! 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! 3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World! 4");
            */

            /*
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start(); new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();
            */

            /* taskCompletion
            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                //cant use thread when we are in variable thread, use Thread.CurrentThread
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(5000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            });

            thread.Start();
            //Console.WriteLine($"Thread number: {thread.ManagedThreadId} ended");
            var test = taskCompletionSource.Task.Result;
            Console.WriteLine("Task was done: {0}", test);
            */

            //Set thread to background
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();





            //Enumerable will create 100 threads
            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                //Threadpool waits before the next thread is done/availible before it starts next thread
                ThreadPool.QueueUserWorkItem((o) => 
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });
            });


            Console.ReadLine();





        }
    }
}
