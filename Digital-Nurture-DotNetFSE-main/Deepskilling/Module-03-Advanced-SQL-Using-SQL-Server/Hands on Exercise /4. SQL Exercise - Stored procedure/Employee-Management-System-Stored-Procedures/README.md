# Employee Management System - Stored Procedures

## Overview

This repository contains SQL Server stored procedure exercises for an Employee Management System. The project demonstrates how to create, modify, execute, and manage stored procedures using SQL Server Management Studio (SSMS). It covers parameterized stored procedures, output parameters, conditional logic, transactions, dynamic SQL, and error handling.

---

## Objectives

- Create stored procedures.
- Modify existing stored procedures.
- Delete stored procedures.
- Execute stored procedures using parameters.
- Return values using output parameters.
- Update employee records.
- Apply conditional logic in stored procedures.
- Use transactions to maintain data integrity.
- Execute dynamic SQL.
- Handle exceptions using TRY...CATCH.

---

## Technologies Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Transact-SQL (T-SQL)

---

## Project Structure

```text
Employee-Management-System-Stored-Procedures/
│
├── README.md
├── Database.sql
├── SampleData.sql
│
├── Exercise-01-Create-Stored-Procedure/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex1.png
│
├── Exercise-02-Modify-Stored-Procedure/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex2.png
│
├── Exercise-03-Delete-Stored-Procedure/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex3.png
│
├── Exercise-04-Execute-Stored-Procedure/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex4.png
│
├── Exercise-05-Return-Data-From-Stored-Procedure/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex5.png
│
├── Exercise-06-Output-Parameters/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex6.png
│
├── Exercise-07-Update-Employee-Salary/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex7.png
│
├── Exercise-08-Give-Bonus/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex8.png
│
├── Exercise-09-Transactions/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex9.png
│
├── Exercise-10-Dynamic-SQL/
│   ├── README.md
│   ├── Solution.sql
│   └── Ex10.png
│
└── Exercise-11-Error-Handling/
    ├── README.md
    ├── Solution.sql
    └── Ex11.png
```

---

## Database Schema

### Departments Table

| Column | Data Type | Description |
|--------|-----------|-------------|
| DepartmentID | INT (Primary Key) | Unique Department ID |
| DepartmentName | VARCHAR(100) | Department Name |

### Employees Table

| Column | Data Type | Description |
|--------|-----------|-------------|
| EmployeeID | INT (Primary Key) | Unique Employee ID |
| FirstName | VARCHAR(50) | Employee First Name |
| LastName | VARCHAR(50) | Employee Last Name |
| DepartmentID | INT (Foreign Key) | References Departments Table |
| Salary | DECIMAL(10,2) | Monthly Salary |
| JoinDate | DATE | Employee Joining Date |

---

## Exercises Included

| Exercise | Description |
|----------|-------------|
| Exercise 01 | Create a Stored Procedure |
| Exercise 02 | Modify a Stored Procedure |
| Exercise 03 | Delete a Stored Procedure |
| Exercise 04 | Execute a Stored Procedure |
| Exercise 05 | Return Data from a Stored Procedure |
| Exercise 06 | Use Output Parameters |
| Exercise 07 | Update Employee Salary |
| Exercise 08 | Stored Procedure with Conditional Logic |
| Exercise 09 | Transactions in Stored Procedures |
| Exercise 10 | Dynamic SQL in Stored Procedures |
| Exercise 11 | Error Handling using TRY...CATCH |

---

## How to Run

### Step 1

Execute:

```sql
Database.sql
```

### Step 2

Execute:

```sql
SampleData.sql
```

### Step 3

Open the required exercise folder.

Execute:

```sql
Solution.sql
```

### Step 4

Verify the output in SQL Server Management Studio (SSMS).

---

## Learning Outcomes

After completing this project, you will be able to:

- Create parameterized stored procedures.
- Modify and delete stored procedures.
- Execute stored procedures with input parameters.
- Use output parameters.
- Update and retrieve employee records.
- Apply conditional logic.
- Use transactions for data consistency.
- Execute dynamic SQL queries.
- Handle runtime errors using TRY...CATCH.
- Develop reusable database programs in SQL Server.

---

## Prerequisites

- Microsoft SQL Server 2019 or later
- SQL Server Management Studio (SSMS)
- Basic knowledge of SQL and T-SQL

---

## Author

**Y. Subrahmanyeswara**

B.Tech – Cyber Security

Vignan University

---

## License

This project is created for educational and learning purposes.
