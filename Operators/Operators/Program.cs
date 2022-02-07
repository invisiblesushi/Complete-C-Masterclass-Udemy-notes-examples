using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {


            //increment operators
            int num = 0;
            num++;
            //1
            Console.WriteLine("num is {0}", num);
            //1 Post increment
            Console.WriteLine("num is {0}", num++);
            //3 Pre increment
            Console.WriteLine("num is {0}", ++num);



            //decrement operator
            num--;
            //2
            Console.WriteLine("num is {0}", num);
            //2 Post decrement
            Console.WriteLine("num is {0}", num--);
            //0 Pre decrement
            Console.WriteLine("num is {0}", --num);

            int num1 = 5;
            int num2 = 3;
            int result;

            //Modulus
            //Returns the remainder
            result = num1 % num2;
            Console.WriteLine("Result of num1 % num2 is {0}", result);


            // relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 {0} is ", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 {0} is ", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 {0} is ", isEqual);



            //Try parse
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if(userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            




        }
    }
}
