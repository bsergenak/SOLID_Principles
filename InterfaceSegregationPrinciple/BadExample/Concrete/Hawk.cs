using InterfaceSegregationPrinciple.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public string Fly() => "All hawk can fly..!";

        public string Walk() => "All hawk can walk..!";
    }
}
