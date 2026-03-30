use Company_SD

-- 1
select * from Employee

-- 2
select Fname, Lname, Salary, Dno 
from Employee

-- 3
SELECT P.Pname, P.Plocation, D.Dname
FROM Project P 
JOIN Departments D
ON P.Dnum = D.Dnum

-- 4
SELECT 
	Fname + ' ' + Lname AS FULL_NAME, 
	Salary*12*0.1 AS ANNUAL_COMM  
FROM Employee 

--5
SELECT 
	SSN,
	Fname + ' ' + Lname AS FULL_NAME
FROM Employee
WHERE Salary > 1000

--6
SELECT 
	SSN,
	Fname + ' ' + Lname AS FULL_NAME
FROM Employee
WHERE Salary*12 > 10000

--7
SELECT 
	Fname + ' ' + Lname AS FULL_NAME,
	Salary
FROM Employee
WHERE Sex = 'F'

-- 8
SELECT Dnum, Dname
FROM Departments
WHERE MGRSSN = 968574

-- 9
SELECT Pnumber, Pname, Plocation
FROM Project
WHERE Dnum = 10


