using LiskovSubstitution.GoodExample.Abstract;
using LiskovSubstitution.GoodExample.Concrete;
using System;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseShape baseShape = new Retangle();
        }
    }
}
