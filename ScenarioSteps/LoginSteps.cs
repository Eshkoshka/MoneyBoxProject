namespace LoopUp.Webportal.UITests.ScenarioSteps
{
    using System;
    using System.Linq;
    using Coypu;
    using FluentAssertions;
    using LooUp.Webportal.UITests.PageObjectPages;
    using TechTalk.SpecFlow;

    [Binding]
    public class LoginSteps : IDisposable
    {
        private readonly LoginPage loginPage;

        public LoginSteps(LoginPage loginPage)
        {
            this.loginPage = loginPage;
        }

        [Given(@"I have navigated to the Account (.*) portal")]
        public void GivenIHaveNavigatedToTheAccountPortal(string addUrl)
        {
            this.loginPage.GoToPage(addUrl);
        }

        [Given(@"I have logged in with user '(.*)' and password '(.*)'")]
        [When(@"I log in with user '(.*)' and password '(.*)'")]
        public void GivenIHaveLoggedInWithUserAndPassword(string email, string pw)
        {
            this.GivenIHaveEnteredEmail(email);
            this.WhenIClickButton();
            this.GivenIHaveEnteredPassword(pw);
            this.WhenIClickButton();
        }

        [Given(@"I have entered email '(.*)'")]
        public void GivenIHaveEnteredEmail(string email)
        {
            this.loginPage.Email.SendKeys(email);
        }

        [Given(@"I have entered password '(.*)'")]
        public void GivenIHaveEnteredPassword(string pw)
        {
            this.loginPage.Password.SendKeys(pw);
        }

        [Given(@"I have clicked Submit button")]
        [When(@"I click Submit button")]
        public void WhenIClickButton()
        {
            this.loginPage.Submit.Click();
        }

        [Then(@"I am successfully logged in as '(.*)'")]
        public void ThenIAmSuccessfullyLoggedInAs(string username)
        {
            this.loginPage.UsernameAppBar.Text.Should().BeEquivalentTo(username, $"Login was unsuccessfull!");
        }

        [When(@"I sign out the user from the drop down menu")]
        public void WhenISignOutFromTheDropDownUserMenu()
        {
            this.loginPage.UsernameAppBar.Click();
            this.loginPage.SignOut.Click();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.loginPage.Dispose();
            }
        }
    }
}
