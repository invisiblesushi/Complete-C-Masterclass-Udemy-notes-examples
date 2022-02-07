using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQToObjectsAndQueryOperators
{
    class Program
    {
        // Cllection of query operators: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }


            // Print students from uni id
            Console.WriteLine("Enter uni id: ");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentFromThatUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value");
            }

            
        }
    }


    
}

