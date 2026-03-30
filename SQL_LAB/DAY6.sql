USE ITI
GO

--1.	 Create a scalar function that takes date and returns Month name of that date.
CREATE FUNCTION GETMONTH(@D DATE)
RETURNS VARCHAR(50)
AS
BEGIN
	RETURN (DATENAME(MONTH, @D))
END
GO
DECLARE @DATE DATE = '2002-08-22'
SELECT DBO.GETMONTH(@DATE)

--2.	 Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
GO
CREATE FUNCTION GETVALUES(@N1 INT, @N2 INT)
RETURNS @T TABLE(VALUE INT)
AS
BEGIN
	DECLARE @I INT = @N1
	WHILE @I <= @N2
	BEGIN
		INSERT INTO @T
		VALUES (@I)
		SET @I += 1
	END
	RETURN
END
GO

SELECT *
FROM GETVALUES(5,10)

--3.	 Create inline function that takes Student No and returns Department Name with Student full name.
GO
CREATE FUNCTION STUDENTINFO(@N INT)
RETURNS TABLE 
AS
	RETURN
	(
		SELECT S.St_Fname + ' ' + S.St_Lname AS ST_FULLNAME, D.Dept_Name
		FROM Student S JOIN Department D
		ON S.Dept_Id = D.Dept_Id
		WHERE S.St_Id = @N
	)
GO

SELECT *
FROM STUDENTINFO(1)

--4.	Create a scalar function that takes Student ID and returns a message to user
--a.	If first name and Last name are null then display 'First name & last name are null'
--b.	If First name is null then display 'first name is null'
--c.	If Last name is null then display 'last name is null'
--d.	Else display 'First name & last name are not null'
GO
CREATE FUNCTION GETMESSAGE1(@ID INT)
RETURNS VARCHAR(50)
AS
BEGIN 
	DECLARE @RES VARCHAR(50)
	SELECT @RES = 
		CASE
			WHEN St_Fname IS NULL AND St_Lname IS NULL THEN 'First name & last name are null'
			WHEN St_Fname IS NULL THEN 'first name is null'
			WHEN St_Lname IS NULL THEN 'last name is null'
			ELSE 'First name & last name are not null'
		END
	FROM Academic.student
	WHERE St_Id = @ID
	RETURN @RES
END
GO

use ITI
SELECT dbo.GETMESSAGE1(2)

--5.	Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 
GO
CREATE FUNCTION GETMNGINFO(@ID INT)
RETURNS TABLE
AS
RETURN
(
	SELECT D.Dept_Name, I.Ins_Name, D.Manager_hiredate 
	FROM Instructor I JOIN Department D
	ON I.Dept_Id = D.Dept_Id
	WHERE I.Ins_Id = @ID
)
GO

SELECT *
FROM DBO.GETMNGINFO(1)

--6.	Create multi-statements table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table 
--Note: Use “ISNULL” function
GO
CREATE FUNCTION GETSTR(@STR VARCHAR(50))
RETURNS @T TABLE (RES VARCHAR(50))
AS 
BEGIN
	IF @STR = 'first name' 
		INSERT INTO @T 
		SELECT ISNULL(St_Fname, ' ') FROM Student
	ELSE IF @STR = 'last name' 
		INSERT INTO @T 
		SELECT ISNULL(St_Lname, ' ') FROM Student
	ELSE IF @STR = 'FULL name' 
		INSERT INTO @T 
		SELECT ISNULL(St_Fname, ' ') + ISNULL(St_Lname, ' ') AS FULLNAME FROM Student
	
	RETURN
END
GO

SELECT * 
FROM GETSTR('first name')

--7.	Write a query that returns the Student No and Student first name without the last char
SELECT St_Id, LEFT(St_Fname, LEN(ST_FNAME)-1)
FROM Student
WHERE St_Fname IS NOT NULL

--8.	Wirte query to delete all grades for the students Located in SD Department 
UPDATE SC
SET SC.GRADE = NULL
FROM Stud_Course SC JOIN Student S
ON SC.St_Id = S.St_Id
JOIN Department D 
ON D.Dept_Id = S.Dept_Id
WHERE D.Dept_Name = 'SD'

--9.	Using Merge statement between the following two tables [User ID, Transaction Amount]
-- Create the Target table
CREATE TABLE LastTransactions (
    UserID INT PRIMARY KEY,
    TransactionAmount DECIMAL(18, 2)
);

-- Create the Source table
CREATE TABLE DailyTransactions (
    UserID INT PRIMARY KEY,
    TransactionAmount DECIMAL(18, 2)
);

-- Insert data into LastTransactions (Target)
INSERT INTO LastTransactions (UserID, TransactionAmount)
VALUES 
(1, 4000),
(4, 2000),
(2, 10000);

-- Insert data into DailyTransactions (Source)
INSERT INTO DailyTransactions (UserID, TransactionAmount)
VALUES 
(1, 1000),
(2, 2000),
(3, 10000);

---------------------------
MERGE LastTransactions AS Target
USING DailyTransactions AS Source
ON Target.UserID = Source.UserID

-- 1. If UserID exists in both: Update the amount
WHEN MATCHED THEN
    UPDATE SET Target.TransactionAmount = Source.TransactionAmount

-- 2. If UserID exists in Daily but not in Last: Insert it
WHEN NOT MATCHED BY TARGET THEN
    INSERT (UserID, TransactionAmount)
    VALUES (Source.UserID, Source.TransactionAmount)

-- 3. Optional: If UserID exists in Last but not in Daily: Delete it
WHEN NOT MATCHED BY SOURCE THEN
    DELETE;
--10.	Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to select and insert data into tables and deny Delete and update
USE ITI;
GO

CREATE SCHEMA Academic;
GO

ALTER SCHEMA ACADEMIC TRANSFER DBO.STUDENT
GO

ALTER SCHEMA ACADEMIC TRANSFER DBO.COURSE
GO

ALTER USER ITIStud WITH DEFAULT_SCHEMA = Academic;
GO

SELECT * FROM Academic.STUDENT
GO