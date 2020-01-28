@UI
Feature: FundAllocations
	In order to see fund allocations
	As a moneybox user
	I want to be able switch between funds

Background: 
Given I have logged into the Moneybox as a TestUser1

Scenario Outline: Verify user can switch between allocations with different percentages
	Given I have navigated to Allocations page
	When I select the '<FundTab>' allocations tab
	Then I can see the percentage in the following order <first>, <second>, <third>
	
	Examples: 
	| FundTab     | first | second | third |
	| Cautious    | 85    | 10     | 5     |
	| Balanced    | 30    | 45     | 25    |
	| Adventurous | 5     | 60     | 35    |




