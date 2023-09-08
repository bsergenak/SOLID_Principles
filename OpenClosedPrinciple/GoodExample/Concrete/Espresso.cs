using OpenClosedPrinciple.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Concrete
{
    public class Espresso : GoodCoffeeShop
    {
        public override double GetTotalPrice(double amount) => amount * 4.45;
    }
}
