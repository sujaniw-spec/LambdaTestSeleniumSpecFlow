Feature: ChromeBrowser2

![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](LambdaTestSeleniumSpecFlow/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@ToDoApp
Scenario Outline: Add items to the ToDoApp - Chrome
	Given I navigate to LambdaTest App on following environment
		| Browser   | BrowserVersion   | OS   |
		| <Browser> | <BrowserVersion> | <OS> |
	And I select the first item
	And I select the secod item
	And I enter the new value in textbox
	When I click the Submit button
	Then I verify whether the item is added to the list

	Examples:
	| Browser       | BrowserVersion | OS    |
	| chrome        | 113.0.5672.127 | WIN10 |
	
