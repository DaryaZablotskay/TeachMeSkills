use [Library]
go

insert into Users (Id, FirstName, LastName, Email, BirthDate, [Address])
values  ('61c5c0c5-a1ba-4d6b-9244-e79ab8192fd4', 'Dasha', 'Zablotskaya', 'DashZabl@gmail.com', '2003-5-14', 'Minsk, Pushkino, 85'),
		('e3d14d58-841a-45bd-8d14-6235a764307a', 'Ilya', 'Dobrinskiy', 'IlDob@gmail.com', '2002-5-18', 'Minsk, Kazintsa, 120'),
		('6b41b9b4-2872-46f4-9cd5-8ad6c698b4cd', 'Ksusha', 'Tsutsalevich', 'KsuTsu@mail.com', '2003-7-7', 'Minsk, Adaevskogo, 99'),
		('fce69aa5-b47a-42a6-80c2-6ee380af8f1d', 'Dima', 'Takarevskiy', 'DiTak@gmail.com', '2003-6-6', 'Trostinets, 26'),
		('bc433f65-13a8-40a0-9f16-8975c309a7c6', 'Masha', 'Ivanova', 'MasIv@mail.com', '1982-11-21', 'Minsk, Timirazeva, 4'),
		('b52a3a18-b7b0-4dfa-961b-550582c74230', 'Vlad', 'Zablotskiy', 'VladZablokskiy@gmail.com', '1997-6-27', 'Georgia, Batumi')

--select * from Users

insert into Authors
values  ('be6d421a-53ff-4b7a-a851-3e6a7cb46506', 'Ivan', 'Shamyakin', 'Belarus', '1921-01-30'),
		('068a31e5-dc48-4426-ab57-dcacde6f4919', 'Lev', 'Tolstoy', 'Russia', '1828-09-09'),
		('6f93c4ed-2e53-4527-b6fb-f5914080215f', 'Charlotte', 'Bronte', 'Great Britain', '1816-04-21'),
		('9c423d26-5240-4074-a078-3b329bb36b57', 'John', 'Green', 'USA', '1977-08-24'),
		('46722c5a-ff6d-41e4-849f-5c8f22f19663', 'Jojo', 'Moyes', 'Great Britain', '1969-08-04'),
		('393f9869-8b9d-4c7c-aef1-0115d48700d2', 'John', 'Tolkien', 'South Africa', '1892-01-03'),
		('d82087c3-64fb-4b57-806c-8665b72629fb', 'Nikolay', 'Gogol', 'Ukraine', '1809-03-20')

--select * from Authors

insert into Books
values  ('7511e36e-c182-4682-bd85-6221ef3d2f32', 'Heart in the palm of your hand', 
			(select Id from Authors where FirstName='Ivan' and LastName='Shamyakin'), 1964),
		('a32be103-fc3e-4e1b-9261-c0e76cd4d803', 'War and Peace', 
			(select Id from Authors where FirstName='Lev' and LastName='Tolstoy'), 1867),
		('f3ab0cfe-df13-4c79-8b63-ac2d3b9519d7', 'Jane Eyre', 
			(select Id from Authors where FirstName='Charlotte' and LastName='Bronte'), 1847),
		('def9c2f6-5553-4c84-b93a-e65b43fb9322', 'The fault in our star', 
			(select Id from Authors where FirstName='John' and LastName='Green'), 2012),
		('e94ff824-7b23-4734-9076-86e06341c6c2', 'Me Before You', 
			(select Id from Authors where FirstName='Jojo' and LastName='Moyes'), 2012),
		('540e99ee-db0c-4d17-b48c-70955ee6df7e', 'Dead Souls', 
			(select Id from Authors where FirstName='Nikolay' and LastName='Gogol'), 1842),
		('768becb6-7645-4723-aced-f2717a846f29', 'The Hobbit, or There and Back Again', 
			(select Id from Authors where FirstName='John' and LastName='Tolkien'), 1937),
		('65b69ec7-e51f-4204-bd30-ebba83d00d75', 'Lord of the Rings: The Fellowship of The Ring', 
			(select Id from Authors where FirstName='John' and LastName='Tolkien'), 1954)

--select * from Books

insert into UserBooks (Id, UserId, BookId)
values  ('054cdc5b-bc44-43e3-80dc-61c332edaff9',
			(select Id from Users where FirstName='Dasha' and LastName='Zablotskaya'),
			(select Id from Books where Name='Heart in the palm of your hand')
		),
		('0c231ffa-5461-4a2e-8655-6e04cce05a83',
			(select Id from Users where FirstName='Ilya' and LastName='Dobrinskiy'),
			(select Id from Books where Name='Lord of the Rings: The Fellowship of The Ring')
		),
		('f323a3a9-ce49-40f1-947c-5d9ead5a76e4',
			(select Id from Users where FirstName='Ilya' and LastName='Dobrinskiy'),
			(select Id from Books where Name='The Hobbit, or There and Back Again')
		),
		('a76877ee-926e-4dfb-b5df-efbdf8733073',
			(select Id from Users where FirstName='Dima' and LastName='Takarevskiy'),
			(select Id from Books where Name='Dead Souls')
		),
		('780a626c-c75b-48dd-b28b-ea0ca7bc4d4b',
			(select Id from Users where FirstName='Dima' and LastName='Takarevskiy'),
			(select Id from Books where Name='War and Peace')
		),
		('d033e8a6-34d4-427e-b289-1d6ebdc92948',
			(select Id from Users where FirstName='Ksusha' and LastName='Tsutsalevich'),
			(select Id from Books where Name='Jane Eyre')
		)

--select * from UserBooks