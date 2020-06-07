------------------------------���ù���
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

------------------------------��ʼ��
--��������Ա��
CREATE TABLE admins(
	aid varchar(30) PRIMARY KEY,
	aname varchar(30),
	aemail varchar(30),
);
--������ʦ��
CREATE TABLE teachers(
	tid varchar(30) PRIMARY KEY,
	tname varchar(30),
	temail varchar(30),
	tsalary int
);
--����ѧ����
CREATE TABLE students(
	sid varchar(30) PRIMARY KEY,
	sname varchar(30),
	semail varchar(30),
	sgrade varchar(30)
);

--����users��
CREATE TABLE users(
	uid varchar(30) PRIMARY KEY,
	upasswd varchar(30),
	ugroup int,
	CONSTRAINT chk_uid_gruop CHECK (ugroup = convert(int,SUBSTRING(uid,1,1)))
);

--����courses
CREATE TABLE courses(
	cid varchar(30) PRIMARY KEY,
	cname varchar(30),
	cterm int,
	cpoint int
);

--����choices
CREATE TABLE choices(
	sid varchar(30) FOREIGN KEY REFERENCES students(sid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	cscore int,
	CONSTRAINT pk_choiceid PRIMARY KEY (sid,tid,cid)
);

--�������α�
CREATE TABLE costea(
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	CONSTRAINT pk_costea PRIMARY KEY (tid,cid)
);



------------------------------������
--����Ա��
--����ʱ
go
create trigger tgr_admin_insert
on admins
for insert
as
INSERT INTO users
select inserted.aid , '123456',1 from inserted;
--ɾ��ʱ
go
create trigger tgr_admin_delete
on admins
for delete
as
DELETE FROM users
where uid = (select deleted.aid from deleted);

--��ʦ��
--����ʱ
go
create trigger tgr_tea_insert
on teachers
for insert
as
INSERT INTO users
select inserted.tid , '123456',2 from inserted;
--ɾ��ʱ
go
create trigger tgr_tea_delete
on teachers
for delete
as
DELETE FROM users
where uid = (select deleted.tid from deleted);

--ѧ����
--����ʱ
go
create trigger tgr_stu_insert
on students
for insert
as
INSERT INTO users
select inserted.sid , '123456',3 from inserted;
--ɾ��ʱ
go
create trigger tgr_stu_delete
on students
for delete
as
DELETE FROM users
where uid = (select deleted.sid from deleted);

--�γ̱�
--ɾ��ʱ���ڿα�
go
create trigger tgr_crs_tea_delete
on courses
for delete
as
DELETE FROM costea
where cid = (select deleted.cid from deleted);
drop trigger tgr_crs_tea_delete
--ɾ��ʱ��ѡ�α�
go
create trigger tgr_crs_chs_delete
on courses
for delete
as
DELETE FROM choices
where cid = (select deleted.cid from deleted);
drop trigger tgr_crs_chs_delete

--���Ա���
select * from admins;
select * from teachers;
select * from students;
select * from users;


------------------------------3
--�������Ա����
INSERT INTO admins
VALUES ('100001','admin1','admin1@xmu.edu.cn');
INSERT INTO admins
VALUES ('100002','admin2','admin2@xmu.edu.cn');
INSERT INTO admins
VALUES ('100003','admin3','admin3@xmu.edu.cn');

--������ʦ����
INSERT INTO teachers
VALUES ('200001','teacher1','teacher1@xmu.edu.cn',1000);
INSERT INTO teachers
VALUES ('200002','teacher2','teacher2@xmu.edu.cn',2000);
INSERT INTO teachers
VALUES ('200003','teacher3','teacher3@xmu.edu.cn',3000);


--����ѧ������
INSERT INTO students
VALUES ('300001','student1','student1@xmu.edu.cn','2021');
INSERT INTO students
VALUES ('300002','student2','student2@xmu.edu.cn','2022');
INSERT INTO students
VALUES ('300003','student3','student3@xmu.edu.cn','2023');



--���Դ�����
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


--����γ�����
INSERT INTO courses
VALUES ('c001','�㷨',1,2);
INSERT INTO courses
VALUES ('c002','���ݿ�',2,3);
INSERT INTO courses
VALUES ('c003','���ݽṹ',3,4);


--����ѡ������
INSERT INTO choices
VALUES ('300001','200001','c001',91);
INSERT INTO choices
VALUES ('300002','200002','c002',92);
INSERT INTO choices
VALUES ('300003','200003','c003',93);

--���뿪������
INSERT INTO costea
VALUES ('c001','200001');
INSERT INTO costea
VALUES ('c002','200002');
INSERT INTO costea
VALUES ('c003','200003');


--���Ա���
select * from admins;
select * from teachers;
select * from students;
select * from users;

select * from courses;
select * from choices;
select * from costea;


--�����洢����
create procedure sp_StudentQuery
 @sid varchar(30),
 @cterm varchar(30)
as 
 select cterm as ѧ��,  courses.cid as �γ̺�, cname as �γ���, cpoint as ѧ��, cscore as ����
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
 select cterm as ѧ��,  courses.cid as �γ̺�, cname as �γ���, cpoint as ѧ��, cscore as ���� 
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
 select cterm as ѧ��,  courses.cid as �γ̺�, cname as �γ���, cpoint as ѧ��, cscore as ����  
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
 select cterm as ѧ��,  courses.cid as �γ̺�, cname as �γ���, cpoint as ѧ��, cscore as ����  
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
  select distinct students.sid ѧ��, sname ����, cname �γ���, cscore ���� 
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
 select distinct students.sid ѧ��, sname ����, cname �γ���, cscore ���� 
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
 select distinct students.sid ѧ��, sname ����, cname �γ���, cscore ���� 
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