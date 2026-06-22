WITH SemesterNumbers AS
(
    SELECT 1 AS Semester

    UNION ALL

    SELECT Semester + 1
    FROM SemesterNumbers
    WHERE Semester < 8
)
SELECT *
FROM SemesterNumbers;
