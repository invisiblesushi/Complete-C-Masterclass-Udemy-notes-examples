using System;

namespace _2d_array_nested_loop
{
    class Program
    {
        static int[,] matrix =
{
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
        static void Main(string[] args)
        {
            //Nested for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //Inner loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    /*
                    //Even number
                    if(matrix[i,j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                    else
                        Console.WriteLine(" ");
                    */

                    //diagonal
                        if (i == j)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                }
                Console.WriteLine("");
            }

            //diagonal reverse
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.Write(matrix[i, j]);

            }





        }
    }
}
