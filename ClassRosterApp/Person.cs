using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassRosterApp
{
    class Person  //Generic Person class containing Name and Last Name
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

    }//End of Person Class
}
