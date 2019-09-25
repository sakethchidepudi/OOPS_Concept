using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Concept
{
    class Person
    {
        public string firstName;
        public string lastName;
        
        public string getName()
        {
            return firstName + " " + lastName + ",";
        }
    }
}
