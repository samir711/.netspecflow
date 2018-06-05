using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow.Platform.Utils.Selenium
{
    public class Settings
    {
        public static string BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        public static string WelcomeMessage = ConfigurationManager.AppSettings["WelcomeMesage"];
        public static string TestMail = ConfigurationManager.AppSettings["TestEmail"];


    }
}
