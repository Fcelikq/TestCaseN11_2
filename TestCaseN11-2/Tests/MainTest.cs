using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestCaseN11_2.Pages;

namespace TestCaseN11_2
{
    public class MainTest
    {
        static IWebDriver driver;
        SignUpPage signUpPage;
        LoginPage loginPage;
        SearchPage searchPage;
        FilterPage filterPage;
        AddProductPage addProductPage;
        BasketPage basketPage;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            signUpPage = new SignUpPage(driver);
            loginPage = new LoginPage(driver);
            searchPage = new SearchPage(driver);
            filterPage = new FilterPage(driver);
            addProductPage = new AddProductPage(driver);
            basketPage = new BasketPage(driver);
            driver.Navigate().GoToUrl("https://www.n11.com/");
        }

        [Test]
        public void TestCaseN11()
        {
            signUpPage.SignUp("firat", "celik", "celebiahmet5656@gmail.com", "deneme123", "deneme123", "078916207", "2", "aðustos", "1995");
            loginPage.Login("kkazuya333@gmail.com", "deneme123");
            searchPage.Search("iphone");
            filterPage.Filter();
            addProductPage.AddProductForMain();
            basketPage.DeleteBasket();
        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}