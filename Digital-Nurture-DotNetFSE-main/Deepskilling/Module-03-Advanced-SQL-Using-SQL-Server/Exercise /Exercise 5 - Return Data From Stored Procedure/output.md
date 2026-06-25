# Output

## Screenshot

![Exercise05\_Output](output.png)

## Result

```text
EmployeeID  FirstName  LastName  DepartmentID  Salary
3           David      Brown     3             70000
4           Emma       Wilson    3             72000
```

The query successfully retrieved all employees belonging to **Department 3**.

## Observation

* Employee records were filtered based on the specified Department ID.
* The query returned only employees from the requested department.
* The logic can be reused to retrieve employees from any department by changing the department ID.

## Learning Outcome

Learned how Stored Procedures can be used to retrieve filtered data based on input parameters, improving code reusability and maintainability. In SQLite, an equivalent `SELECT` statement was used because Stored Procedures are not supported.

## Conclusion

This exercise demonstrated how parameterized queries (or Stored Procedures in SQL Server) can efficiently retrieve specific records while promoting reusable database logic.
