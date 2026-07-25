# Exercise 3 Output

`sql
EXEC sp_InsertEmployee 7, 'Charlie', 'Brown', 3, 5000.00;
`

Expected Error Output:
`
Msg 2812, Level 16, State 62, Server ROLEX, Line 1
Could not find stored procedure 'sp_InsertEmployee'.
`
