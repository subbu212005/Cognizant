# Exercise 03: Create LOGON Trigger

### Objective
Create a server-level `LOGON` trigger that logs every connection attempt to a table `LogonAudit` in the database.

### WARNING
Logon triggers execute every time a login session is established. If the trigger code throws an error or cannot execute (e.g., if the target database or table is offline), **all** connections to the database server can get blocked, locking everyone out. Always write logon triggers with defensive logic or error handling, and ensure you have a dedicated administrator connection (DAC) or another session active to disable/drop the trigger if needed.

### Steps
1. Create the `LogonAudit` table in the database to store connection details.
2. Create the logon trigger `trg_AuditLogon` at the server level (`ON ALL SERVER`).
3. Verify by opening a new connection and querying the `LogonAudit` table.
4. Disable or drop the trigger to clean up.
