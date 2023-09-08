using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.BadExample
{
    public class BadAreaCalculator
    {
        public static int CalculateArea(BadRetangle badRetangle) => badRetangle.Width * badRetangle.Lenght;
        public static int CalculateArea(BadArea badArea) => badArea.Width * badArea.Lenght;

    }
}
