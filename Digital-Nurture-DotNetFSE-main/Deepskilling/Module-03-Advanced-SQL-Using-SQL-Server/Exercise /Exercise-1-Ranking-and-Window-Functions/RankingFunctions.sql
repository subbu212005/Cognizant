SELECT
    StudentID,
    StudentName,
    Marks,
    ROW_NUMBER() OVER(ORDER BY Marks DESC) AS RowNumber,
    RANK() OVER(ORDER BY Marks DESC) AS RankValue,
    DENSE_RANK() OVER(ORDER BY Marks DESC) AS DenseRankValue
FROM Students;
