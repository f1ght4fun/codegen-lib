﻿-- this script is used to create the database needed for tests
USE [master]
GO
if exists (select * from sysdatabases where name='modelTest')
ALTER DATABASE modelTest SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
if exists (select * from sysdatabases where name='modelTest')
DROP DATABASE modelTest
go
USE [master]
GO
CREATE DATABASE modelTest
go
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [modelTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
use modelTest
go
print 'database modelTest created and changed to '
go
CREATE TABLE [Project](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] nvarchar(250) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY  
(
	[ProjectId] ASC
)
) 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmployeeRank](
	[RankId] [int] IDENTITY(1,1) NOT NULL,
	[Rank] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeRank] PRIMARY KEY  
(
	[RankId] ASC
)
) 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NOT NULL,
	[EmployeeRankId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY  
(
	[EmployeeId] ASC
)
) 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [EmployeeProject](
	[EmployeeProjectId] [int] IDENTITY(1,1) NOT NULL,
	[EPEmployeeId] [int] NOT NULL,
	[EPProjectId] [int] NOT NULL,
	[AssignDate] [date] NULL,
	[EndDate] [date] NULL,
	[Rate] [decimal](10, 2) NULL,
 CONSTRAINT [PK_EmployeeProject] PRIMARY KEY  
(
	[EmployeeProjectId] ASC
)
) 
GO
ALTER TABLE [Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EmployeeRank]
 FOREIGN KEY([EmployeeRankId])
REFERENCES [EmployeeRank] ([RankId])
GO
ALTER TABLE [Employee] CHECK CONSTRAINT [FK_Employee_EmployeeRank]
GO
ALTER TABLE [EmployeeProject]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProject_Employee] FOREIGN KEY([EPEmployeeId])
REFERENCES [Employee] ([EmployeeId])
GO
ALTER TABLE [EmployeeProject] CHECK CONSTRAINT [FK_EmployeeProject_Employee]
GO
ALTER TABLE [EmployeeProject]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProject_Project] FOREIGN KEY([EPProjectId])
REFERENCES [Project] ([ProjectId])
GO
ALTER TABLE [EmployeeProject] CHECK CONSTRAINT [FK_EmployeeProject_Project]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[FK_EmployeeInfo_Employee]') AND parent_object_id = OBJECT_ID(N'[EmployeeInfo]'))
ALTER TABLE [EmployeeInfo] DROP CONSTRAINT [FK_EmployeeInfo_Employee]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeeInfo]') AND type in (N'U'))
DROP TABLE [EmployeeInfo]
GO
CREATE TABLE [EmployeeInfo](
	[EmployeeInfoId] [int] IDENTITY NOT NULL,
	[EIEmployeeId] [int] NOT NULL,
	[Salary] [decimal](10, 2) NULL,
	[Address] [nvarchar](600) NULL,
 CONSTRAINT [PK_EmployeeInfo] PRIMARY KEY ([EmployeeInfoId] ASC))

GO
ALTER TABLE [EmployeeInfo]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeInfo_Employee] FOREIGN KEY([EIEmployeeId])
REFERENCES [Employee] ([EmployeeId])
GO
ALTER TABLE [EmployeeInfo] CHECK CONSTRAINT [FK_EmployeeInfo_Employee]
GO
set IDENTITY_INSERT dbo.EmployeeRank ON
go
insert into EmployeeRank (rankId, Rank) values (1,'President')
insert into EmployeeRank (rankId, Rank) values (2,'Associate Consultant')
insert into EmployeeRank (rankId, Rank) values (3,'Snior Consultant')
go
set IDENTITY_INSERT dbo.EmployeeRank OFF
go
set IDENTITY_INSERT dbo.Project ON
go
insert into Project (ProjectId, ProjectName) values (1,'Cyprus Police')
insert into Project (ProjectId, ProjectName) values (2,'Cyprus VAT')
insert into Project (ProjectId, ProjectName) values (3,'EDY')
insert into Project (ProjectId, ProjectName) values (4,'MARLOW')
go
set IDENTITY_INSERT dbo.Project OFF
go
set IDENTITY_INSERT dbo.Employee ON
go
insert into Employee (Employeeid, Employeename,EmployeeRankId) values (1,'Barack Obama',1)
insert into Employee (Employeeid, Employeename,EmployeeRankId) values (2,'George Bush',2)
insert into Employee (Employeeid, Employeename,EmployeeRankId) values (3,'George Clunie',3)
insert into Employee (Employeeid, Employeename,EmployeeRankId) values (4,'Melissa Domme',2)
go
set IDENTITY_INSERT dbo.Employee OFF
go
insert into EmployeeInfo (EIEmployeeid, Salary) values (1,3000)
insert into EmployeeInfo (EIEmployeeid, Salary) values (2,1000)
insert into EmployeeInfo (EIEmployeeid, Salary) values (3,3500)
insert into EmployeeInfo (EIEmployeeid, Salary) values (4,1500)
go
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (1,1, dateAdd(m,-34, getDate()),dateAdd(m,-3, getDate()),500.00)
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (1,2,dateAdd(m,-13, getDate()),null,1000.00)
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (1,3,dateAdd(m,-1, getDate()),null,700.00)
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (2,1, dateAdd(m,-12, getDate()),null,100.00)
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (2,2,dateAdd(m,-10, getDate()),null,100.00)
insert into [EmployeeProject] ([EPEmployeeId],[EPProjectId],[AssignDate],[EndDate],[Rate])
values (2,3,dateAdd(m,-3, getDate()),null,100.00)
go
ALTER TABLE dbo.Employee ADD
	Salary decimal(10,2) null, [Address] nvarchar(50) NULL,
	Telephone nvarchar(10) NULL,
	Mobile nvarchar(10) NULL,
	IdNumber nvarchar(10) NULL,
	SSINumber nvarchar(10) NULL,
	HireDate date NULL
GO
ALTER TABLE dbo.Employee ADD
	NumDependents int null
go
ALTER TABLE dbo.Project ADD
	isActive int not null default 1 -- note: do not make this a bit, we need to test boolean fields
go
CREATE TABLE [dbo].sysLanguageStrings(
[langKey] [varchar](70) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[langValueEN] nvarchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[langValueEL] nvarchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
CONSTRAINT [PK_sysLanguageStrings] PRIMARY KEY ([langKey])) 
go
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[EmployeeType]') AND type in (N'U'))
DROP TABLE [EmployeeType]
go
CREATE TABLE [EmployeeType](
	[EmployeeTypeCode] varchar(10) NOT NULL,
	[EmployeeType] [nvarchar](50) NOT NULL,
 CONSTRAINT [EmployeeType_PK] PRIMARY KEY ( [EmployeeTypeCode] )
)
go
ALTER TABLE dbo.Employee ADD
	[EmployeeTypeCode]  varchar(10) NULL
go
ALTER TABLE Employee  WITH CHECK ADD  CONSTRAINT EmployeeR01 FOREIGN KEY([EmployeeTypeCode])
REFERENCES [EmployeeType] ([EmployeeTypeCode])
go
ALTER TABLE dbo.Employee ADD
createDate datetime,updateDate datetime,createUser varchar(50),updateUser varchar(50)
go
ALTER TABLE dbo.Employee ADD
	sampleGuidField uniqueidentifier NULL
go
ALTER TABLE Employee add  isActive bit
go
ALTER TABLE dbo.Employee ADD
	sampleBigInt bigint NULL,
	sampleSmallInt smallint NULL,
	sampleNumericFieldInt numeric(18, 0) NULL,
	sampleNumericField2Decimals numeric(10, 2) NULL
go
ALTER TABLE dbo.Employee ADD [CvFileContent] [varbinary](max)  NULL 
go
ALTER TABLE dbo.Employee ADD photo [varbinary](max)  NULL 
go
ALTER TABLE dbo.Project ADD ProjectTypeId int NULL 
go
CREATE TABLE [Employee_Evaluation](
	Employee_Evaluation_Id int IDENTITY NOT NULL ,
	evaluator_id int ,
	evaluation_date datetime,
	evaluation_result  [varbinary](max)  NULL ,
	employee_id int
  CONSTRAINT [Employee_Evaluation_PK] PRIMARY KEY ( Employee_Evaluation_Id ),
  CONSTRAINT [Employee_Evaluation_R01] FOREIGN KEY(employee_id) REFERENCES [Employee] ([EmployeeId]),
  CONSTRAINT [Employee_Evaluation_R02] FOREIGN KEY(evaluator_id) REFERENCES [Employee] ([EmployeeId])
)
go

INSERT INTO [Employee_Evaluation]
           ([evaluator_id]
           ,[evaluation_date]
           ,[evaluation_result]
           ,[employee_id])
     VALUES
           (1
           ,'2015-01-01'
           ,convert(  varbinary(max),'Very good')
           ,2)
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[usp_addcol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [usp_addcol]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [usp_addcol](@tblName varchar(100), @fldName varchar(100),@dtype varchar(100))
AS
begin
declare @ret int
set @ret = 0
if exists(select * from syscolumns where lower(name)=lower(@fldName) 
	and lower(object_name(id)) = lower(@tblName))
	
set @ret=1

if @ret=0
	begin
	--print 'adding field'
	exec('ALTER TABLE '+@tblName+' add '+@fldName+' '+@dtype)
	end

end
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[usp_addAuditFields]') AND type in (N'P', N'PC'))
DROP PROCEDURE [usp_addAuditFields]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [usp_addAuditFields](@tblName varchar(100))
AS
begin
exec usp_addcol @tblName,'createUser','int not null default -1'
exec usp_addcol @tblName,'createDate','datetime not null default getdate()'
exec usp_addcol @tblName,'updateUser','int not null default -1'
exec usp_addcol @tblName,'updateDate','datetime not null default getdate()'
end
GO
exec [usp_addAuditFields] 'employee'
go
insert into [EmployeeType] ([EmployeeTypeCode],[EmployeeType]) 
values ('X1','Test Me')
go
create view vEmployee as 
SELECT        Employee.EmployeeId, Employee.EmployeeName, Employee.EmployeeRankId, Employee.Salary, Employee.Address, Employee.Telephone, Employee.Mobile, 
                         Employee.IdNumber, Employee.SSINumber, Employee.HireDate, Employee.NumDependents, Employee.EmployeeTypeCode, Employee.createDate, 
                         Employee.updateDate, Employee.createUser, Employee.updateUser, Employee.sampleGuidField, Employee.isActive, Employee.sampleBigInt, 
                         Employee.sampleSmallInt, Employee.sampleNumericFieldInt, Employee.sampleNumericField2Decimals, Employee.CvFileContent, Employee.photo, 
                         EmployeeType.EmployeeType as EmployeeTypeDescr, EmployeeRank.Rank as RankDescr
FROM            Employee LEFT OUTER JOIN
                         EmployeeType ON Employee.EmployeeTypeCode = EmployeeType.EmployeeTypeCode LEFT OUTER JOIN
                         EmployeeRank ON Employee.EmployeeRankId = EmployeeRank.RankId
go
----------------------------------------

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[AccountType]') AND type in (N'U'))
DROP TABLE [AccountType]
GO


CREATE TABLE [AccountType](
	[accountTypeid] [int] IDENTITY(1,1) NOT NULL,
	[AccountType] [nvarchar](50) NULL,
	[qbTypeCode] [nvarchar](50) NULL,
	[positiveAmtIsDebit] [int] NULL,
 CONSTRAINT [PK_AccountType] PRIMARY KEY CLUSTERED 
(
	[accountTypeid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Bank]') AND type in (N'U'))
DROP TABLE [Bank]
GO
CREATE TABLE [Bank](
	[BANKID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](50) NULL,
	[BankCode] [nvarchar](20) NULL,
	[BankSWIFTCode] [varchar](200) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[BANKID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Account]') AND type in (N'U'))
DROP TABLE [Account]
GO

CREATE TABLE [Account](
	[accountid] [int] IDENTITY(1,1) NOT NULL,
	[account] [nvarchar](50) NULL,
	[accountTypeid] [int] NULL,
	[bankaccnumber] [nvarchar](100) NULL,
	[nextCheckNumber] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
	[createdate] [datetime] NOT NULL,
	[updatedate] [datetime] NOT NULL,
	[updateuser] varchar(10) NOT NULL,
	[createuser] varchar(10) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[accountid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [Account]  WITH NOCHECK ADD  CONSTRAINT [FK_ACCOUNT_ACCOUNT_ACCOUNTTY] FOREIGN KEY([accountTypeid])
REFERENCES [AccountType] ([accountTypeid])
GO

ALTER TABLE [Account] CHECK CONSTRAINT [FK_ACCOUNT_ACCOUNT_ACCOUNTTY]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[AccountInfo]') AND type in (N'U'))
DROP TABLE [AccountInfo]
GO
CREATE TABLE [AccountInfo](
	[AccInfoId] [int] IDENTITY(1,1) NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[ContactPhone] [nvarchar](20) NULL,
	[ContactFax] [nvarchar](20) NULL,
	[accountID] [int] NULL,
	[signeeEmployee] [nvarchar](100) NULL,
	[CompanyName] [nvarchar](255) NULL,
	[CompanyBankCode] [nvarchar](20) NULL,
	[BankId] [int] NULL,
	[COOPCode] [nvarchar](100) NULL,
	[createdate] [datetime] NOT NULL,
	[updatedate] [datetime] NOT NULL,
	[updateuser] varchar(50) NOT NULL,
	[createuser] varchar(50) NOT NULL,
 CONSTRAINT [PK_AccountInfo] PRIMARY KEY CLUSTERED 
(
	[AccInfoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [AccountInfo]  WITH CHECK ADD  CONSTRAINT [AccountInfo_R01] FOREIGN KEY([BankId])
REFERENCES [Bank] ([BANKID])
GO

ALTER TABLE [AccountInfo] CHECK CONSTRAINT [AccountInfo_R01]
GO

ALTER TABLE [AccountInfo]  WITH NOCHECK ADD  CONSTRAINT [FK_ACCOUNT_INFO_ACCOUNTID] FOREIGN KEY([accountID])
REFERENCES [Account] ([accountid])
GO

ALTER TABLE [AccountInfo] CHECK CONSTRAINT [FK_ACCOUNT_INFO_ACCOUNTID]
GO

INSERT INTO [AccountType]([AccountType],[qbTypeCode],[positiveAmtIsDebit]) VALUES ('BANK','BANK',0);
INSERT INTO [Bank]([BankName],[BankCode],[BankSWIFTCode]) VALUES ('BOC','02','XBCOdkdk');
INSERT INTO [Account]
           ([account]
           ,[accountTypeid]
           ,[bankaccnumber]
           ,[nextCheckNumber]
           ,[Description]
           ,[createdate]
           ,[updatedate]
           ,[updateuser]
           ,[createuser])
     VALUES
           ( 'BOC' 
           , 1
           , '019039999'
           , '1'
           , 'bank'
           , getdate() 
           , getDate() 
           , 'admin'
           , 'admin' )
GO
INSERT INTO [modelTest].[dbo].[AccountInfo]
           ([ContactName]
           ,[ContactPhone]
           ,[ContactFax]
           ,[accountID]
           ,[signeeEmployee]
           ,[CompanyName]
           ,[CompanyBankCode]
           ,[BankId]
           ,[COOPCode]
           ,[createdate]
           ,[updatedate]
           ,[updateuser]
           ,[createuser])
     VALUES
           ('Test name'
           ,'22-909930'
           ,null
           ,1
           ,'test employee'
           ,'Microsoft'
           ,'MS'
           ,1
           ,null
           ,getDate()
           ,getDate()
           ,'admin'
           ,'admin')
GO

