use Company_SD
--1
select dnum , fname , ssn 
from Departments inner join Employee
on ssn = MGRSSN
--2
select dname , pname
from Departments d inner join project p 
on d.Dnum = p.Dnum
--3
select fname , d.*
from Employee right outer join Dependent d
on ESSN = ssn 

--4
select p.Pnumber, p.pname, p.plocation 
from project p
where p.city like 'Cairo' or p.city like 'Alex'

--5
select * from Project 
where Pname like 'A%'

--6
select * 
from Employee
where Dno = 30 and Salary>=1000 and Salary<=2000

--7
select e.fname+' '+e.Lname
from Employee e , Project p , Works_for w 
where w.ESSn = e.SSN and p.Pnumber = w.Pno and p.Pname like 'al rabwah'
and e.dno=10 and w.hours>=10 

--8
-- x-employee--child--fk
-- y-supervisor--parent--pk
select (x.fname+' '+x.Lname) as employeeName
from Employee x , Employee y 
where y.SSN = x.Superssn and y.Fname like 'kamel'

--9
select (e.fname+' '+e.Lname) as employeeName , p.Pname
from Employee e , Project p , Works_for w
where w.ESSn = e.SSN and p.Pnumber=w.pno 
order by p.pname

--10
select p.Pnumber , d.Dname , e.Lname as ManagerName , e.Address ,e.Bdate
from Project p , Departments d, Employee e
where p.Dnum = d.Dnum and e.SSN = d.MGRSSN and p.City like 'cairo'

--11
select *
from employee , Departments
where SSN=MGRSSN

----12
select e.*
from Employee e left outer join Dependent d
on d.ESSN=e.SSN

--13
insert into Employee values('amr','sherif','102672','2/8/1996','aaaa','m','3000','112233',null)


--14
insert into Employee values('youssef','sherif','102660','2/8/1996','aaaa','m',null,null,'30')


--15

UPDATE Employee
SET Salary += (0.1*Salary)
WHERE Fname like 'amr' and Lname like 'sherif'



