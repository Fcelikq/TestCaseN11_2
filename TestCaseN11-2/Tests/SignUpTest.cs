using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestCaseN11_2.Pages;

namespace TestCaseN11_2.Tests
{
    class SignUpTest
    {
        static IWebDriver driver;
        SignUpPage signUpPage;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            signUpPage = new SignUpPage(driver);
            driver.Navigate().GoToUrl("https://www.n11.com/");
        }
        [Test]
        public void TestSignUp()
        {

            signUpPage.SignUp("firat", "celik", "celebiahmet5656@gmail.com", "deneme123", "deneme123", "078916207", "2", "ağustos", "1995");

        }
    }
}
