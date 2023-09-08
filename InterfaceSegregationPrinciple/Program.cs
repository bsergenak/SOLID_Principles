using InterfaceSegregationPrinciple.GoodExample.Concrete;
using InterfaceSegregationPrinciple.GoodExample.Interface;
using System;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWalkBird walkBird = new KaraBatak(); //s t'nin yerine geçebilceğini kanıtı
        }
    }
}
