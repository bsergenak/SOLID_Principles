using DependencyInversionPrinciple.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.GoodExample.Concrete
{
    public class Restaurant
    {
        private IProduct _product;

        //Constructor Injection
        public Restaurant(IProduct product)
        {
            _product = product;
        }

        //IProduct pro2 = new Levrek(); //Dependency Injection Örneği
        //IProduct pro3 = new Chicken(); //Dependency Injection 

        public string GenerateCookingInstruction() => $"{_product.GetCookingInstruction()}";
    }
}
