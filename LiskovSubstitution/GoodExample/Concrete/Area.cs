using LiskovSubstitution.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.GoodExample.Concrete
{
    public class Area : BaseShape
    {
        public override int CalculateSquare() => Edge * Edge;
    }
}
