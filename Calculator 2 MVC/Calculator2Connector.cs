using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator2Connector //Connector class that interacts with the View and the model
    {
        public Calculator2Connector()//Connnector constructor which includes all neccesary steps
        {
            //Create instance of View and Model
            Calculator2Model myCalc = new Calculator2Model();
            Calculator2View myView = new Calculator2View();

            bool exitApp = false;

            // loop to control app exit
            while (!exitApp)
            {
                //Set number1 and number2 to user input
                myCalc.Number1 = myView.GetNum("first");
                myCalc.Number2 = myView.GetNum("second");

                string op = myView.GetOperationFromUser();


                //Exception control
                try
                {
                    double result = myCalc.DoOperation(op);

                    //Check to see if an operation was done
                    if (double.IsNaN(result))
                    {
                        myView.OperationFail();

                    }
                    else
                    {
                        myView.Result(result);
                    }
                }
                catch (Exception e)
                {
                    myView.OperationException(e);
                }

                exitApp = myView.AppController();

            }//end of loop
            



        }//end of Constructor
    }// end of Connector Class
}
