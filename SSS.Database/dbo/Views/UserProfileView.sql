CREATE VIEW [dbo].[UserProfileView]
	AS select 
		u.[Id]
      ,u.[UserName]
      ,[FirstName]
      ,[LastName]
      ,[Created]
      ,[CurrentSemester]
      ,[IsGraduated]
      ,[IsExpelled]
      ,[AspNetUserId]
      ,u.[Email]
      ,[Address]
      ,[HomePhone]
      ,[Cellphone]
      ,[DegreeId]
	  ,r.Name as Role
 from dbo.[User] u
join dbo.AspNetUsers au on u.AspNetUserId = au.Id
join dbo.AspNetUserRoles aur on au.Id =aur.UserId
join dbo.AspNetRoles r on r.Id = aur.RoleId 