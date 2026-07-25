# Employee Management System – Stored Procedures (SQL Server)

## Overview

This repository contains SQL Server stored procedure exercises for an Employee Management System. The project demonstrates how to create, modify, execute, and manage stored procedures using SQL Server Management Studio (SSMS). It also covers output parameters, transactions, dynamic SQL, conditional logic, and error handling.

---

## Objectives

- Learn how to create stored procedures.
- Modify existing stored procedures.
- Execute stored procedures with parameters.
- Delete stored procedures.
- Return values using output parameters.
- Implement conditional logic in stored procedures.
- Use transactions to maintain data integrity.
- Execute dynamic SQL within stored procedures.
- Handle errors using TRY...CATCH blocks.

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
├── Exercise-02-Modify-Stored-Procedure/
├── Exercise-03-Delete-Stored-Procedure/
├── Exercise-04-Execute-Stored-Procedure/
├── Exercise-05-Return-Data-From-Stored-Procedure/
├── Exercise-06-Output-Parameters/
├── Exercise-07-Update-Employee-Salary/
├── Exercise-08-Give-Bonus/
├── Exercise-09-Transactions/
├── Exercise-10-Dynamic-SQL/
└── Exercise-11-Error-Handling/
```

Each exercise folder contains:

- README.md
- Solution.sql
- Output.md
- Output.png

---

## Database Schema

### Departments

| Column | Data Type |
|---------|-----------|
| DepartmentID | INT (Primary Key) |
| DepartmentName | VARCHAR(100) |

### Employees

| Column | Data Type |
|---------|-----------|
| EmployeeID | INT (Primary Key) |
| FirstName | VARCHAR(50) |
| LastName | VARCHAR(50) |
| DepartmentID | INT (Foreign Key) |
| Salary | DECIMAL(10,2) |
| JoinDate | DATE |

---

## Exercises Included

### Exercise 1
Create a Stored Procedure

### Exercise 2
Modify a Stored Procedure

### Exercise 3
Delete a Stored Procedure

### Exercise 4
Execute a Stored Procedure

### Exercise 5
Return Data from a Stored Procedure

### Exercise 6
Use Output Parameters

### Exercise 7
Update Employee Salary

### Exercise 8
Stored Procedure with Conditional Logic

### Exercise 9
Transactions in Stored Procedures

### Exercise 10
Dynamic SQL in Stored Procedures

### Exercise 11
Error Handling using TRY...CATCH

---

## How to Execute

### Step 1

Execute:

```
Database.sql
```

### Step 2

Execute:

```
SampleData.sql
```

### Step 3

Open any exercise folder.

Execute:

```
Solution.sql
```

### Step 4

Verify the results in SQL Server Management Studio.

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Create stored procedures
- Modify stored procedures
- Execute procedures using parameters
- Delete stored procedures
- Use output parameters
- Implement conditional logic
- Work with transactions
- Use dynamic SQL
- Handle exceptions using TRY...CATCH
- Build reusable SQL Server database programs

---

## Author

**Y. Subrahmanyeswara**

B.Tech – Cyber Security

Vignan University

---

## License

This project is developed for educational and learning purposes.
