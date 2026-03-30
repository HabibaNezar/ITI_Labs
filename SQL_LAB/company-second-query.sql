use Company_SD

--1.Display the Department id, name and id and the name of its manager.
SELECT D.Dnum, D.Dname, E.Dno, E.Fname + ' ' + E.Lname 
FROM Departments D INNER JOIN Employee E
ON D.MGRSSN = E.SSN 

--2.Display the name of the departments and the name of the projects under its control.
SELECT D.Dname, P.Pname
FROM Departments D INNER JOIN Project P
ON D.Dnum = P.Dnum

--3.Display the full data about all the dependence associated with the name of the employee they depend on him/her.
SELECT D.*, E.Fname, E.Lname
FROM Employee E INNER JOIN Dependent D
ON E.SSN = D.ESSN

--4.Display the Id, name and location of the projects in Cairo or Alex city.
SELECT P.Pnumber, P.Pname, P.Plocation
FROM Project P
WHERE P.City IN ('Cairo', 'Alex')

--5.Display the Projects full data of the projects with a name starts with "a" letter.
SELECT P.*
FROM Project P 
WHERE P.Pname LIKE 'a%'


--6.display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E
WHERE E.Salary BETWEEN 1000 AND 2000
AND E.Dno = 30

--7.Retrieve the names of all employees in department 10 who works more than or equal 10 hours per week on "AL Rabwah" project.
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E INNER JOIN Departments D
ON E.Dno = D.Dnum
INNER JOIN Works_for W
ON W.ESSn = E.SSN
INNER JOIN Project P
ON P.Pnumber = W.Pno
WHERE E.Dno = 10 
AND  P.Pname = 'AL Rabwah'
AND W.Hours >= 10

--8.Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME
FROM Employee E INNER JOIN Employee S
ON E.Superssn = S.SSN
WHERE S.Fname = 'Kamel'
AND S.Lname = 'Mohamed'

--9.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
SELECT E.Fname + ' ' + E.Lname AS FULL_NAME, P.Pname
FROM Employee E INNER JOIN Works_for W
ON E.SSN = W.ESSn
INNER JOIN Project P
ON W.Pno = P.Pnumber
ORDER BY P.Pname


--10.For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
SELECT P.Pname, P.Pnumber, E.Lname AS Manager_LastName, E.Address, E.Bdate
FROM Project P INNER JOIN Departments D
ON P.Dnum = D.Dnum
INNER JOIN Employee E
ON D.MGRSSN = E.SSN
WHERE P.City = 'Cairo'

--11.Display All Data of the managers
SELECT E.*
FROM Employee E INNER JOIN Departments D
ON E.SSN = D.MGRSSN

--12.Display All Employees data and the data of their dependents even if they have no dependents
SELECT E.*, D.*
FROM Employee E LEFT JOIN Dependent D
ON E.SSN = D.ESSN

--13.Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO EMPLOYEE
(Fname, Lname, SSN, Bdate, Address, Sex, Salary, SuperSSN, Dno)
VALUES
('Habiba', 'Nezar', 102672, '2000-02-11', 'Cairo', 'F', 3000, 112233, 30);

--14.Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
INSERT INTO EMPLOYEE
(Fname, Lname, SSN, Bdate, Address, Sex, Dno)
VALUES
('Ahmed', 'Ashraf', 102685, '2000-02-11', 'Cairo', 'F', 30);


--15.sUpgrade your salary by 20 % of its last value.
UPDATE Employee
SET Salary = Salary*1.2
WHERE SSN = 102672