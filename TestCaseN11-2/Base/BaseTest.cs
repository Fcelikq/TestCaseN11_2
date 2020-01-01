using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace TestCaseN11_2.Base
{
    class BaseTest
    {
        IWebDriver driver;
        public BaseTest(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.n11.com/");
        }
    }
}
