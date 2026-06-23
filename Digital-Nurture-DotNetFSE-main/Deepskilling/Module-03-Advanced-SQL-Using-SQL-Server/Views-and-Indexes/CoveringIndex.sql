CREATE INDEX IX_StudentCover
ON Students(StudentName)
INCLUDE(Marks, Department);
