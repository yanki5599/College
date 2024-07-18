
use college;

create table Teacher(
	ID int primary key identity,
	NatId varchar(15) unique,
	FirstName nvarchar(MAX) not null,
	LastName nvarchar(MAX),
	Phone varchar(15),
	HourlyRateNis int not null,
);

create table Student(
	ID int primary key identity,
	NatId varchar(15) unique,
	FirstName nvarchar(MAX) not null,
	LastName nvarchar(MAX) not null,
	Phone varchar(15),
);

create table Course(
	ID int primary key identity,
	Name nvarchar(MAX)  not null --unique // can not index nvarchar...
);


create table Topic(
	ID int primary key identity,
	HoursInTotal int not null,
	Name nvarchar(MAX) not null,
	--constraint AK_courseTopicName unique(Course_ID,Name) // can not index nvarchar...
);

create table TopicInCourse(
	ID int primary key identity,
	Topic_ID int foreign key references Topic(ID),
	Course_ID int foreign key references Course(ID)
	constraint AK_TopicInCourse unique(Topic_ID,Course_ID)
);


create table DaysInWeek(
	ID int primary key identity,
	Sunday		bit not null,
	Monday		bit not null,
	Tuesday		bit not null,
	Wednesday	bit not null,
	Thursday	bit not null,
	friday		bit not null,
	Saturday	bit not null,		-- god forbid from studing this day
);


create table Hours(
	ID int primary key identity,
	StartTime time not null,
	EndTime time not null,
	constraint AK_startEnd unique(StartTime,EndTime)
);

create table CourseCycle(
	ID int primary key identity,
	Course_ID int foreign key references Course(ID),
	StartDate datetime not null,
	Price int not null,
	DaysInWeek_ID int foreign key references DaysInWeek(ID),
	Hours_ID int foreign key references Hours(ID),

);

create table TeachTopic(
	CourseCycle_ID int foreign key references CourseCycle(ID),
	TopicInCourse_ID int foreign key references TopicInCourse(ID),
	Teacher_ID int foreign key references Teacher(ID)
	constraint AK_teachTopicCycle unique(CourseCycle_ID,TopicInCourse_ID)
);

create table StudentInCourse(
	CourseCycle_ID int foreign key references CourseCycle(ID),
	Student_ID int foreign key references Student(ID),
	constraint AK_studentCourseCycle unique(CourseCycle_ID,Student_ID)
);

----------------------[ manegment ]-------------------------------------------------

create table AdminUser(
	ID int primary key identity,
	NatID varchar(10) unique,
	FullName nvarchar(Max) ,
	Password varbinary(256) ,
);

insert into AdminUser(NatID,FullName,Password)
values('315175455','Jacob',HASHBYTES('sha2_256','1234'))

select * from AdminUser