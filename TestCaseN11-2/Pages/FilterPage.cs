using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;

namespace TestCaseN11_2.Pages
{
    class FilterPage : Base.BasePage
    {
        public FilterPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void Filter()
        {
            Click(FILTERMODEL);
            Click(FILTERCOLOR);
            Click(FILTERPOINT);
        }
    }
}
