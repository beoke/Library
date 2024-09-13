create table Login(
Id int NOT NULL IDENTITY(1,1), primary key,
Username varchar (50) NOT NULL DEFAULT (''),
Pass varchar (25) NOT NULL DEFAULT (''));

insert into Login (Username, Pass) Values ('admin','pass');

