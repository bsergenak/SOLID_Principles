using InterfaceSegregationPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Chicken : IWalkBird
    {
        public string Walk() => "All chickens can walk...!";
    }
}
