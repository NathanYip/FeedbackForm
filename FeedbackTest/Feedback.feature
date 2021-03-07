Feature: FeedbackForm
	In order improve the user experience
	As a customer
	I want to be able to give my feedback

@mytag
Scenario: Submit a feedback form
	Given I am on the feedback form page 
	And I have entered my name Kandis M. Arwood
	And I have entered my address 4140 Franklin Street
	And I have entered my email KandisMArwood@rhyta.com
	And I have entered my comments Very imformative, i appreciate the help.
	When I press submit
	Then the form should say i have submitted my feedback

Scenario: Submit a feedback form without email 
	Given I am on the feedback form page 
	And I have entered my name Nicholas V. Miller
	And I have entered my address 4194 Turkey Pen Road
	And I have entered my comments Very imformative, i appreciate the help.
	When I press submit
	Then the form should say i have not entered a field
		
Scenario: Submit a feedback form without name
	Given I am on the feedback form page 
	And I have entered my address 254 Carter Street
	And I have entered my email DaleMIrby@jourrapide.com
	And I have entered my comments Very imformative, i appreciate the help.
	When I press submit
	Then the form should say i have not entered a field

Scenario: Submit a feedback form without address
	Given I am on the feedback form page 
	And I have entered my name Nicholas V. Miller
	And I have entered my email DaleMIrby@jourrapide.com
	And I have entered my comments Very imformative, i appreciate the help.
	When I press submit
	Then the form should say i have not entered a field

Scenario: Submit a feedback form without comment
	Given I am on the feedback form page 
	And I have entered my name Nicholas V. Miller
	And I have entered my address 254 Carter Street
	And I have entered my email DaleMIrby@jourrapide.com
	When I press submit
	Then the form should say i have not entered a field
