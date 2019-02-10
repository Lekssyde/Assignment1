using System;
using TechTalk.SpecFlow;
using TrainingcoG.PageObjects;

namespace TrainingcoG.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage Login;

        public LoginSteps()
        {
            Login = new LoginPage();
        }

        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            Login.ClickOnLogin();
        }

        [When(@"I enter myemail ""(.*)""")]
        public void WhenIEnterMyemail(string email)
        {
            Login.EnterMyEmail(email);
        }


        [When(@"I enter mypassword")]
        public void WhenIEnterMyPassword()
        {
            Login.EnterMyPassword();
        }

        [When(@"I click on secure sign in")]
        public void WhenIClickOnSecureSignIn()
        {
            Login.ClickOnSecureSignIn();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
