using System;

namespace StructsC
//Classes are refrence types, Structs are value types
//If create object of class, value can have nothing
//Struct has to have a value 
//Structs differs by cannot have constructor
//Does not support inheritance

/*
Classes Only:
Can support inheritance
Are reference (pointer) types
The reference can be null
Have memory overhead per new instance

Structs Only:
Cannot support inheritance
Are value types
Are passed by value (like integers)
Cannot have a null reference (unless Nullable is used)
Do not have a memory overhead per new instance - unless 'boxed'

Both Classes and Structs:
Are compound data types typically used to contain a few variables that have some logical relationship
Can contain methods and events
Can support interfaces
 */

{

    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is {0}", game1.name);
            Console.WriteLine("Game 1's developer is {0}", game1.developer);
            Console.WriteLine("Game 1's rating is {0}", game1.rating);
            Console.WriteLine("Game 1's release is {0}", game1.releaseDate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            //game1.Display(); will only work after we have assigned all the values in game1
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();

        }
    }
}
