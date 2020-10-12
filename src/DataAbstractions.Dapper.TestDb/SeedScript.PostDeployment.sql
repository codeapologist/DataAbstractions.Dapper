/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/



USE [TestDb]
GO

INSERT INTO [dbo].[Department]
           ([Id]
           ,[Name])
     VALUES
           (1, 'Support'),
           (2, 'Operations'),
           (3, 'Development')

GO

INSERT INTO [dbo].[Company]
           ([Id]
           ,[Name])
     VALUES
           (1, 'Mock Company'),
           (2, 'Bogus Company'),
           (3, 'Fake Company')
GO


INSERT INTO [dbo].[Employee]
           ([Id]
           ,[CompanyId]
           ,[DepartmentId]
           ,[FirstName]
           ,[LastName]
           ,[Title])
     VALUES
           (1, 1, 3, 'John', 'Doe', 'Developer'),
           (2, 2, 1, 'Jane', 'Doe', 'System Admin'),
           (3, 3, 2, 'Mike', 'Smith', 'Account Manager')
GO




