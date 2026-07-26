# Employee Management System – SQL Functions

## Overview

The **Employee Management System – SQL Functions** project demonstrates the creation and management of **User-Defined Functions (UDFs)** in SQL Server. It includes scalar functions, table-valued functions, nested functions, and function modification and deletion. These exercises help understand how functions improve code reusability and simplify complex SQL operations.

---

## Objectives

- Create scalar functions.
- Create table-valued functions.
- Create user-defined functions (UDFs).
- Modify existing functions.
- Delete functions.
- Execute scalar and table-valued functions.
- Return data using functions.
- Create nested functions.
- Improve database code reusability.

---

## Technologies Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Transact-SQL (T-SQL)

---

## Project Structure

```text
Employee-Management-System-Functions/
│
├── README.md
├── Database.sql
├── SampleData.sql
│
├── Exercise-01-Create-Scalar-Function
├── Exercise-02-Create-Table-Valued-Function
├── Exercise-03-Create-User-Defined-Function
├── Exercise-04-Modify-User-Defined-Function
├── Exercise-05-Delete-User-Defined-Function
├── Exercise-06-Execute-User-Defined-Function
├── Exercise-07-Return-Data-From-Scalar-Function
├── Exercise-08-Return-Data-From-Table-Valued-Function
├── Exercise-09-Create-Nested-User-Defined-Function
└── Exercise-10-Modify-Nested-User-Defined-Function
```

Each exercise folder contains:

- README.md
- Solution.sql
- Output.md
- ex.png (SSMS Output Screenshot)

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
| DepartmentID | INT | Foreign Key |
| Salary | DECIMAL(10,2) | Monthly Salary |
| JoinDate | DATE | Date of Joining |

---

## Exercises

### Exercise 01
Create a Scalar Function to calculate annual salary.

### Exercise 02
Create a Table-Valued Function to retrieve employees by department.

### Exercise 03
Create a User-Defined Function to calculate employee bonus.

### Exercise 04
Modify the User-Defined Function to change the bonus calculation.

### Exercise 05
Delete the User-Defined Function.

### Exercise 06
Execute the User-Defined Function.

### Exercise 07
Return data using the Scalar Function.

### Exercise 08
Return data using the Table-Valued Function.

### Exercise 09
Create a Nested User-Defined Function to calculate total compensation.

### Exercise 10
Modify the Nested User-Defined Function.

---

## Prerequisites

Before running the exercises, ensure that you have:

- SQL Server installed
- SQL Server Management Studio (SSMS)
- Basic knowledge of SQL and T-SQL

---

## How to Run

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

Open any exercise folder and execute:

```
Solution.sql
```

### Step 4

Verify the output and compare it with the expected results in **Output.md**.

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Create scalar functions.
- Create table-valued functions.
- Modify existing functions.
- Delete SQL functions.
- Execute user-defined functions.
- Build reusable database logic.
- Use nested functions effectively.
- Improve SQL code modularity and maintainability.

---

## Repository Contents

- Database Creation Script
- Sample Data Script
- 10 SQL Function Exercises
- Individual Solutions
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
