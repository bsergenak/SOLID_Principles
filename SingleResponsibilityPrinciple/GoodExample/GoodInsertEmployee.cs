using SingleResponsibilityPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.GoodExample
{
    public class GoodInsertEmployee
    {
        public GoodLogger goodLoger;
        public GoodInsertEmployee() => goodLoger = new GoodLogger();
        string log;
        public bool CreateEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                stringBuilder.Append(employee.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.LastName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.HireDate);
                stringBuilder.AppendLine();

                //Loglama işlemlerin başlaması gerekiyor.
                log = goodLoger.BuildLog(stringBuilder.ToString());

                goodLoger.LogFile(@"C:\Test\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                log = goodLoger.BuildLog(ex.Message.ToString());
                goodLoger.LogFile(@"C:\Test\Log.txt", log);
                return false;
            }
        }
    }
}
