USE EmployeeManagementSystemTriggersDb;
GO

-- Create the LogonAudit table
IF OBJECT_ID('LogonAudit', 'U') IS NULL
BEGIN
    CREATE TABLE LogonAudit (
        AuditID INT IDENTITY(1,1) PRIMARY KEY,
        LoginName VARCHAR(100),
        LoginTime DATETIME,
        AppName VARCHAR(256)
    );
END;
GO

-- Create LOGON trigger
USE master;
GO

CREATE OR ALTER TRIGGER trg_AuditLogon
ON ALL SERVER
FOR LOGON
AS
BEGIN
    BEGIN TRY
        -- Insert connection information safely using try-catch to avoid lockouts
        INSERT INTO EmployeeManagementSystemTriggersDb.dbo.LogonAudit (LoginName, LoginTime, AppName)
        VALUES (ORIGINAL_LOGIN(), GETDATE(), APP_NAME());
    END TRY
    BEGIN CATCH
        -- Do nothing, let the logon succeed even if logging fails
    END CATCH
END;
GO
