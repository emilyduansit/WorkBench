Feature: SubmitPRnReview
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Submit PR and Review
	Given I create PR successfully 
	And I submit the PR
	When I go to the Review Page
	Then I see the PR