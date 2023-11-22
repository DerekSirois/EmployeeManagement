CREATE TABLE [dbo].[Employee]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [CreatedAt] DATETIME NOT NULL DEFAULT sysdatetime(), 
    [UpdatedAt] DATETIME NOT NULL DEFAULT sysdatetime(), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [PhoneNumber] NVARCHAR(10) NOT NULL, 
    [EmployeeNumber] NVARCHAR(50) NOT NULL, 
    [BirthDay] DATE NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    [SIN] VARBINARY(160) NULL, 
    [DepartmentId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Employee_ToDepartment] FOREIGN KEY (DepartmentId) REFERENCES [Department]([Id])
)
