# Exercise 11 Output

`sql
EXEC sp_UpdateSalaryWithErrorHandling 99, 6000.00;
EXEC sp_UpdateSalaryWithErrorHandling 1, -100.00;
`

Expected Error Output:
`
Msg 50000, Level 16, State 1, Server ROLEX, Procedure sp_UpdateSalaryWithErrorHandling, Line 28
Employee does not exist.

Msg 50000, Level 16, State 1, Server ROLEX, Procedure sp_UpdateSalaryWithErrorHandling, Line 28
Salary cannot be negative.
`
