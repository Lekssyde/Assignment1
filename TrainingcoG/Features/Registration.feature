Feature: Registration
	As a user of the site
	I would like to register
	So that I can login to the site

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter last name
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password
	And I confirm password
	And I click on signup
	Then I should be registered