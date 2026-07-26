# Exercise 09 - Transactions in Stored Procedure

## Aim

To create a stored procedure that updates employee salary using transactions to ensure data integrity.

---

## Objective

Create a stored procedure that updates an employee's salary using **BEGIN TRANSACTION**, **COMMIT**, and **ROLLBACK**.

---

## Prerequisites

- Microsoft SQL Server
- SQL Server Management Studio (SSMS)
- Employee Management System Database

---

## Files

- Solution.sql
- Ex9.png

---

## Procedure

1. Open SQL Server Management Studio.
2. Connect to the Employee Management database.
3. Create the stored procedure.
4. Begin a transaction.
5. Update the employee salary.
6. Commit the transaction if successful.
7. Roll back the transaction if an error occurs.
8. Execute the stored procedure and verify the result.

---

## Expected Output

The employee salary is updated successfully. If an error occurs, the transaction is rolled back.

---

## Result

The stored procedure updated the employee salary while maintaining data integrity using transactions.

---

## Learning Outcome

- Understand SQL Server transactions.
- Learn COMMIT and ROLLBACK.
- Maintain database consistency.
