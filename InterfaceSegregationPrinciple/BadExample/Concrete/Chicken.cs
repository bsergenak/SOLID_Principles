using InterfaceSegregationPrinciple.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.BadExample.Concrete
{
    public class Chicken : IBird
    {
        //IBird sınıfından kalıtım yoluıyla gereksiz yetenek kazanan Chicken.cs sınıfı ISP ters düşmüştür.
        public string Fly() => "Each chicken can't to be fly..!";

        public string Walk() => "All chicken can walk..!";
    }
}
