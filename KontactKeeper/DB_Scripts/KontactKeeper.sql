create database Kontact_Keeper
--You need to change the directory
on primary (
Name = Kontact_Keeper1,
Filename = 'C:\Datafiles\Kontact_Keeper1.mdf',
size = 20,
maxsize = 500,
filegrowth = 1
)

Log ON(
Name = Kontact_KeeperLog,
Filename = 'C:\Datafiles\Kontact_KeeperLog.ldf',
size = 20,
maxsize = 500,
filegrowth = 1
)


--FB
create table tblFBUser
( 
ID         smallint Identity(101,1)    Primary Key,
FBID       nvarchar(50)                Not Null,
FBName     nvarchar(50)                Not Null,
LastSeen   datetime                    Not Null
)

Insert Into tblFBUser(ID,FBID,FBName,LastSeen)
Values
(101, 'User1','Jill Fitzgerald',2020-06-28),
(102, 'User2','Edward Marryfiled',2020-09-08),
(103, 'User3','Elizabeth Clarke',2020-10-01),
(104, 'User4','Thomas Kentz',2020-02-01)


--Admin
create table tblAdmin
(
ID         smallint Identity(1001,1)    Primary Key,
FName      nvarchar(50)                Not Null,
LName      nvarchar(50)                Not Null,
UName      nvarchar(50)                Not Null,
UPassword  nvarchar(50)                Not Null
)

insert into tblAdmin(ID,FName,LName,UName,UPassword)
Values
(1001, 'Lucy', 'Jones', 'LUCYJ01', 'L09cyJ0n3s'),
(1001, 'Rebecca', 'Davies', 'RebeccaLove', 'Davies_Bec'),
(1001, 'Brent', 'Taylor', 'Brent9901', 'TaylorisBrent'),
(1001, 'Jacob', 'Evans', 'JacobEvans', 'JE81')