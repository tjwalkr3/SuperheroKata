Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given I have a Calculator
	And the first number is 50
	And the next number is 70
	When the two numbers are added
	Then the result should be 120