# Exercise 02: Create INSTEAD OF Trigger

### Objective
Create a database view `vw_EmployeeDetails` joining `Employees` and `Departments`. Then, write an `INSTEAD OF INSERT` trigger on the view to handle insertion logic across multiple tables.

### Steps
1. Create the view `vw_EmployeeDetails`.
2. Create the `trg_InsteadOfInsertEmployee` trigger on the view. This trigger checks if the specified department exists. If not, it inserts it into `Departments`, and then inserts the new employee record into `Employees`.
3. Verify by inserting a record into the view and checking both `Departments` and `Employees` tables.
