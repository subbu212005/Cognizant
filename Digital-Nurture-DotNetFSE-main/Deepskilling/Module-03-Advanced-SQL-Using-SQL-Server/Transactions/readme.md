# Transactions

## Introduction

A transaction is a sequence of one or more SQL statements executed as a single logical unit of work. Transactions ensure that database operations are completed successfully while maintaining data consistency and integrity.

A transaction must either complete entirely or be rolled back completely.

---

## What are Transactions?

A transaction is a group of SQL operations treated as a single unit.

Examples:

* Bank money transfer
* Online shopping order processing
* Student registration system
* Inventory management

---

## ACID Properties

### Atomicity

Ensures that all operations within a transaction are completed successfully or none are executed.

### Consistency

Ensures that the database remains in a valid state before and after the transaction.

### Isolation

Ensures that concurrent transactions do not interfere with each other.

### Durability

Ensures that committed changes are permanently stored in the database.

---

## Transaction States

### Active State

The transaction is currently being executed.

### Partially Committed State

The final statement has executed, but changes are not yet permanently saved.

### Committed State

All changes have been permanently saved.

### Failed State

The transaction encounters an error.

### Aborted State

The transaction is rolled back and all changes are undone.

---

## Transaction Management Statements

### BEGIN TRANSACTION

Starts a transaction.

```sql
BEGIN TRANSACTION;
```

### COMMIT

Saves all changes permanently.

```sql
COMMIT;
```

### ROLLBACK

Undoes all changes made during the transaction.

```sql
ROLLBACK;
```

### SAVE TRANSACTION

Creates a savepoint inside a transaction.

```sql
SAVE TRANSACTION SavePoint1;
```

---

## Savepoints

A savepoint allows partial rollback within a transaction without rolling back the entire transaction.

### Example

```sql
BEGIN TRANSACTION;

UPDATE Students
SET Marks = Marks + 5;

SAVE TRANSACTION MarksUpdated;

UPDATE Students
SET Marks = Marks + 10;

ROLLBACK TRANSACTION MarksUpdated;

COMMIT;
```

---

## Implicit vs Explicit Transactions

### Implicit Transactions

SQL Server automatically starts a transaction for certain statements.

### Explicit Transactions

The developer manually controls the transaction using:

* BEGIN TRANSACTION
* COMMIT
* ROLLBACK

---

## Nested Transactions

A transaction started within another transaction is called a nested transaction.

### Example

```sql
BEGIN TRANSACTION;

BEGIN TRANSACTION;

COMMIT;

COMMIT;
```

---

## Transaction Isolation Levels

### READ UNCOMMITTED

Allows reading uncommitted data.

### READ COMMITTED

Reads only committed data.

### REPEATABLE READ

Prevents changes to data that has been read.

### SERIALIZABLE

Provides the highest isolation level.

### SNAPSHOT

Provides a consistent snapshot of data.

---

## Locking and Blocking

### Locking

SQL Server places locks on data to maintain consistency.

### Blocking

Occurs when one transaction waits for another transaction to release a lock.

---

## Transaction Deadlocks

A deadlock occurs when two or more transactions wait indefinitely for resources locked by each other.

### Causes

* Conflicting locks
* Long-running transactions
* Poor transaction design

### Prevention

* Keep transactions short
* Access resources in the same order
* Use proper indexing
* Minimize lock duration

---

## Learning Outcome

After completing this topic, I understood transaction management, ACID properties, transaction states, savepoints, isolation levels, locking mechanisms, blocking behavior, and deadlock prevention techniques in SQL Server.

---

## Conclusion

Transactions are essential for maintaining data integrity, consistency, and reliability in database applications. Proper transaction management ensures accurate and secure database operations.

