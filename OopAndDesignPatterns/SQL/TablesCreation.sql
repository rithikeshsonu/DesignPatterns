USE SQLPractice;
GO
-- Drop tables if they exist (optional)
IF OBJECT_ID('Employees', 'U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('Departments', 'U') IS NOT NULL DROP TABLE Departments;
GO

-- Create Departments Table
CREATE TABLE Departments (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);
GO

-- Create Employees Table
CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    Name VARCHAR(50),
    DeptID INT,
    JoinDate DATE,
    Salary DECIMAL(10, 2),
    ManagerID INT NULL,
    FOREIGN KEY (DeptID) REFERENCES Departments(DeptID),
    FOREIGN KEY (ManagerID) REFERENCES Employees(EmpID)
);
GO

-- Insert Departments
INSERT INTO Departments (DeptID, DeptName) VALUES
(1, 'Engineering'),
(2, 'HR'),
(3, 'Sales');
GO

-- Insert Employees
INSERT INTO Employees (EmpID, Name, DeptID, JoinDate, Salary, ManagerID) VALUES
(1, 'Alice',    1, '2020-01-15', 80000.00, NULL),    -- Top-level manager
(2, 'Bob',      1, '2021-03-12', 60000.00, 1),
(3, 'Charlie',  2, '2022-06-10', 75000.00, 1),
(4, 'Diana',    3, '2019-11-01', 72000.00, NULL),    -- Another top-level manager
(5, 'Eve',      2, '2023-01-05', 65000.00, 3);
GO
