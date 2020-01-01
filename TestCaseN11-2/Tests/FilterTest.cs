
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestCaseN11_2.Pages;

namespace TestCaseN11_2.Tests
{
    class FilterTest
    {
        static IWebDriver driver;
        FilterPage filterPage;
        SearchPage searchPage;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            filterPage = new FilterPage(driver);
            searchPage = new SearchPage(driver);
            driver.Navigate().GoToUrl("https://www.n11.com/");
        }
        [Test]
        public void TestSignUp()
        {
            searchPage.Search("iphone");
            filterPage.Filter();

        }
    }
}
