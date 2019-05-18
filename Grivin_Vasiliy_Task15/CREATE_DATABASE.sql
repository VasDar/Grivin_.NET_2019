CREATE DATABASE UserAndAwards
	ON (NAME = UserAndAwards_dat,
			FILENAME = 'D:\EPAM_DATABASE_SQL_SCRIPT\UserAndAwards.mdf',
			SIZE = 10,
			MAXSIZE = 100,
			FILEGROWTH = 5)
	LOG ON (NAME = UserAndAwords_log,
			FILENAME = 'D:\EPAM_DATABASE_SQL_SCRIPT\UserAndAwards.ldf',
			SIZE = 10,
			MAXSIZE = 100,
			FILEGROWTH = 5)
	GO
USE UserAndAwards
GO
CREATE TABLE [Users](
		ID INT PRIMARY KEY IDENTITY(1,1)NOT NULL,
		FistName nvarchar(50) not null,
		LastName nvarchar(50) not null,
		Birthday date not null)


INSERT INTO Users
	VALUES('�������','������', '1999-05-24')
INSERT INTO Users
	VALUES('�������','��������', '1995-08-04')
INSERT INTO Users
	VALUES('�������','�������', '1988-10-02')
		
		
create table [Awards](
		ID INT PRIMARY KEY IDENTITY(1,1)NOT NULL,
		Title nvarchar(50) not null,
		Discription nvarchar(250) null)
		
		
INSERT INTO Awards
VALUES('�����', '����� ���������� ������������ ���������� �� �������.')
INSERT INTO Awards
VALUES('�������������� ������', '����� ���������� ������� ��� � ������� ����������, ������������, ������ � ������.')
Insert into Awards
Values ('����������� ������','������������� ��������� ������, ������������ �� ���������� ������� ������������.')

create table [Relations](  --communication User and Awards
		
		Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		IDAwards int not null,
		IDUser int not null,
		foreign key (IDUser) references [Users](ID)ON DELETE CASCADE,
		foreign key (IDAwards) references [Awards](ID)ON DELETE CASCADE
)
Insert into Relations
values(1,1),(2,2),(3,3),(1,3)