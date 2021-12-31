Feature: Increment the counter
    This feature lets a user increment the counter by clicking on the button.

Scenario: Basic increment scenario
    Given I am on the counter page
    When I click the increment button 19 times
    Then The counter should show an "19"
