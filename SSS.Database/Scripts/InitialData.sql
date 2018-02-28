
INSERT [dbo].[AspNetRoles] ([Id],  [Name] ) VALUES (N'8B8ECA14-9BA2-4426-B8A4-605AFBC3AFCD', N'Teacher')
INSERT [dbo].[AspNetRoles] ([Id], [Name] ) VALUES (N'9A68183E-3DE1-4FC7-A671-F809C5C6305E',  N'Student')
INSERT [dbo].[AspNetRoles] ([Id],  [Name] ) VALUES (N'9B5A369C-8B88-4B92-8B9D-126FFFB0102A',  N'Admin')

--INSERT [dbo].[AspNetUserRoles] ([Id], [UserId], [RoleId]) VALUES (N'32cfdf1f-c73e-47d5-b406-c8d1f8b17436', N'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c', N'9B5A369C-8B88-4B92-8B9D-126FFFB0102A')

--INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c', 0, N'cf8f2a27-701f-41d6-b911-b0511931d4c6', N'aortiz@sciodev.com', 0, 1, NULL, N'AORTIZ@SCIODEV.COM', N'AORTIZ', N'AQAAAAEAACcQAAAAECCRtmpCnVJsVn+/StNMhzDG4X9M4G1r3k5nTjRqnsza7GsmrAQmmJ0Hh8QxKKOAMg==', NULL, 0, N'1899e245-1206-4bdb-9243-27b18e0c4ada', 0, N'aortiz')

--INSERT INTO [dbo].[User]   ([Id]   ,[UserName],[FirstName],[LastName],[Created],[CurrentSemester],[IsGraduated],[IsExpelled],[AspNetUserId],[Email]) VALUES('b898cb00-be75-45c2-b543-b04ce2b9e1af','aortiz','Armando','Ortiz',CURRENT_TIMESTAMP,1,1,0,'1d566a78-28e5-4eb6-85ef-ac1b3ed5923c','aortiz@sciodev.com')

