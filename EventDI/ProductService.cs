using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public class ProductService
    {
        private readonly ICost _cost;
       

        public ProductService(ICost Event) 
        {
            _cost = Event;
        }

        public double Cost()
        {
            return _cost.GetCost();
        }

        public double Cost(string code)
        {
            return _cost.GetCost(code);
        }

        public void RecommendedDates()
        {
            
        }
    }
}
