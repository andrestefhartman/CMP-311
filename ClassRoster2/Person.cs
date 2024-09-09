using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class Person
    {
        private string name = "";
        private string lastName = "";

        public Person()
        {

        }

        public Person(string Name, string LastName)
        {
            name = Name;
            lastName = LastName;
        }



        public string Name  //Method to get and set Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName  //Method to get and set Last Name
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }//Person class containing name and last name
}
