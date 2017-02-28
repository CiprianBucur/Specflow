Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Minus
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press minus
	Then the result should be -20 on the screen

Scenario: Adunare și scădere
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be -120 on the screen
	When I press minus
	Then the result should be -20 on the screen

Scenario Outline: parametri
	Given I have entered <a> into the calculator
	And I have entered <b> into the calculator
	When I press <operația>
	Then the result should be <rezultat> on the screen

	Examples: 
	| a | b  | operația | rezultat |
	| 3 | 5  | add      | 8        |
	| 7 | 4  | minus    | 3        |
	| 9 | -3 | add      | 6        |

Scenario: Afișare pe linie
	Given linie
	| Nume      | Prenume  | E-mail               |
	| "Popescu" | "Ion"    | "popescu@e-mail.com" |
	| "Dan"     | "Vasile" | "dan@e-mail.com"     |

Scenario: Afișare pe coloană
	Given coloană
	| Câmp    | Valoare           |
	| Nume    | "Gigel"           |
	| Prenume | "Nicu"            |
	| E-mail  | "nicu@e-mail.com" |
