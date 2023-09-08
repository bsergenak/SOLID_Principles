using DependencyInversionPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.GoodExample.Concrete
{
    public class Levrek : IProduct
    {
        public string GetCookingInstruction() => "Fırında levrek tarifi..!";
    }
}
