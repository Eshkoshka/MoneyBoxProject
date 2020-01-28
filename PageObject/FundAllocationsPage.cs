using System;

public class FundAllocationsPage
{

    public FundAllocationsPage(BrowserSessionManager browserSession)
    : base(browserSession)
    {
    }

    public ElementScope Login => this.BrowserSession.Browser.FindCss("[data-test-id='Login']");

    public ElementScope Password => this.BrowserSession.Browser.FindCss("[data-test-id='password']");

    public ElementScope LoginButton => this.BrowserSession.Browser.FindCss("[data-test-id='LoginButton']");

    public ElementScope FundTab(string fundTabName) => this.BrowserSession.Browser.FindXPath($".//div[@text='{fundTabName}']");

    public void goToPage(string url)
    {
        this.browserSession.Navigate().GoToUrl(url);
    }

}
