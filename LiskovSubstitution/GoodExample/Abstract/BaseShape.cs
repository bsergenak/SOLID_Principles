using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.GoodExample.Abstract
{
    public abstract class BaseShape
    {
        //Kenar sayısı bilgisi her dörtgende şekilde ortaktır.
        public int Edge { get; set; }
        public abstract int CalculateSquare();
    }
}
