using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;
namespace TestCaseN11_2.Pages
{
    class BasketPage : Base.BasePage
    {
        public BasketPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void DeleteBasket()
        {
            Click(GOBASKET);
            Click(DELETEPRODUCT);
            Click(LOGO);
        }
    }
}
