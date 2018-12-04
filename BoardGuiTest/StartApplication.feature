Feature: StartApplication
	In order to avoid start problems
	As a program user
	I want to test that starting works

Scenario: Start Application
	When I start the application
	Then the screen should show a new sudoku field
