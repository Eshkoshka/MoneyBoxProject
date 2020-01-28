using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace LoopUpProject.PageObject
{
    public class MeetingPage
    {

        private IWebDriver _driver;
        private string baseURL;
        public MeetingPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
            baseURL = ConfigurationManager.AppSettings["BaseURL"];
        }

        public void goToPage()
        {
            _driver.Navigate().GoToUrl(baseURL + "/8C1Vtk2");
        }


        [FindsBy(How = How.CssSelector, Using = "[data-test-id='join-card-name-input']")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[data-test-id='join-card-number-input']")]
        public IWebElement CallNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[data-test-id='join-card-call-button']")]
        public IWebElement CallMeNow { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//p[@class='text-input-error-msg small-6 columns']")]
        public IWebElement Error { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class='alert-box error']")]
        public IWebElement NotConnectedError { get; set; }

        [FindsBy(How = How.ClassName, Using = "country-selector-flag")]
        public IWebElement CountryFlag { get; set; }

        [FindsBy(How = How.ClassName, Using = "connecting-card")]
        public IWebElement ConnectingCard { get; set; }

        [FindsBy(How = How.ClassName, Using = "country-dropdown-wrapper")]
        public IList<IWebElement> CountryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='dropdown-country-label']")]
        public IList<IWebElement> CountryOption { get; set; }

        public void SelectFromCountryMenu(string menuOption)
        {
            CountryFlag.Click();
            CountryOption.ToList().First(option => option.Text == menuOption).Click();
        }

        [FindsBy(How = How.ClassName, Using = "leg-name-content")]
        public IWebElement LegName { get; set; }
        

        [FindsBy(How = How.CssSelector, Using = "[data-test-id='leg-subtitle']")]
        public IWebElement LegNumber { get; set; }

        [FindsBy(How = How.ClassName, Using = "card-table-cell")]
        public IWebElement LeavingMessage { get; set; }

        [FindsBy(How = How.CssSelector, Using = "[class='login']")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.ClassName, Using = "call-feedback-card")]
        public IWebElement Feedback { get; set; }      

        [FindsBy(How = How.CssSelector, Using = "[data-test-id='already-on-call']")]
        public IWebElement MeetingKey { get; set; }

    }

}

