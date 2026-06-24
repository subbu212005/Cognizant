-- Create Products Table

DROP TABLE IF EXISTS Products;

CREATE TABLE Products
(
    ProductID INTEGER PRIMARY KEY,
    ProductName TEXT,
    Category TEXT,
    Price REAL
);

-- Insert Sample Data

INSERT INTO Products VALUES
(1,'Laptop','Electronics',1200),
(2,'Mobile','Electronics',800),
(3,'Tablet','Electronics',600),
(4,'Chair','Furniture',300),
(5,'Table','Furniture',450);

-- Create Index

CREATE INDEX IX_ProductName
ON Products(ProductName);

-- Search Query

SELECT
    ProductName,
    Category,
    Price
FROM Products
WHERE ProductName = 'Laptop';
