use sd

--1

declare c1 cursor

for select salary from emp  --on salary of emp

for update

declare @sal int  -- varialbe take the result in it
open c1
fetch c1 into @sal  -- put pointer on salary 
while @@FETCH_STATUS=0
	begin  
		if @sal>=3000

			update emp  
			set salary=@sal*1.20
			where current of c1

		else if @sal<3000

			update emp
			set salary=@sal*1.10
			where current of c1
		
		fetch c1 into @sal
	end
close c1
deallocate c1


--2
use ITI

declare c1 cursor
for 
	select i.Ins_Name , d.Dept_Name
	from Instructor i , Department d
	where i.Ins_Id = d.Dept_Manager
for update

declare @manager varchar(20) , @depName varchar(10)
open c1
fetch c1 into @manager ,@depName
while @@FETCH_STATUS=0
	begin  
		select @manager ,@depName
		fetch c1 into @manager ,@depName
	end
close c1
deallocate c1


--3
declare c1 cursor
for 
	select distinct st_fname 
	from student 
	where st_fname is not null

for read only

declare @name varchar(20), @all_names varchar(500)=''
open c1
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
		set @all_names=CONCAT(@all_names,',',@name)
		fetch c1 into @name
	end
select @all_names
close c1
deallocate c1

--4

use sd

--Full backup (.mdf) , differential backup (.mdf) , transaction log backup (.ldf) , (filegroup backup)


--i made a new job using sql server agent and i made step and schedule using this query
--backup database sd
--to disk = 'D:\MY ITI\5-Data base\day 10\sd_db.bak'



--insert (simple-constructor-based on select - based on excute-bulk)
--bulk insert emp
--from 'd:\data.txt'
--with (fieldterminator =',')

--5
--wizard import export


--6

/*USE [ITI]
GO
 Object:  User [iti]    Script Date: 1/1/2023 7:23:30 PM
CREATE USER [iti] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ITIStud]    Script Date: 1/1/2023 7:23:30 PM ******/
CREATE USER [ITIStud] FOR LOGIN [ITIStud] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [koko]    Script Date: 1/1/2023 7:23:30 PM ******/
CREATE USER [koko] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [iti]    Script Date: 1/1/2023 7:23:30 PM ******/
CREATE SCHEMA [iti]
GO
/****** Object:  UserDefinedFunction [dbo].[getMonth]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getMonth](@date date)
returns varchar(20)

begin

	declare @result varchar(20) =  FORMAT(@date,'MMMM')
	return @result
end 
GO
/****** Object:  UserDefinedFunction [dbo].[getValuesBetween]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE function [dbo].[getValuesBetween](@num1 int , @num2 int) 
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
GO
/****** Object:  UserDefinedFunction [dbo].[SendMSG]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[SendMSG](@StudentID int)
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
GO
/****** Object:  UserDefinedFunction [dbo].[studentNames]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[studentNames](@format nvarchar(50)) 
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
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[St_Id] [int] NOT NULL,
	[St_Fname] [nvarchar](50) NULL,
	[St_Lname] [nchar](10) NULL,
	[St_Address] [nvarchar](100) NULL,
	[St_Age] [int] NULL,
	[Dept_Id] [int] NULL,
	[St_super] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[St_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Dept_Id] [int] NOT NULL,
	[Dept_Name] [nvarchar](50) NULL,
	[Dept_Desc] [nvarchar](100) NULL,
	[Dept_Location] [nvarchar](50) NULL,
	[Dept_Manager] [int] NULL,
	[Manager_hiredate] [date] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Dept_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[getDepartement]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDepartement](@StudentNum int)
returns table
as 
return
				(
					select Dept_name , (St_Fname+ ' ' + St_Lname) as [full name] 
					from student s , department d
					where s.Dept_Id = d.dept_id and s.St_Id = @StudentNum
				)
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructor](
	[Ins_Id] [int] NOT NULL,
	[Ins_Name] [nvarchar](50) NULL,
	[Ins_Degree] [nvarchar](50) NULL,
	[Salary] [money] NULL,
	[Dept_Id] [int] NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[Ins_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[getDetailsofManager]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getDetailsofManager](@managerID int)
returns table
as 
return
			(
				select d.dept_name , i.ins_name , d.manager_hiredate 
				from instructor i , department d
				where i.Ins_Id=d.Dept_Manager and Dept_Manager = @managerID
			)
GO
/****** Object:  Table [dbo].[auditTableOnstudent]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auditTableOnstudent](
	[_UserName] [varchar](100) NULL,
	[_ModifiedDate] [date] NULL,
	[_Note] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Crs_Id] [int] NOT NULL,
	[Crs_Name] [nvarchar](50) NULL,
	[Crs_Duration] [int] NULL,
	[Top_Id] [int] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Crs_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dailytransactions]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dailytransactions](
	[UserID] [int] NULL,
	[TransactionAmount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[history]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[history](
	[_user] [varchar](20) NULL,
	[_date] [date] NULL,
	[_oldid] [int] NULL,
	[_newid] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ins_Course]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ins_Course](
	[Ins_Id] [int] NOT NULL,
	[Crs_Id] [int] NOT NULL,
	[Evaluation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ins_Course] PRIMARY KEY CLUSTERED 
(
	[Ins_Id] ASC,
	[Crs_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lasttransactions]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lasttransactions](
	[UserID] [int] NULL,
	[TransactionAmount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stud_Course]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stud_Course](
	[Crs_Id] [int] NOT NULL,
	[St_Id] [int] NOT NULL,
	[Grade] [int] NULL,
 CONSTRAINT [PK_Stud_Course] PRIMARY KEY CLUSTERED 
(
	[Crs_Id] ASC,
	[St_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topic]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topic](
	[Top_Id] [int] NOT NULL,
	[Top_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Topic] PRIMARY KEY CLUSTERED 
(
	[Top_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Topic] FOREIGN KEY([Top_Id])
REFERENCES [dbo].[Topic] ([Top_Id])
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Topic]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Instructor] FOREIGN KEY([Dept_Manager])
REFERENCES [dbo].[Instructor] ([Ins_Id])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Instructor]
GO
ALTER TABLE [dbo].[Ins_Course]  WITH CHECK ADD  CONSTRAINT [FK_Ins_Course_Course] FOREIGN KEY([Crs_Id])
REFERENCES [dbo].[Course] ([Crs_Id])
GO
ALTER TABLE [dbo].[Ins_Course] CHECK CONSTRAINT [FK_Ins_Course_Course]
GO
ALTER TABLE [dbo].[Ins_Course]  WITH CHECK ADD  CONSTRAINT [FK_Ins_Course_Instructor] FOREIGN KEY([Ins_Id])
REFERENCES [dbo].[Instructor] ([Ins_Id])
GO
ALTER TABLE [dbo].[Ins_Course] CHECK CONSTRAINT [FK_Ins_Course_Instructor]
GO
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Instructor_Department] FOREIGN KEY([Dept_Id])
REFERENCES [dbo].[Department] ([Dept_Id])
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [FK_Instructor_Department]
GO
ALTER TABLE [dbo].[Stud_Course]  WITH CHECK ADD  CONSTRAINT [FK_Stud_Course_Course] FOREIGN KEY([Crs_Id])
REFERENCES [dbo].[Course] ([Crs_Id])
GO
ALTER TABLE [dbo].[Stud_Course] CHECK CONSTRAINT [FK_Stud_Course_Course]
GO
ALTER TABLE [dbo].[Stud_Course]  WITH CHECK ADD  CONSTRAINT [FK_Stud_Course_Student] FOREIGN KEY([St_Id])
REFERENCES [dbo].[Student] ([St_Id])
GO
ALTER TABLE [dbo].[Stud_Course] CHECK CONSTRAINT [FK_Stud_Course_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Department] FOREIGN KEY([Dept_Id])
REFERENCES [dbo].[Department] ([Dept_Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Department]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Student] FOREIGN KEY([St_super])
REFERENCES [dbo].[Student] ([St_Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Student]
GO
/****** Object:  StoredProcedure [dbo].[studNum_SP]    Script Date: 1/1/2023 7:23:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[studNum_SP] 
as 
select count(s.St_Fname) as [number of students] , s.Dept_Id
from student s
group by s.Dept_Id
GO*/


--7


Create SEQUENCE MySequence
START WITH 1
INCREMENT BY 1
MinValue 1
MaxValue 10
NO CYCLE; 



