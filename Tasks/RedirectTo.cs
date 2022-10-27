using MercadoLibre.Actions;
using MercadoLibre.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibre.Tasks
{
    class RedirectTo
    {
        public static void ToCountry(IWebDriver driver)
        {
            Click.On(driver, MercadoLibreUI.country);
            driver.Manage().Cookies.DeleteAllCookies(); //delete all cookies
        }

        public static void Search(IWebDriver driver)
        {
            Click.On(driver, MercadoLibreUI.searchButton);
        }

        public static void FilterUsedItems(IWebDriver driver)
        {
            Click.On(driver, MercadoLibreUI.filterUsed);
        }

        public static void FilterNewItems(IWebDriver driver)
        {
            Click.On(driver, MercadoLibreUI.filterNew);
        }

        public static void VerifyCookies(IWebDriver driver)
        {
            if (MercadoLibreUI.cookiesButton != null)
            {
                Click.On(driver, MercadoLibreUI.cookiesButton);
            }
        }

        
    }
}
