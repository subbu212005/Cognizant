# Exercise 05 – Logging Errors in a Transaction

## Objective

Combine transactions with TRY...CATCH for reliable data insertion.

## Problem Statement

Create **BatchInsertEmployees** to insert multiple employee records inside a transaction. If any insert fails, roll back the transaction and record the error in **AuditLog**.

## Files Included

- Solution.sql
- Output.md
- ex5.png

## Expected Output

Either all employee records are inserted successfully, or none are inserted and the error is logged.

## Learning Outcome

- Use SQL Server transactions.
- Roll back failed operations.
- Log transaction errors.
