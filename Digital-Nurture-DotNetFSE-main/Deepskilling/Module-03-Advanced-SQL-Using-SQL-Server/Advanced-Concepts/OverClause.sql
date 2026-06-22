SELECT
    StudentID,
    StudentName,
    Marks,
    AVG(Marks) OVER() AS AverageMarks
FROM Students;
