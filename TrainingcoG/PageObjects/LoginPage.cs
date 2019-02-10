using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingcoG.Utilities;

namespace TrainingcoG.PageObjects
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement Myemail { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement securesignin { get; set; }

        public void ClickOnLogin()
        {
            login.Click();
        }

        public void EnterMyEmail(string email)
        {
            Myemail.SendKeys(email);
        }

        public void EnterMyPassword()
        {
            password.SendKeys("password");
        }

        public void ClickOnSecureSignIn()
        {
            securesignin.Click();
        }
    }
}
