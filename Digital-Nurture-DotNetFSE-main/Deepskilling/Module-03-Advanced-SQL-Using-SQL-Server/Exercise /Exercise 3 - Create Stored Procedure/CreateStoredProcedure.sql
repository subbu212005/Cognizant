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

-- Equivalent operation of Stored Procedure

SELECT
    ProductID,
    ProductName,
    Price
FROM Products;
