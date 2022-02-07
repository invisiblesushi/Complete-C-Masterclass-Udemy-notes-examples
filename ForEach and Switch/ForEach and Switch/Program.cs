using System;

namespace ForEach_and_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create an application that takes 2 input values.

            Any input value(1st input)

            Asks the data type of the input value. (2nd input)

            It will print to the console the options like below to take input for the 2nd input value:

            Press 1 for String

            Press 2 for integer

            Press 3 for Boolean
            */

            Boolean valid = false;
            string inputValueType = string.Empty;

            Console.WriteLine("Input a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    //Checks for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    //Check for integer
                    int retValue;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;

                case 3:
                    bool retFlag = false;
                    //Check for boolean
                    valid = Boolean.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;

                default:
                     
                    Console.WriteLine("Not able to detect input type");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }





            static bool IsAllAlphabetic(string value)
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                return true;
            }

        }
    }
}
