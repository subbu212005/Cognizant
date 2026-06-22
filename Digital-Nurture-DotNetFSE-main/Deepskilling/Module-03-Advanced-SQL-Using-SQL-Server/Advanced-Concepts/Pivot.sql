SELECT *
FROM
(
    SELECT StudentName, Course, Marks
    FROM Students
) AS SourceTable

PIVOT
(
    AVG(Marks)
    FOR Course IN ([CSE], [ECE], [EEE])
) AS PivotTable;
