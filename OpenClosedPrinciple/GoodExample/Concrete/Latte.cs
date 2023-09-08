using OpenClosedPrinciple.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.GoodExample.Concrete
{
    public class Latte : GoodCoffeeShop
    {
        public override double GetTotalPrice(double amount) => amount * 5.59;
    }
}
