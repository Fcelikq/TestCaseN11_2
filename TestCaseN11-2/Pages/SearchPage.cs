using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;
namespace TestCaseN11_2.Pages
{
    class SearchPage:Base.BasePage
    {
        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void Search(String searchData)
        {
            SendKeys(SEARCH, searchData);
            Click(SEARCHBUTTON);
        }
    }
}
