using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoLibre.Actions
{
    class Text
    {
        public static void Set(IWebDriver driver, By locator, string critery)
        {
            driver.FindElement(locator).SendKeys(critery);
        }

        public static void Clean(IWebDriver driver, By locator)
        {
            driver.FindElement(locator).Clear();
        }
    }
}
