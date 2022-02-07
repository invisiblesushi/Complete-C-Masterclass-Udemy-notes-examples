using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    class Program
    {
        // Defining a delegate type, called FilterDelegate that takes a person object and returns
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Create 4 person obj
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            //Add obj to list
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };


            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            // Anonymous method
            // Here we created a variable called filter of type FilterDelegate.
            // Then we assigned an anonymous method to it instead of an already defined method
            // Declaring a variable and assigning its value at the same time. just like x = 3
            // Anonymous method bacause it does not have a name, but behaves like a method
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30; 
            };

            DisplayPeople("Between 20 and 30:", people, filter);

            // Pass anonymous method directly as a parameter
            DisplayPeople("All", people, delegate (Person p) { 
                return true; 
            }
            );



            string searchKeyword = "A";
            // Lambda expression
            DisplayPeople("Age > 20 with a search keyword:" + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            //Expression lambda
            //one line of code
            DisplayPeople("Exactly 25:", people, p => p.Age == 25);

        }


        //A method to display the list of people that passes the filter condition
        //(returns true)
        //This method will take a title to be displayed, the list of people
        //and a filter delegate
        //We can pass in a method that follows the FilterDelegate description
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                //Check if person passes filter
                if (filter(p))
                {
                    //Print person name, age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
            Console.WriteLine("");
        }

        // Filters
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

    }
}
