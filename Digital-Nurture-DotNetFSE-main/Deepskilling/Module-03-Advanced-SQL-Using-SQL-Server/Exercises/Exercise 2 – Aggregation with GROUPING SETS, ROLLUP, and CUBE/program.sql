USE CognizantDB;
GO

/*=========================================
    DROP TABLES (Correct Order)
=========================================*/

IF OBJECT_ID('OrderDetails','U') IS NOT NULL
    DROP TABLE OrderDetails;
GO

IF OBJECT_ID('Orders','U') IS NOT NULL
    DROP TABLE Orders;
GO

IF OBJECT_ID('Customers','U') IS NOT NULL
    DROP TABLE Customers;
GO

IF OBJECT_ID('Products','U') IS NOT NULL
    DROP TABLE Products;
GO

/*=========================================
    CREATE TABLES
=========================================*/

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY(CustomerID)
    REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY(OrderID)
    REFERENCES Orders(OrderID),
    FOREIGN KEY(ProductID)
    REFERENCES Products(ProductID)
);

/*=========================================
    INSERT PRODUCTS
=========================================*/

INSERT INTO Products VALUES
(1,'Laptop A','Electronics',800.00),
(2,'Laptop B','Electronics',1200.00),
(3,'Laptop C','Electronics',1200.00),
(4,'Mouse','Electronics',50.00),
(5,'Office Chair','Furniture',300.00),
(6,'Dining Table','Furniture',700.00),
(7,'Sofa','Furniture',700.00),
(8,'Bookshelf','Furniture',450.00);

/*=========================================
    INSERT CUSTOMERS
=========================================*/

INSERT INTO Customers VALUES
(1,'John','East'),
(2,'Alice','West'),
(3,'David','North');

/*=========================================
    INSERT ORDERS
=========================================*/

INSERT INTO Orders VALUES
(101,1,'2025-01-02'),
(102,2,'2025-01-05'),
(103,3,'2025-01-10');

/*=========================================
    INSERT ORDER DETAILS
=========================================*/

INSERT INTO OrderDetails VALUES
(1,101,2,5),
(2,101,6,2),
(3,102,3,4),
(4,102,8,6),
(5,103,7,3),
(6,103,1,2);

/*=========================================
    DISPLAY TABLES
=========================================*/

SELECT * FROM Products;
SELECT * FROM Customers;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;

/*=========================================
    GROUPING SETS
=========================================*/

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Customers c
JOIN Orders o
ON c.CustomerID=o.CustomerID
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
GROUP BY GROUPING SETS
(
    (c.Region,p.Category),
    (c.Region),
    (p.Category)
)
ORDER BY Region,Category;

/*=========================================
    ROLLUP
=========================================*/

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Customers c
JOIN Orders o
ON c.CustomerID=o.CustomerID
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
GROUP BY ROLLUP
(
    c.Region,
    p.Category
)
ORDER BY Region,Category;

/*=========================================
    CUBE
=========================================*/

SELECT
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM Customers c
JOIN Orders o
ON c.CustomerID=o.CustomerID
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
GROUP BY CUBE
(
    c.Region,
    p.Category
)
ORDER BY Region,Category;
