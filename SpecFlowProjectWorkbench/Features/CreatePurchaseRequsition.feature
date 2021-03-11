Feature: CreatePurchaseRequsition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create the purchase requisition
	Given I login correctly
	And I input items
	When I click save
	Then I save the PR