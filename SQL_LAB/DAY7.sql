Use ITI 
GO

--1.	 Create a view that displays student full name, course name if the student has a grade more than 50. 
CREATE VIEW VSTD_CRS 
AS
	SELECT St_Fname + ' ' + St_Lname AS STUDENT_FULLNAME, Crs_Name
	FROM Academic.Student S JOIN Stud_Course SC
	ON S.St_Id = SC.St_Id
	JOIN Academic.Course C
	ON SC.Crs_Id = C.Crs_Id
	WHERE SC.Grade > 50
GO

SELECT *
FROM VSTD_CRS
GO

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 
alter VIEW VMNG
WITH ENCRYPTION
AS
	SELECT I.Ins_Name, C.Crs_Name
	FROM Instructor I JOIN Ins_Course IC 
	ON I.Ins_Id = IC.Ins_Id
	JOIN Academic.Course C
	ON IC.Crs_Id = C.Crs_Id
	JOIN Department D ON I.Ins_Id = D.Dept_Manager
GO

SELECT *
FROM VMNG
GO

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
CREATE VIEW VINS
AS
	SELECT I.Ins_Name, D.Dept_Name
	FROM Instructor I JOIN Department D 
	ON I.Dept_Id = D.Dept_Id
	WHERE D.Dept_Name = 'SD' OR D.Dept_Name = 'Java'
GO

SELECT *
FROM VINS
GO

--4.	 Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;
CREATE VIEW V1
WITH ENCRYPTION 
AS
	SELECT *
	FROM Academic.Student
	WHERE St_Address = 'ALEX' OR St_Address = 'CAIRO'
	WITH CHECK OPTION
GO

SELECT *
FROM V1
GO

--5.	Create a view that will display the project name and the number of employees work on it. “Use Company DB”
USE [company dp]
GO

CREATE VIEW VDCAMP
AS
	SELECT P.PNAME, COUNT(W.ESSN) AS NUMBER_OF_EMPLOYEES
	FROM PROJECT P JOIN WORKS_ON W
	ON P.PNUMBER = W.PNO
	GROUP BY P.PNAME
GO

--6.	Create the following schema and transfer the following tables to it 
--a.	Company Schema 
--i.	Department table (Programmatically)
--ii.	Project table (by wizard)
CREATE SCHEMA CAMPANY
GO

ALTER SCHEMA CAMPANY TRANSFER DEPARTMENT
GO

--b.	Human Resource Schema
--i.	  Employee table (Programmatically)
CREATE SCHEMA HR
GO

ALTER SCHEMA HR
TRANSFER EMPLOYEE
GO

--7.	Create index on column (manager_Hiredate) that allow u to cluster the data in table Department. What will happen?  - Use ITI DB
USE ITI
GO

CREATE CLUSTERED INDEX I1
ON DEPARTMENT(manager_Hiredate)
GO
---- BECAUSE CANT CREATE MORE THAN 1 CLUSTERED IN THE TABLE

--8.	Create index that allow u to enter unique ages in student table. What will happen?  - Use ITI DB
CREATE UNIQUE NONCLUSTERED INDEX I2
ON ACADEMIC.STUDENT(ST_AGE)
GO
---- IF THERE A DULICATE VALUE IN AGE THAT WILL GIVE ERROR

--9.	Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
USE [company dp]
GO

DECLARE C1 CURSOR
FOR SELECT SALARY FROM HR.EMPLOYEE
FOR UPDATE

DECLARE @SAL DECIMAL
OPEN C1
FETCH C1 INTO @SAL
WHILE @@FETCH_STATUS = 0
	BEGIN 
		IF @SAL < 3000
			UPDATE HR.EMPLOYEE
			SET SALARY = @SAL*1.1
			WHERE CURRENT OF C1
		ELSE IF @SAL >= 3000
			UPDATE HR.EMPLOYEE
			SET SALARY = @SAL*1.2
			WHERE CURRENT OF C1
		FETCH C1 INTO @SAL
	END
CLOSE C1
DEALLOCATE C1
GO


--10.	Display Department name with its manager name using cursor. Use ITI DB
USE ITI
GO

DECLARE C2 CURSOR
FOR SELECT D.Dept_Name, I.Ins_Name FROM Department D JOIN Instructor I ON D.Dept_Manager = I.Ins_Id
FOR READ ONLY

DECLARE @DNAME VARCHAR(50), @INAME VARCHAR(50) 
OPEN C2
FETCH C2 INTO @DNAME, @INAME
WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @DNAME, @INAME
		FETCH C2 INTO @DNAME, @INAME
	END
CLOSE C2
DEALLOCATE C2
GO

--11.	Try to display all instructor names in one cell separated by comma. Using Cursor . Use ITI DB
DECLARE C3 CURSOR
FOR SELECT INS_NAME FROM INSTRUCTOR
FOR READ ONLY

DECLARE @STR VARCHAR(50), @TSTR VARCHAR(500) = ''
OPEN C3
FETCH C3 INTO @STR
WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @TSTR = '' 
			SET @TSTR = @STR
		ELSE 
			SET @TSTR = CONCAT(@TSTR, ', ', @STR)
		FETCH C3 INTO @STR
	END
CLOSE C3
DEALLOCATE C3
--GO

SELECT @TSTR AS All_Instructors; 
GO

--12.	Try to generate script from DB ITI that describes all tables and views in this DB
USE ITI;
GO

SELECT 
    TABLE_SCHEMA AS [Schema_Name],
    TABLE_NAME AS [Object_Name],
    TABLE_TYPE AS [Object_Type]
FROM 
    INFORMATION_SCHEMA.TABLES
ORDER BY 
    TABLE_TYPE, 
    TABLE_NAME;
GO
