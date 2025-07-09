use Sqlpractice
GO
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Country VARCHAR(50)
);
GO
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    Name VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);
GO
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
GO
CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO
-- Customers
INSERT INTO Customers VALUES
(1, 'Alice', 'alice@mail.com', 'USA'),
(2, 'Bob', 'bob@mail.com', 'Canada'),
(3, 'Charlie', 'charlie@mail.com', 'USA'),
(4, 'Diana', 'diana@mail.com', 'UK');
GO
-- Products
INSERT INTO Products VALUES
(101, 'Laptop', 'Electronics', 1000.00),
(102, 'Mouse', 'Electronics', 25.00),
(103, 'Chair', 'Furniture', 150.00),
(104, 'Notebook', 'Stationery', 5.00);
GO
-- Orders
INSERT INTO Orders VALUES
(1001, 1, '2023-10-01', 1050.00),
(1002, 2, '2023-10-03', 175.00),
(1003, 3, '2023-10-05', 30.00),
(1004, 1, '2023-10-08', 150.00);
GO
-- Order Items
INSERT INTO OrderItems VALUES
(1, 1001, 101, 1),  -- Laptop
(2, 1001, 102, 2),  -- Mouse
(3, 1002, 103, 1),  -- Chair
(4, 1002, 104, 5),  -- Notebook
(5, 1003, 104, 6),
(6, 1004, 103, 1);
GO
