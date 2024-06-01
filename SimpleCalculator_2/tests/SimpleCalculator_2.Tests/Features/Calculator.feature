Feature: Simple Calculator 
  In order to perform simple calculations 
  As a user 
  I want to add two numbers 
 
  Scenario: Add two numbers 
    Given the first number is 50 
    And the second number is 70 
    When the two numbers are added 
    Then the result should be 120 
