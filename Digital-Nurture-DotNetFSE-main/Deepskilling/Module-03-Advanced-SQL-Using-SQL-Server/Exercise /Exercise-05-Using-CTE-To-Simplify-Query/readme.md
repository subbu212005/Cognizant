# Exercise 5 - Using CTE to Simplify a Query

## Objective

Use Common Table Expressions (CTEs) to simplify complex SQL queries.

## Goal

Identify customers who have placed more than three orders.

## Scenario

The Online Retail Store wants to find loyal customers who have placed more than three orders in total.

## Steps

1. Create a CTE that counts the number of orders placed by each customer.
2. Join the CTE with the Customers table.
3. Filter customers having more than 3 orders.

## Concepts Used

* WITH Clause
* Common Table Expression (CTE)
* Aggregate Functions
* JOIN
* Filtering Data

## Observation

The CTE simplified the query structure by separating the order-counting logic from the main query.

## Learning Outcome

Learned how Common Table Expressions improve query readability, maintainability, and simplify complex SQL operations.

## Conclusion

CTEs provide a clean and efficient way to break complex queries into smaller logical parts, making SQL code easier to understand and maintain.
