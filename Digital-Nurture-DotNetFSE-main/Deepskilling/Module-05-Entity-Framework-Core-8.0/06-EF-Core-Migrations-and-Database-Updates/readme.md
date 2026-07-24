# EF Core Migrations and Database Updates

## Introduction

Entity Framework Core Migrations provide a way to manage and apply database schema changes while preserving existing data. Migrations enable developers to evolve the database structure as the application's data model changes.

This topic covers creating, removing, and updating migrations, seeding initial data, and managing database schema changes using Entity Framework Core 8.

---

## What are Migrations?

A migration is a set of instructions that describes changes to the database schema based on modifications made to entity classes.

Migrations help:

* Create databases automatically.
* Update database schema.
* Preserve existing data.
* Track schema changes.
* Simplify database version control.

---# EF Core Migrations and Database Updates Demo

This project demonstrates how to configure, generate, apply, and manage database migrations using **Entity Framework Core 8** in a .NET 8 Console Application. It shows best practices for setting up a local database workspace, design-time context instantiation, automatic schema migration on startup, and basic data seeding/querying.

---

## Key Features Demonstrated

1. **SQLite Database Provider**: Set up to run out of the box with zero external database engine dependencies. It writes directly to a local file database (`MigrationDemo.db`).
2. **Design-Time DbContext Factory**: Implements [AppDbContextFactory](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Data/AppDbContextFactory.cs) supporting EF Core CLI migration commands.
3. **Automatic Startup Migration**: Applies any outstanding database schema migrations automatically when the application runs.
4. **Data Seeding & Verification**: Detects if data exists, automatically seeds sample employee records if empty, and displays all database entries to verify successful database transactions.

---

## Project Structure

* **[MigrationDemo.csproj](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/MigrationDemo.csproj)**: Project build configuration including Entity Framework package references and copy-on-build configuration for config files.
* **[Program.cs](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Program.cs)**: Entry point that loads configuration, initializes the DbContext, applies migrations, seeds dummy records, and retrieves database records.
* **[appsettings.json](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/appsettings.json)**: Configuration file containing the database connection string.
* **[Data/](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Data)**:
  * **[AppDbContext.cs](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Data/AppDbContext.cs)**: DbContext representing the database session and exposing database sets.
  * **[AppDbContextFactory.cs](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Data/AppDbContextFactory.cs)**: Design-time DbContext factory used by tools to construct the DbContext context instance.
* **[Models/](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Models)**:
  * **[Employee.cs](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Models/Employee.cs)**: Domain model representing the employee database entity.
* **[Migrations/](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Migrations)**: Auto-generated C# migration files that EF Core uses to apply or rollback schema updates.

---

## Prerequisites

1. **.NET 8 SDK**
2. **EF Core CLI Tools**:
   Ensure you have the EF Core tools installed globally on your machine:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
   *If already installed, verify the version:*
   ```bash
   dotnet ef --version
   ```

---

## Step-by-Step Execution Guide

Navigate to the project root directory:
```bash
cd Code/MigrationDemo
```

### 1. Build the Project
Compile the application to restore NuGet packages and build files:
```bash
dotnet build
```

### 2. Generate a New Migration (Optional)
If you make changes to models (e.g., adding properties to [Employee](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Models/Employee.cs)), run:
```bash
dotnet ef migrations add <MigrationName>
```
*Note: A migration called `InitialCreate` is already generated and included in the code repository.*

### 3. Apply Schema Migrations
Apply any pending migrations to create or update the local SQLite database file:
```bash
dotnet ef database update
```
*(Alternatively, simply running the program will automatically run database migrations for you).*

### 4. Run the Project
Execute the console application:
```bash
dotnet run
```

---

## Program Behavior

* **First Run**:
  - The application automatically creates the SQLite database file (`MigrationDemo.db`) in the executable output directory.
  - Generates the schema tables matching the [Employee](file:///C:/Users/subbu/Downloads/06-EF-Core-Migrations-and-Database-Updates/06-EF-Core-Migrations-and-Database-Updates/Code/MigrationDemo/Models/Employee.cs) structure.
  - Seeds three default employee records.
  - Displays list of employees.

* **Subsequent Runs**:
  - Detects that data is already present in the SQLite database.
  - Skips seeding step.
  - Safely reads and lists the persisted records from `MigrationDemo.db`.
to keeping the database synchronized with application models throughout the development lifecycle.

