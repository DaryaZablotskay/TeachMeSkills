use [Library]
go

create or alter view UserInfo as
select us.Id as 'UserId', us.FirstName as 'UserFirstName',us.LastName as 'UserLastName', 
	us.Age as 'UserAge', aut.FirstName as 'AuthorFirstName',aut.LastName as 'AuthorLastName',
	b.Name as 'BookName', b.Year as 'BookYear'
from Users us
left join UserBooks usb on usb.UserId=us.Id
left join Books b on b.Id=usb.BookId
left join Authors aut on aut.Id=b.AuthorId

--select * from UserInfo