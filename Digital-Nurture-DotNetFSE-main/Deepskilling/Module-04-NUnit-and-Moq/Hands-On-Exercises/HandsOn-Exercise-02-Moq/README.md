# Hands-On Exercise 02 - Write Testable Code with Moq

## Objective

Understand mocking and dependency injection using the Moq framework.

## Concepts Covered

* Mock Objects
* Dependency Injection
* Constructor Injection
* Testable Code
* Isolation Testing
* State Based Testing
* Interaction Testing

## Scenario

The application sends emails to customers whenever a transaction occurs. Direct testing of email functionality is difficult because it depends on an SMTP server.

Using Moq, a mock implementation of the mail service is created so that unit tests can run without sending actual emails.

## Tools Used

* NUnit
* Moq
* Visual Studio
* C#

## Learning Outcome

Successfully mocked external dependencies and tested application behavior without using real SMTP services.
