CREATE TRIGGER trg_InsteadOfDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN
    PRINT 'Delete Operation Blocked';
END;
