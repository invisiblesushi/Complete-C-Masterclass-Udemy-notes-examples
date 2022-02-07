using System;
using System.Collections.Generic;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a generic IEnumerable variable that takes any collection of type int
            //We will use this variable to store the collections that will get returned by the GetCollection() method
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            unknownCollection = GetCollection(5);
            Console.WriteLine("This was a array if int");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numberList;
            }
            else if(option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
