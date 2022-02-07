using System;

namespace Classes_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            //Create object of my class
            //an instance of Human
            Human denis = new Human();
            //access public variable from outside, and even change it
            denis.firstName = "Denis";
            //call method of the class
            denis.IntroduceMyself();
            */

            Human sissy = new Human("Sissy", "Wagner");
            sissy.IntroduceMyself();


        }
    }
}
