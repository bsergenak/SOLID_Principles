using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.BadExample
{
    public enum CoffeeType { Latte = 1, Expresso = 2, Coffee = 3};
    public class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            double totalPrice = 0;
            switch (coffeeType)
            {
                case CoffeeType.Latte: totalPrice += amount * 4.25;
                    break;
                case CoffeeType.Expresso: totalPrice += amount * 5.35;
                    break;
                case CoffeeType.Coffee: totalPrice += amount * 2.15;
                    break;
            }
            return totalPrice;
        }
        //Burada teorikte bahsettiğimiz gibi yeni bir kahve türü geldiğinde hem enum'da hemde GetTotalPrice() methodunda değişiklik yapmak zorunda kalacağız. yani var olan yapımda değişlik yapacağız.

    }
}
