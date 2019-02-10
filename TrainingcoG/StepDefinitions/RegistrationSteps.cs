using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TrainingcoG.PageObjects;
using TrainingcoG.Utilities;

namespace TrainingcoG.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("https://www.giftrete.com/");
            Hooks.driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName();
        }
        
        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobileNumber();
        }

        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.EnterPassword();
        }

        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.EnterConfirmPassword();
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(30000);

            //NUnit Assertion
            Assert.IsTrue(registration.SuccessMessageIsDisplayed(), "Error Message: Registration failed");
                        
        }
    }
}
