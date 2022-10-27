using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoLibre.Actions
{
    class IsDisplayed
    {
        public static bool element(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            return driver.FindElement(locator).Displayed;
        }
    }
}
