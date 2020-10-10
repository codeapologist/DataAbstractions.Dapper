CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CompanyId] INT NOT NULL, 
    [DepartmentId] INT NOT NULL,
    [Name] NVARCHAR(50) NULL, 
    [Title] NVARCHAR(50) NULL
)
