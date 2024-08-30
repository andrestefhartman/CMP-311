using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class TipModel
    {
        private double bill;
        private double tipPercentage;
        

        public TipModel()
        {
            bill = 0;
            tipPercentage = 0;
            
            
        }

        public TipModel(double bill, double tipPercentage) 
        { 
            this.bill = bill;
            this.tipPercentage = tipPercentage;
            
        }

        public double Bill
        {
            get { return bill; }
            set { bill = value; }
        }

        public double TipPercentage
        {
            get { return tipPercentage; }
            set { tipPercentage = value; }
        }

        public double Tip()
        {
            double tip = bill * tipPercentage/100;
            return tip;
        }
    }
}
