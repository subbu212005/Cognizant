# Overview of EF Core 8 and .NET 8 Integration

Welcome to the **Entity Framework Core 8 and .NET 8 Integration** introductory guide. This project is a starting point for understanding how modern Object-Relational Mapping (ORM) works in Microsoft's ecosystem, showcasing the capabilities of Entity Framework Core 8 (EF Core 8) integrated with .NET 8.

---

##  Overview

This repository demonstrates the basics of EF Core 8—Microsoft's modern, lightweight, extensible, and cross-platform ORM framework designed for .NET 8 applications. It provides C# developers with an automated mechanism for storing and retrieving data from databases using strongly typed objects.

##  Learning Objectives

By exploring this repository and running the demo code, you will learn:
*   **Core ORM Concepts:** Understanding the bridge between Object-Oriented Programming (C# classes) and Relational Databases (SQL tables).
*   **EF Core vs. EF6 (Classic):** Clear differences in performance, platform compatibility, and features.
*   **New Features in EF Core 8:** Performance optimizations, enhanced JSON columns, advanced LINQ translations, and improved SQL generation.
*   **Modern .NET 8 Integration:** Leverage C# 12 and modern runtime optimizations with EF Core 8.

---

##  EF Core vs. EF (Classic Framework)

| Feature | EF Core 8 (Modern) | EF6 (Classic Framework) |
| :--- | :--- | :--- |
| **Cross-Platform** | Yes (Windows, macOS, Linux) | Windows-Only |
| **Performance** | Optimized, lightweight, extremely fast | Heavier, slower query generation |
| **Active Development** | Yes (Active support & features) | Maintenance mode only |
| **Target Runtime** | .NET 8 / .NET Core | .NET Framework |
| **JSON Columns Support**| Built-in native support | Not supported out-of-the-box |

---

##  Prerequisites

To run this demo project, you will need:

1.  **[.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)** or higher installed.
2.  An IDE or editor of your choice (e.g., **Visual Studio 2022**, **VS Code**, or **JetBrains Rider**).

---

## Project Structure

```text
├── 01-Overview-of-EF-Core-8-and-.NET-8-Integration/
│   ├── Notes.md                     # Core theoretical notes and concepts
│   ├── README.md                    # This repository guide
│   └── Code/
│       └── EFCoreOverviewDemo/      # C# Console Application project
│           ├── Program.cs           # Main entry point displaying features
│           └── EFCoreOverviewDemo.csproj  # MSBuild project file
```

---

##  Running the Demo Project

To run this project locally, follow these simple steps:

1. Open your terminal (Command Prompt, PowerShell, or bash).
2. Navigate to the project root directory:
   ```powershell
   cd "01-Overview-of-EF-Core-8-and-.NET-8-Integration/Code/EFCoreOverviewDemo"
   ```
3. Run the application:
   ```powershell
   dotnet run
   ```

---

##  Key Concepts Detailed

### What is an ORM?
An **Object-Relational Mapper (ORM)** eliminates the need for writing repetitive ADO.NET data-access code. It maps relational database schemas to your object-oriented domain classes, handling operations like inserts, updates, deletes, and complex select queries under the hood.

### EF Core 8 Features Demonstrated
*   **Cross-Platform & Lightweight Architecture:** Allows microservices to run inside Docker containers on Linux.
*   **LINQ Queries:** Express database queries using SQL-like expressions directly inside C# code.
*   **Migrations:** Schema version control for databases. Keep your database schema synchronized with C# models.
*   **Change Tracking:** Automatically tracks changes made to entity objects so you can persist them with a single database call (`SaveChanges`).
