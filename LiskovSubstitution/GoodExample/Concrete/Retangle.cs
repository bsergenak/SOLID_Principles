using LiskovSubstitution.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.GoodExample.Concrete
{
    public class Retangle : BaseShape
    {
        public int Width { get; set; }
        public override int CalculateSquare() => Width * Edge;
    }
}
