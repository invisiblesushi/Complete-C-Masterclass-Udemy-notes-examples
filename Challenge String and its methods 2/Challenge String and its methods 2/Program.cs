using System;

namespace Challenge_String_and_its_methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputStr;
            char inputChar;

            Console.WriteLine("Enter a string here: ");
            inputStr = Console.ReadLine();

            Console.WriteLine("Enter the character to search: ");
            inputChar = Console.ReadLine()[0];

            int result = inputStr.IndexOf(inputChar);
            string resultText = string.Format("index of {0} in {1} is located at: {2}", inputChar, inputStr, result);
            Console.WriteLine(resultText);
            //Console.WriteLine("index of {0} in {1} is located at: {2}", inputChar, inputStr, result);


            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            //string fullName = String.Format("{0} {1}", firstName, lastName);
            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("Your fullname is {0}", fullName);
            Console.Read();


        }
    }
}
