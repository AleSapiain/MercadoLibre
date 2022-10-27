using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MercadoLibre
{
    public class BaseTest
    {
        ChromeOptions options = new ChromeOptions();
        protected IWebDriver driver;
        protected string Url = "https://mercadolibre.com/";

        [SetUp]
        public void SetupBase()
        {
            options.AddArguments("--start-maximized");
            options.AddArguments("--incognito");

            driver = new ChromeDriver(@"D:\SeleniumTest-Ganadero\MercadoLibre\resources", options);
            driver.Navigate().GoToUrl(Url);
        }

        [TearDown]
        public void TearDownBase()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}