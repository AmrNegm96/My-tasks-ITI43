use iti

--1

alter proc studNum_SP 
as 
select count(s.St_Fname) as [number of students] , s.Dept_Id
from student s
group by s.Dept_Id

studNum_SP

execute studNum_SP

exec studNum_SP

--2

use SD

alter proc empNumAtP1_SP
as 
declare @x int 
select @x = count(e.EmpNo)
from emp e , Works_on w
where e.EmpNo = w.EmpNo and w.ProjectNo like 'p1'

if (@x>3)
	select 'The number of employees in the project p1 is 3 or more'
else if(@x<=3)
	begin
		select 'The following employees work for the project p1' ,e.EmpFname , e.EmpLname
		from emp e , Works_on w
		where e.EmpNo = w.EmpNo and w.ProjectNo like 'p1'
	end


empNumAtP1_SP


--3

alter proc oldNewEmp_SP  @oldEmpNum int, @newEmpNum int , @Pnum varchar(10)
as

delete from Works_on where EmpNo = @oldEmpNum

insert into Works_on (EmpNo,ProjectNo)
values(@newEmpNum , @Pnum)

--4
create table auditTableOnBudget
(
_ProjectNum varchar(20),
_UserName varchar(100),
_ModifiedDate date,
_oldBudget int,
_newBudget int
)


	
create trigger AuditTriggerOnBudgetUpdate
on company.project
after update
as
	if update(budget)
		begin
			declare @oldBud int,@newBud int
			select @newBud=Budget from deleted
			select @newBud=Budget from inserted
			declare @Pnum varchar(20) 
			select @Pnum = projectNo from inserted
			insert into auditTableOnBudget
			values(@Pnum , suser_name() ,getdate() ,@oldBud ,@newBud)
		end
--------------------always old password is null why???------------------------------------------
--------------------always old password is null why???------------------------------------------
--------------------always old password is null why???------------------------------------------
update Company.Project
set Budget = 22222
where ProjectNo like 'p3'


--5
use iti


create trigger preventFromInserting
on Department
instead of insert
as 
	select 'You can not insert any values on that table'

insert into Department (Dept_Id,Dept_Name)
values (1, 'abc');


--6


use sd

alter trigger preventInsertionEmployee
on emp 
instead of insert
as
	if format(getdate(),'MMMM')='december'
			begin
				select 'You can not insert values during this month'
			end
		else
			insert into emp 
				select * from inserted 

insert into Emp 
values (100000,'amr','sherif','d1',50000)

--7

use iti

create table auditTableOnstudent
(
_UserName varchar(100),
_ModifiedDate date,
_Note varchar(200)
)

alter trigger StudentAudit
on student
after insert
as 
	declare @key varchar(10) = (select st_id from inserted)
	declare @note varchar(200) = suser_name()+' Insert New Row
	with key ='+@key+' in table Student'
	insert into auditTableOnstudent
		select suser_name() , getdate() ,@note
		from inserted

	
insert into student 
values (40,'amr','sherif','cairo',25,10,1)

--8

alter trigger StudentAudit2
on student
instead of delete
as 
	declare @key varchar(10) = (select st_id from deleted)
	declare @note varchar(200) = 'try to delete Row
	with key ='+@key
	insert into auditTableOnstudent
		select suser_name() , getdate() ,@note
		from deleted

	
delete from student 
where st_id = 30 

--9
use AdventureWorks2012

select * from HumanResources.Employee
for xml raw('employee')

select * from HumanResources.Employee
for xml raw('employee') , elements


--10
use iti

select d.Dept_Name , i.Ins_Name
from Department d , Instructor i
where i.Dept_Id=d.Dept_Id
for xml auto , elements

select d.Dept_Name "@departementID",
	   Ins_Name "instructorName/Name"
from Department d , Instructor i
where i.Dept_Id=d.Dept_Id
for xml path


--11



create table Customers
(FirstName varchar(20),
Zipcode int,
orderItem VARCHAR(20),
ID int
)

--1)create proc processtree
declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'


--2)declare document handle
declare @hdocs int

--3)create memory tree
Exec sp_xml_preparedocument @hdocs output, @docs

--4)process document 'read tree from memory'
--OPENXML Creates Result set from XML Document
insert into Customers
SELECT * 
FROM OPENXML (@hdocs, '//customer')  --levels  XPATH Code
WITH (firstName varchar(20) '@FirstName',
	  ZipCode int '@Zipcode', 
	  OrderName varchar(20) 'order',
	  OrderID int 'order/@ID'
	  )
--5)remove memory tree
Exec sp_xml_removedocument @hdocs


