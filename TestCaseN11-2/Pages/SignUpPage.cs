using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static TestCaseN11_2.Constans.ConstansMain;
namespace TestCaseN11_2.Pages
{
    class SignUpPage:Base.BasePage
    {
       
        public SignUpPage(IWebDriver webDriver): base(webDriver)
        {
        }

        public void SignUp(String name, String lastName, String email, String pass, String passAgain, String phone, String day, String month, String year)
        {   
           Click(SIGNUPBUTTON);
           SendKeys(FIRSTNAME , name);
           SendKeys(LASTNAME , lastName);
            SendKeys(EMAIL, email);
            SendKeys(PASSWORD, pass);
            SendKeys(REPASSWORD, passAgain);
            Click(PHONE);
            SendKeys(PHONE, phone);
            Click(GENDER);
            SendKeys(BIRTHDAY, day);
            SendKeys(BIRTHMONTH, month);
            SendKeys(BIRTHYEAR, year);
            Click(ACCEPTCONTRACT);
            Back();
        }
    }
}
