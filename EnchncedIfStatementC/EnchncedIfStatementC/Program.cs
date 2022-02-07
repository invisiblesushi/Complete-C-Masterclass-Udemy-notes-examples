using System;

namespace EnchncedIfStatementC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //Increase by 30 degree
            temperature += 30;

            // in short
            //stateOfMatter is going to be
            //? if true
            //: else
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);


            //Challenge - add gas state
            //if more than 100 its gas, else if less than 0 its solid, else liquid
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            */


            int inputTemp = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            Console.Write("Enter temperature: ");
            inputValue = Console.ReadLine();

            //Validate value
            bool ValidInteger = int.TryParse(inputValue, out inputTemp);

            if (ValidInteger)
            {
                // condition ? iftrue : iffalse
                // If condition is true this will be executed, if false after : will be executed
                tempMessage = inputTemp <= 15 ? 
                    //True
                    "it's cold in here" : 
                    //False
                    (inputTemp >= 16 && inputTemp <= 28) ? 
                    //True
                    "it is ok in here" : inputTemp > 28 ? 
                    //False
                    "Its hot here" : 
                    //Else
                    "";
            }
            Console.WriteLine(tempMessage);

            Console.Read();
        }


    }
}
