using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskEleks.Assembly;

namespace TestTaskEleks.Pages
{
    public class StatusPage : Driver
    {
        private readonly IWebElement statusMessage = WebDriver.FindElement(By.XPath("//div[contains(@class,'confirmation')]" +
                                                                                     "/div[contains(@class,'content')]"));


        public string GetStatusMessage()
        {
            return statusMessage.Text;
        }
    }
}
