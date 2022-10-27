using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibre.UI
{
    class MercadoLibreUI
    {
        public static By country = By.Id("BO");
        public static By searchBar = By.Id("cb1-edit");
        public static By searchButton = By.ClassName("nav-search-btn");
        public static By filterUsed = By.XPath("//div/ul/li/a[@aria-label='Usado']/span[@class='ui-search-filter-results-qty shops__filter-results-qty']");
        public static By filterNew = By.XPath("//div/ul/li/a[@aria-label='Nuevo']/span[@class='ui-search-filter-results-qty shops__filter-results-qty']");
        public static By cookiesButton = By.ClassName("cookie-consent-banner-opt-out__action--key-accept");
        public static By resultsList = By.XPath("//section/ol/li");
    }
}
