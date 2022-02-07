using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            Tv myTv = new Tv(false, "Samsung");
            myTv.SwitchOn();
            myTv.WatchTv();
        }
    }
}
