CREATE INDEX IX_StudentName
ON Students(StudentName);

CREATE INDEX IX_StudentCover
ON Students(StudentName)
INCLUDE(Marks, Department);
