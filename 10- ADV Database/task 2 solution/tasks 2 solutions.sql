use iti

--1
alter function getMonth(@date date)
returns varchar(20)

begin

	declare @result varchar(20) =  FORMAT(@date,'MMMM')
	return @result
end 


select dbo.getMonth('1996/02/08') as "month"
 
 --2

 alter function getValuesBetween(@num1 int , @num2 int) 
returns @t table
		(
		 nums int
		)
as
begin

declare @temp int = @num1+1

			WHILE (@temp<@num2)
			BEGIN
				insert into @t values(@temp)
			   set @temp = @temp + 1
			END
return
end

select * from getValuesBetween(1,10)


--3

create function getDepartement(@StudentNum int)
returns table
as 
return
				(
					select Dept_name , (St_Fname+ ' ' + St_Lname) as [full name] 
					from student s , department d
					where s.Dept_Id = d.dept_id and s.St_Id = @StudentNum
				)

select * from dbo.getDepartement(9)


--4

alter function SendMSG(@StudentID int)
returns varchar(100)

begin

declare @msg nvarchar(100)

declare @FirstName varchar(50) 
select @FirstName=St_Fname from Student where st_id = @StudentID


declare @LastName varchar(50) 
select @LastName=St_Lname from Student where st_id = @StudentID

				IF (@FirstName is NULL and @LastName is NULL )
					BEGIN
						 set @msg = 'First name & last name are null'
					END
				ELSE IF (@FirstName is NULL)
					BEGIN
						 set @msg = 'first name is null'
					END
				ELSE IF (@LastName is NULL)
					BEGIN
						 set @msg = 'last name is null'
					END
				ELSE 
					BEGIN
						 set @msg = 'First name & last name are not null'
					END

				return @msg
end 


select dbo.SendMSG(13) as MSG

--5

alter function getDetailsofManager(@managerID int)
returns table
as 
return
			(
				select d.dept_name , i.ins_name , d.manager_hiredate 
				from instructor i , department d
				where i.Ins_Id=d.Dept_Manager and Dept_Manager = @managerID
			)

select * from dbo.getDetailsofManager(1)

--6

alter function studentNames(@format nvarchar(50)) 
returns @t table
		(
		 studentName nvarchar(50)
		)
as
begin
	if (@format='fullname')
		begin
			insert @t
			select isNull(st_fname+' '+st_lname ,'no name')
			from student
		end
	else if (@format='first name')
		begin 
				insert  into @t
				select isNull(st_fname,'no name')
				from student
		end
	else if (@format='last name')
		begin 
				insert  into @t
				select isNull(st_lname,'no name')
				from student
		end

return
end

select * from studentNames('fullname')

select * from studentNames('first name')

select * from studentNames('last name')


--7

select st_id , left(st_fname, len(st_fname)-1) as [Name without last letter]
from student 

--8

delete c
from student s , Department d , stud_course c
where s.Dept_Id=d.Dept_Id and c.St_Id = s.St_Id and dept_name like 'SD'

---------------------------------------------------------------------------------------------------

Bonus:

1.	Give an example for hierarchyid Data type

2.	Create a batch that inserts 3000 rows in the student table(ITI database). 
	The values of the st_id column should be unique and between 3000 and 6000. 
	All values of the columns st_fname, st_lname, should be set to 'Jane', ' Smith' respectively.