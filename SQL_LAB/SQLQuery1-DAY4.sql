USE Company_SD


--1.Display (Using Union Function)
	--a. The name and the gender of the dependence that's gender is Female and depending on Female Employee.
	--b. And the male dependence that depends on Male Employee.
	SELECT D.Dependent_name, D.Sex
	FROM Dependent D INNER JOIN Employee E
	ON D.ESSN = E.SSN
	WHERE D.Sex = 'F' AND E.Sex = 'F'
	UNION
	SELECT D.Dependent_name, D.Sex
	FROM Dependent D INNER JOIN Employee E
	ON D.ESSN = E.SSN
	WHERE D.Sex = 'M' AND E.Sex = 'M'

--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.
SELECT P.Pname, SUM(W.Hours) AS TOTAL_HOURS
FROM Project P INNER JOIN Works_for W
ON P.Pnumber = W.Pno
GROUP BY P.Pname

--3.Display the data of the department which has the smallest employee ID over all employees' ID.
SELECT TOP 1 D.*
FROM Departments D
INNER JOIN Employee E 
ON D.Dnum = E.Dno
ORDER BY E.SSN ASC;

--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
SELECT D.Dname, MAX(E.Salary) AS MAX_SALARY, MIN(E.Salary) AS MIN_SALARY, AVG(E.Salary) AS AVG_SALARY
FROM Employee E RIGHT JOIN Departments D
ON E.Dno = D.Dnum
GROUP BY D.Dname

--5.List the full name of all managers who have no dependents.
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E INNER JOIN Departments D
ON E.SSN = D.MGRSSN
LEFT JOIN Dependent DEP
ON DEP.ESSN = E.SSN
WHERE DEP.ESSN IS NULL

--6.For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
SELECT D.Dname, COUNT(E.SSN) AS EMPLOYEE_NUMBER
FROM Departments D INNER JOIN Employee E
ON E.Dno = D.Dnum
GROUP BY D.Dnum, D.Dname
HAVING AVG(E.Salary) < (
	SELECT AVG(E.Salary)
	FROM Employee E
)

--7.Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME, P.Pname
FROM Employee E INNER JOIN Works_for W
ON E.SSN = W.ESSn
INNER JOIN Project P
ON W.Pno = P.Pnumber
ORDER BY E.Dno, E.Fname, E.Lname

--8.Try to get the max 2 salaries using sub query
SELECT MAX(E.Salary) AS SECOND_MAX
FROM EMPLOYEE E
WHERE Salary < (
	SELECT MAX(E.Salary)
	FROM EMPLOYEE E
)

--9.Get the full name of employees that is similar to any dependent name
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E
WHERE (E.Fname + ' ' + E.Lname) IN(
	SELECT D.Dependent_name
	FROM Dependent D
)

--10.Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
SELECT E.SSN, E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E
WHERE EXISTS(
	SELECT *
    FROM Dependent D
	WHERE D.ESSN = E.SSN
)

--11.In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
INSERT INTO Departments(Dnum,Dname,MGRSSN,[MGRStart Date])
VALUES(100, 'DEPT IT', 112233, '2006-11-01')

--12.Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager)
--a.First try to update her record in the department table
UPDATE Departments
SET MGRSSN = 968574, [MGRStart Date] = GETDATE()
WHERE Dnum = 100;

--b.Update your record to be department 20 manager.
UPDATE Employee
SET Dno = 20
WHERE SSN = 102672

--c.Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
UPDATE EMPLOYEE
SET Superssn = 102672
WHERE SSN = 102660

--13.Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
--Hint:(Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).
SELECT *
FROM Dependent
WHERE ESSN = 223344;

DELETE FROM Dependent
WHERE ESSN = 223344;

SELECT *
FROM Departments
WHERE MGRSSN = 223344;

UPDATE Departments
SET MGRSSN = 102672, [MgrStart Date] = GETDATE()
WHERE MGRSSN = 223344;

SELECT *
FROM Employee
WHERE Superssn = 223344;

UPDATE Employee
SET Superssn = 102672
WHERE Superssn = 223344;

SELECT *
FROM Works_for
WHERE ESSN = 223344;

DELETE FROM Works_for
WHERE ESSn = 223344

DELETE FROM Employee
WHERE SSN = 223344;


--14.Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
UPDATE E
SET E.Salary = E.Salary * 1.3
FROM Employee E
INNER JOIN Works_for W
ON E.SSN = W.ESSN
INNER JOIN Project P
ON W.Pno = P.Pnumber
WHERE P.Pname = 'Al Rabwah';
