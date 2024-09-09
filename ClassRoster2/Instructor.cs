using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class Instructor : Person
    {
        private string contactEmail = "";

        public Instructor() : base()
        {

        }

        public Instructor(string Name, string LastName) : base(Name, LastName)
        {

        }

        public Instructor(string Name, string LastName, string ContacEmail) : base(Name, LastName)
        {
            contactEmail = ContacEmail;
        }


        public string ContactEmail //Method to get and set Instructor contact details
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }
    } //Instructor class which inherits from Person class
}
