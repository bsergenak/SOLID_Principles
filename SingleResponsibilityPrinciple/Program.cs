using SingleResponsibilityPrinciple.BadExample;
using SingleResponsibilityPrinciple.GoodExample;
using System;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BadEmployee bad = new BadEmployee();
            //bad.CreateEmployee(new Entity.Employee { FirstName = "Barkın", LastName = "Bayzin", Id = 1, HireDate = DateTime.Now });

            GoodInsertEmployee goodInsertEmployee =new GoodInsertEmployee();
            bool eklendiMi = goodInsertEmployee.CreateEmployee(new Entity.Employee { FirstName = "Barkın", LastName = "Bayzin", Id = 1, HireDate = DateTime.Now });

            if (eklendiMi)
                Console.WriteLine("Başarılı bir şekilde eklendi");
            else
                Console.WriteLine("Kayıt Başarısız");
            
            Console.ReadLine();
        }
    }
}
