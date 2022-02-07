using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();

            try
            {
                int inputInt = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number to long or short for int");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //Code to be executed anyways
                Console.WriteLine("This is called anyways");
            };



        }
    }
}
