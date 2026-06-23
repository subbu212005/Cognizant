# Views and Indexes

## Introduction

Views and Indexes are important database objects in SQL Server that help improve data accessibility, security, and query performance.

Views provide a virtual table based on SQL queries, while Indexes improve the speed of data retrieval operations.

---

## Introduction to Views

A View is a virtual table created from the result of a SQL query.

Views do not store data physically; they display data from underlying tables.

### Benefits of Views

* Simplify complex queries
* Improve security
* Enhance code reusability
* Provide logical data abstraction

---

## Creating Views

```sql
CREATE VIEW StudentView
AS
SELECT StudentID, StudentName, Marks
FROM Students;
```

---

## Modifying Views

```sql
ALTER VIEW StudentView
AS
SELECT StudentID, StudentName, Marks, Department
FROM Students;
```

---

## Dropping Views

```sql
DROP VIEW StudentView;
```

---

## Types of Views

### Simple View

Based on a single table.

### Complex View

Based on multiple tables.

### Indexed View

A view with a clustered index that stores data physically.

---

## Updating Views

```sql
UPDATE StudentView
SET Marks = 90
WHERE StudentID = 101;
```

---

## Indexed Views

Indexed Views improve query performance by storing the view data physically.

### Benefits

* Faster query execution
* Improved reporting performance
* Better aggregation performance

---

## Security and Views

Views can restrict access to specific rows and columns without exposing the underlying tables.

---

## Introduction to Indexes

An Index is a database object that improves data retrieval speed.

Indexes work similarly to a book index by helping SQL Server locate data quickly.

---

## Types of Indexes

### Clustered Index

Determines the physical order of data in a table.

### Non-Clustered Index

Stores a separate structure that points to the data.

### Unique Index

Ensures uniqueness of values.

### Composite Index

Created on multiple columns.

### Covering Index

Contains all columns required by a query.

---

## Creating Indexes

```sql
CREATE INDEX IX_StudentName
ON Students(StudentName);
```

---

## Modifying Indexes

Indexes can be rebuilt or reorganized to improve performance.

```sql
ALTER INDEX IX_StudentName
ON Students
REBUILD;
```

---

## Dropping Indexes

```sql
DROP INDEX IX_StudentName
ON Students;
```

---

## Covering Indexes

```sql
CREATE INDEX IX_StudentCover
ON Students(StudentName)
INCLUDE(Marks, Department);
```

---

## Index Fragmentation

Index fragmentation occurs when index pages become inefficiently organized.

### Solutions

* REBUILD Index
* REORGANIZE Index

---

## Indexing and Query Optimization

Proper indexing helps:

* Reduce query execution time
* Improve search performance
* Reduce disk I/O
* Improve scalability

---

## Learning Outcome

After completing this topic, I understood how Views and Indexes improve database security, maintainability, and query performance in SQL Server.

---

## Conclusion

Views simplify data access, while Indexes improve data retrieval performance. Together they play a critical role in efficient database design and optimization.

