# Exercise 01 – Basic TRY...CATCH for Error Logging

## Objective

Create a stored procedure to insert employee details and log any errors using a TRY...CATCH block.

## Problem Statement

Implement a stored procedure named **AddEmployee** that inserts a new employee into the **Employees** table. If an error occurs (such as a duplicate email), catch the exception and record the error details in the **AuditLog** table.

## Files Included

- Solution.sql
- Output.md
- ex1.png

## Expected Output

The employee is inserted successfully, or the error is logged into **AuditLog**.

## Learning Outcome

- Use TRY...CATCH blocks.
- Log SQL Server errors.
- Improve database reliability.
