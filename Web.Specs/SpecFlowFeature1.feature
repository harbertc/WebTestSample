@web
Feature: Test

Scenario: User Searches Yahoo
	Given I navigate to 'http://www.yahoo.com'
	Then the page title is 'Yahoo'


Scenario: User Searches Google
	Given I navigate to 'http://www.google.com'
	Then the page title is 'Google'
