using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue<int> queue = new Queue<int>();

            //Print element in front
            queue.Enqueue(1);
            Console.WriteLine("The value in front is {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value in queue is {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The value in queue is {0}", queue.Peek());

            while(queue.Count > 0)
            {
                //Dequeue() will return the element that was removed
                Console.WriteLine("The front value {0} was removed from queue", queue.Dequeue());
                Console.WriteLine("Queue count: {0}", queue.Count);
            }
            */

            Queue<Order> ordersQueue = new Queue<Order>();
            foreach (Order o in RecieveOrdersFromBranch1())
            {
                //adds order to queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                //adds order to queue
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                //Remove the order in front
                //Store it in var currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                //Process the order
                currentOrder.ProcessOrder();
            }


        }

        //Creates and returns array
        static Order[] RecieveOrdersFromBranch1() 
        {
            //Creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            //Creating new orders array
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }
    }


    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}
