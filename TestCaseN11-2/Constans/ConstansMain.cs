using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCaseN11_2.Constans
{
    class ConstansMain
    {
        //SignUp page
        public static By SIGNUPBUTTON = By.ClassName("btnSignUp");
        public static By FIRSTNAME = By.Id("firstName");
        public static By LASTNAME = By.Id("lastName");
        public static By EMAIL = By.Id("registrationEmail"); 
        public static By PASSWORD = By.Id("registrationPassword"); 
        public static By REPASSWORD = By.Id("passwordAgain");
        public static By PHONE = By.Id("phoneNumber");
        public static By GENDER = By.CssSelector(".genderArea");
        public static By BIRTHDAY = By.Id("birthDay");
        public static By BIRTHMONTH = By.Id("birthMonth");
        public static By BIRTHYEAR = By.Id("birthYear");
        public static By ACCEPTCONTRACT = By.ClassName("checkbox");
        //SignIn page
        public static By SIGNBUTTON = By.ClassName("btnSignIn");
        public static By USERNAME = By.Id("email");
        public static By LOGINPASSWORD = By.Id("password");
        public static By LOGINBUTTON = By.Id("loginButton");

        //Search page
        public static By SEARCH = By.Id("searchData");
        public static By SEARCHBUTTON = By.ClassName("icon");

        //filter page 
        public static By FILTERMODEL = By.CssSelector("input[data-iv='Apple iPhone 7']");
        public static By FILTERCOLOR= By.CssSelector("input[data-iv='Mavi']");
        public static By FILTERPOINT = By.CssSelector("input[data-point='4']");
        //add product page
        public static By GETPRODUCT = By.XPath("//ul[@class='clearfix']/li[1]/div/div/a");
        public static By  CLICKCOLOR= By.XPath("//select[@id='743859957']");
        public static By CHOSECOLOR = By.CssSelector("option[value='MOR']");
        public static By ADDBASKET = By.CssSelector(".btnAddBasket");
        //Add Product For main
        public static By CLICKCOLORFORMAIN = By.XPath("//select[@id='741149978']");
        public static By CHOSECOLORFORMAIN = By.CssSelector("option[value='Kırmızı']");
        public static By CLICKCAMPAIGN = By.XPath("//select[@id='437254642']");
        public static By CHOSECAMPAIGN = By.CssSelector("option[value='Kampanya Yeterli.Yararlanmak İstemiyorum']");
        //Basket page
        public static By GOBASKET = By.CssSelector(".iconBasket");
        public static By DELETEPRODUCT = By.CssSelector("span[title='Sil']");
        public static By LOGO = By.ClassName("logo");
    }
}
