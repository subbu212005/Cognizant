# SQL Exercise 6 – Triggers

## Overview

This project demonstrates the implementation of **Triggers** in Microsoft SQL Server. Triggers are special stored procedures that automatically execute when specific database events such as **INSERT**, **UPDATE**, **DELETE**, or **LOGON** occur. They are commonly used to enforce business rules, maintain data integrity, audit changes, and automate database operations.

This repository contains hands-on exercises covering different types of SQL Server triggers, including AFTER triggers, INSTEAD OF triggers, LOGON triggers, trigger modification, trigger deletion, and computed column updates.

---

## Objectives

- Understand the concept of SQL Server triggers.
- Create AFTER triggers to audit data changes.
- Create INSTEAD OF triggers to control database operations.
- Create LOGON triggers to restrict database access.
- Modify existing triggers using SQL Server Management Studio (SSMS).
- Delete unnecessary triggers.
- Automatically update computed columns using triggers.

---

## Technologies Used

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Transact-SQL (T-SQL)

---

## Repository Structure

```text
Employee-Management-System-Triggers/
│
├── README.md
├── Database.sql
├── SampleData.sql
│
├── Exercise-01-Create-After-Trigger
├── Exercise-02-Create-Instead-Of-Trigger
├── Exercise-03-Create-Logon-Trigger
├── Exercise-04-Modify-Trigger
├── Exercise-05-Delete-Trigger
└── Exercise-06-Update-Computed-Column-Trigger
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
| DepartmentID | INT | Foreign Key |
| Salary | DECIMAL(10,2) | Monthly Salary |
| JoinDate | DATE | Date of Joining |

---

## Exercises

### Exercise 1
Create an AFTER Trigger to log salary updates.

### Exercise 2
Create an INSTEAD OF DELETE Trigger to prevent employee record deletion.

### Exercise 3
Create a LOGON Trigger to restrict access during maintenance hours.

### Exercise 4
Modify an existing trigger using SQL Server Management Studio (SSMS).

### Exercise 5
Delete an existing trigger.

### Exercise 6
Create a trigger to automatically update the AnnualSalary column whenever Salary changes.

---

## Prerequisites

Before running the exercises, ensure you have:

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

Navigate to the required exercise folder and execute:

```sql
Solution.sql
```

### Step 4

Verify the output using SSMS and compare it with **Output.md**.

---

## Learning Outcomes

After completing these exercises, you will be able to:

- Create and manage SQL Server triggers.
- Audit database changes using AFTER triggers.
- Prevent unwanted operations using INSTEAD OF triggers.
- Control database access using LOGON triggers.
- Modify and delete existing triggers.
- Maintain computed data automatically.
- Improve database integrity and automation using triggers.

---

## Repository Contents

- Database Creation Script
- Sample Data Script
- Six Trigger Exercises
- Individual SQL Solutions
- Expected Outputs
- SSMS Output Screenshots

---

## Author

**Y. Subrahmanyeswara**

B.Tech – Cyber Security

Vignan University

---

## License

This project is developed for educational and learning purposes.
