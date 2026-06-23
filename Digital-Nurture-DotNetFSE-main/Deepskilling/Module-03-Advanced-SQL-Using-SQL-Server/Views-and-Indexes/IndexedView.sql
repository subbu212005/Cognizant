CREATE VIEW StudentMarksView
WITH SCHEMABINDING
AS
SELECT StudentID, Marks
FROM dbo.Students;
