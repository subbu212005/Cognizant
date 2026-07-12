# Lab 5 - Retrieving Data from the Database

## Objective

Retrieve records from SQL Server using Entity Framework Core.

---

## Methods Used

- ToListAsync()
- FindAsync()
- FirstOrDefaultAsync()

---

## Run

```bash
dotnet run
```

---

## Expected Output

```
===== ALL PRODUCTS =====

1 Laptop ₹75000
2 Rice Bag ₹1200

===== FIND PRODUCT BY ID =====

Found: Laptop

===== FIRST PRODUCT PRICE > 50000 =====

Expensive Product: Laptop
```

---

## Conclusion

This lab demonstrates retrieving data from SQL Server using asynchronous EF Core methods.
