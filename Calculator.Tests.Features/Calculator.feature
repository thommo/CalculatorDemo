Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered '<addend1>' into the calculator
	And I have entered '<addend2>' into the calculator
	When I press add
	Then the result should be '<result>'
	  And current value is '<result>'
Examples:
| addend1 | addend2 | result |
| 50      | 70      | 120    |
| -30     | 40      | 10     |

Scenario Outline: Divide two numbers
	Given I have entered '<dividend>' into the calculator
	And I have entered '<divisor>' into the calculator
	When I press divide
	Then the result should be '<result>'
Examples:
| dividend | divisor | result   | 
| 12       | 4       | 3        |
| 42       | 0       | Infinity |
| 0        | 0       | Nan      |
