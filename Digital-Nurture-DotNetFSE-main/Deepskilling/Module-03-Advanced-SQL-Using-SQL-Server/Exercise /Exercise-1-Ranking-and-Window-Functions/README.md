# Exercise 1 - Ranking and Window Functions

## Objective

Use SQL Server Window Functions to rank products within categories.

## Goal

Use ROW_NUMBER(), RANK(), DENSE_RANK(), OVER(), and PARTITION BY.

## Scenario

Find the top 3 most expensive products in each category using different ranking functions.

## Steps

1. Use ROW_NUMBER() to assign a unique rank within each category.
2. Use RANK() and DENSE_RANK() to compare how ties are handled.
3. Use PARTITION BY Category and ORDER BY Price DESC.

## Concepts Used

* ROW_NUMBER()
* RANK()
* DENSE_RANK()
* OVER()
* PARTITION BY

## Observation

The ranking functions successfully assigned ranks to products within each category. ROW_NUMBER() generated unique rankings, while RANK() and DENSE_RANK() handled tied values differently.

## Learning Outcome

Learned how to use ROW_NUMBER(), RANK(), DENSE_RANK(), OVER(), and PARTITION BY to perform ranking and analytical operations on grouped data.

## Conclusion

This exercise provided practical experience in applying SQL Server Window Functions for ranking and reporting operations in an online retail environment.
