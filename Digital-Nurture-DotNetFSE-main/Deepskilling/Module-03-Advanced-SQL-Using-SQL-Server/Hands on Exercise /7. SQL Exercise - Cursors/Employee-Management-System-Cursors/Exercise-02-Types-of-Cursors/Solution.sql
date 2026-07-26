-- SQL solution for Exercise-02-Types-of-Cursors
DECLARE @FirstName VARCHAR(50);
DECLARE @LastName VARCHAR(50);

DECLARE scroll_cursor CURSOR SCROLL FOR
SELECT FirstName, LastName FROM Employees;

OPEN scroll_cursor;

-- Fetch the first row
FETCH FIRST FROM scroll_cursor INTO @FirstName, @LastName;
PRINT 'First: ' + @FirstName + ' ' + @LastName;

-- Fetch the last row
FETCH LAST FROM scroll_cursor INTO @FirstName, @LastName;
PRINT 'Last: ' + @FirstName + ' ' + @LastName;

-- Fetch the prior row
FETCH PRIOR FROM scroll_cursor INTO @FirstName, @LastName;
PRINT 'Prior: ' + @FirstName + ' ' + @LastName;

-- Fetch absolute row 2
FETCH ABSOLUTE 2 FROM scroll_cursor INTO @FirstName, @LastName;
PRINT 'Absolute 2: ' + @FirstName + ' ' + @LastName;

CLOSE scroll_cursor;
DEALLOCATE scroll_cursor;
