# Exercise 3 – Recursive CTE and MERGE

## Objective

The objective of this exercise is to understand the use of Recursive Common Table Expressions (CTEs) for generating sequential data and the MERGE statement for synchronizing records between tables.

## SQL Concepts Used

- WITH
- Recursive CTE
- DATEADD()
- MERGE
- INSERT
- UPDATE

## Tasks Performed

- Created a recursive CTE to generate dates from 2025-01-01 to 2025-01-31.
- Created a StagingProducts table.
- Inserted sample records into the staging table.
- Used the MERGE statement to update existing products and insert new products into the Products table.

## Learning Outcomes

- Learned how recursive CTEs generate sequential datasets.
- Understood how the MERGE statement combines INSERT and UPDATE operations.
- Improved knowledge of SQL data synchronization techniques.
- Gained practical experience with data maintenance operations.

## Conclusion

Recursive CTEs simplify sequence generation, while MERGE provides an efficient approach for maintaining synchronized data between source and destination tables.
