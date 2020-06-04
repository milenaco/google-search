using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleSearch.UITests.PageObjectModels;


namespace GoogleSearch.UITests
{
    
    public class GoogleSearchShould : IClassFixture<ChromeDriverFixture>
    {
        
        public readonly ChromeDriverFixture ChromeDriverFixture;
        public GoogleSearchShould(ChromeDriverFixture chromeDriverFixture)
        {
            ChromeDriverFixture = chromeDriverFixture;
        }

        [Fact]
        [Trait("Category","Smoke")]
        public void GoogleSearchResults()    
        {
           
            var mittoUrl = "https://www.mitto.ch/";

            var googlePage = new GooglePage(ChromeDriverFixture.Driver);

            googlePage.NavigateTo();           
            googlePage.Search("Mitto CH");
 
            Assert.Equal(mittoUrl, googlePage.FirstUrl());

            DemoHelper.Pause();   

        }


    }
}
