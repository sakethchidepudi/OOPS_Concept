using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Concept
{
    class Player : Person
    {
        public string sports;

        public string get_PLayer()
        {
            return firstName + " " + lastName + " ," + sports;
        }

        public Player(string firstName, string lastName,string sports)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sports = sports;
        }

    }
}
