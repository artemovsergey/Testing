Feature: SimpleExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have a number: 50
	When I add 70 to the number
	Then my number should be 120