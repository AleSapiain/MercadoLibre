using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoLibre.Actions
{
    class Count
    {
        public static int resultItems(IWebDriver driver, By locator)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            int result = driver.FindElements(locator).Count;
            return result;
        }
    }
}
