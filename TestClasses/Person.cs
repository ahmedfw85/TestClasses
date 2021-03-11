using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Person
    {
        String name;
        int age;

        // Constructor that takes no arguments:
        public Person()
        {
            name = "unknown";
            age = 18;
        }

        // Constructor that takes one argument:
        public Person(string NewName, int NewAge)
        {
            name = NewName;
            age = NewAge;
        }
        //--------------- Methods------------
        public String ShowDetails()
        {
            return "Name: " + name + ", Age: " + age;
        }
        public int AddFiveToAge()
        {
            return age + 5;
        }
    } 
}
