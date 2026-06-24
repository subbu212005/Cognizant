-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert Sample Data
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop Pro', 'Electronics', 1200.00),
(2, 'Smartphone X', 'Electronics', 900.00),
(3, 'Tablet Plus', 'Electronics', 700.00),
(4, 'Smart Watch', 'Electronics', 500.00),

(5, 'Office Chair', 'Furniture', 350.00),
(6, 'Study Table', 'Furniture', 450.00),
(7, 'Bookshelf', 'Furniture', 300.00),
(8, 'Sofa Set', 'Furniture', 800.00),

(9, 'Running Shoes', 'Sports', 150.00);
-- Find Top 3 Most Expensive Products in Each Category
SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum,

        RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNum,

        DENSE_RANK() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS DenseRankNum

    FROM Products
) RankedProducts
WHERE RowNum <= 3
ORDER BY Category, RowNum;
