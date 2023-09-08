using InterfaceSegregationPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class KaraBatak : IWalkBird, ISwimBird, IFlyBird
    {
        public string Fly() => "All KaraBatak can fly..!";

        public string Walk() => "All KaraBatak can walk..!";

        public string Swim() => "All KaraBatak can swim..!";

    }
}
