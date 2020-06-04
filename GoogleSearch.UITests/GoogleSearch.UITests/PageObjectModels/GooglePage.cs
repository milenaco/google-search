using OpenQA.Selenium;
using System;

namespace GoogleSearch.UITests.PageObjectModels
{
    public class GooglePage
    {
        private readonly IWebDriver Driver;
        private const string PageUrl = "https://www.google.com/";

        public GooglePage(IWebDriver driver)
        {
            Driver = driver;
        }

        private IWebElement GetSearchInputField() => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));       
  
        private IWebElement GetFirstSearchResult() => Driver.FindElement(By.XPath("(//h3)[1]/../../a"));
 
        /// <summary>
        /// Navigate to the page
        /// </summary>
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            Driver.Manage().Window.Maximize();
            EnsurePageLoaded();
        }

        /// <summary>
        /// Perform search for provided url
        /// </summary>
        /// <param name="searchWord"></param>
        public void Search(string searchWord)
        {
            var searchInputField = this.GetSearchInputField();
            if(this.GetSearchInputField() != null)
            {
                searchInputField.SendKeys(searchWord);
                searchInputField.SendKeys(Keys.Enter);
            }
        }

        /// <summary>
        /// Returns First href element in search results
        /// </summary>
        /// <returns></returns>
        public string FirstUrl() => this.GetFirstSearchResult().GetAttribute("href");

        private void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == PageUrl);
            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page URL = '{ Driver.Url}' Page Source: \r\n { Driver.PageSource }");
            }
        }
    }
}
