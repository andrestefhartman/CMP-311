using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRosterApp
{
    class Student : Person  //Class containing additional Student information (Inherits from Person class)
    {
        private double classRank;

        public Student() : base()
        {

        }

        public Student(string Name, string LastName) : base(Name, LastName)
        {

        }

        public Student(string Name, string LastName, double ClassRank) : base(Name, LastName)
        {
            classRank = ClassRank;
        }

        public double ClassRank //Method to get and set Class Rank
        {
            get { return classRank; }
            set { classRank = value; }
        }

    }//End of Student class


}
