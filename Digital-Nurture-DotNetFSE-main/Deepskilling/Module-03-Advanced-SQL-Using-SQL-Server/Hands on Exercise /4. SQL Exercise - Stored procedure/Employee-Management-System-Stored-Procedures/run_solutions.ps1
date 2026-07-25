# run_solutions.ps1
# Sequential runner script for Employee Management System Stored Procedure solutions

$ErrorActionPreference = "Stop"

$server = Read-Host "Enter SQL Server name [default: localhost]"
if ([string]::IsNullOrWhiteSpace($server)) {
    $server = "localhost"
}

$db = "EmployeeManagementDB"
Write-Host "`nConnecting to $server -> Database: $db" -ForegroundColor Cyan

# Define local function to execute SQL files
function Execute-Sql-File($filePath) {
    if (Test-Path $filePath) {
        Write-Host "Executing: $(Split-Path $filePath -Leaf)... " -NoNewline -ForegroundColor White
        sqlcmd -S $server -E -C -d $db -i $filePath -b
        Write-Host "SUCCESS" -ForegroundColor Green
    } else {
        Write-Host "FAILED (File not found: $filePath)" -ForegroundColor Red
    }
}

# 1. Initialize Database Schema & Seed Data
Write-Host "`n=== 1. Initializing Database Schema & Sample Data ===" -ForegroundColor Yellow
Execute-Sql-File "Database.sql"
Execute-Sql-File "SampleData.sql"

# 2. Run Exercise Solutions sequentially
Write-Host "`n=== 2. Compiling Exercise Solutions ===" -ForegroundColor Yellow

$exercises = @(
    "Exercise-01-Create-Stored-Procedure\Solution.sql",
    "Exercise-02-Modify-Stored-Procedure\Solution.sql",
    "Exercise-03-Delete-Stored-Procedure\Solution.sql",
    "Exercise-04-Execute-Stored-Procedure\Solution.sql",
    "Exercise-05-Return-Data-From-Stored-Procedure\Solution.sql",
    "Exercise-06-Output-Parameters\Solution.sql",
    "Exercise-07-Update-Employee-Salary\Solution.sql",
    "Exercise-08-Give-Bonus\Solution.sql",
    "Exercise-09-Transactions\Solution.sql",
    "Exercise-10-Dynamic-SQL\Solution.sql",
    "Exercise-11-Error-Handling\Solution.sql"
)

foreach ($exec in $exercises) {
    Execute-Sql-File $exec
}

Write-Host "`n=== All Stored Procedures Compiled Successfully! ===" -ForegroundColor Green
