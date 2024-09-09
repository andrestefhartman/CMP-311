using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class ZooController
    {

        public ZooController()
        {
            ZooModel zooModel = new ZooModel();
            ZooView zooView = new ZooView();
            bool exitApp = false;


            while (!exitApp)
            {
                string menuOption = "";

                menuOption = zooView.Menu();

                switch (menuOption)
                {
                    case "1":
                        zooModel.AddMammal(zooView.GetMammal());
                        break;
                    case "2":
                        zooModel.addReptile(zooView.GetReptile());
                        break;
                    case "3":
                        zooModel.addAmphibian(zooView.GetAmphibian());
                        break;
                    case "4":
                        zooView.PrintAnimals(zooModel.GetAnimals());
                        break;
                    case "5":
                        zooView.PrintMammals(zooModel.GetMammals());
                        break;
                    case "6":
                        zooView.PrintReptiles(zooModel.GetReptiles());
                        break;
                    case "7":
                        zooView.PrintAmphibians(zooModel.GetAmphibians());
                        break;
                    case "x":
                        exitApp = true;
                        break;
                    default:
                        zooView.InvalidInput();
                        break;
                }
            }


        }
    }
}
