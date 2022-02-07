using System;

namespace Challenge_1___String_and_its_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please enter your name and press enter");

            //Reads and assigns input to variable
            name = Console.ReadLine();

            string myNameUpperCase = String.Format("Upper case: {0}", name);
            string myNameLowerCase = String.Format("Lower case: {0}", name);
            string myNameTrim = String.Format("Trim : {0}", name);
            string myNameSubString = string.Format("Substring value: {0}", name.Substring(0, 5));

            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrim);
            Console.WriteLine(myNameSubString);

            Console.Read();
        }
    }
}
