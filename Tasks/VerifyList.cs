using MercadoLibre.Actions;
using MercadoLibre.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoLibre.Tasks
{
    class VerifyList
    {
        public static int countElements(IWebDriver driver)
        {
            return Count.resultItems(driver, MercadoLibreUI.resultsList);
        }
    }
}
