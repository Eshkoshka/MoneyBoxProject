namespace LooUp.Webportal.UITests.PageObjectPages
{
    using Coypu;
    using LoopUp.Webportal.UITests;
    using TechTalk.SpecFlow;

    [Binding]
    public class LoginPage : BasePage
    {
        public LoginPage(BrowserSessionManager browserSession)
            : base(browserSession)
        {
        }

        public ElementScope Email => this.BrowserSession.Browser.FindCss("[data-test-id='email']");

        public ElementScope Password => this.BrowserSession.Browser.FindCss("[data-test-id='password']");

        public ElementScope Submit => this.BrowserSession.Browser.FindCss("[data-test-id='submit']");

        public ElementScope UsernameAppBar => this.BrowserSession.Browser.FindXPath(".//div[@data-test-id='app-bar-large-name']");

        public ElementScope WelcomeBar => this.BrowserSession.Browser.FindXPath("//h2[@class='display-2 mt-1 welcome-bar-text handle-overflow']");

        public ElementScope SignOut => this.BrowserSession.Browser.FindXPath("//div[@role='listitem'][2]//div[@class='v-list__tile__content']//div[@data-test-id='app-bar-sign-out']");

        public void GoToPage(string addUrl)
        {
            this.BrowserSession.Browser.Visit(addUrl);
        }

        public bool GetPageUrl(string pageUrl)
        {
            return this.BrowserSession.Browser.Location.Equals(pageUrl);
        }
    }
}
