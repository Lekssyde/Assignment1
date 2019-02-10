Feature: Login
	So that I can use the site
	I need to login

@mytag
Scenario: Valid Login
	Given I navigate to the site
	When I click on login link
	And I enter myemail "test@giftrete.com"
	And I enter mypassword
	And I click on secure sign in
	Then I should be logged in