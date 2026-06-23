DECLARE @StudentName VARCHAR(50);

DECLARE StudentCursor CURSOR FOR
SELECT StudentName
FROM Students;

OPEN StudentCursor;

FETCH NEXT FROM StudentCursor INTO @StudentName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @StudentName;

    FETCH NEXT FROM StudentCursor INTO @StudentName;
END;

CLOSE StudentCursor;
DEALLOCATE StudentCursor;
