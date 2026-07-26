# Verification Query

```sql
-- Query the LogonAudit table to see captured logons
USE EmployeeManagementSystemTriggersDb;
SELECT * FROM LogonAudit;

-- Clean up: Drop the server logon trigger so it doesn't run permanently
USE master;
DROP TRIGGER trg_AuditLogon ON ALL SERVER;
```

### Expected Output
Rows in `LogonAudit` reflecting logins from your applications (including `sqlcmd`, SSMS, or other active connections).