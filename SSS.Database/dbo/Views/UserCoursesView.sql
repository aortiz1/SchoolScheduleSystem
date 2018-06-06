CREATE VIEW [dbo].[UserCoursesView]
	AS select distinct u.Id as UserId,
u.FirstName +' ' + u.LastName as StudentName,
u.DegreeId,
d.Description as Degree,
c.Id as CourseId,
c.Description as Course,
uc.Active,
uc.Semester
 from dbo.[User] u
inner join dbo.Degree d on d.Id = u.DegreeId
inner join dbo.Course c on c.DegreeId = d.Id
inner join dbo.UserCourse uc on uc.UserId =  u.Id and uc.CourseId = c.Id