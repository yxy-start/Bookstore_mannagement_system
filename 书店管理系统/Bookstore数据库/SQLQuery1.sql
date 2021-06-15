
use Bookstore 
create table Book(
	bookName char(50) not null ,
	bookGenres char(20) not null,
	bookAuthor char(20) not null,
	bookPrice tinyint 
);

insert into Book(bookName ,bookGenres ,bookAuthor ,bookPrice ) values
	('道德经','中国哲学','老子',100),
	('孟子','中国哲学','孟子',100),
	('论语','中国哲学','孔子',80),
	('尼古拉的遗嘱','宗教理论','PINGZ',50),
	('万物简史','宗教理论','比尔·布莱森',20),
	('科学技术哲学导论','科学技术哲学','刘大椿',90),
	('科学究竟是什么','科学技术哲学','查尔默斯',55),
	('沧浪之水','中国政治','阎真',62),
	('孙子兵法','中国军事','孙子',65),
	('中国的军事战略','中国军事','国务院新闻办公室',50)

select * from Book