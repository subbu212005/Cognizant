# Verification Query

```sql
-- Check if table trigger exists (should return 0 rows)
SELECT name, parent_class_desc 
FROM sys.triggers 
WHERE name = 'trg_AfterInsertEmployee';

-- Check if server trigger exists (should return 0 rows)
SELECT name 
FROM sys.server_triggers 
WHERE name = 'trg_AuditLogon';
```

### Expected Output
Both queries should return 0 rows, confirming the triggers were successfully deleted.