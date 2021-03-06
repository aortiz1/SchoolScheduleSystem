﻿CREATE TABLE [dbo].[User]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(MAX) NULL, 
    [FirstName] VARCHAR(MAX) NULL, 
    [LastName] VARCHAR(MAX) NULL, 
    [PasswordHash] VARCHAR(MAX) NULL, 
    [Created] DATETIME NULL, 
    [CurrentSemester] INT NULL, 
    [IsGraduated] BIT NULL, 
    [IsExpelled] BIT NULL, 
    [AspNetUserId] VARCHAR(MAX) NULL, 
    [Email] VARCHAR(MAX) NULL, 
    [Address] VARCHAR(MAX) NULL, 
    [HomePhone] VARCHAR(50) NULL, 
    [Cellphone] VARCHAR(50) NULL, 
    [DegreeId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_User_Degree] FOREIGN KEY ([DegreeId]) REFERENCES [Degree]([Id])
)
