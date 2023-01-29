use iti 

--1


create view view_fullname_gradeMoreThan50 ([Full name],Crs_Name , Grade)
as
	select (s.st_fname+ ' ' + s.St_Lname) as [Full name] ,c.Crs_Name , sc.Grade
	from student s, course c , Stud_Course sc
	where	s.St_Id=sc.St_Id and sc.Crs_Id=c.Crs_Id and sc.Grade > 50 

select * from view_fullname_gradeMoreThan50
select [Full name] from view_fullname_gradeMoreThan50

--2
create view view_ManagerName_TopicName ([managers],Top_Name)
WITH ENCRYPTION
as
select distinct i.Ins_Name as [managers] , t.Top_Name
from Instructor i , Department d , Ins_Course ic , Course c , topic t
where i.Ins_Id=d.Dept_Manager and i.Ins_Id = ic.Ins_Id and c.Crs_Id = ic.Crs_Id and t.Top_Id=c.Top_Id

select * from  view_ManagerName_TopicName
select distinct [managers] from  view_ManagerName_TopicName --6 managers


SP_HELPTEXT view_ManagerName_TopicName   --The text for object 'view_ManagerName_TopicName' is encrypted.

--3

create view view_InsName_DeptName ([instructor],[departement])
as
select i.Ins_Name as [instructor] , d.Dept_Name as [departement]
from Instructor i , Department d
where i.Dept_Id=d.Dept_Id and ((d.Dept_Name like 'SD') or (d.Dept_Name like 'Java'))

select * from  view_InsName_DeptName
select  distinct [departement] from  view_InsName_DeptName


--4

create view view_Ciaro_Alex_students
as
	select *
	from student s 
	where s.St_Address like 'Cairo' or s.St_Address like 'Alex'
	with check option

select * from view_Ciaro_Alex_students

insert into view_Ciaro_Alex_students 
values(21,'x','negm','tanta',25,10,1)

insert into view_Ciaro_Alex_students 
values(20,'x','negm','Alex',25,10,1)

Update view_Ciaro_Alex_students set st_address='tanta'
Where st_address='alex';

--5

use sd

create view view_project_empNo
as
	select p.ProjectName , count(e.EmpFname) as [number of employees]
	from company.Project p  , Works_on w , emp e  
	where p.ProjectNo = w.ProjectNo and e.EmpNo = w.EmpNo
	group by ProjectName

select * from view_project_empNo

--6
-- done
create nonclustered index index1
on department(manager_hiredate)

--7
-- age is not uqnique so it doesn't work
create unique index index2  
on student(st_age)

--8

create table Dailytransactions
(
UserID int,
TransactionAmount int
)

create table lasttransactions
(
UserID int,
TransactionAmount int
)

Merge into lasttransactions as T 
using Dailytransactions as S

On T.UserID = S.UserID 

When matched then
	update 
	set T.TransactionAmount= S.TransactionAmount

When not matched by target Then 
insert
values(S.UserID , S.TransactionAmount)

When not matched by Source then
	delete;


	--Part 2--
--1

create view v_clerk (eNo,pNo,hireDate)
as
select e.EmpNo , p.ProjectNo ,w.Enter_Date
from emp e , Works_on w , Company.Project p 
where e.EmpNo = w.EmpNo and p.ProjectNo = w.ProjectNo and w.Job like 'clerk'

select eno , pno from v_clerk 

--2

create view v_without_budget
as
select p.ProjectNo , p.ProjectName 
from Company.Project p 
where p.Budget is NULL or p.Budget = 0 
with check option

select * from v_without_budget


--3

create view v_count
as
select p.ProjectName , count(w.job) as [number of jobs]
from Company.Project p , Works_on w
where p.ProjectNo=w.ProjectNo
group by p.ProjectName


select * from v_count

--4

create view v_project_p2
as
select *
from v_clerk
where pNo like 'p2'

select * from v_project_p2

--5

alter view v_without_budget
as
select *  
from Company.Project p 
where p.ProjectNo like 'p1' or   p.ProjectNo like 'p2'


select * from v_without_budget

--6

drop view v_clerk
drop view v_count

--7

create view v_empD2 (enameF , enameL)
as
select e.EmpFname as firstName , e.EmpLname as lastName
from emp e
where DeptNo = 'd2'
--8

select *
from v_empD2
where enameL like '%j%'

--9
create view v_dept (Did , Dname , Daddress)
as
select d.DeptNo ,  d.DeptName , d.Location
from Company.Departement d

select * from v_dept


--10

insert into v_dept (Did , Dname , Daddress) 
values ('d4' , 'Development',NULL)


--11

alter view v_2006_check
as
select e.EmpNo , w.ProjectNo , w.Enter_Date
from emp e , Works_on w 
where w.EmpNo = e.EmpNo and (Enter_Date between ' 2006/1/1' and '2006/12/31')

select * from v_2006_check

