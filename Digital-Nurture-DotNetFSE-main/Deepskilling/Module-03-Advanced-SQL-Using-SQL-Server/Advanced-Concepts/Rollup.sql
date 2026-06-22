SELECT
    Course,
    Gender,
    COUNT(*) AS TotalStudents
FROM Students
GROUP BY ROLLUP(Course, Gender);
