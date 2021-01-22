using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskEleks.Assembly;

namespace TestTaskEleks.Pages
{
    public class NewMessagePage: Driver
    {
        private readonly IWebElement addresseeField = WebDriver.FindElement(By.XPath("//textarea[@id='to']"));
        private readonly IWebElement themeField = WebDriver.FindElement(By.XPath("//input[@name='subject']"));
        private readonly IWebElement textArea = WebDriver.FindElement(By.XPath("//textarea[@id='text']"));
        private readonly IWebElement saveButton= WebDriver.FindElement(By.XPath("//input[@name='save_in_drafts']"));

        public void SaveButtonClick() => saveButton.Click();

        public void EnterTestMessageData(string testString)
        {
            addresseeField.SendKeys(testString);
            themeField.SendKeys(testString);
            textArea.SendKeys(testString);
        }
    }
}
