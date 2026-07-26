# Exercise-01-Create-Stored-Procedure
# Exercise 01 – Create Scalar Function

## Aim
To create and use a **Scalar-Valued Function** in SQL Server that calculates the annual salary of an employee based on their monthly salary.

---

## Objective
- Learn how to create a Scalar-Valued Function.
- Return a single value from a SQL function.
- Use the function in a `SELECT` statement.
- Display employee annual salaries.

---

## Software Requirements
- SQL Server 2019/2022 (or Express Edition)
- SQL Server Management Studio (SSMS) or SQLCMD
- EmployeeManagementDB Database

---

## Database Used
**EmployeeManagementDB**

---

## Function Created

```sql
CREATE FUNCTION fn_CalculateAnnualSalary
(
    @MonthlySalary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @MonthlySalary * 12;
END;
```

---

## Query Used

```sql
SELECT
    EmployeeID,
    FirstName,
    LastName,
    Salary,
    dbo.fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees;
```

---

## Sample Output

| EmployeeID | FirstName | LastName | Salary | AnnualSalary |
|------------|-----------|----------|--------|--------------|
| 1 | John | Doe | 5000.00 | 60000.00 |
| 2 | Jane | Smith | 6000.00 | 72000.00 |
| 3 | Bob | Johnson | 5500.00 | 66000.00 |

---

## Output Screenshot

Refer to **Output.png**.

---

## Note

If the script is executed more than once, SQL Server may display the following message:

```text
There is already an object named 'fn_CalculateAnnualSalary' in the database.
```

This occurs because the function already exists. To recreate it, first execute:

```sql
DROP FUNCTION IF EXISTS dbo.fn_CalculateAnnualSalary;
GO
```

Then execute the `CREATE FUNCTION` statement again.

---

## Result

The Scalar-Valued Function **fn_CalculateAnnualSalary** was created successfully and used to calculate the annual salary for each employee.
Objective: sp_InsertEmployee
<img width="1447" height="460" alt="ex1" src="https://github.com/user-attachments/assets/c5f8768a-f3d2-4189-99bd-3519816f6916" />


