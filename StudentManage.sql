------------------------------常用功能
/*
use master;
drop database StudentManage;

drop table admins;
drop table teachers;
drop table students;
drop table users;
drop table choices;
drop table costea;



select * from admins;
select * from teachers;
select * from students;
select * from users;
*/


------------------------------1
create database StudentManage;


------------------------------2
use StudentManage;
use StudentManage;

------------------------------初始化
--创建管理员表
CREATE TABLE admins(
	aid varchar(30) PRIMARY KEY,
	aname varchar(30),
	aemail varchar(30),
);
--创建老师表
CREATE TABLE teachers(
	tid varchar(30) PRIMARY KEY,
	tname varchar(30),
	temail varchar(30),
	tsalary int
);
--创建学生表
CREATE TABLE students(
	sid varchar(30) PRIMARY KEY,
	sname varchar(30),
	semail varchar(30),
	sgrade varchar(30)
);

--创建users表
CREATE TABLE users(
	uid varchar(30) PRIMARY KEY,
	upasswd varchar(30),
	ugroup int,
	CONSTRAINT chk_uid_gruop CHECK (ugroup = convert(int,SUBSTRING(uid,1,1)))
);

--创建courses
CREATE TABLE courses(
	cid varchar(30) PRIMARY KEY,
	cname varchar(30),
	cterm int,
	cpoint int
);

--创建choices
CREATE TABLE choices(
	sid varchar(30) FOREIGN KEY REFERENCES students(sid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	cscore int,
	CONSTRAINT pk_choiceid PRIMARY KEY (sid,tid,cid)
);

--创建开课表
CREATE TABLE costea(
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	CONSTRAINT pk_costea PRIMARY KEY (tid,cid)
);



------------------------------触发器
--管理员表
--插入时
go
create trigger tgr_admin_insert
on admins
for insert
as
INSERT INTO users
select inserted.aid , '123456',1 from inserted;
--删除时
go
create trigger tgr_admin_delete
on admins
for delete
as
DELETE FROM users
where uid = (select deleted.aid from deleted);

--教师表
--插入时
go
create trigger tgr_tea_insert
on teachers
for insert
as
INSERT INTO users
select inserted.tid , '123456',2 from inserted;
--删除时
go
create trigger tgr_tea_delete
on teachers
for delete
as
DELETE FROM users
where uid = (select deleted.tid from deleted);

--学生表
--插入时
go
create trigger tgr_stu_insert
on students
for insert
as
INSERT INTO users
select inserted.sid , '123456',3 from inserted;
--删除时
go
create trigger tgr_stu_delete
on students
for delete
as
DELETE FROM users
where uid = (select deleted.sid from deleted);

--课程表
--删除时对授课表
go
create trigger tgr_crs_tea_delete
on courses
for delete
as
DELETE FROM costea
where cid = (select deleted.cid from deleted);
drop trigger tgr_crs_tea_delete
--删除时对选课表
go
create trigger tgr_crs_chs_delete
on courses
for delete
as
DELETE FROM choices
where cid = (select deleted.cid from deleted);
drop trigger tgr_crs_chs_delete

--测试表项
select * from admins;
select * from teachers;
select * from students;
select * from users;


------------------------------3
--插入管理员数据
INSERT INTO admins
VALUES ('100001','admin1','admin1@xmu.edu.cn');
INSERT INTO admins
VALUES ('100002','admin2','admin2@xmu.edu.cn');
INSERT INTO admins
VALUES ('100003','admin3','admin3@xmu.edu.cn');

--插入老师数据
INSERT INTO teachers
VALUES ('200001','teacher1','teacher1@xmu.edu.cn',1000);
INSERT INTO teachers
VALUES ('200002','teacher2','teacher2@xmu.edu.cn',2000);
INSERT INTO teachers
VALUES ('200003','teacher3','teacher3@xmu.edu.cn',3000);


--插入学生数据
INSERT INTO students
VALUES ('300001','student1','student1@xmu.edu.cn','2021');
INSERT INTO students
VALUES ('300002','student2','student2@xmu.edu.cn','2022');
INSERT INTO students
VALUES ('300003','student3','student3@xmu.edu.cn','2023');



--测试触发器
/*
select * from admins
select * from users

INSERT INTO admins
VALUES ('100004','admin4','admin4@xmu.edu.cn');

select * from admins
select * from users

DELETE FROM admins
WHERE aid='100004';

select * from admins
select * from users
*/


--插入课程数据
INSERT INTO courses
VALUES ('c001','算法',1,2);
INSERT INTO courses
VALUES ('c002','数据库',2,3);
INSERT INTO courses
VALUES ('c003','数据结构',3,4);


--插入选课数据
INSERT INTO choices
VALUES ('300001','200001','c001',91);
INSERT INTO choices
VALUES ('300002','200002','c002',92);
INSERT INTO choices
VALUES ('300003','200003','c003',93);

--插入开课数据
INSERT INTO costea
VALUES ('c001','200001');
INSERT INTO costea
VALUES ('c002','200002');
INSERT INTO costea
VALUES ('c003','200003');


--测试表项
select * from admins;
select * from teachers;
select * from students;
select * from users;

select * from courses;
select * from choices;
select * from costea;


--创建存储过程
create procedure sp_StudentQuery
 @sid varchar(30),
 @cterm varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数
 from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 and courses.cterm = @cterm
 group by cterm, courses.cid, cname, cpoint, cscore
 order by courses.cid
 return;
 
 
create procedure sp_StudentQuery_all
 @sid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数 
 from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 group by cterm, courses.cid, cname, cpoint, cscore
 order by courses.cid
 return;

create procedure sp_StudentQuery_with_cid
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
 
create procedure sp_StudentQuery_all_with_cid
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
 
 create procedure sp_TeacherQuery_with_cid_sid
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
 
 create procedure sp_TeacherQuery_with_cid_sid_all
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

 create procedure sp_TeacherQuery_with_cid
 @cid varchar(30)
as  
 select CONVERT(varchar(30),COUNT(*)) choicenum, CONVERT(varchar(30),AVG(cscore))  avgscore 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid and courses.cid = @cid
 return;
 
 create procedure sp_TeacherQuery_with_cid_all
 @cid varchar(30)
as 
 select distinct students.sid 学号, sname 姓名, cname 课程名, cscore 分数 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and courses.cid = @cid
 return;

 create procedure sp_TeacherQuery_with_sid
 @sid varchar(30)
as 
 select CONVERT(varchar(30),COUNT(*)) choicenum, CONVERT(varchar(30),AVG(cscore))  avgscore 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 return

 create procedure sp_TeacherQuery_with_sid_all
 @sid varchar(30)
as  
 select distinct students.sid 学号, sname 姓名, cname 课程名, cscore 分数 
 from choices,students,courses 
 where students.sid = choices.sid 
 and courses.cid = choices.cid 
 and students.sid = @sid
 return;
 
 drop procedure sp_StudentQuery_all_with_cid
 drop procedure sp_StudentQuery_all
 drop procedure sp_StudentQuery_with_cid
 drop procedure sp_StudentQuery
 drop procedure sp_TeacherQuery_with_cid_sid
 drop procedure sp_TeacherQuery_with_cid_sid_all
 drop procedure sp_TeacherQuery_with_cid
 drop procedure sp_TeacherQuery_with_cid_all
 drop procedure sp_TeacherQuery_with_sid
 drop procedure sp_TeacherQuery_with_sid_all