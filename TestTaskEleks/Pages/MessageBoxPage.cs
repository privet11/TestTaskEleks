using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskEleks.Assembly;

namespace TestTaskEleks.Pages
{
    public class MessageBoxPage: Driver
    {
        private readonly IWebElement createMessageButton = WebDriver.FindElement(By.XPath("//a[text()='Створити листа']"));

        public void CreateMessageButtonClick() => createMessageButton.Click();

    }
}
