SELECT
    Course,
    Gender,
    COUNT(*) AS TotalStudents
FROM Students
GROUP BY GROUPING SETS
(
    (Course),
    (Gender),
    ()
);
