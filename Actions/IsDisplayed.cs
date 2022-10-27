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
            return driver.FindElement(locator).Displayed;
        }
    }
}
