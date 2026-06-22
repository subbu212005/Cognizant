MERGE StudentBackup AS Target
USING Students AS Source
ON Target.StudentID = Source.StudentID

WHEN MATCHED THEN
    UPDATE SET Target.Marks = Source.Marks

WHEN NOT MATCHED THEN
    INSERT(StudentID, StudentName, Marks)
    VALUES(Source.StudentID, Source.StudentName, Source.Marks);
