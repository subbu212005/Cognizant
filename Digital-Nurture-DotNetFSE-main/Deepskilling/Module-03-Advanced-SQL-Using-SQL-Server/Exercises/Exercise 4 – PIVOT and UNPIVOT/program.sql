USE CognizantDB;
GO

/*=========================================
Exercise 4 : PIVOT and UNPIVOT
=========================================*/

--------------------------------------------------
-- Step 1 : Aggregate Sales by Product and Month
--------------------------------------------------

SELECT
    p.ProductName,
    DATENAME(MONTH,o.OrderDate) AS SalesMonth,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
JOIN OrderDetails od
ON o.OrderID = od.OrderID
JOIN Products p
ON od.ProductID = p.ProductID
GROUP BY
p.ProductName,
DATENAME(MONTH,o.OrderDate);

--------------------------------------------------
-- Step 2 : PIVOT
--------------------------------------------------

SELECT *
FROM
(
    SELECT
        p.ProductName,
        DATENAME(MONTH,o.OrderDate) AS SalesMonth,
        od.Quantity
    FROM Orders o
    JOIN OrderDetails od
    ON o.OrderID=od.OrderID
    JOIN Products p
    ON od.ProductID=p.ProductID
) AS SourceTable

PIVOT
(
    SUM(Quantity)
    FOR SalesMonth IN
    ([January],[February],[March],[April],
     [May],[June],[July],[August],
     [September],[October],[November],[December])
) AS PivotTable;

--------------------------------------------------
-- Step 3 : UNPIVOT
--------------------------------------------------

SELECT
ProductName,
SalesMonth,
Quantity

FROM
(
SELECT *
FROM
(
    SELECT
        p.ProductName,
        DATENAME(MONTH,o.OrderDate) AS SalesMonth,
        od.Quantity
    FROM Orders o
    JOIN OrderDetails od
    ON o.OrderID=od.OrderID
    JOIN Products p
    ON od.ProductID=p.ProductID
) AS SourceTable

PIVOT
(
SUM(Quantity)
FOR SalesMonth IN
(
[January],[February],[March],[April],
[May],[June],[July],[August],
[September],[October],[November],[December]
)
) AS PivotTable

) AS PivotResult

UNPIVOT
(
Quantity
FOR SalesMonth IN
(
[January],[February],[March],[April],
[May],[June],[July],[August],
[September],[October],[November],[December]
)
) AS UnpivotTable

WHERE Quantity IS NOT NULL

ORDER BY ProductName;
