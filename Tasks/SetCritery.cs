using MercadoLibre.Actions;
using MercadoLibre.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoLibre.Tasks
{
    class SetCritery
    {
        public static void sendCritery(IWebDriver driver, string critery)
        {
            Text.Clean(driver, MercadoLibreUI.searchBar);
            Text.Set(driver, MercadoLibreUI.searchBar, critery);
        }
    }
}
