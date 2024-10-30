using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public class EventInfo
    {
        private int id;
        private string description = "";
        private int attendees;
        private double cost;

        public EventInfo(int iD, string Description, int Attendees)
        {
            id = iD;
            description = Description;
            attendees = Attendees;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Attendees
        {
            get { return attendees; }
            set { attendees = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public static double Discount(string code)
        {
            code = code.ToLower();

            switch (code)
            {
                case "d":
                    return 0.9;

                case "l":
                    return 1.1;

                case "e":
                    return 0.75;
                case "f":
                    return 0;
                default:
                    return 1;
            }
        }
    }
}
