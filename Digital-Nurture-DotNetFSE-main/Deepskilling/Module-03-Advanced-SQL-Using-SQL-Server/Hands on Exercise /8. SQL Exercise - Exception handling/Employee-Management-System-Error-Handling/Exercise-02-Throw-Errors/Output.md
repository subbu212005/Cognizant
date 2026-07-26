### Expected Output for Exercise-02-Throw-Errors

When executing `sp_InsertEmployee` with a negative salary, the stored procedure validations trigger a custom `THROW` statement, returning:

| ErrorMessage | ErrorNumber | ErrorState |
| :--- | :--- | :--- |
| Salary must be a positive value. | 50001 | 1 |
