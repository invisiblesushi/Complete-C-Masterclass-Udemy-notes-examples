using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_and_finalizers_destructors
{
    class Member
    {
        //Member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //Member - public field
        public int age;

        //Member property - exposes jobTitle safely - Properties start with a capital letter
        public string JobTitle {
            get{
                return jobTitle;
            }
            set {
                jobTitle = value;
            } }

        //Publuc member Method, can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                ShaingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void ShaingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }


       //member constructor
       public Member()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Member() {
            //Cleanup statements
            Console.WriteLine("Deconstruction of member object");
            Debug.Write("---Deconstruction of member object---");
        }

    }
}
