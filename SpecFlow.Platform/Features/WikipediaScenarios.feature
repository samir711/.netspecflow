Feature: WikipediaScenarios
	These are scenarios on the Wikipedia

Background: 
	Given I navigate to the homepage

@Debug
Scenario: 01. Return click
	When I click the English link
	Then  I see the page tile contains "Wikipedia, the free encylopedia"


 