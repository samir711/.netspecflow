using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecFlow.Platform.Utils.Extensions;

namespace SpecFlow.Platform.Pages
{
    public class EnglishHomePage : BasePage
    {

        public PortalPage NavToAllPortal()
        {
           var LinkAllPortal = Driver.FindElement(By.LinkText("All portals"));
           LinkAllPortal.WeClick();
           Console.WriteLine(":: I have clicked the All Portal link ");
           return InstanceOf<PortalPage>();
        }

    }
}
