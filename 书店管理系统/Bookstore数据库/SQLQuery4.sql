use Bookstore 
CREATE TABLE [普通用户表](
	[用户编号] [char](20) primary key,
	[用户名] [char](20) NOT NULL,
	[用户密码] [char](20) NOT NULL,
	[性别] [char](10) NOT NULL,
	[电话号码] [char](20) NOT NULL,
	[籍贯] [char](50) NOT NULL
)

insert into 普通用户表(用户编号,用户名 ,用户密码 ,性别 ,电话号码,籍贯) values
	('P001','yu','123','男',123456,'甘肃庆阳'),
	('P002','abc','123','女',123456,'甘肃兰州'),
	('P003','aaa','123','男',123456,'甘肃平凉')

insert into 普通用户表(用户名 ,用户密码 ,性别 ,电话号码,籍贯) values ('于','123','男','789456','甘肃兰州')
select * from 普通用户表