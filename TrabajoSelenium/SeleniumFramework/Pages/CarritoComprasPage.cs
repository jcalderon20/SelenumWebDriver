using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class CarritoComprasPage : BasePage
    {

        RemoteWebDriver _webDriver;
        public CarritoComprasPage()
        {
            _webDriver = base.webDriver;
        }

        public By txt_name_v = By.Id("ZANZEA Boho Summer Evening Party Sundress Oversized Strappy Long Maxi Dress Plus"); 

        public void get_name1(String producto)
        {
            GetElementText(txt_name_v);
        }
    }
}
