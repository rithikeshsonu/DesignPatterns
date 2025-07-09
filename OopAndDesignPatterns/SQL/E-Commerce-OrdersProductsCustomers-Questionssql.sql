use SQLPractice

--1. List all customers with the total number of orders.
SELECT c.Name, COUNT(o.OrderID) As TotalOrders
FROM Customers c
LEFT JOIN Orders o on c.CustomerID = o.CustomerID
GROUP BY c.Name;

--2. Show total revenue generated
SELECT SUM(TotalAmount) AS TotalRevenueGenerated
FROM Orders

--3. List products with total quantity sold.
SELECT p.Name, SUM(oi.Quantity) as QuantitySold
FROM Products p 
JOIN OrderItems oi on p.ProductID = oi.ProductID
GROUP BY p.Name
--4. Find the top 2 customers by total spend.
SELECT TOP 2 c.Name, SUM(o.TotalAmount) AS TotalSpent
FROM Customers c 
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.Name
ORDER BY TotalSpent DESC;

--5. Find average order value per customer.
SELECT c.Name, AVG(o.TotalAmount) as AvgOrderValue
FROM Customers c LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.Name

--6. List all orders with product names and quantities.

SELECT o.OrderID, p.Name, oi.Quantity FROM Orders o JOIN OrderItems oi on o.OrderID = oi.OrderID
JOIN Products p on p.ProductID = oi.ProductID
SELECT * FROM Customers
SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM OrderItems