using System;

namespace Multi_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 2d array
            string[,] matrix;

            //3d array
            int[,,] threeD;

            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },   //Row 0
                { 4, 5, 6 },   //Row 1
                { 7, 8, 9 }    //Row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Value 7 is {0}", array2D[2, 0]);


            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"hi there", "Whats up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };

            Console.WriteLine("The value is {0}", array3D[1, 1, 0]);
            Console.WriteLine("The value is {0}", array3D[0, 2, 0]);

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine(array2DString[1,1]);


            //How many dimentions
            int dimentions = array2DString.Rank;
            Console.WriteLine(dimentions);


        }
    }
}
