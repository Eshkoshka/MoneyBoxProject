# MoneyBoxProject

# MoneyBoxProject
Please see below answers to QA tasks:

Task 1
The proportional amount taken from each fund would be 333,33.

Task 2
    1. Dan sold 500 + 5500 + 79 = 6079 orders
    
    2. 
      Select *
      From Orders
      Where Amount >= 1000;
   
   3.
      Select Orders.Amount
      From Customer Right Join Orders on Customer.ID = Orders.ID
      Where Customer.Name = 'Paul'
      And Customer.Surname = 'Brown';
    
    4. Since Dan is a salesperson, that information is not available from the current tables.

Task 3
    1. Bug01 - Sequence of fund is not displayed correctly
      Steps to reproduce:
      1. Login to money box 
      2. Navigate to Confirm allocations
      3. Compare the fund sequence with API response
    Expected: Sequence displayed matches sequence from Json file.
    Actual: Global shares fund is displayed 2nd, but should be 3rd.
      Property shares fund is displayed 3rd, but should be 2nd.

    Bug02 - Percentage displayed is not correctly calculated 
      Steps to reproduce:
      1. Login to money box 
      2. Navigate to Confirm allocations
      3. Compare the displayed percentage with the API response
    Expected: Precentage matches the displayed amount with Json file.
    Actual: 85% should be displayed as 8.5%,
      10% should be displayed as 1%,
      5% should be displayed as 0.5%.

    2. Test01 - Verify user can edit the fund allocations before selecting Confirm.
        Given I have logged in the moneybox app
        And I have navigated to Confirm Allocation screen	
        When I select the edit icon next to the graph
        And I make changes fro the allocation screen
        And I save the changes
        Then the changes have been displayed correctly

     Test02 - Verify the reponse time of the  View perfomance page 
        Given I have logged in the moneybox app
        And I have navigated to Confirm Allocation screen
        When I select View Perfomance button 	
        Then I can see the response in the dev console
        And response did not take longer than 0.1 seconds
    
3. See above project folders for the automation test (feature files, scenario steps and page object).
I have selected C# language, as I am not experienced with Ruby.
	
