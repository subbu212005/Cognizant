# Lab 4 - Inserting Initial Data into the Database

## Objective

Insert initial records into the SQL Server database using Entity Framework Core.

---

## Steps

### Run the application

```bash
dotnet run
```

---

## Inserted Categories

- Electronics
- Groceries

---

## Inserted Products

- Laptop
- Rice Bag

---

## Expected Output

```
Initial data inserted successfully.

----------------------------------

Categories Added:
1. Electronics
2. Groceries

Products Added:
Laptop - ₹75000
Rice Bag - ₹1200
```

---

## Conclusion

This lab demonstrates inserting data using `AddRangeAsync()` and `SaveChangesAsync()`.
