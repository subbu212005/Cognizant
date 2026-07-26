-- Add sample Departments and Employees here.
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'Human Resources'),
(2, 'Engineering'),
(3, 'Sales'),
(4, 'Marketing');

INSERT INTO Employees (EmployeeID, FirstName, LastName, Email, Salary, DepartmentID) VALUES
(101, 'John', 'Doe', 'john.doe@example.com', 60000.00, 2),
(102, 'Jane', 'Smith', 'jane.smith@example.com', 65000.00, 2),
(103, 'Michael', 'Johnson', 'michael.j@example.com', 55000.00, 1),
(104, 'Emily', 'Brown', 'emily.b@example.com', 48000.00, 4),
(105, 'David', 'Lee', 'david.l@example.com', 70000.00, 3);
