# Exercise 06: Update Computed Column Trigger

### Objective
Maintain an aggregated/computed column in a parent table using triggers. We will add a `TotalSalary` column to the `Departments` table, and write a trigger on the `Employees` table that keeps this total salary synchronized whenever employees are inserted, updated, or deleted.

### Steps
1. Add the column `TotalSalary DECIMAL(12,2) DEFAULT 0.00` to the `Departments` table.
2. Initialize existing values for `TotalSalary`.
3. Create the AFTER trigger `trg_UpdateDepartmentTotalSalary` on the `Employees` table.
4. Verify by inserting, updating, and deleting employees and checking the `TotalSalary` in `Departments`.
