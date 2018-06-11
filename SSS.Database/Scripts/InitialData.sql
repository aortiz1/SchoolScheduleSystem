
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8B8ECA14-9BA2-4426-B8A4-605AFBC3AFCD', N'Teacher')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9A68183E-3DE1-4FC7-A671-F809C5C6305E', N'Student')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9B5A369C-8B88-4B92-8B9D-126FFFB0102A', N'Admin')
GO




INSERT [dbo].[Degree] ([Id], [Description]) VALUES (N'eee2e521-c08b-4081-8258-fdd9246a0eae', N'Computer Science Engeneering')
INSERT [dbo].[Degree] ([Id], [Description]) VALUES (N'8f9eb80b-5201-4bd5-a378-4d09e5d0bc72', N'Electric Engeneering')
INSERT [dbo].[Degree] ([Id], [Description]) VALUES (N'b26228bb-ff97-40a0-b996-93d2aba3dca0', N'Civil Engeneering')
INSERT [dbo].[Degree] ([Id], [Description]) VALUES (N'4c3af512-aa1e-416f-a400-f868539ffc6a', N'Electronic Engeneering')






INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'40a6550e-d314-45d0-830b-97aa7c274ae9'  ,N'Operative Systems I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'27e5439a-39dd-46c4-9893-b2db574765a9'  ,N'Operative Systems II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'5e3389a6-b463-4836-9da2-cfa130c3521c'  ,N'Programming I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'3b10dc22-ff72-488e-9877-4555dfc55c9d'  ,N'Programming II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'1e5ae080-0f4d-4393-b221-379aa9883ce8'  ,N'Programming III' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'b214f517-e1a5-45ef-b072-c6f203cad19b'  ,N'Programming IV' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'76e41916-fe8f-4a27-b47f-eca27a7ae0ab'  ,N'Databases I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'0059a3fb-b763-4f65-86e9-f0a1ccf0dff0'  ,N'Databases II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'278f655e-f9db-4cde-8fb8-0af500e942c2'  ,N'Project Management I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'69f28f3f-28cb-460b-8939-8a6347930676'  ,N'Project Management II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'85b18f73-5c4d-4033-b489-de505f8b5059'  ,N'Project Management III' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'99e6ec8e-efc2-421c-a23e-9dd34a94dd54'  ,N'Project Management IV' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'f0d578c0-2680-454e-9079-490780df0185'  ,N'Movil Applications' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'673e8753-06db-4343-abcb-53c31bef33ca'  ,N'Graphic programming' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'171f995f-351b-4fda-bcd8-b0defa089a93'  ,N'Data structures' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'faeec999-9821-4e67-92c5-18d61320093b'  ,N'Accounting' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'98e4789e-7872-440b-bc19-f37d04926d33'  ,N'Mathematics I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'ac115bc3-7389-4098-bda5-2ad7b93175a0'  ,N'Mathematics II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'29491f67-7622-4154-92ef-3d0859b5c927'  ,N'Mathematics III' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'b3178a8c-7328-4b4a-b83f-14ca8cf2a65a'  ,N'Mathematics IV' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'd5b40ec1-ac1f-44c1-9edd-2d55dc62188f'  ,N'Introduction to Programming' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'2ac0b945-94d8-486b-b9b7-5b7d64cc9d27'  ,N'Process Investigation' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'5fa3d130-ff29-4fe3-921d-f44bd884da0e'  ,N'Simulation' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'ea446ac4-542e-4f8c-b85e-9a911a987a05'  ,N'Introduction to IT' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'5a583714-f2bd-44f6-b37a-a2f641232c21'  ,N'IT and Networks' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'620221d2-9757-4e97-826f-78037eecbec3'  ,N'Administration' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'31bb87d7-a818-4604-a096-299cd6909920'  ,N'Web Applications I' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT INTO [dbo].[Course]  ([Id] ,[Description] ,[MinimunSemesterAllowed] ,[PreviousCourseId],[DegreeId])   VALUES  (N'0381d959-45e4-4f80-9233-8f21ad5fe18b'  ,N'Web Applications II' ,null ,null ,N'eee2e521-c08b-4081-8258-fdd9246a0eae')



INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7811d9dc-34c5-4c4c-b8ce-fb49499e8197', N'test@mail.com', 0, N'AJCr7JPsXBvRna/WAvTgo1DXU8OeKwpmcmOiCVU16CrlA7aIcv8NwYZdDeLYIwRu4Q==', N'edb5d583-574f-4b5f-b71a-e1bc446e11e4', NULL, 0, 0, NULL, 0, 0, N'test@mail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd7475ee7-bc03-4de1-bc6d-d96d04b78627', N'testy@mail.com', 0, N'AAP+F0yvVndCLgesgMIMQ/kbrLBD2LQYaVkmEh3gSY8mAdoSMtx1At2AY8M91OHFSA==', N'32cfef2b-9d3f-40a5-a2f5-b4db0a6d1dec', NULL, 0, 0, NULL, 0, 0, N'testy@mail.com')

INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7811d9dc-34c5-4c4c-b8ce-fb49499e8197', N'9A68183E-3DE1-4FC7-A671-F809C5C6305E')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd7475ee7-bc03-4de1-bc6d-d96d04b78627', N'9A68183E-3DE1-4FC7-A671-F809C5C6305E')

INSERT [dbo].[User] ([Id], [UserName], [FirstName], [LastName], [PasswordHash], [Created], [CurrentSemester], [IsGraduated], [IsExpelled], [AspNetUserId], [Email], [Address], [HomePhone], [Cellphone], [DegreeId]) VALUES (N'cd09da0d-614e-4c7c-a5bd-a2c22af96c6e', NULL, N'Test', N'User', NULL, CAST(N'2018-06-07 15:08:01.077' AS DateTime), 1, 0, 0, N'7811d9dc-34c5-4c4c-b8ce-fb49499e8197', N'test@mail.com', NULL, NULL, NULL, N'eee2e521-c08b-4081-8258-fdd9246a0eae')
INSERT [dbo].[User] ([Id], [UserName], [FirstName], [LastName], [PasswordHash], [Created], [CurrentSemester], [IsGraduated], [IsExpelled], [AspNetUserId], [Email], [Address], [HomePhone], [Cellphone], [DegreeId]) VALUES (N'9c6a7bd3-e538-41c6-8659-f7f74ee35267', N'testy', N'Testy', N'User', NULL, CAST(N'2018-04-18 11:08:39.267' AS DateTime), 1, 0, 0, N'd7475ee7-bc03-4de1-bc6d-d96d04b78627', N'testy@mail.com', NULL, NULL, NULL, N'eee2e521-c08b-4081-8258-fdd9246a0eae')


--INSERT [dbo].[AspNetUserRoles] ([Id], [UserId], [RoleId]) VALUES (N'32cfdf1f-c73e-47d5-b406-c8d1f8b17436', N'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c', N'9B5A369C-8B88-4B92-8B9D-126FFFB0102A')

--INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c', 0, N'cf8f2a27-701f-41d6-b911-b0511931d4c6', N'aortiz@sciodev.com', 0, 1, NULL, N'AORTIZ@SCIODEV.COM', N'AORTIZ', N'AQAAAAEAACcQAAAAECCRtmpCnVJsVn+/StNMhzDG4X9M4G1r3k5nTjRqnsza7GsmrAQmmJ0Hh8QxKKOAMg==', NULL, 0, N'1899e245-1206-4bdb-9243-27b18e0c4ada', 0, N'aortiz')

--INSERT INTO [dbo].[User]   ([Id]   ,[UserName],[FirstName],[LastName],[Created],[CurrentSemester],[IsGraduated],[IsExpelled],[AspNetUserId],[Email]) VALUES('b898cb00-be75-45c2-b543-b04ce2b9e1af','aortiz','Armando','Ortiz',CURRENT_TIMESTAMP,1,1,0,'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c','aortiz@sciodev.com')

INSERT [dbo].[UserCourse] ([Id], [CourseId], [Created], [Status], [Active], [UserId], [Semester]) VALUES (N'f32e12c3-19c6-44df-bf8c-1249584797b3', N'31bb87d7-a818-4604-a096-299cd6909920', CAST(N'2018-06-08 16:50:02.427' AS DateTime), NULL, 1, N'9c6a7bd3-e538-41c6-8659-f7f74ee35267', 1)
INSERT [dbo].[UserCourse] ([Id], [CourseId], [Created], [Status], [Active], [UserId], [Semester]) VALUES (N'f11bc650-98e5-48f7-8386-1ac31fe6502f', N'b3178a8c-7328-4b4a-b83f-14ca8cf2a65a', CAST(N'2018-06-08 16:55:06.943' AS DateTime), NULL, 1, N'9c6a7bd3-e538-41c6-8659-f7f74ee35267', 1)
INSERT [dbo].[UserCourse] ([Id], [CourseId], [Created], [Status], [Active], [UserId], [Semester]) VALUES (N'd93d2374-0f27-435b-9aa6-5267677c20bc', N'5e3389a6-b463-4836-9da2-cfa130c3521c', CAST(N'2018-06-06 00:00:00.000' AS DateTime), NULL, 1, N'9c6a7bd3-e538-41c6-8659-f7f74ee35267', 1)
