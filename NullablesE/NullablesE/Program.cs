using System;

namespace NullablesE
{
    class Program
    {
        //Nullables are variables that can have a value or dont have a value
        static void Main(string[] args)
        {
            // Add a ? after the datatype
            int? num1 = null;
            //int num2 = null;    //Error not a nullable type
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Nullable bumbers are: {0},{1},{2},{3}",num1, num2,num3,num4);
            Console.WriteLine("Nullable bool val are: {0}", boolval);

            // No gender choosen cause of null
            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender choosen");
            }

            //Convert to non nullable type, need to cast it to double
            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }
            Console.WriteLine("Value of num8 is " + num8);

            // The NULL coalescing operator ??
            // If num6 is empty, then enter 8.53
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is " + num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is " + num8);



        }
    }
}
