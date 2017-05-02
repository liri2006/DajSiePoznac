using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestWithPageObjectModel
{
    public class SearchResultsPage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.CssSelector, Using = ".main-heading")]
        private IWebElement _mainHeading;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver; 

            PageFactory.InitElements(_driver, this);
        }

        public string MainHeading => _mainHeading.Text;
    }
}
