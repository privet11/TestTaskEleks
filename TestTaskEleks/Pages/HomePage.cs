using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskEleks.Assembly;

namespace TestTaskEleks.Pages
{
    public class HomePage : Driver
    {
        private readonly IWebElement loginButton = WebDriver.FindElement(By.XPath("//input[@value='Увійти']"));
        private readonly IWebElement loginField = WebDriver.FindElement(By.XPath("//input[@name='login']"));
        private readonly IWebElement passwordField = WebDriver.FindElement(By.XPath("//input[@name='pass']"));


        public void LoginButtonClick() => loginButton.Click();

        public void EnterUserData(string login, string pass)
        {
            loginField.SendKeys(login);
            passwordField.SendKeys(pass);
        }

    }
}
