# Exercise 3 - CTEs and MERGE

## Objective

Use Common Table Expressions (CTEs), Recursive CTEs, and MERGE-like operations for data processing and synchronization.

## Goal

Generate a calendar table using a Recursive CTE and update product information from a staging table.

## Scenario

The Online Retail Store wants to:

* Generate a calendar table for January 2025.
* Update existing product prices.
* Insert new products from a staging table.

## Steps

1. Create a Recursive CTE to generate dates from 2025-01-01 to 2025-01-31.
2. Create a StagingProducts table.
3. Update existing product prices.
4. Insert new products that do not exist in the Products table.

## Concepts Used

* WITH Clause
* Common Table Expressions (CTE)
* Recursive CTE
* UPDATE
* INSERT

## Observation

The Recursive CTE successfully generated a sequence of dates. Product records were updated and inserted using separate UPDATE and INSERT operations.

## Learning Outcome

Learned how Recursive CTEs simplify sequence generation and how staging tables can be used to synchronize data.

## Conclusion

This exercise demonstrated practical usage of Recursive CTEs and data synchronization techniques in SQL.
