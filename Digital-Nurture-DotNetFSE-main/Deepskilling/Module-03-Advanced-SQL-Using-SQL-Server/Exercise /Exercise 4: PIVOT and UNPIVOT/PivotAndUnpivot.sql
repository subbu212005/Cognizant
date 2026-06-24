-- =====================================
-- Create Sales Table
-- ====================================

CREATE TABLE Sales
(
    ProductName TEXT,
    MonthName TEXT,
    Quantity INTEGER
);

INSERT INTO Sales VALUES
('Laptop','January',10),
('Laptop','February',15),
('Laptop','March',20),

('Mobile','January',8),
('Mobile','February',12),
('Mobile','March',18);

-- =====================================
-- PIVOT (SQLite Alternative)
-- =====================================

SELECT
    ProductName,

    SUM(CASE
            WHEN MonthName='January'
            THEN Quantity
            ELSE 0
        END) AS January,

    SUM(CASE
            WHEN MonthName='February'
            THEN Quantity
            ELSE 0
        END) AS February,

    SUM(CASE
            WHEN MonthName='March'
            THEN Quantity
            ELSE 0
        END) AS March

FROM Sales
GROUP BY ProductName;

-- =====================================
-- UNPIVOT (SQLite Alternative)
-- =====================================

SELECT ProductName, MonthName, Quantity
FROM Sales
ORDER BY ProductName, MonthName;
