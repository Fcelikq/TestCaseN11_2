using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;
namespace TestCaseN11_2.Pages
{
    class LoginPage : Base.BasePage
    {
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public void Login(String email, String pass) {
            Click(SIGNBUTTON);
            SendKeys(USERNAME, email);
            SendKeys(LOGINPASSWORD, pass);
            Click(LOGINBUTTON);
        } 
    }
}
