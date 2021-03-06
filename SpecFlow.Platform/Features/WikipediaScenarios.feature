﻿Feature: WikipediaScenarios
	These are scenarios on the Wikipedia

Background: 
	Given I navigate to the homepage

@Debug
Scenario: 01. Return click
	When I click the English link
	Then  I see the page title contains "Wikipedia, the free encyclopedia"

@Debug
Scenario: 02. Void click
  When I Open the language list
   Then I see the language list
   #Then I see
   #| expectedText |
   #| Azərbaycanca |
   #| Esperanto    |

 @Debug
 Scenario: 03. POM Navigation
  When I click the English link
  And I go to All Portal
  And I navigate to Community page
  When I go to Dashboard
  Then I see "Welcome to the Wikipedia Dashboard" in the PageSource
