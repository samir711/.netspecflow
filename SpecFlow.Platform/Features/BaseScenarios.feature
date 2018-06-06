Feature: BaseScenarios
	 These Scenarios can be used in any project

Background: 
Given I navigate to the homepage


@Chrome
Scenario: 01. Validate the title of website
	Then  I see the page title contains "Wikipedia"

@Chrome
Scenario: 02. Validate the Url of the website
	Then  I see the page Url contains "www.wikipedia.org"


@Chrome
Scenario: 03. Validate the PageSource string on the website
	Then  I see "The Free Encyclopedia" in the PageSource


@Chrome
Scenario: 04. Validate existence of multiple texts in PageSource
	Then  I see 
	| expectedText          |
	| The Free Encyclopedia |
	| Deutsch               |
	| Русский               |
	| 日本語                   |

