# Stored Procedures and User-Defined Functions

## Introduction

Stored Procedures and User-Defined Functions (UDFs) are database objects used to improve code reusability, maintainability, security, and performance in SQL Server.

They allow developers to encapsulate business logic and execute it whenever required.

---

## What is a Stored Procedure?

A Stored Procedure is a precompiled collection of SQL statements stored in the database and executed as a single unit.

### Benefits of Stored Procedures

* Code Reusability
* Improved Performance
* Better Security
* Easier Maintenance
* Reduced Network Traffic

### Types of Stored Procedures

#### User-Defined Stored Procedures

Created by users to perform specific tasks.

#### Temporary Stored Procedures

Exist temporarily and are automatically removed when the session ends.

#### System Stored Procedures

Provided by SQL Server for administrative tasks.

#### Extended Stored Procedures

Allow execution of external programs from SQL Server.

---

## Stored Procedure Operations

### Create a Stored Procedure

```sql
CREATE PROCEDURE GetStudents
AS
BEGIN
    SELECT * FROM Students;
END;
```

### Execute a Stored Procedure

```sql
EXEC GetStudents;
```

### Modify a Stored Procedure

```sql
ALTER PROCEDURE GetStudents
AS
BEGIN
    SELECT StudentID, StudentName
    FROM Students;
END;
```

### Delete a Stored Procedure

```sql
DROP PROCEDURE GetStudents;
```

### Parameters

Stored Procedures can accept parameters.

```sql
EXEC GetStudentById 101;
```

---

## What are Functions in SQL Server?

Functions are database objects that return a value or table and can be used within SQL queries.

### Benefits of User-Defined Functions

* Reusable Logic
* Improved Readability
* Better Maintainability
* Reduced Code Duplication

### Types of Functions

#### Scalar Functions

Return a single value.

#### Table-Valued Functions

Return a table.

#### System Functions

Built-in SQL Server functions.

#### Built-in Functions

Functions provided by SQL Server such as GETDATE(), LEN(), SUM(), AVG().

---

## User-Defined Function Operations

### Create Function

### Modify Function

### Delete Function

### Execute Function

---

## Learning Outcome

After completing this topic, I understood Stored Procedures, their types, parameters, execution methods, and User-Defined Functions including Scalar Functions and Table-Valued Functions in SQL Server.

---

## Conclusion

Stored Procedures and User-Defined Functions improve database performance, security, maintainability, and code reusability in SQL Server applications.

