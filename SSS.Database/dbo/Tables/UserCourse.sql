CREATE TABLE [dbo].[UserCourse]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [CourseId] UNIQUEIDENTIFIER NULL, 
    [Created] DATETIME NULL, 
    [Status] UNIQUEIDENTIFIER NULL, 
    [Active] BIT NULL, 
    [UserId] UNIQUEIDENTIFIER NULL, 
    [Semester] INT NULL, 
    CONSTRAINT [FK_UserCourse_Course] FOREIGN KEY ([CourseId]) REFERENCES dbo.[Course]([Id]), 
    CONSTRAINT [FK_UserCourse_User] FOREIGN KEY ([UserId]) REFERENCES dbo.[User]([Id])
)
