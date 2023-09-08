using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.GoodExample
{
    public class GoodLogger
    {
        public void LogFile(string filePath, string log) => File.WriteAllText(filePath, log);

        public string BuildLog(string logInformation)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            sb.Append("Log Info: ");
            sb.Append(logInformation);
            return sb.ToString();
        }
    }
}
