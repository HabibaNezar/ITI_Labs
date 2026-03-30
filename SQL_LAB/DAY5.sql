USE ITI

--1.	Retrieve number of students who have a value in their age. 
SELECT COUNT(St_Age)
FROM Student

--2.	Get all instructors Names without repetition
SELECT DISTINCT Ins_Name
FROM Instructor

--3.	Display student with the following Format (use isNull function)
--Student ID	Student Full Name	Department name
SELECT ISNULL(St_Id,0) AS [Student ID], ISNULL(St_Fname,'FNAME IS NULL') + ' ' + ISNULL(St_Lname,'FNAME IS NULL') AS [Student Full Name], ISNULL(Dept_Name,'FNAME IS NULL') AS [Department name]
FROM Student S JOIN Department D
ON S.Dept_Id = D.Dept_Id

--4.	Display instructor Name and Department Name 
--Note: display all the instructors if they are attached to a department or not
SELECT I.Ins_Name, D.Dept_Name
FROM Instructor I LEFT JOIN Department D
ON I.Dept_Id = D.Dept_Id

--5.	Display student full name and the name of the course he is taking
--For only courses which have a grade  
SELECT S.St_Fname + ' ' + S.St_Fname AS [student full name], C.Crs_Name
FROM Student S JOIN Stud_Course SC ON SC.St_Id = S.St_Id
JOIN Course C  ON SC.Crs_Id = C.Crs_Id
WHERE SC.GRADE IS NOT NULL

--6.	Display number of courses for each topic name
SELECT TOP_ID, COUNT(Top_Id)
FROM Course
GROUP BY Top_Id

--7.	Display max and min salary for instructors
SELECT MAX(SALARY) AS [MAX SALARY], MIN(Salary) AS [MIN SALARY]
FROM Instructor

--8.	Display instructors who have salaries less than the average salary of all instructors.
SELECT Ins_Name
FROM Instructor
WHERE Salary < 
(SELECT AVG(SALARY)
FROM Instructor)

--9.	Display the Department name that contains the instructor who receives the minimum salary.
SELECT DISTINCT D.Dept_Name
FROM Department D JOIN Instructor I
ON D.Dept_Id = I.Dept_Id
WHERE I.Ins_Name IN 
(SELECT Ins_Name
FROM Instructor
WHERE Salary < 
(SELECT AVG(SALARY)
FROM Instructor))


--10.	 Select max two salaries in instructor table. 
SELECT TOP(2) SALARY
FROM Instructor
ORDER BY Salary DESC

--11.	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
SELECT Ins_Name, COALESCE(CAST(Salary AS VARCHAR), 'BONUS') 
FROM Instructor;

--12.	Select Average Salary for instructors 
SELECT AVG(SALARY)
FROM Instructor

--13.	Select Student first name and the data of his supervisor 
SELECT S.St_Fname, I.*
FROM Student S JOIN Instructor I
ON S.St_super = I.Ins_Id

--14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
SELECT INS_NAME, SALARY, DEPT_ID
FROM(
	SELECT ROW_NUMBER() OVER (PARTITION BY DEPT_ID ORDER BY SALARY DESC) AS RN, *
	FROM Instructor
	WHERE Salary IS NOT NULL
	)T
WHERE RN<=2;

--15.	 Write a query to select a random student from each department.  “using one of Ranking Functions
SELECT *
FROM
	(SELECT *, ROW_NUMBER() OVER(PARTITION BY DEPT_ID ORDER BY NEWID()) AS RN
	FROM Student
	WHERE Dept_Id IS NOT NULL) T
WHERE RN = 1

-----------------------------------------------------------------------------------------------------------------------------

USE AdventureWorks2012

--1.	Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
SELECT SalesOrderID, ShipDate 
FROM Sales.SalesOrderHeader 
WHERE OrderDate BETWEEN '2002-07-28' AND '2014-07-29';

--2.	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
SELECT ProductID, Name 
FROM Production.Product 
WHERE StandardCost < 110.00;

--3.	Display ProductID, Name if its weight is unknown
SELECT ProductID, Name 
FROM Production.Product 
WHERE Weight IS NULL;

--4.	 Display all Products with a Silver, Black, or Red Color
SELECT ProductID, Name, Color 
FROM Production.Product 
WHERE Color IN ('Silver', 'Black', 'Red');

--5.	 Display any Product with a Name starting with the letter B
SELECT ProductID, Name 
FROM Production.Product 
WHERE Name LIKE 'B%';

--6.	Run the following Query
--UPDATE Production.ProductDescription
--SET Description = 'Chromoly steel_High of defects'
--WHERE ProductDescriptionID = 3
--Then write a query that displays any Product description with underscore value in its description.
SELECT ProductDescriptionID, Description 
FROM Production.ProductDescription 
WHERE Description LIKE '%[_]%';

--7.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'
SELECT OrderDate, SUM(TotalDue) AS TotalDueSum 
FROM Sales.SalesOrderHeader 
WHERE OrderDate BETWEEN '2001-07-01' AND '2014-07-31' 
GROUP BY OrderDate;

--8.	 Display the Employees HireDate (note no repeated values are allowed)
SELECT DISTINCT HireDate 
FROM HumanResources.Employee;

--9.	 Calculate the average of the unique ListPrices in the Product table
SELECT AVG(DISTINCT ListPrice) AS AverageUniqueListPrice 
FROM Production.Product;

--10.	Display the Product Name and its ListPrice within the values of 100 and 120 the list should has the following format "The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)
SELECT 'The ' + Name + ' is only! ' + CAST(ListPrice AS VARCHAR(20)) AS ProductOffer
FROM Production.Product 
WHERE ListPrice BETWEEN 100 AND 120 
ORDER BY ListPrice;

--11.	
--a)	 Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table  in a newly created table named [store_Archive]
--Note: Check your database to see the new table and how many rows in it?
SELECT rowguid, Name, SalesPersonID, Demographics 
INTO dbo.store_Archive 
FROM Sales.Store;

--b)	Try the previous query but without transferring the data? 
SELECT rowguid, Name, SalesPersonID, Demographics 
INTO dbo.store_Archive_Empty 
FROM Sales.Store 
WHERE 1 = 0;

--12.	Using union statement, retrieve the today’s date in different styles using convert or format funtion
SELECT CONVERT(VARCHAR, GETDATE(), 101) AS TodayDate -- mm/dd/yyyy
UNION
SELECT CONVERT(VARCHAR, GETDATE(), 103) -- dd/mm/yyyy
UNION
SELECT FORMAT(GETDATE(), 'yyyy-MM-dd'); -- yyyy-mm-dd
