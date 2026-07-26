### Expected Output for Exercise-01-Basic-Try-Catch

When attempting to insert a duplicate department ID, the TRY block fails, and the CATCH block captures the error details:

| ErrorNumber | ErrorSeverity | ErrorState | ErrorProcedure | ErrorLine | ErrorMessage |
| :--- | :--- | :--- | :--- | :--- | :--- |
| 2627 | 14 | 1 | NULL | 6 | Violation of PRIMARY KEY constraint 'PK__Departme__B2079BCDAA8166F6'. Cannot insert duplicate key in object 'dbo.Departments'. The duplicate key value is (1). |
