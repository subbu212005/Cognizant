-- ==========================================
-- Create Products Table
-- ==========================================

DROP TABLE IF EXISTS Products;

CREATE TABLE Products
(
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Price REAL
);

INSERT INTO Products VALUES
(1,'Laptop',1200),
(2,'Mobile',800),
(3,'Tablet',600);

-- ==========================================
-- Recursive CTE
-- Generate Dates from
-- 2025-01-01 to 2025-01-31
-- ==========================================

WITH RECURSIVE CalendarDates AS
(
    SELECT DATE('2025-01-01') AS CalendarDate

    UNION ALL

    SELECT DATE(CalendarDate,'+1 day')
    FROM CalendarDates
    WHERE CalendarDate < '2025-01-31'
)

SELECT *
FROM CalendarDates;

-- ==========================================
-- Create Staging Table
-- ==========================================

DROP TABLE IF EXISTS StagingProducts;

CREATE TABLE StagingProducts
(
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Price REAL
);

INSERT INTO StagingProducts VALUES
(1,'Laptop',1300),
(2,'Mobile',850),
(4,'Smart Watch',500);

-- ==========================================
-- Update Existing Products
-- ==========================================

UPDATE Products
SET Price =
(
    SELECT Price
    FROM StagingProducts
    WHERE StagingProducts.ProductID = Products.ProductID
)
WHERE ProductID IN
(
    SELECT ProductID
    FROM StagingProducts
);

-- ==========================================
-- Insert New Products
-- ==========================================

INSERT INTO Products
(
    ProductID,
    ProductName,
    Price
)
SELECT
    ProductID,
    ProductName,
    Price
FROM StagingProducts
WHERE ProductID NOT IN
(
    SELECT ProductID
    FROM Products
);

-- ==========================================
-- Final Result
-- ==========================================

SELECT *
FROM Products;
