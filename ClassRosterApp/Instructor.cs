using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRosterApp
{
    class Instructor : Person //Class containing addition Instructor information (Inherits from person class)
    {
        private string contactEmail = "";

        public Instructor(): base()
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
    }//End of Instructor Class
}
