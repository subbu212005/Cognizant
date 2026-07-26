# Exercise 10 - Dynamic SQL in Stored Procedure

## Aim

To create a stored procedure that retrieves employee details using dynamic SQL.

---

## Objective

Create a stored procedure that accepts a filter column and filter value, builds a dynamic SQL query, and executes it using **sp_executesql**.

---

## Prerequisites

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Employee Management System Database

---

## Files

- Solution.sql
- Ex10.png

---

## Procedure

1. Open SQL Server Management Studio.
2. Create the stored procedure.
3. Accept the filter column and filter value as parameters.
4. Build the SQL query dynamically.
5. Execute the query using **sp_executesql**.
6. Verify the returned employee details.

---

## Expected Output

Employee records matching the specified filter are displayed successfully.

---

## Result

The stored procedure executed dynamic SQL and returned the expected employee details.

---

## Learning Outcome

- Learn Dynamic SQL.
- Execute SQL statements using **sp_executesql**.
- Build flexible database queries.
