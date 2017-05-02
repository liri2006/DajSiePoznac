using FirstTestWithPageObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    public class DajSiePoznacTests
    {
        private IWebDriver _driver;
        private DajSiePoznacPage _dajSiePoznacPage;
        private SearchResultsPage _searchResultsPage;


        [Test]
        public void DajSiePoznac()
        {
            {
                _driver = new ChromeDriver();
                _dajSiePoznacPage = DajSiePoznacPage.NavigateTo(_driver);
                _dajSiePoznacPage.SearchText = "Daj się poznać";
                _searchResultsPage = _dajSiePoznacPage.SearchForText();
                Assert.True(_searchResultsPage.MainHeading.Contains("SEARCH RESULTS: DAJ SIĘ POZNAĆ"));
            }
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Dispose();
        }

    }
}
