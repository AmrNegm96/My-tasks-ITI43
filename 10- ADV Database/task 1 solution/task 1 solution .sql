
--departement table

create default def1 as 'NY'

create rule r1 as @ in ('NY','DS','KW')

sp_addtype loc , 'nchar(2)'


sp_bindefault def1,loc

sp_bindrule r1,loc

create table Departement (
DeptNo varchar(20) primary key,
DeptName varchar(20),
Location loc
)

--Employee table

create table Employee(
EmpNo int primary key, 
EmpFname varchar(20) not null ,
EmpLname varchar(20) not null,
DeptNo varchar(20),
Salary money unique,

constraint c1 foreign key(DeptNo) references Departement(DeptNo)
      on delete set NULL on update cascade
)

create rule r2 as @x<6000 

sp_bindrule r2,'employee.salary'

--test 1 
--  the empNo does not exit

--test2 
-- works in case (p2) because we have composite primary key (p1,p3) exit

--test3
--refrence error that the EmpNo doesnt exist in works_on 

--test4
--refrence error that the EmpNo does exist in works_on 

ALTER TABLE employee
ADD TelephoneNumber int;

ALTER TABLE employee
DROP COLUMN TelephoneNumber;
------------------------------------------------------------------------------------------------------------------

--Part 2 

create schema Human_Resource

create schema Company

alter schema Company transfer Departement

--alter schema Company transfer Project

alter schema Human_Resource transfer Employee

sp_help 'Human_Resource.employee'




CREATE SYNONYM emp1  
FOR Human_Resource.employee  

--select * 
--into emp
--from Human_Resource.employee

Select * from Employee --invalid object

Select * from [Human Resource].Employee --invalid object

Select * from Emp

Select * from [Human Resource].Emp --invalid object

Select * from dbo.Emp

--UPDATE table_name
--SET column1 = value1, column2 = value2, ...
--WHERE condition;

update company.project
set budget = budget *1.1
where ProjectNo = (	select ProjectNo
					from Works_on 
					where EmpNo = 10102 and Job like 'manager')


update company.Departement 
set deptName = 'sales'
where deptNo = (select DeptNo 
				from emp 
				where  EmpFname like 'james')


select * 
from emp 



update works_on
set enter_date = '12/12/2007'
where projectNo = 'p1' and empNo in (select e.empNo
										from emp e , company.Departement d
										where e.deptNo = d.DeptNo and deptname like 'sales')



delete 
from works_on 
where empNo in (select empno
				from emp e , company.departement d
				where e.deptno = d.deptno and d.location like 'kw') 




--Not working

select * from student 

delete from Student

update student 
set St_Fname = 'amr'
where St_Id = 1 


