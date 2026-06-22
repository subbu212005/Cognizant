SELECT
    StudentID,
    StudentName,
    Course,
    Marks,
    AVG(Marks) OVER(PARTITION BY Course) AS CourseAverage
FROM Students;
