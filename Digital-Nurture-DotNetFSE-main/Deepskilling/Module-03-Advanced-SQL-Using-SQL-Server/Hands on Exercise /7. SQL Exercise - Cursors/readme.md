# Employee Management System – SQL Server Cursors

## Overview

This project demonstrates the implementation of **Cursors** in Microsoft SQL Server. Cursors allow row-by-row processing of query results, making them useful for tasks that require sequential processing of records. The exercises in this repository cover cursor creation, execution, and the different cursor types available in SQL Server.

---

## Objectives

- Understand the concept of SQL Server cursors.
- Create and execute cursors.
- Fetch records one row at a time.
- Learn different cursor types.
- Compare the behavior of Static, Dynamic, Forward-Only, and Keyset-Driven cursors.

---

## Technologies Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Transact-SQL (T-SQL)

---

## Repository Structure

```text
Employee-Management-System-Cursors/
│
├── README.md
├── Database.sql
├── SampleData.sql
│
├── Exercise-01-Create-Cursor
└── Exercise-02-Types-of-Cursors
```

Each exercise folder contains:

- README.md
- Solution.sql
- Output.md
- ex1.png / ex2.png

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

### Exercise 1
Create a Cursor to iterate through employee records.

### Exercise 2
Understand and compare different SQL Server cursor types.

---

## Prerequisites

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Basic knowledge of SQL

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

Compare the results with **Output.md**.

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Create SQL Server cursors.
- Process records row by row.
- Fetch data using cursors.
- Understand different cursor types.
- Choose the appropriate cursor for various scenarios.

---

## Repository Contents

- Database Creation Script
- Sample Data Script
- Cursor Exercises
- SQL Solutions
- Output Documentation
- SSMS Screenshots

---

## Author

**Y. Subrahmanyeswara**

B.Tech – Cyber Security

Vignan University

---

## License

This project is created for educational and learning purposes.

