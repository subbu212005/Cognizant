# Exercise 1 – Ranking and Window Functions

## Objective

This exercise demonstrates how SQL Server Window Functions can be used to rank products within each category based on price.

## SQL Concepts Used

- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- OVER()
- PARTITION BY
- ORDER BY

## Files Included

- Query.sql
- Output-ROW_NUMBER.png
- Output-RANK.png
- Output-DENSE_RANK.png
- Output-Comparison.png

## What I Learned

- Used `PARTITION BY` to divide data into categories.
- Applied `ORDER BY` inside window functions to rank products by price.
- Understood the difference between `ROW_NUMBER()`, `RANK()`, and `DENSE_RANK()`.
- Retrieved the top three most expensive products from each category using ranking functions.

## Conclusion

Window functions provide an efficient way to rank, analyze, and compare records within groups without modifying the original data. They are widely used in reporting, analytics, and business intelligence queries.
