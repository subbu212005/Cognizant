SELECT StudentID,
       StudentName,
       ROW_NUMBER() OVER(ORDER BY StudentID) AS RowNum
FROM Students;
