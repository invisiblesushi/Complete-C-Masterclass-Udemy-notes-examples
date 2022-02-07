using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        // Challenge
        /*
         * Write a program that will iterrate through each element of the students array and insert them into a hashtable.
         * If a student with the same ID already exists in the hashtable skip it and display the following error:
         * "Sorry, A student with the same ID already Exists".
         * Hint: Use the method ContainsKey() to check wether a student with the same ID already exist
         */


        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            foreach (Student studentObj in students)
            {
                if (studentsTable.ContainsKey(studentObj.Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID already Exists");
                }
                else
                {
                    studentsTable.Add(studentObj.Id, studentObj);
                    Console.WriteLine("Student with id{0} was added", studentObj.Id);
                }
            }




            /*
            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrive induvidial item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retrive all values from HashTable
            foreach (DictionaryEntry entry in studentsTable)
            {
                // Temporaly Student object, with cast to Student
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student name:{0}", temp.Name);
                Console.WriteLine("Student GPA{0}", temp.GPA);
            }


            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}", value.Id);
                Console.WriteLine("Student name:{0}", value.Name);
                Console.WriteLine("Student GPA{0}", value.GPA);
            }


            Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            */






        } 
    }
}
