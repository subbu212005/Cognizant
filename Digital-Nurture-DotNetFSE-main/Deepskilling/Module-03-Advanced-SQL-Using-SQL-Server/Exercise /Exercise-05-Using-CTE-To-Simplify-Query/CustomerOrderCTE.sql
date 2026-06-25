CREATE TABLE Customers
(
    CustomerID INTEGER PRIMARY KEY,
    CustomerName TEXT
);

INSERT INTO Customers VALUES
(1,'Rahul'),
(2,'Priya'),
(3,'Kiran');

-- Create Orders Table

DROP TABLE IF EXISTS Orders;

CREATE TABLE Orders
(
    OrderID INTEGER PRIMARY KEY,
    CustomerID INTEGER
);

INSERT INTO Orders VALUES
(101,1),
(102,1),
(103,1),
(104,1),
(105,2),
(106,2),
(107,3);

-- CTE Query

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
