use [Library]
go

alter table UserBooks
add constraint UC_UserBooks unique (UserId, BookId)