CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,

    FOREIGN KEY (CustomerID)
    REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,

    FOREIGN KEY (OrderID)
    REFERENCES Orders(OrderID),

    FOREIGN KEY (ProductID)
    REFERENCES Products(ProductID)
);

-- ==========================================
-- Insert Sample Data
-- ==========================================

INSERT INTO Customers VALUES
(1,'Rahul','North'),
(2,'Priya','South'),
(3,'Kiran','East'),
(4,'Amit','West');

INSERT INTO Products VALUES
(101,'Laptop','Electronics'),
(102,'Mobile','Electronics'),
(103,'Chair','Furniture'),
(104,'Table','Furniture'),
(105,'Shoes','Sports');

INSERT INTO Orders VALUES
(1001,1,'2025-01-10'),
(1002,2,'2025-01-11'),
(1003,3,'2025-01-12'),
(1004,4,'2025-01-13');

INSERT INTO OrderDetails VALUES
(1,1001,101,5),
(2,1001,103,2),
(3,1002,102,4),
(4,1002,105,3),
(5,1003,101,6),
(6,1003,104,2),
(7,1004,105,7);

-- ==========================================
-- GROUPING SETS
-- ==========================================

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY GROUPING SETS
(
    (c.Region),
    (p.Category),
    (c.Region, p.Category)
);

-- ==========================================
-- ROLLUP
-- ==========================================

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY ROLLUP
(
    c.Region,
    p.Category
);

-- ==========================================
-- CUBE
-- ==========================================

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Orders o
INNER JOIN OrderDetails od
    ON o.OrderID = od.OrderID
INNER JOIN Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN Products p
    ON od.ProductID = p.ProductID
GROUP BY CUBE
(
    c.Region,
    p.Category
);
