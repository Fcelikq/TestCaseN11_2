using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;
namespace TestCaseN11_2.Pages
{
    class AddProductPage:Base.BasePage
    {
        public AddProductPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public void AddProduct()
        {
            Click(GETPRODUCT);
            Click(CLICKCOLOR);
            Click(CHOSECOLOR);
            Click(CLICKCOLOR);
            Click(ADDBASKET);
        }
        public void AddProductForMain()
        {
            Click(GETPRODUCT);
            Click(CLICKCOLORFORMAIN);
            Click(CHOSECOLORFORMAIN);
            Click(CLICKCOLORFORMAIN);
            Click(CLICKCAMPAIGN);
            Click(CHOSECAMPAIGN);
            Click(CLICKCAMPAIGN);
            Click(ADDBASKET);
        }
    }
}
