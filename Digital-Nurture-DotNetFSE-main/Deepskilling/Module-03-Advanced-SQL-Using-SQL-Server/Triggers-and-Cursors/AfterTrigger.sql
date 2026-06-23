CREATE TRIGGER trg_AfterInsert
ON Students
AFTER INSERT
AS
BEGIN
    PRINT 'Student Record Inserted';
END;
