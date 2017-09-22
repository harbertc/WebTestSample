@web
Feature: Test

Scenario: User Searches Yahoo
	Given I navigate to 'http://www.yahoo.com'
	Then the page title is 'Yahoo'


Scenario: User Searches Google
	Given I navigate to 'http://www.google.com'
	Then the page title is 'Google'

Scenario: User Goes to Github
	Given I navigate to 'http://www.github.com'
	Then the page title is "The world's leading software development platform · GitHub"

Scenario: User Goes to Appveyor
	Given I navigate to 'http://www.appveyor.com'
	Then the page title is "Continuous Integration and Deployment service for Windows developers | AppVeyor"