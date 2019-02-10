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
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passWord { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmpassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement SuccessMessage { get; set; }

        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName()
        {
            firstName.SendKeys("Lekan");
        }

        public void EnterLastName()
        {
            lastName.SendKeys("Elesho");
        }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void EnterMobileNumber()
        {
            mobileNumber.SendKeys("07745501234");
        }

        public void EnterPassword()
        {
            passWord.SendKeys("Password123");
        }

        public void EnterConfirmPassword()
        {
            confirmpassword.SendKeys("Password123");
        }

        public void ClickSignUp()
        {
            signUp.Click();
        }

        public Boolean SuccessMessageIsDisplayed()
        {
            try
            {
                return SuccessMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
