﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Basic
{
    //This class is a blueprint for a datatype
    class Human
    {
        //Member variable
        private string firstName;
        private string lastName;

        // constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, i'm {0} {1}", firstName, lastName);
        }

    }
}
