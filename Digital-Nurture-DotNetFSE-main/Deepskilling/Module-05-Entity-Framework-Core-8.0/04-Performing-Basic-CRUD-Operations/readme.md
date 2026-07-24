# Performing Basic CRUD Operations

## Introduction

CRUD stands for **Create, Read, Update, and Delete**, the four fundamental operations performed on database records. Entity Framework Core simplifies these operations by allowing developers to interact with the database using C# objects instead of writing SQL queries.

This topic demonstrates how to insert, retrieve, update, and delete data using Entity Framework Core 8.0

# EF Core CRUD Operations - Detailed Guide

This document covers the core concepts and methods used when performing Basic CRUD (Create, Read, Update, Delete) operations using Entity Framework Core 8.

---

## 1. Create: Adding Entities
Adding entities inserts new rows into database tables.

### `Add` vs `AddAsync`
* **`Add`**: Sync method. It begins tracking the given entity and any other reachable entities that are not already being tracked. Because it only writes to local memory structures (the change tracker), it does not execute any I/O and completes instantly.
* **`AddAsync`**: Async method. It should **only** be used when special value generators (such as HiLo database key generators) need to access the database immediately to generate a primary key. For normal use-cases, use the synchronous `Add` method.

*Example:*
```csharp
var product = new Product { Name = "Tablet", Price = 299.99m };
db.Products.Add(product); // Prepares the record for insertion
```

---

## 2. Read: Querying Entities
Querying retrieves records from the database and maps them to C# objects.

### `Find` vs `FirstOrDefault` / `SingleOrDefault`
* **`Find` / `FindAsync`**:
  * Looks up an entity using its primary key.
  * **Efficiency**: It first checks the EF Change Tracker to see if the entity is already loaded in memory. If found, it returns the tracked instance immediately without making a database query.
* **`FirstOrDefault` / `FirstOrDefaultAsync`**:
  * Evaluates a predicate expression (e.g., `p => p.Name == "Laptop"`) and returns the first matching record.
  * **I/O Behavior**: It always executes a database query, even if the entity is already loaded in the tracker.
* **`SingleOrDefault` / `SingleOrDefaultAsync`**:
  * Similar to `FirstOrDefault`, but throws an exception if more than one matching entity is found.

*Example:*
```csharp
// Checks tracking cache first:
var p1 = db.Products.Find(1); 

// Always queries database:
var p2 = db.Products.FirstOrDefault(p => p.Id == 1); 
```

---

## 3. Update: Modifying Entities
Updating changes the columns of existing rows in the database.

### Change Tracker States
EF Core keeps track of the state of loaded entities via the Change Tracker:
1. **`Unchanged`**: Loaded from the database and not modified.
2. **`Modified`**: Property values have changed. When `SaveChanges` is called, EF Core generates an `UPDATE` statement only for modified properties.
3. **`Added`**: New entity not yet in the database. Prepares an `INSERT` statement.
4. **`Deleted`**: Entity marked to be removed. Prepares a `DELETE` statement.
5. **`Detached`**: Entity is not being tracked by the DbContext.

### `Update` Method Behavior
* When an entity is loaded from the database and tracked, simply changing its properties marks its state as `Modified`. Calling `db.Update()` explicitly is **not required**.
* The `db.Update()` or `db.Products.Update()` method is used primarily for **detached entities** (e.g., coming from a API payload). It instructs the tracker to start tracking the entity in the `Modified` state, meaning all properties will be written to the database upon save.

*Example:*
```csharp
// Managed update (recommended):
var product = db.Products.Find(1);
product.Price = 850.00m; // Automatically tracked as Modified

// Detached update:
db.Products.Update(detachedProduct);
```

---

## 4. Delete: Removing Entities
Removing deletes rows from the database.

### `Remove` Method
* Marks the tracked entity's state as `Deleted`.
* Once `SaveChanges` is called, a SQL `DELETE` query is sent.
* If the entity is not tracked, it must be loaded first or attached to the context in the `Deleted` state before calling `SaveChanges`.

*Example:*
```csharp
var product = db.Products.Find(2);
db.Products.Remove(product); // Marks for deletion
```

---

## 5. SaveChanges / SaveChangesAsync
All modifications (`Add`, `Update`, `Remove`) remain in memory until `SaveChanges` is called.
* **`SaveChanges`** reads the Entity States in the Change Tracker, builds corresponding SQL transactions (inserting, updating, and deleting rows in a single batch), and executes them against the database.
* It operates as an **atomic transaction**: either all changes succeed, or the entire operation rolls back.

---

## Command Reference

```bash
# Add EF Core CLI Tools globally
dotnet tool install --global dotnet-ef

# Create a migration
dotnet ef migrations add <Name>

# Update target database
dotnet ef database update
```



