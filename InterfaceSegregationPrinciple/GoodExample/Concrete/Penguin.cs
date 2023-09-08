using InterfaceSegregationPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.GoodExample.Concrete
{
    public class Penguin : IWalkBird, ISwimBird
    {
        public string Swim() => "All penguins can swim..!";

        public string Walk() => "All penguins can walk..!";
    }
}
