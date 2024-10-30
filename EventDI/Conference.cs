using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public class Conference : EventInfo, ICost
    {
        const double pricePerHead = 20.75;
        public Conference(int iD, string Description, int Attendees) : base(iD, Description, Attendees)
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
