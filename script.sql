USE [StudentManage]
GO
/****** Object:  User [u1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE USER [u1] FOR LOGIN [stu_users] WITH DEFAULT_SCHEMA=[u1]
GO
/****** Object:  User [t1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE USER [t1] FOR LOGIN [教师] WITH DEFAULT_SCHEMA=[t1]
GO
/****** Object:  User [s1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE USER [s1] FOR LOGIN [学生] WITH DEFAULT_SCHEMA=[s1]
GO
/****** Object:  User [a1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE USER [a1] FOR LOGIN [管理员] WITH DEFAULT_SCHEMA=[a1]
GO
/****** Object:  User [100001]    Script Date: 06/14/2020 17:46:19 ******/
CREATE USER [100001] FOR LOGIN [100001] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [u1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE SCHEMA [u1] AUTHORIZATION [u1]
GO
/****** Object:  Schema [t1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE SCHEMA [t1] AUTHORIZATION [t1]
GO
/****** Object:  Schema [s1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE SCHEMA [s1] AUTHORIZATION [s1]
GO
/****** Object:  Schema [a1]    Script Date: 06/14/2020 17:46:19 ******/
CREATE SCHEMA [a1] AUTHORIZATION [a1]
GO
/****** Object:  Table [dbo].[courses]    Script Date: 06/14/2020 17:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[courses](
	[cid] [varchar](30) NOT NULL,
	[cname] [varchar](30) NULL,
	[cterm] [int] NULL,
	[cpoint] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[db_courses]    Script Date: 06/14/2020 17:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[db_courses]
AS 
SELECT *
FROM  courses;
GO
/****** Object:  Table [dbo].[choices]    Script Date: 06/14/2020 17:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[choices](
	[sid] [varchar](30) NOT NULL,
	[tid] [varchar](30) NOT NULL,
	[cid] [varchar](30) NOT NULL,
	[cscore] [int] NULL,
 CONSTRAINT [pk_choiceid] PRIMARY KEY CLUSTERED 
(
	[sid] ASC,
	[tid] ASC,
	[cid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[db_choices]    Script Date: 06/14/2020 17:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[db_choices]
AS 
SELECT *
FROM  choices;
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentQuery_with_cid]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_StudentQuery_with_cid]
 @sid varchar(30),
 @cterm varchar(30),
 @cid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数  
 from courses, choices
 where courses.cid = choices.cid
 and choices.cid = @cid
 and choices.sid = @sid
 and courses.cterm = @cterm
 order by courses.cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentQuery_all_with_cid]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_StudentQuery_all_with_cid]
 @sid varchar(30),
 @cid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数  
 from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 and choices.cid = @cid
 order by courses.cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentQuery_all]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_StudentQuery_all]
 @sid varchar(30)
as 
 select cterm as 学期,  db_courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数 
 from db_courses, db_choices
 where db_courses.cid = db_choices.cid
 and db_choices.sid = @sid
 group by cterm, db_courses.cid, cname, cpoint, cscore
 order by db_courses.cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentQuery]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_StudentQuery]
 @sid varchar(30),
 @cterm varchar(30)
as 
 select cterm as 学期,  db_courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数
 from db_courses, db_choices
 where db_courses.cid = db_choices.cid
 and db_choices.sid = @sid
 and db_courses.cterm = @cterm
 group by cterm, db_courses.cid, cname, cpoint, cscore
 order by db_courses.cid
 return;
GO
/****** Object:  Table [dbo].[users]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[uid] [varchar](30) NOT NULL,
	[upasswd] [varchar](30) NULL,
	[ugroup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[admins]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admins](
	[aid] [varchar](30) NOT NULL,
	[aname] [varchar](30) NULL,
	[aemail] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[aid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[costea]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[costea](
	[cid] [varchar](30) NOT NULL,
	[tid] [varchar](30) NOT NULL,
 CONSTRAINT [pk_costea] PRIMARY KEY CLUSTERED 
(
	[tid] ASC,
	[cid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teachers]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teachers](
	[tid] [varchar](30) NOT NULL,
	[tname] [varchar](30) NULL,
	[temail] [varchar](30) NULL,
	[tsalary] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[students]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students](
	[sid] [varchar](30) NOT NULL,
	[sname] [varchar](30) NULL,
	[semail] [varchar](30) NULL,
	[sgrade] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_sid_all]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_sid_all]
 @sid varchar(30)
as  
 select distinct students.sid 学号, sname 姓名, cname 课程名, cscore 分数 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_sid]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_sid]
 @sid varchar(30)
as 
 select CONVERT(varchar(30),COUNT(*)) choicenum, CONVERT(varchar(30),AVG(cscore))  avgscore 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 return
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_cid_sid_all]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_cid_sid_all]
 @sid varchar(30),
 @cid varchar(30)
as 
  select distinct students.sid 学号, sname 姓名, cname 课程名, cscore 分数 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 and courses.cid = @cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_cid_sid]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_cid_sid]
 @sid varchar(30),
 @cid varchar(30)
as 
 select CONVERT(varchar(30),COUNT(*)) choicenum, CONVERT(varchar(30),AVG(cscore))  avgscore 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 and courses.cid = @cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_cid_all]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_cid_all]
 @cid varchar(30)
as 
 select distinct students.sid 学号, sname 姓名, cname 课程名, cscore 分数 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and courses.cid = @cid
 return;
GO
/****** Object:  StoredProcedure [dbo].[sp_TeacherQuery_with_cid]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TeacherQuery_with_cid]
 @cid varchar(30)
as  
 select CONVERT(varchar(30),COUNT(*)) choicenum, CONVERT(varchar(30),AVG(cscore))  avgscore 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid and courses.cid = @cid
 return;
GO
/****** Object:  View [dbo].[pwd_users]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[pwd_users] 
AS 
SELECT *
FROM  users;
GO
/****** Object:  View [dbo].[db_teachers]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[db_teachers]
AS 
SELECT *
FROM  teachers;
GO
/****** Object:  View [dbo].[db_students]    Script Date: 06/14/2020 17:46:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[db_students]
AS 
SELECT *
FROM  students;
GO
/****** Object:  Check [chk_uid_group]    Script Date: 06/14/2020 17:46:24 ******/
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [chk_uid_group] CHECK  (([ugroup]=CONVERT([int],substring([uid],(1),(1)),0)))
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [chk_uid_group]
GO
/****** Object:  ForeignKey [FK__choices__cid__15502E78]    Script Date: 06/14/2020 17:46:22 ******/
ALTER TABLE [dbo].[choices]  WITH CHECK ADD FOREIGN KEY([cid])
REFERENCES [dbo].[courses] ([cid])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__choices__sid__1367E606]    Script Date: 06/14/2020 17:46:22 ******/
ALTER TABLE [dbo].[choices]  WITH CHECK ADD FOREIGN KEY([sid])
REFERENCES [dbo].[students] ([sid])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__choices__tid__145C0A3F]    Script Date: 06/14/2020 17:46:22 ******/
ALTER TABLE [dbo].[choices]  WITH CHECK ADD FOREIGN KEY([tid])
REFERENCES [dbo].[teachers] ([tid])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__costea__cid__182C9B23]    Script Date: 06/14/2020 17:46:24 ******/
ALTER TABLE [dbo].[costea]  WITH CHECK ADD FOREIGN KEY([cid])
REFERENCES [dbo].[courses] ([cid])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__costea__tid__1920BF5C]    Script Date: 06/14/2020 17:46:24 ******/
ALTER TABLE [dbo].[costea]  WITH CHECK ADD FOREIGN KEY([tid])
REFERENCES [dbo].[teachers] ([tid])
ON DELETE CASCADE
GO
