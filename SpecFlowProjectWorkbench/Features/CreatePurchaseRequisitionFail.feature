Feature: CreatePurchaseRequisitionFail
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create PR Fail
	Given I login correctly
	And I input item
	When I click save
	Then I see the failure messages