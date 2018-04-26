@web
Feature: Test The Website Titles

Scenario: User Searches Yahoo
	Given I navigate to 'http://www.yahoo.com'
	Then the page title is 'Yahoo'


Scenario: User Searches Google
	Given I navigate to 'http://www.google.com'
	Then the page title is 'Google'

Scenario: User Goes to Appveyor
	Given I navigate to 'http://www.appveyor.com'
	Then the page title is "Continuous Integration and Deployment service for Windows developers | AppVeyor"

Scenario: User Checks Environment
	Then the environment is 'DEV'