﻿Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator2
	When I press add
	Then the result should be 120 on the screen

Scenario: Minus
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator2
	When I press minus
	Then the result should be 20 on the screen