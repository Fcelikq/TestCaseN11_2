﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestCaseN11_2.Base
{
    
    class BasePage
    {
        IWebDriver driver;
        WebDriverWait wait;
        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
       
        public IWebElement FindElement(By by){
            return driver.FindElement(by);
        }
        public void Back()
        {
            driver.Navigate().Back();
        }
        public void Forward()
        {
            driver.Navigate().Forward();
        }
        public void SendKeys(By by, String text)
        {
            FindElement(by).SendKeys(text);
        }
        public void Click(By by)
        {
            FindElement(by).Click();
        }
        public void HoverElement(By by)
        {
            IWebElement element;
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
