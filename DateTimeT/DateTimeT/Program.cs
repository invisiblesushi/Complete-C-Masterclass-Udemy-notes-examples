using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);

            Console.WriteLine("My birthday is {0}", dateTime);

            // Write today on screen
            Console.WriteLine(DateTime.Today);

            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            // Write tomorrows date
            Console.WriteLine("Tommorrow will be the: " + GetTomorrow());

            // Day of week
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            // First day of year
            Console.WriteLine(GetFirstDayOfYear(1999));

            // Current minute
            Console.WriteLine("Minute: {0}", DateTime.Now.Minute);

            // display the time in this structure x o'clock y minutes and z secounds
            Console.WriteLine("{0} o'clock {1} minutes and {2} secounds", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second) ;


            //Days since your birthday
            Console.WriteLine("Write your birthdate in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = DateTime.Now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }


        }

        // Return tomorrows date
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
