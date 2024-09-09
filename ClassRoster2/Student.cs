using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class Student : Person
    {
        private string classRank = "";

        public Student() : base()
        {

        }

        public Student(string Name, string LastName) : base(Name, LastName)
        {

        }

        public Student(string Name, string LastName, string ClassRank) : base(Name, LastName)
        {
            classRank = ClassRank;
        }

        public string ClassRank //Method to get and set Class Rank
        {
            get { return classRank; }
            set { classRank = value; }
        }
    }//Student class which inherits from person class
}
