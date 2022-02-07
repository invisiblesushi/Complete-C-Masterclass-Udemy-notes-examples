using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictonaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95,200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Intern", "Ernest", 22, 8)
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            
            //Adds employees object from array to dictionary
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            //Gets CEO from dictionary
            //Employee empl = employeeDictionary["CEO"];
            //Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            string key = "CEO";
            if (employeeDirectory.ContainsKey(key))
            {
                Employee empl = employeeDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }



            // Try get value
            Employee result = null;
            if (employeeDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value retrieved!.");
                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("Key does not exist");
            }

            // Update key
            // Replace employee in key with
            string keyToUpdate = "HR";
            if (employeeDirectory.ContainsKey(keyToUpdate))
            {
                employeeDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }
            else
            {
                Console.WriteLine("No employee found key: {0}", keyToUpdate);
            }


            // Remove
            // .Remove will return a bool
            string keyToRemove = "Intern";
            if (employeeDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with key {0} was removed", keyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found key: {0}", keyToRemove);
            }


            // return key-value pair and prints
            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                //print key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                //storing value in obj
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }



        }
    }


    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary { 
            get { return Rate * 8 * 5 * 4 * 12; } 
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
