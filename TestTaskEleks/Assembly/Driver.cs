using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskEleks.Assembly
{
    public class Driver
    {
        private static IWebDriver webDriver = null;
        private static string baseURL = "https://www.i.ua/";

        public static IWebDriver WebDriver
        {
            get
            {
                if (webDriver == null)
                {
                    webDriver = new ChromeDriver();
                    webDriver.Manage().Window.Maximize();
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    webDriver.Navigate().GoToUrl(baseURL);
                }
                return webDriver;
            }
            set
            {
                webDriver = value;
            }
        }
    }
}
