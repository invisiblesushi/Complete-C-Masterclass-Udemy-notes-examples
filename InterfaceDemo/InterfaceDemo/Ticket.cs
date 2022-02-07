using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
                    //Which : interface we want to use, Need to define which type of object to compare.
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }
        
        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }
        

        //Implementing our own Equals() method by using IEquatable<>
        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
