use [Library]
go

create or alter trigger trigger_UserBooks_CreatedDate 
on UserBooks
after insert
as update UserBooks
set CreatedDate = GetDate()
where Id in (select Id from inserted)

create or alter trigger trigger_Users_ExpiredDate
on Users
after insert
as update Users
set ExpiredDate =DATEADD(YEAR, 1, GETDATE())
where Id in (select Id from inserted)

create or alter trigger trigger_Users_Age
on Users
after insert, update
as update Users
set Age=DATEDIFF(year, BirthDate, GETDATE())
where Id in (select Id from inserted)

