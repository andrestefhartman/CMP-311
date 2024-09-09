using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class ClassRoster2Model
    {
        //Create instance of instructor
        Instructor instructor = new Instructor();

        //Create list which contains the student roster
        List<Student> studentsRoster = new List<Student>();

        public ClassRoster2Model()
        {

        }

        public List<string> InstructorInfo() //Method which returns instructor info in a List
        {
            List<string> instructorInfo = new List<string>();
            instructorInfo.Add(instructor.Name);
            instructorInfo.Add(instructor.LastName);
            instructorInfo.Add(instructor.ContactEmail);

            return instructorInfo;
        }
        public void AddInstructor(List<string> instructorInfo) //Method which adds instructor info from a List
        {
            instructor.Name = instructorInfo[0];
            instructor.LastName = instructorInfo[1];
            instructor.ContactEmail = instructorInfo[2];
        }

        public void AddStudent(List<string> studentInfo) //Method which adds a student to the roster from a List containing student info
        {
            Student student = new Student();
            student.Name = studentInfo[0];
            student.LastName = studentInfo[1];
            student.ClassRank = studentInfo[2];

            studentsRoster.Add(student);

        }

        public List<string> GetRoster() //Method which returns the student roster as a list
        {
            List<string> roster = new List<string>();


            //Loop stores all student info in one list
            for (int i = 0; i < studentsRoster.Count; i++)
            {
                roster.Add(studentsRoster[i].Name);
                roster.Add(studentsRoster[i].LastName);
                roster.Add(studentsRoster[i].ClassRank);


            }

            return roster;
        }


        
    
        
            
    }
}
