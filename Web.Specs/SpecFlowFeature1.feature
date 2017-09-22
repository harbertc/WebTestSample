@web
Feature: Test

Scenario: User Searches Google
	Given I navigate to 'http://www.google.com'
	Then the page title is 'Google'
