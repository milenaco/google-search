﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSearch.UITests
{
    public sealed class ChromeDriverFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        
        public ChromeDriverFixture()
        {
            Driver = new ChromeDriver();
        }
        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
