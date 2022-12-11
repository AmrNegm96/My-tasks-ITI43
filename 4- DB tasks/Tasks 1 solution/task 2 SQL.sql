use Company_SD
--1
select * from Employee

--2
select Fname,Lname,salary,dno 
from Employee

--3
select * from Project

--4
select fname,(salary*12)*0.1 from employee as annualcomm

--5
select ssn,fname,salary from Employee where Salary>1000

--6
select ssn,fname,salary from Employee where Salary*12>10000

--7
select ssn,fname from Employee where sex='f'

--8
select dname,dnum,mgrssn from Departments where mgrssn=968574

--9
select pname,pnumber,plocation from Project where dnum=10