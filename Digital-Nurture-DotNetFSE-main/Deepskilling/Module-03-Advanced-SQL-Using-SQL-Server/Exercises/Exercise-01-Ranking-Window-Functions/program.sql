
-- Exercise 1: Ranking and Window Functions

CREATE TABLE Products(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(30),
    Price DECIMAL(10,2)
);

INSERT INTO Products VALUES
(1,'Laptop A','Electronics',800),
(2,'Laptop B','Electronics',1200),
(3,'Laptop C','Electronics',1200),
(4,'Mouse','Electronics',50),
(5,'Office Chair','Furniture',300),
(6,'Dining Table','Furniture',700),
(7,'Sofa','Furniture',700),
(8,'Bookshelf','Furniture',450);

WITH RankedProducts AS
(
SELECT *,
ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) AS RowNum,
RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS RankNum,
DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
FROM Products
)
SELECT *
FROM RankedProducts
WHERE RowNum<=3
ORDER BY Category,RowNum;
