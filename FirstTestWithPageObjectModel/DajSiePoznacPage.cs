using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestWithPageObjectModel
{
    public class DajSiePoznacPage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"http://devstyle.pl";

        [FindsBy(How = How.Name, Using = "s")] private IWebElement _searchText;
        [FindsBy(How = How.ClassName, Using = "search-button")] private IWebElement _searchButton;

        public DajSiePoznacPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver,this);
        }

        public static DajSiePoznacPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new DajSiePoznacPage(driver);
        }

        public string SearchText
        {
            set
            {
                _searchText.SendKeys(value);
            }
        }

        public SearchResultsPage SearchForText()
        {
            _searchButton.Click();

            return new SearchResultsPage(_driver);
        }

    }
}
