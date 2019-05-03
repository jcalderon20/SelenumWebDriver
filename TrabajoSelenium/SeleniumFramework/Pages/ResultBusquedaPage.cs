using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages
{
    class ResultBusquedaPage : BasePage
    {
        RemoteWebDriver _webDriver;
        public ResultBusquedaPage()
        {
            _webDriver = base.webDriver;
        }
        public By mouse_list = By.ClassName("icon-view-grid");
        public By link = By.LinkText("Elegant Fashion Women Sexy Boat Neck Glitter Dress Evening Party Formal Dress");
        public By link2 = By.LinkText("Women Sleeveless Summer Boho Printed Beach Casual Loose Mini Shirt Beach Dress");
        public By list = By.LinkText("List View");
        //public By span_wait = By.Id(" ");

        public void mouse_lista()
        {
            MouseOverElement(mouse_list);
        }

        public void cliclista()
        {
            ClickOn(list);
            Thread.Sleep(10000);
        }

        public void clic_link()
        {
            ClickOn(link);
        }
        public void verificarnombre1()
        {
            
        }
        public void clic_link2()
        {
            ClickOn(link2);
        }
    }
}