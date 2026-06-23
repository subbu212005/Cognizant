# Exercise 2 - SQL Index Hands-On

## Objective

Implement Indexes in SQL Server to improve query performance and data retrieval speed.

## Concepts Used

* Clustered Index
* Non-Clustered Index
* Covering Index
* Query Optimization

## Description

Indexes help SQL Server locate data quickly without scanning the entire table.

They improve query execution time and overall database performance.

## SQL Query

```sql
CREATE INDEX IX_StudentName
ON Students(StudentName);
```

## Covering Index Example

```sql
CREATE INDEX IX_StudentCover
ON Students(StudentName)
INCLUDE(Marks, Department);
```

## Observation

Indexes significantly reduce query execution time when searching or filtering large datasets.

## Learning Outcome

Learned how indexes improve SQL Server performance and support efficient query optimization.
