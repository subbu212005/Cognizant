USE CognizantDB;
GO

/*=========================================
Exercise 5 : Using CTE to Simplify a Query
=========================================*/

--------------------------------------------------
-- Insert Additional Orders
--------------------------------------------------

INSERT INTO Orders VALUES
(104,1,'2025-01-12'),
(105,1,'2025-01-15'),
(106,1,'2025-01-20');

--------------------------------------------------
-- CTE to Count Orders
--------------------------------------------------

WITH CustomerOrderCounts AS
(
    SELECT
        CustomerID,
        COUNT(OrderID) AS OrderCount
    FROM Orders
    GROUP BY CustomerID
)

SELECT
    c.CustomerID,
    c.CustomerName,
    coc.OrderCount
FROM CustomerOrderCounts coc
JOIN Customers c
ON c.CustomerID = coc.CustomerID
WHERE coc.OrderCount > 3;
