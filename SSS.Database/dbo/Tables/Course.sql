CREATE TABLE [dbo].[Course]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(MAX) NULL, 
    [MinimunSemesterAllowed] INT NULL, 
    [PreviousCourseId] UNIQUEIDENTIFIER NULL, 
    [DegreeId] UNIQUEIDENTIFIER NULL, 
    CONSTRAINT [FK_Course_Degree] FOREIGN KEY (DegreeId) REFERENCES dbo.[Degree]([Id])
)
