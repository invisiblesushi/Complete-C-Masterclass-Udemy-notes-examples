using System;
using System.Collections.Generic;

namespace StacksDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining a new stack
            Stack<int> stack = new Stack<int>();

            // Add element using Push()
            // Peek() return top element
            stack.Push(1);
            Console.WriteLine("Top value: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value: {0}", stack.Peek()); 
            stack.Push(3);
            // remove item from stack
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item: {0}", myStackItem);

            Console.WriteLine("Top value: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("The top value {0} removed", stack.Pop());
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }


            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //defining new stack of int
            Stack<int> myStack = new Stack<int>();
            //foreach number in our array
            foreach (int number in numbers)
            {
                //Print
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Numbers in reverse");
            while(myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }


        }
    }
}
