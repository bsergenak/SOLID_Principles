using InterfaceSegregationPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Hawk : IWalkBird, IFlyBird
    {
        public string Fly() => "All hawk can fly..!";

        public string Walk() => "All hawk can walk..!";
    }
}
