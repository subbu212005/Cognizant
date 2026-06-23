# Triggers and Cursors

## Introduction

Triggers and Cursors are important SQL Server features used for automation and row-by-row processing.

Triggers automatically execute when specific database events occur, while Cursors allow sequential processing of records returned by a query.

---

## What are Triggers?

A Trigger is a special type of stored procedure that automatically executes when specific events occur in a database table or view.

### When Do We Use Triggers?

* Audit changes in tables
* Validate data
* Maintain data integrity
* Automatically update related tables
* Log database activities

---

## Types of SQL Server Triggers

### DML Triggers

Triggered by INSERT, UPDATE, or DELETE operations.

#### AFTER Trigger

Executes after the triggering event completes successfully.

#### INSTEAD OF Trigger

Executes instead of the triggering event.

### Logon Trigger

Executes when a user logs into SQL Server.

---

## Create Trigger

```sql id="z5y9mx"
CREATE TRIGGER trg_AfterInsert
ON Students
AFTER INSERT
AS
BEGIN
    PRINT 'Student record inserted successfully';
END;
```

---

## Modify Trigger

Triggers can be modified using:

```sql id="lns4yz"
ALTER TRIGGER trg_AfterInsert
ON Students
AFTER INSERT
AS
BEGIN
    PRINT 'New student added';
END;
```

---

## Delete Trigger

```sql id="5wmljg"
DROP TRIGGER trg_AfterInsert;
```

---

## Advantages of Triggers

* Automatic execution
* Improved data integrity
* Auditing support
* Enforces business rules

---

## Disadvantages of Triggers

* Difficult debugging
* Hidden execution logic
* Performance overhead
* Increased complexity

---

## What are Cursors?

A Cursor is a database object used to process query results one row at a time.

---

## Life Cycle of a Cursor

1. Declare Cursor
2. Open Cursor
3. Fetch Records
4. Close Cursor
5. Deallocate Cursor

---

## Uses of SQL Server Cursor

* Row-by-row processing
* Data migration
* Custom calculations
* Reporting tasks

---

## Types of Cursors in SQL Server

### Static Cursor

Creates a snapshot of data.

### Dynamic Cursor

Reflects all changes in the underlying data.

### Forward-Only Cursor

Moves only in the forward direction.

### Keyset Cursor

Tracks updates but not inserts.

---

## Limitations of SQL Server Cursor

* Slower performance
* Higher memory consumption
* Not suitable for large datasets

---

## Alternatives to Cursor

* WHILE Loops
* Common Table Expressions (CTE)
* Window Functions
* Set-Based Queries

---

## Learning Outcome

After completing this topic, I understood SQL Server Triggers and Cursors, their types, advantages, limitations, and practical applications.

---

## Conclusion

Triggers automate database operations, while Cursors enable row-by-row processing. Proper usage improves database functionality and maintainability.

