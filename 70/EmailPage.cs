using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace _70
{
    class EmailPage {
        IWebDriver driver;
        
        private static By LogoutIcon = By.ClassName("user-account");
        private static By LogoutLink = By.ClassName("legouser__menu-item_action_exit");
        public EmailPage(IWebDriver driver) {
            this.driver = driver;
            Logout();
        }
        public void Logout() {
            var iconWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var iconElement = iconWait.Until(condition => driver.FindElement(LogoutIcon).Displayed);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("Screen1", OpenQA.Selenium.ScreenshotImageFormat.Jpeg);

            var logoutIconElement = driver.FindElement(LogoutIcon);
            logoutIconElement.Click();

            var linkWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var linkElement = linkWait.Until(condition => driver.FindElement(LogoutIcon).Displayed);

            var logoutLinkElement = driver.FindElement(LogoutLink);
            logoutLinkElement.Click();
        }
    }
}
