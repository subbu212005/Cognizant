SELECT StudentName, Course, Marks
FROM StudentReport

UNPIVOT
(
    Marks FOR Course IN
    ([CSE], [ECE], [EEE])
) AS UnpivotTable;
