use iti
--1
select *
from student
where St_Age is not null

--2
select distinct i.Ins_Name
from Instructor i

--3
select 
isnull(s.St_Id ,0) as [Student ID] ,
isnull ((s.St_Fname+' '+s.St_Lname),'  ') as [Student Full Name] , 
isnull(d.Dept_Name,' ') as [Department name]
from Student s , Department d
where s.Dept_Id=d.Dept_Id 

--4 
select i.*
from Instructor i left outer join Department d
on i.Dept_Id = d.Dept_Id 

--5 
select s.St_Id , s.St_Fname +' '+s.St_Lname , c.Crs_Name 
from Student s , course c , Stud_Course sc
where s.St_Id = sc.St_Id and c.Crs_Id=sc.Crs_Id

--6
select count(t.Top_Id) as [Number of topics], t.Top_Name
from Course c , Topic t
where c.Top_Id=t.Top_Id
group by t.Top_Name

--7
select max(i.salary) as [Max salary] , min(i.salary) as [Min salary]
from Instructor i

--8  avg=11666.6666
select *
from Instructor i 
where i.Salary < (select avg(i.salary)
					from Instructor i)

--9 
select d.Dept_Name , i.Salary
from Department d , Instructor i
where i.Dept_Id = d.Dept_Id and i.Salary = (select min(i.salary)
					from Instructor i)
					
--10
select top(2) salary
from Instructor
order by Salary desc 

--11 
-- we changed the salary to varchar to put char sentence instead of the money
select Ins_Name, COALESCE(cast(Salary as varchar(20)), 'Instructor Bonus')
from Instructor

--12
select avg(i.Salary) as [average salary]
from Instructor i 

--13
-- student x is student is child then it takes the fk
-- student y is supervisor is parent then it takes the pk

select x.St_Fname as student_first_name , y.*
from student x , student y
where x.St_super=y.St_Id

--14
select *
from (select * , ROW_NUMBER() OVER (PARTITION BY dept_id ORDER BY salary  DESC) as RN 
		from Instructor  ) T
WHERE t.rn <= 2

--15
select *
from(select *, row_number() 
	over (partition by dept_id order by newid() ) as rn
	from student) t
where t.rn = 1

--------------------------------------------------------------------------------------------------------
use AdventureWorks2012

--1

select s.SalesOrderID , s.ShipDate 
from sales.SalesOrderHeader s
where ShipDate between '7/28/2002' and '7/29/2014'

--2

select p.ProductID , p.Name
from production.Product p
where StandardCost<110

--3

select p.ProductID
from Production.Product p
where p.Weight is null

--4

select *
from Production.Product p
where p.Color = 'Silver' OR p.COLOR = 'Red' OR p.COLOR = 'Black'

--or
--where p.Color like 'Silver'or p.color like 'Red' OR p.color like 'Black'

--5

select *
from Production.Product p
where p.Name like 'b%'

--6

update production.productdescription
set description = ' Chromoly steel_High of defects'
where productdescriptionid = 3

SELECT * FROM Production.ProductDescription
WHERE Description LIKE '%[_]%'

--7

select sum(TotalDue) as [sum of total due for each order date] , OrderDate
from Sales.SalesOrderHeader
where OrderDate between '7/1/2001' and '7/31/2014'
group by OrderDate

--8
select distinct HireDate
from HumanResources.Employee

--9

select  avg(distinct(p.ListPrice)) 
from Production.Product p

--10

select ('The' + Name + 'is only ' + (cast(ListPrice as varchar(10)))) 
from Production.Product
where ListPrice between 100 and 120
order by ListPrice

--11

--created table and copied data

SELECT rowguid, Name, SalesPersonID, Demographics
INTO store_Archive
FROM Sales.Store   --701 rows affected 

-- created table but did not copy data in it

SELECT rowguid, Name, SalesPersonID, Demographics
INTO storeArchive
FROM Sales.Store   
where 1=2 


--12

SELECT CONVERT(VARCHAR(20), GETDATE(), 102)
UNION all
SELECT CONVERT(VARCHAR(20), GETDATE(), 103)
UNION all
SELECT CONVERT(VARCHAR(20), GETDATE(), 104)