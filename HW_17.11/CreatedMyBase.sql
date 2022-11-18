create database MyBase
go
use MyBase
go

create table Galaxy(
	[name galaxy] nvarchar(255) not null,
	[age galaxy] int not null,
	radius int not null,
	speed int not null,
	galaxy_id uniqueidentifier primary key
);

create table Planet(
	[name planet] nvarchar(255) not null,
	size nvarchar(255) not null,
	galaxy_id uniqueidentifier,
	planet_id uniqueidentifier primary key,
	constraint FK_Galaxy_Planet_PlanetId foreign key (galaxy_id) references Galaxy(galaxy_id)
);

create table Mainland(
	[name mainland] nvarchar(255) not null,
	size nvarchar(255) not null,
	mainland_id uniqueidentifier primary key,
	planet_id uniqueidentifier,
	constraint FK_Planet_Mainland_MainlandId foreign key (planet_id) references Planet(planet_id)
);

create table Ocean(
	[name ocean] nvarchar(255) not null,
	size nvarchar(255) not null,
	depth int,
	location nvarchar(255),
	ocean_id uniqueidentifier primary key,
	planet_id uniqueidentifier,
	constraint FK_Planet_Ocean_OceanId foreign key (planet_id) references Planet(planet_id)
);

create table People(
	[name person] nvarchar(255) not null,
	gender nvarchar(255) not null,
	age int not null,
	person_id uniqueidentifier primary key,
	planet_id uniqueidentifier,
	constraint FK_Planet_People_PersonId foreign key (planet_id) references Planet(planet_id)
);

create table [Birth Certificate](
	birthDate datetime not null,
	[name mom] nvarchar(255) not null,
	[name dad] nvarchar(255),
	[address] nvarchar(255) not null,
	CertificateBirth_id uniqueidentifier primary key,
	person_id uniqueidentifier,
	constraint FK_People_CertificateBirth_CertificateBirthId foreign key (person_id) references People(person_id)
);

create table Phone(
	model nvarchar(255) not null,
	[phone Number] int,
	Phone_id uniqueidentifier primary key,
	person_id uniqueidentifier,
	constraint FK_People_Phone_PhoneId foreign key (person_id) references People(person_id)
);

create table Position(
	[name position] nvarchar(255) not null,
	[salary] decimal,
	workplace nvarchar(255),
	position_id uniqueidentifier primary key
);

create table JunctionTable_People_Position(
	person_id uniqueidentifier,
	position_id uniqueidentifier,
	constraint FK_People_JunctionTable_Position foreign key (person_id) references People(person_id),
	constraint FK_Position_JunctionTable foreign key (position_id) references Position(position_id),
	constraint PK_People_Position primary key (person_id, position_id)
);

create table [Address](
	country nvarchar(255),
	city nvarchar(255),
	street nvarchar(255),
	home int,
	address_id uniqueidentifier primary key
);

create table JunctionTable_People_Address(
	person_id uniqueidentifier,
	address_id uniqueidentifier,
	constraint FK_People_JunctionTable_Address foreign key (person_id) references People(person_id),
	constraint FK_Address_JunctionTable foreign key (address_id) references [Address](address_id),
	constraint PK_People_Address primary key (person_id, address_id)
);

create table Pet(
	typeOfAnimal nvarchar(255),
	[name animal] nvarchar(255),
	age int,
	pet_id uniqueidentifier primary key
);

create table JunctionTable_People_Pet(
	person_id uniqueidentifier,
	pet_id uniqueidentifier,
	constraint FK_People_JunctionTable_Pet foreign key (person_id) references People(person_id),
	constraint FK_Pet_JunctionTable foreign key (pet_id) references Pet(pet_id),
	constraint PK_People_Pet primary key (person_id, pet_id)
);

create table Hobby(
	[name hobby] nvarchar(255),
	active bit,
	hobby_id uniqueidentifier primary key
);

create table JunctionTable_People_Hobby(
	person_id uniqueidentifier,
	hobby_id uniqueidentifier,
	constraint FK_People_JunctionTable_Hobby foreign key (person_id) references People(person_id),
	constraint FK_Hobby_JunctionTable foreign key (hobby_id) references Hobby(hobby_id),
	constraint PK_People_Hobby primary key (person_id, hobby_id)
);