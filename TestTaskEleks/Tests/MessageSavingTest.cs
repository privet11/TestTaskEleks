using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskEleks.Pages;

namespace TestTaskEleks
{
    [TestClass]
    public class MessageSavingTest : PagesGet
    {
        readonly string testEmail = "TestTaskEmail@i.ua";
        readonly string testPass = "testtaskpass123";
        readonly string testString = "TestString@i.ua";
        readonly string confirmationMessage = "Лист успішно збережено";

        [TestMethod]
        public void SaveMessage()
        {
            GetPages<HomePage>().EnterUserData(testEmail, testPass);
            GetPages<HomePage>().LoginButtonClick();
            GetPages<MessageBoxPage>().CreateMessageButtonClick();
            GetPages<NewMessagePage>().EnterTestMessageData(testString);
            GetPages<NewMessagePage>().SaveButtonClick();
            Assert.AreEqual(GetPages<StatusPage>().GetStatusMessage(), confirmationMessage);
        }
    }
}
