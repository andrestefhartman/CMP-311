using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public class Birthday: EventInfo, ICost
    {
        const double pricePerHead = 12.50;
        public Birthday(int iD, string Description, int Attendees) : base(iD, Description, Attendees)
        {

        }

        public double GetCost()
        {
            return pricePerHead * this.Attendees;
        }

        public double GetCost(string code)
        {
            return pricePerHead * this.Attendees * Discount(code);
        }

        

    }
}
