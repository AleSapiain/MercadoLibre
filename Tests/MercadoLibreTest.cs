using MercadoLibre.Actions;
using MercadoLibre.Tasks;
using MercadoLibre.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibre.Tests
{
    [TestFixture]
    public class MercadoLibreTest : BaseTest
    {
        private List<String> searchString = new List<string> { "Console", "Laptop", "Iphone" };
        private int itemsMin = 3;

        [Test]
        public void LoadElements()
        {
            Assert.IsTrue(IsDisplayed.element(driver, MercadoLibreUI.country), "El país se encuentra disponible en la lista");
            RedirectTo.ToCountry(driver);
            Assert.IsTrue(IsDisplayed.element(driver, MercadoLibreUI.searchBar), "La barra de búsqueda es visible");

            RedirectTo.VerifyCookies(driver);
        }

        [Test]
        public void SearchUsedItems()
        {
            RedirectTo.ToCountry(driver);
            RedirectTo.VerifyCookies(driver);

            searchString.ForEach( item =>
            {
                SetCritery.sendCritery(driver, item);
                RedirectTo.Search(driver);
                RedirectTo.FilterUsedItems(driver);
                Assert.GreaterOrEqual(VerifyList.countElements(driver), itemsMin, "Existen mas de " + itemsMin + " " + item + "(s) usados(as) disponibles.");

                System.Threading.Thread.Sleep(2000);
            });
        }

        [Test]
        public void SearchNewItems()
        {
            RedirectTo.ToCountry(driver);
            RedirectTo.VerifyCookies(driver);

            searchString.ForEach(item =>
            {
                SetCritery.sendCritery(driver, item);
                RedirectTo.Search(driver);
                RedirectTo.FilterNewItems(driver);
                Assert.GreaterOrEqual(VerifyList.countElements(driver), itemsMin, "Existen mas de " + itemsMin + " " + item + "(s) nuevos(as) disponibles.");

                System.Threading.Thread.Sleep(2000);
            });
        }
    }
}
