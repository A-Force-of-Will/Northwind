Feature: Increment the counter by n
    This feature lets a user increment with a desired number on the counter by clicking on the button.

Scenario: Basic increment n scenario
    Given I am on the counter-n page
    When I set the increment number to 4
    When I click on the increment 20 times
    Then The counter should show "80".
