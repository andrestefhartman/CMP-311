using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class TipConnector
    {

        public TipConnector()
        {
       
            TipModel myTip = new TipModel();
            TipView myTipView = new TipView();


            myTip.Bill = myTipView.GetBill();
            myTip.TipPercentage = myTipView.GetPercent();

            myTipView.PrintTip(myTip.Tip());

        }

    }
}
