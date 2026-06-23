# Exercise 1 - Ranking and Window Functions

## Objective

Implement SQL Server Window Functions to perform ranking and analytical operations on data.

## Concepts Used

* OVER()
* PARTITION BY
* ROW_NUMBER()
* RANK()
* DENSE_RANK()

## Description

Window functions perform calculations across a set of rows related to the current row without grouping the result set.

These functions are commonly used in reporting, analytics, and ranking scenarios.

## SQL Query

```sql
SELECT
    StudentID,
    StudentName,
    Marks,

    ROW_NUMBER() OVER(ORDER BY Marks DESC) AS RowNumber,

    RANK() OVER(ORDER BY Marks DESC) AS RankValue,

    DENSE_RANK() OVER(ORDER BY Marks DESC) AS DenseRankValue

FROM Students;
```

## Sample Output

| StudentID | StudentName | Marks | RowNumber | RankValue | DenseRankValue |
| --------- | ----------- | ----- | --------- | --------- | -------------- |
| 101       | Rahul       | 95    | 1         | 1         | 1              |
| 102       | Priya       | 90    | 2         | 2         | 2              |
| 103       | Kiran       | 90    | 3         | 2         | 2              |

## Observation

Window functions help perform ranking operations efficiently without modifying the underlying data.

## Learning Outcome

Learned how to use ROW_NUMBER(), RANK(), DENSE_RANK(), OVER(), and PARTITION BY for analytical queries.

