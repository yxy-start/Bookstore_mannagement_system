
use Bookstore 
create table Book(
	bookName char(50) not null ,
	bookGenres char(20) not null,
	bookAuthor char(20) not null,
	bookPrice tinyint 
);

insert into Book(bookName ,bookGenres ,bookAuthor ,bookPrice ) values
	('���¾�','�й���ѧ','����',100),
	('����','�й���ѧ','����',100),
	('����','�й���ѧ','����',80),
	('�����������','�ڽ�����','PINGZ',50),
	('�����ʷ','�ڽ�����','�ȶ�������ɭ',20),
	('��ѧ������ѧ����','��ѧ������ѧ','����',90),
	('��ѧ������ʲô','��ѧ������ѧ','���Ĭ˹',55),
	('����֮ˮ','�й�����','����',62),
	('���ӱ���','�й�����','����',65),
	('�й��ľ���ս��','�й�����','����Ժ���Ű칫��',50)

select * from Book