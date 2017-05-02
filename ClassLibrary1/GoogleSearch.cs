using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Automation
{
    class GoogleSuggest
    {
        static void Main(string[] args)
        {

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://www.google.com/");
                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("Ser");
                query.SendKeys(Keys.Return);
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Title.StartsWith("ser", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("Page title is: " + driver.Title);
            }
        }
    }

}


