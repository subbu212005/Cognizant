# Output

## Recursive CTE Output

The recursive CTE successfully generated a calendar containing dates from **2025-01-01** to **2025-01-31**.

### Screenshot

![Recursive CTE Output](beforemerge.png,aftermerge.png,StagingProducts.png)

---

## Products Before MERGE

| ProductID | ProductName | Category | Price |
|-----------|-------------|----------|------:|
|1|Laptop A|Electronics|800.00|
|2|Laptop B|Electronics|1200.00|
|3|Laptop C|Electronics|1200.00|
|4|Mouse|Electronics|50.00|
|5|Office Chair|Furniture|300.00|
|6|Dining Table|Furniture|700.00|
|7|Sofa|Furniture|700.00|
|8|Bookshelf|Furniture|450.00|

---

## Products After MERGE

| ProductID | ProductName | Category | Price |
|-----------|-------------|----------|------:|
|1|Laptop A|Electronics|800.00|
|2|Laptop B|Electronics|1250.00|
|3|Laptop C|Electronics|1200.00|
|4|Mouse|Electronics|50.00|
|5|Office Chair|Furniture|300.00|
|6|Dining Table|Furniture|750.00|
|7|Sofa|Furniture|700.00|
|8|Bookshelf|Furniture|450.00|
|9|Gaming Chair|Furniture|950.00|

---

## StagingProducts Table

| ProductID | ProductName | Category | Price |
|-----------|-------------|----------|------:|
|2|Laptop B|Electronics|1250.00|
|6|Dining Table|Furniture|750.00|
|9|Gaming Chair|Furniture|950.00|

---

## Observation

- A recursive CTE generated all dates from **1 January 2025** to **31 January 2025**.
- The **MERGE** statement updated the prices of existing products:
  - Laptop B → **1200.00 → 1250.00**
  - Dining Table → **700.00 → 750.00**
- A new product (**Gaming Chair**) was inserted into the `Products` table.
- The MERGE statement efficiently performed both **UPDATE** and **INSERT** operations in a single query.

---

## Conclusion

This exercise demonstrates the use of **Recursive CTEs** for generating sequential data and the **MERGE** statement for synchronizing data between a staging table and the main table. It simplifies ETL operations by combining update and insert actions into one statement.
