using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class ClassRoster2Controller
    {
        public ClassRoster2Controller()
        {

            //Create instance of Model and View
            ClassRoster2Model myModel = new ClassRoster2Model();
            ClassRoster2View myView = new ClassRoster2View();

            bool exitApp = false;

            //Add instructor info
            myModel.AddInstructor(myView.GetInstructorInfo());


            //Exit control loop
            while (!exitApp)
            {
                string menuOption = "";

                menuOption = myView.Menu();


                //Switch takes user selection 
                switch (menuOption)
                {
                    case "a": //Add student to roster
                        myModel.AddStudent(myView.AddStudent());
                        break;

                    case "b": //Print roster
                        myView.PrintInstructor(myModel.InstructorInfo());
                        myView.PrintRoster(myModel.GetRoster());
                        break;

                    case "x": //Exit App
                        exitApp = true;
                        break;

                    default: //Print Invalid input method
                        myView.InvalidInput();
                        break;
                }
            }

            
        }

        
    }
}
