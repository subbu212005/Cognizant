# Exercise 04 – Nested TRY...CATCH with RAISERROR

## Objective

Implement nested TRY...CATCH blocks for department transfer.

## Problem Statement

Create a stored procedure named **TransferEmployee**. If the target department does not exist, raise a custom error, log it, and re-throw the exception using nested TRY...CATCH blocks.

## Files Included

- Solution.sql
- Output.md
- ex4.png

## Expected Output

The error is logged and the transfer is cancelled.

## Learning Outcome

- Implement nested error handling.
- Use RAISERROR with TRY...CATCH.
- Control execution flow.
