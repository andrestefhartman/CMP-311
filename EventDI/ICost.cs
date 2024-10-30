using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public interface ICost
    {
        double GetCost();

        double GetCost(string code);
    }
}
