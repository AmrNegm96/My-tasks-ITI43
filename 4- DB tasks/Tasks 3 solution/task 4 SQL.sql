use Company_SD

--1

select d.Dependent_name , d.Sex
from  Dependent d , Employee e
where e.ssn=d.essn and d.Sex='f' and e.Sex='f'

union all

select d.Dependent_name , d.Sex
from  Dependent d , Employee e
where e.ssn=d.essn and d.Sex='m' and e.Sex='m'

--2

select  p.Pname , sum(Hours)
from Project p , Works_for w 
where p.Pnumber=w.Pno
group by p.Pname

--3 better way to writethis query ??????????

select d.*
from Departments d , Employee e
where d.Dnum=e.Dno and ssn= (select min(ssn) from Employee)

--4 

select d.Dname, max(salary) as max_salary , min(salary) as min_salary , avg(salary) as avg_salary
from Departments d , Employee e
where d.dnum = e.dno
group by d.dname

--5 

select (e.Fname+' '+e.Lname) as name
from Employee e , Departments dp
where e.SSN=dp.MGRSSN and dp.MGRSSN not in (select ESSN from Dependent)

--6

select d.Dname , d.Dnum , count(e.ssn) [number of employees]
from Employee e , Departments d 
where e.Dno=d.Dnum
group by Dname,Dnum 
having avg(e.Salary) < (select avg(salary) from Employee)

--7

Select e.fname , e.lname , p.Pname
from Employee e , Project p, Works_for w
where p.Pnumber = w.Pno and w.ESSn = e.SSN
order by p.Dnum, e.Fname ASC

--8

select max(salary) as max_salary from Employee 
union all
select max(salary) 
from employee e 
where Salary not in (select max(salary) as [max salary] 
from employee e )

--9

select (e.Fname+' '+e.Lname) 
from Employee e , Dependent d
where (e.Fname+' '+e.Lname) like d.Dependent_name


--10

SELECT fname+' '+Lname
FROM Employee
WHERE EXISTS (SELECT Dependent_name FROM Dependent d WHERE ssn = d.ESSN)


--11
INSERT INTO Departments 
VALUES ('dept it',100,112233,11/1/2006);

--12

UPDATE Departments
SET MGRSSN = 968574
WHERE mgrssn= 112233

UPDATE Departments
SET MGRSSN = 102672
WHERE mgrssn= 968574

UPDATE Employee
SET Superssn = 102672
WHERE ssn = 102660

--13
update Employee 
set Superssn=102672
where Superssn=223344

update Departments 
set mgrssn=102672
where mgrssn=223344

DELETE from Works_for Where ESSn=223344

DELETE from Employee Where ssn=223344;

--14
update Employee
set Salary=salary*1.3
where ssn in (select w.ESSn
from  Works_for w , project p
where w.Pno=p.Pnumber  and p.Pname like 'Al Rabwah')
