using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _70
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("viktoriayaroshenko1@yandex.ru", "Polinka9999");
        }
    }
}
