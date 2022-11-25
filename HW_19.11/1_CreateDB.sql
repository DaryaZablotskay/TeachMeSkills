create database [Library]
go
use [Library]
go

create table Authors(
	Id uniqueidentifier primary key,
	[FirstName] nvarchar(255) not null,
	[LastName] nvarchar(255) not null,
	Country nvarchar(255),
	BirthDate date not null
);

create table Books(
	Id uniqueidentifier primary key,
	[Name] nvarchar(255) not null,
	AuthorId uniqueidentifier,
	constraint FK_Authors_Books_AuthorId foreign key (AuthorId) references Authors (Id)
);

create table Users(
	Id uniqueidentifier primary key,
	[FirstName] nvarchar(255) not null,
	[LastName] nvarchar(255) not null,
	Email nvarchar(255) unique,
	BirthDate date not null,
	Age int,
	[Address] nvarchar(255),
	ExpiredDate date
);

create table UserBooks(
	Id uniqueidentifier primary key,
	UserId uniqueidentifier,
	constraint FK_Users_UsersBooks_UserId foreign key (UserId) references Users (Id)
		on delete cascade,
	BookId uniqueidentifier,
	constraint FK_Books_UsersBooks_UserId foreign key (BookId) references Books (Id)
		on delete cascade,
	CreatedDate datetime
);

alter table Books
add year int