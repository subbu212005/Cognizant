# Employee Management System – SQL Server Error Handling

## Overview

This project demonstrates **Error Handling in Microsoft SQL Server** using **TRY...CATCH**, **THROW**, **RAISERROR**, transactions, and audit logging. These exercises show how to build reliable database applications by handling exceptions, enforcing business rules, logging errors, and maintaining data integrity.

---

## Objectives

- Understand SQL Server error handling.
- Use TRY...CATCH blocks.
- Log errors into an audit table.
- Re-throw exceptions using THROW.
- Raise custom errors using RAISERROR.
- Implement nested TRY...CATCH blocks.
- Combine transactions with error handling.
- Control application behavior using severity and state.

---

## Technologies Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Transact-SQL (T-SQL)

---

## Repository Structure

```text
Employee-Management-System-Error-Handling/
│
├── README.md
├── Database.sql
├── SampleData.sql
│
├── Exercise-01-Basic-Try-Catch
├── Exercise-02-Throw-Errors
├── Exercise-03-Custom-Raiserror
├── Exercise-04-Nested-Try-Catch
├── Exercise-05-Transaction-Error-Logging
└── Exercise-06-Dynamic-Raiserror
```

Each exercise folder contains:

- README.md
- Solution.sql
- Output.md
- ex1.png / ex2.png / ... / ex6.png

---

## Database Schema

### Departments

| Column | Data Type | Description |
|---------|-----------|-------------|
| DepartmentID | INT | Primary Key |
| DepartmentName | VARCHAR(100) | Department Name |

### Employees

| Column | Data Type | Description |
|---------|-----------|-------------|
| EmployeeID | INT | Primary Key |
| FirstName | VARCHAR(50) | Employee First Name |
| LastName | VARCHAR(50) | Employee Last Name |
| Email | VARCHAR(100) | Unique Email |
| Salary | DECIMAL(10,2) | Monthly Salary |
| DepartmentID | INT | Foreign Key |

### AuditLog

| Column | Data Type | Description |
|---------|-----------|-------------|
| LogID | INT IDENTITY | Primary Key |
| Action | VARCHAR(100) | Performed Action |
| ErrorMessage | VARCHAR(4000) | Error Details |
| ActionDate | DATETIME | Log Timestamp |

---

## Exercises

### Exercise 1
Basic TRY...CATCH with Error Logging

### Exercise 2
Using THROW to Re-raise Errors

### Exercise 3
Custom Error with RAISERROR

### Exercise 4
Nested TRY...CATCH with RAISERROR

### Exercise 5
Logging Errors in Transactions

### Exercise 6
Dynamic RAISERROR using Severity and State

---

## Prerequisites

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Basic knowledge of SQL and T-SQL

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

Open the required exercise folder and execute:

```sql
Solution.sql
```

### Step 4

Compare the output with **Output.md** and capture the SSMS result in the corresponding screenshot file.

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Handle SQL Server exceptions.
- Log database errors.
- Use THROW to propagate exceptions.
- Create business rule validations using RAISERROR.
- Implement nested error handling.
- Maintain data consistency using transactions.
- Develop robust SQL Server applications.

---

## Repository Contents

- Database Creation Script
- Sample Data Script
- Six Error Handling Exercises
- SQL Solutions
- Output Documentation
- SSMS Output Screenshots

---

## Author

**Y. Subrahmanyeswara**

B.Tech – Cyber Security

Vignan University

---

## License

This project is created for educational and learning purposes.
