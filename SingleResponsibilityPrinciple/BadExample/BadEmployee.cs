using SingleResponsibilityPrinciple.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.BadExample
{
    public class BadEmployee
    {
        public void CreateEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                #region İşlem 1: Çalışanın özlük bilgilerini kayıt etmesi
                stringBuilder.Append(employee.Id);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.FirstName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.LastName);
                stringBuilder.AppendLine();
                stringBuilder.Append(employee.HireDate);
                stringBuilder.AppendLine();
                File.WriteAllText(@"C:\Test\EmployeeData.txt", stringBuilder.ToString());
                #endregion

                #region İşlem 2: Çalışanın sisteme giriş yapması sonucunda doğan log'ların tutulması
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Kayıt Tarihi: ");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.Append(employee.Id);
                File.WriteAllText(@"C:\Test\Log.txt", stringBuilder.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                #region İşlem 3: Yukarıdaki süreçlerden herhangi birinin gerçekleşmesi durumunda alınacak hataların tutulması.
                stringBuilder = new StringBuilder();
                stringBuilder.Append(ex.Message);
                stringBuilder.Append(DateTime.Now.ToString());
                File.WriteAllText(@"C:\Test\Log.txt", stringBuilder.ToString());
                #endregion
            }
        }
    }
}
