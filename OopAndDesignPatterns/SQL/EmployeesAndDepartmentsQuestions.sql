SELECT * FROM Employees
SELECT * FROM Departments
--1. List all employees with their department names.
SELECT emp.Name, dept.DeptName, *
FROM Employees emp
JOIN Departments dept ON emp.deptid = dept.deptid

--2. Find employees who joined after January 1, 2021.
SELECT Name, JoinDate
FROM employees 
WHERE JoinDate > '2021-01-01'

--3. Find the average salary for each department.
SELECT dept.DeptName ,ROUND( AVG(emp.salary), 2) as AverageSalary
FROM Employees emp
JOIN Departments dept on emp.DeptID = dept.DeptID
Group by dept.DeptName

--4. Find the highest paid employee in each department.
--Idea
---First fetch all records by join. then find by salary = max(salary) Corelated Subquery
SELECT  dept.DeptName, emp.Name, emp.Salary
FROM Employees emp
JOIN Departments dept ON emp.deptid = dept.deptid
WHERE Salary = (SELECT MAX(Salary) FROM Employees e2 where e2.DeptID = emp.DeptID)

--5. List employees who are managers (i.e., others report to them).
--Self Join
SELECT distinct e2.Name
FROM Employees e1
JOIN Employees e2 on e1.ManagerID = e2.EmpID

--Sub query
SELECT [name] FROM Employees WHERE EmpID IN(
SELECT distinct ManagerID from Employees WHERE ManagerID IS NOT NULL)

--6. Count the number of employees under each manager.
SELECT m.Name, COUNT(e.EmpID) AS TeamSize FROM
Employees e
JOIN Employees m on e.ManagerID = m.EmpID
GROUP BY m.Name

--7. Find employees who do not report to anyone (top-level managers).
SELECT Name FROM Employees WHERE ManagerID IS NULL

--8. Show employees with salary above department average.

SELECT e.Name, e.Salary--, d.DeptName
FROM Employees e-- JOIN Departments d on e.DeptID = d.DeptID
WHERE e.Salary > (
SELECT AVG(salary) FROM Employees e2 WHERE e2.DeptID = e.DeptID)

--9. List departments and total salary cost.
SELECT * FROM Departments d JOIN Employees e on e.DeptID = d.DeptID

SELECT DeptName, SUM(e.salary) AS TotalDeptSalary
FROM Employees e 
JOIN Departments d on e.DeptID = d.DeptID
GROUP BY DeptName;

--10. Get employees and their managers' names.
SELECT *--emp.Name as Emp_Name, man.Name AS Man_Name
FROM Employees emp 
LEFT JOIN Employees man on emp.ManagerID = man.EmpID