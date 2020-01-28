using FluentAssertions;
using LoopUpProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Coypu;

namespace LoopUpProject.ScenarioSteps
{
    [Binding]
    public class MeetingSteps
    {
        private MeetingPage _meetingPage;
        private IWebDriver driver;

        public MeetingSteps(MeetingPage meetingPage)
        {
            _meetingPage = meetingPage;
        }

        [Given(@"I have navigated to the LoopUp meeting")]
        public void GivenIHaveNavigatedToTheLoopUpMeeting()
        {
            _meetingPage.goToPage();

        }

        [Given(@"the fields have been cleared")]
        public void GivenTheFieldsHaveBeenCleared()
        {
            _meetingPage.Username.Clear();
            _meetingPage.CallNumber.Clear();
        }


        [When(@"I enter username '(.*)'")]
        public void WhenIEnterUsername(string name)
        {
            _meetingPage.Username.Clear();
            _meetingPage.Username.SendKeys(name);
        }


        [When(@"I enter the call number '(.*)'")]
        public void WhenIEnterTheCallNumber(string number)
        {
            _meetingPage.CallNumber.Clear();
            _meetingPage.CallNumber.SendKeys(number);
        }


        [When(@"I select Call me now")]
        public void WhenISelectCallMeNow()
        {
            _meetingPage.CallMeNow.Click();

        }


        [When(@"I select (.*) option from the coutry dropdown")]
        public void WhenISelectYourProfileFromTheDropDown(string value)
        {
            _meetingPage.SelectFromCountryMenu(value);
        }

        [Then(@"the user '(.*)' and number '(.*)' is displayed in the Call menu")]
        public void ThenTheUserIsDisplayedInTheCallMenu(string name, string number)
        {
            
            _meetingPage.LegName.Text.Should().BeEquivalentTo(name);

            _meetingPage.LegNumber.Text.Should().BeEquivalentTo(number);
        }

 
        [Then(@"an error message is displayed")]
        public void ThenAnErrorMessageIsDisplayed()
        {

            var errorField = _meetingPage.Error.Text;

            if (errorField == "Required")
            {
                _meetingPage.Error.Text.Should().Be("Required");
            }

            else
            {
                _meetingPage.Error.Text.Should().Be("Invalid");
            }
        }

        [Then(@"the '(.*)' error message is displayed")]
        public void ThenTheErrorMessageIsDisplayed(string error)
        {
            _meetingPage.NotConnectedError.Text.Should().BeEquivalentTo(error);
        }


    }

}
