using System;

[Binding]
public class FundAllocationsSteps
{
    private readonly FundAllocationsPage fundAllocationsPage;

    public FundAllocationsSteps(FundAllocationsPage fundAllocationsPage)
    {
        this.fundAllocationsPage = fundAllocationsPage;
    }

    [Given(@"I have logged into the Moneybox as a TestUser1")]
    public void GivenIHaveNavigatedToTheAccountPortal(string addUrl)
    {
        this.fundAllocationsPage.goToPage(addUrl);
        this.fundAllocationsPage.Login.SendKeys("TestUser1");
        this.fundAllocationsPage.Password.SendKeys("Testpassword124");
        this.fundAllocationsPage.LoginButton.Click();
    }

    [Given(@"I have navigated to Allocations page")]
    public void GivenIHaveNavigatedToTheAccountPortal(string addUrl)
    {
        this.fundAllocationsPage.goToPage(addUrl);
    }

    [Given(@"I select the '(.*)' allocations tab")]
    public void GivenIHaveNavigatedToTheAccountPortal(string tab)
    {
        this.fundAllocationsPage.FundTab(tab).Click();
    }
        
    [Then(@"I can see the percentage in the following order (.*), (.*), (.*)")]
    public void ThenTheSentActionIsDisplayedForAllTheFollowingUsers(int first, int second, int third)
    {
        this.fundAllocationsPage.Percentage(first).Text.Should().Match(first);
        this.fundAllocationsPage.Percentage(second).Text.Should().Match(second);
        this.fundAllocationsPage.Percentage(third).Text.Should().Match(third);
    }
}
