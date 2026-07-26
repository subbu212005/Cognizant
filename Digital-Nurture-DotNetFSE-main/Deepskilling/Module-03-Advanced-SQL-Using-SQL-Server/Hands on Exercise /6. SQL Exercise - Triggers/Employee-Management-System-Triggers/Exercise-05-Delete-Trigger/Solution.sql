-- Drop the table-level trigger if it exists
IF OBJECT_ID('trg_AfterInsertEmployee', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER trg_AfterInsertEmployee;
END;
GO

-- Drop the server-level trigger if it exists
IF EXISTS (SELECT 1 FROM sys.server_triggers WHERE name = 'trg_AuditLogon')
BEGIN
    DROP TRIGGER trg_AuditLogon ON ALL SERVER;
END;
GO
