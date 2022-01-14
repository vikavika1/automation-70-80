using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace _70
{
    class LoginPage
    {
        IWebDriver driver;
        private static string url = "https://passport.yandex.by/";
        private static By InputBox = By.CssSelector(".Textinput-Control");
        private static By Button = By.CssSelector(".Button2_view_action");
        
        public LoginPage(IWebDriver driver) {
            this.driver = driver;
            this.driver.Navigate().GoToUrl(url);
            this.driver.Manage().Window.Maximize();
        }
        public EmailPage login(string username, string password) {
            var usernameBox = driver.FindElement(InputBox);
            usernameBox.SendKeys(username);

            var usernameButton = driver.FindElement(Button);
            usernameButton.Click();

            Thread.Sleep(1000);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(condition => driver.FindElement(InputBox).Displayed);

            var inputPasswordBox = driver.FindElement(InputBox);
            inputPasswordBox.SendKeys(password);

            var passButton = driver.FindElement(Button);
            passButton.Click();

            return new EmailPage(driver);
        }
    }
}
