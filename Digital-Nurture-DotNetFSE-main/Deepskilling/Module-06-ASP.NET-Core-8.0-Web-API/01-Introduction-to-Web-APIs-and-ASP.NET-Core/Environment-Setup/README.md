# Environment Setup for ASP.NET Core 8 Web API

## Software Required

- Windows 10/11
- .NET 8 SDK
- Visual Studio Code
- SQL Server
- SQL Server Management Studio (SSMS)
- Postman

## Install .NET SDK

Download and install the latest .NET 8 SDK.

Verify installation

dotnet --version

Expected Output

8.0.xxx

## Install VS Code Extensions

- C#
- C# Dev Kit
- SQL Server (optional)
- REST Client (optional)

## Verify Installation

dotnet --info

## Create Project

dotnet new webapi -n WebApiDemo

Open Project

cd WebApiDemo

code .

Run Project

dotnet run

Open Browser

https://localhost:5001/swagger

or

http://localhost:5000/swagger
