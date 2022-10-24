Feature: SnakeEatsFood

@mytag
Scenario: Eat food
	Given gameboard was created
	Then snake length should be 2
	When snake eats food
	Then snake length should be 3