CREATE PROCEDURE [dbo].[RemainingCoursesSP]
	@userId uniqueidentifier ,
	@degreeId uniqueidentifier
AS
	SELECT  distinct 
c.Id as CourseId
,c.Description as Course
,[MinimunSemesterAllowed]
,[PreviousCourseId]
,[DegreeId]
,d.Description as Degree
 from   dbo.Degree d 
inner join dbo.Course c on c.DegreeId = d.Id
where d.Id = @degreeId
and c.id not in (
select distinct  
c2.Id as CourseId
 from dbo.[User] u2
inner join dbo.Degree d2 on d2.Id = u2.DegreeId
inner join dbo.Course c2 on c2.DegreeId = d2.Id
inner join dbo.UserCourse uc2 on uc2.UserId =  u2.Id and uc2.CourseId = c2.Id
where u2.Id = @userId and d2.Id = @degreeId
)
RETURN 0
