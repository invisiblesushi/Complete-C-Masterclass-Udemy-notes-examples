using System;

namespace EnumsC
{
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su};

    //January to start at 1 instead of 0
    //Can reassign the index and keep on counting from that point on
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec}

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day Su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);

            Console.WriteLine((int) Day.Mo);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);


        }
    }
}
